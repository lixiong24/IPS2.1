﻿using JX.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：Roles 的应用层服务接口.
	/// </summary>
	public partial interface IRolesServiceAppADO : IServiceAppADO<RolesDTO>
	{
		/// <summary>
		/// 通过主键删除角色。
		/// 1、删除字段的权限设置。
		/// 2、删除节点的权限设置。
		/// 3、删除专题的权限设置。
		/// 4、删除角色的权限设置。
		/// 5、删除角色和与管理员的关系。
		/// </summary>
		/// <returns></returns>
		bool DeleteFull(System.Int32 roleID);
		/// <summary>
		/// 通过主键删除角色。
		/// 1、删除字段的权限设置。
		/// 2、删除节点的权限设置。
		/// 3、删除专题的权限设置。
		/// 4、删除角色的权限设置。
		/// 5、删除角色和与管理员的关系。
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteFullAsync(System.Int32 roleID);

		/// <summary>
		/// 移除指定角色的所有常规权限
		/// </summary>
		/// <param name="roleID"></param>
		/// <returns></returns>
		Task<bool> DeletePermissionFromRoles(int roleID);

		/// <summary>
		/// 添加常规权限到角色
		/// </summary>
		/// <param name="roleID"></param>
		/// <param name="operateCodes">多个权限码用“,”分隔</param>
		/// <returns></returns>
		Task<bool> AddPermissionToRoles(int roleID,string operateCodes);

		/// <summary>
		/// 得到指定角色的所有权限码
		/// </summary>
		/// <param name="roleID"></param>
		/// <returns></returns>
		Task<IList<RolesPermissionsDTO>> GetRolesPermissionsByRoleID(int roleID);

		/// <summary>
		/// 得到指定权限码的所有角色
		/// </summary>
		/// <param name="operateCode"></param>
		/// <returns></returns>
		Task<IList<RolesPermissionsDTO>> GetRolesPermissionsByOperateCode(string operateCode);

		/// <summary>
		/// 得到属于指定角色的管理员列表，管理员不包括扩展属性
		/// </summary>
		/// <param name="roleID"></param>
		/// <returns></returns>
		Task<IList<AdminDTO>> GetMemberListByRoleID(int roleID);

		/// <summary>
		/// 得到不属于指定角色的管理员列表，管理员不包括扩展属性
		/// </summary>
		/// <param name="roleID"></param>
		/// <returns></returns>
		Task<IList<AdminDTO>> GetMemberListNotInRole(int roleID);

		/// <summary>
		/// 添加管理员到角色
		/// </summary>
		/// <param name="admins">管理员ID，多个ID用“,”分隔</param>
		/// <param name="roleId"></param>
		/// <returns></returns>
		Task<bool> AddMembersToRole(string admins, int roleId);
	}
}