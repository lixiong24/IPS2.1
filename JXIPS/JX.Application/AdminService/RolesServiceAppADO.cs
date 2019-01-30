using AutoMapper;
using JX.Application.DTOs;
using JX.Core;
using JX.Core.Entity;
using JX.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：Roles 的应用层服务接口实现类.
	/// </summary>
	public partial class RolesServiceAppADO : IRolesServiceAppADO
	{
		private char[] split = new char[] { ',' };

		#region 仓储接口
		private readonly IAdminRepositoryADO _AdminRepositoryADO;
		private readonly IAdminRolesRepositoryADO _AdminRolesRepository;
		private readonly IRolesPermissionsRepositoryADO _RolesPermissionsRepository;
		private readonly IRoleFieldPermissionsRepositoryADO _RoleFieldPermissionsRepositoryADO;
		private readonly IRoleNodePermissionsRepositoryADO _RoleNodePermissionsRepositoryADO;
		private readonly IRoleSpecialPermissionsRepositoryADO _RoleSpecialPermissionsRepositoryADO;
		private readonly ILogRepositoryADO _LogRepository;
		/// <summary>
		/// 构造器注入
		/// </summary>
		/// <param name="repository"></param>
		/// <param name="adminRepositoryADO"></param>
		/// <param name="adminRolesRepository"></param>
		/// <param name="rolesPermissionsRepository"></param>
		/// <param name="roleFieldPermissionsRepositoryADO"></param>
		/// <param name="roleNodePermissionsRepositoryADO"></param>
		/// <param name="roleSpecialPermissionsRepositoryADO"></param>
		/// <param name="logRepository"></param>
		public RolesServiceAppADO(IRolesRepositoryADO repository,
			IAdminRepositoryADO adminRepositoryADO,
			IAdminRolesRepositoryADO adminRolesRepository,
			IRolesPermissionsRepositoryADO rolesPermissionsRepository,
			IRoleFieldPermissionsRepositoryADO roleFieldPermissionsRepositoryADO,
			IRoleNodePermissionsRepositoryADO roleNodePermissionsRepositoryADO,
			IRoleSpecialPermissionsRepositoryADO roleSpecialPermissionsRepositoryADO,
			ILogRepositoryADO logRepository)
		{
			_repository = repository;
			_AdminRepositoryADO = adminRepositoryADO;
			_AdminRolesRepository = adminRolesRepository;
			_RolesPermissionsRepository = rolesPermissionsRepository;
			_RoleFieldPermissionsRepositoryADO = roleFieldPermissionsRepositoryADO;
			_RoleNodePermissionsRepositoryADO = roleNodePermissionsRepositoryADO;
			_RoleSpecialPermissionsRepositoryADO = roleSpecialPermissionsRepositoryADO;
			_LogRepository = logRepository;
		}
		#endregion

		#region 删除角色和相关权限
		/// <summary>
		/// 通过主键删除角色。
		/// 1、删除字段的权限设置。
		/// 2、删除节点的权限设置。
		/// 3、删除专题的权限设置。
		/// 4、删除角色的权限设置。
		/// </summary>
		/// <returns></returns>
		public bool DeleteFull(System.Int32 roleID)
		{
			if (roleID <= 0)
			{
				return false;
			}
			DeleteRoleRelation(roleID);
			return Delete(roleID);
		}
		/// <summary>
		/// 通过主键删除角色。
		/// 1、删除字段的权限设置。
		/// 2、删除节点的权限设置。
		/// 3、删除专题的权限设置。
		/// 4、删除角色的权限设置。
		/// </summary>
		/// <returns></returns>
		public async Task<bool> DeleteFullAsync(System.Int32 roleID)
		{
			if (roleID <= 0)
			{
				return false;
			}
			DeleteRoleRelation(roleID);
			return await DeleteAsync(roleID);
		}

		/// <summary>
		/// 移除指定角色的所有常规权限
		/// </summary>
		/// <param name="roleID"></param>
		/// <returns></returns>
		public async Task<bool> DeletePermissionFromRoles(int roleID)
		{
			return await _RolesPermissionsRepository.DeletePermissionFromRolesAsync(roleID);
		}


		/// <summary>
		/// 删除角色相关的所有权限
		/// </summary>
		/// <param name="roleId"></param>
		private void DeleteRoleRelation(int roleId)
		{
			_RolesPermissionsRepository.DeletePermissionFromRoles(roleId);
			_RoleFieldPermissionsRepositoryADO.DeleteFieldPermissionFromRoles(roleId);
			_RoleNodePermissionsRepositoryADO.DeleteNodePermissionFromRoles(roleId);
			_RoleSpecialPermissionsRepositoryADO.DeleteSpecialPermissionFromRoles(roleId);
			_AdminRolesRepository.RemoveAdminFromRolesByRoleId(roleId);
		}
		#endregion

		#region 常规权限管理
		/// <summary>
		/// 添加权限到角色，并清除对应权限的缓存数据
		/// </summary>
		/// <param name="roleID"></param>
		/// <param name="operateCodes">多个权限码用“,”分隔</param>
		/// <returns></returns>
		public async Task<bool> AddPermissionToRoles(int roleID, string operateCodes)
		{
			if (roleID <= 0 || string.IsNullOrEmpty(operateCodes))
				return false;
			List<string> listCacheKey = new List<string>();
			var arrOperateCodes = operateCodes.Split(split, StringSplitOptions.RemoveEmptyEntries);
			arrOperateCodes = StringHelper.RemoveRepeatItem(arrOperateCodes);
			foreach (string str in arrOperateCodes)
			{
				if (!string.IsNullOrEmpty(str) && (str != "None"))
				{
					listCacheKey.Add("CK_OperatorCode_"+str);
					await _RolesPermissionsRepository.AddAsync(new RolesPermissions() { RoleID = roleID, OperateCode = str });
				}
			}
			CacheHelper.CacheServiceProvider.RemoveAll(listCacheKey);
			return true;
		}

		/// <summary>
		/// 得到指定角色的所有权限码
		/// </summary>
		/// <param name="roleID"></param>
		/// <returns></returns>
		public async Task<IList<RolesPermissionsDTO>> GetRolesPermissionsByRoleID(int roleID)
		{
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("RoleID",roleID);
			var entityList = await _RolesPermissionsRepository.GetEntityListAsync(" and RoleID=@RoleID",dict);
			return Mapper.Map<List<RolesPermissionsDTO>>(entityList);
		}

		/// <summary>
		/// 得到指定权限码的所有角色
		/// </summary>
		/// <param name="operateCode"></param>
		/// <returns></returns>
		public async Task<IList<RolesPermissionsDTO>> GetRolesPermissionsByOperateCode(string operateCode)
		{
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("OperateCode", operateCode);
			var entityList = await _RolesPermissionsRepository.GetEntityListAsync(" and OperateCode=@OperateCode", dict);
			return Mapper.Map<List<RolesPermissionsDTO>>(entityList);
		}
		#endregion

		#region 角色成员管理
		/// <summary>
		/// 得到属于指定角色的管理员列表，管理员不包括扩展属性
		/// </summary>
		/// <param name="roleID"></param>
		/// <returns></returns>
		public async Task<IList<AdminDTO>> GetMemberListByRoleID(int roleID)
		{
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("RoleID", roleID);
			var entityList = await _AdminRepositoryADO.GetEntityListAsync(" and AdminID IN (SELECT AdminID FROM AdminRoles WHERE (RoleID = @RoleID))", dict);
			return Mapper.Map<List<AdminDTO>>(entityList);
		}

		/// <summary>
		/// 得到不属于指定角色的管理员列表，管理员不包括扩展属性
		/// </summary>
		/// <param name="roleID"></param>
		/// <returns></returns>
		public async Task<IList<AdminDTO>> GetMemberListNotInRole(int roleID)
		{
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("RoleID", roleID);
			var entityList = await _AdminRepositoryADO.GetEntityListAsync(" and AdminID NOT IN (SELECT AdminID FROM AdminRoles WHERE (RoleID = @RoleID))", dict);
			return Mapper.Map<List<AdminDTO>>(entityList);
		}

		/// <summary>
		/// 添加管理员到角色
		/// </summary>
		/// <param name="admins">管理员ID，多个ID用“,”分隔</param>
		/// <param name="roleId"></param>
		/// <returns></returns>
		public async Task<bool> AddMembersToRole(string admins, int roleId)
		{
			_AdminRolesRepository.RemoveAdminFromRolesByRoleId(roleId);
			if (!string.IsNullOrEmpty(admins))
			{
				foreach (string str in admins.Split(split, StringSplitOptions.RemoveEmptyEntries))
				{
					await _AdminRolesRepository.AddAsync(new AdminRoles() { AdminID=DataConverter.CLng(str),RoleID=roleId});
				}
			}
			return true;
		}
		#endregion
	}
}