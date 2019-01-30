﻿using JX.Application.DTOs;
using JX.Infrastructure.Framework;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：Admin 的应用层服务接口.
	/// </summary>
	public partial interface IAdminServiceAppADO : IServiceAppADO<AdminDTO>
	{
		#region 得到实体，包括扩展属性
		/// <summary>
		/// 通过主键返回第一条信息的实体类，包括扩展属性。
		/// </summary>
		/// <returns></returns>
		AdminDTO GetDTOFull(System.Int32 adminID);
		/// <summary>
		/// 通过主键返回第一条信息的实体类，包括扩展属性。
		/// </summary>
		/// <returns></returns>
		Task<AdminDTO> GetDTOFullAsync(System.Int32 adminID);
		/// <summary>
		/// 获取实体，包括扩展属性
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		AdminDTO GetDTOFull(string strWhere, Dictionary<string, object> dict = null);
		/// <summary>
		/// 获取实体，包括扩展属性（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		Task<AdminDTO> GetDTOFullAsync(string strWhere, Dictionary<string, object> dict = null);
		/// <summary>
		/// 为实体添加RoleIDs和RoleNames两个属性的值
		/// </summary>
		/// <param name="admin"></param>
		/// <returns></returns>
		AdminDTO GetAdminFull(AdminDTO admin);
		#endregion

		#region 得到实体列表，包括扩展属性
		/// <summary>
		/// 得到实体列表，包括扩展属性
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		IList<AdminDTO> GetDTOFullList(string strWhere = "", Dictionary<string, object> dict = null);
		/// <summary>
		/// 得到实体列表，包括扩展属性（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		Task<IList<AdminDTO>> GetDTOFullListAsync(string strWhere = "", Dictionary<string, object> dict = null);
		#endregion

		#region 得到分页，包括扩展属性
		/// <summary>
		/// 通过存储过程“Common_GetList”，得到分页后的数据，包括扩展属性
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		IList<AdminDTO> GetListFull(int startRowIndexId, int maxNumberRows, string Filter, out int Total);
		#endregion

		#region 登录、修改密码
		/// <summary>
		/// 管理员登录。
		/// 1、登录失败，记录登录错误次数，记录登录日志。
		/// 2、登录成功，清空登录错误次数，记录登录日志。
		/// </summary>
		/// <param name="adminName"></param>
		/// <param name="adminPassword">明文密码</param>
		/// <param name="manageCode">管理认证码</param>
		/// <returns></returns>
		Task<IdentityResult> Login(string adminName, string adminPassword,string manageCode="");

		/// <summary>
		/// 修改管理员密码。成功返回“ok”，失败返回错误原因。
		/// </summary>
		/// <param name="claimsPrincipal">当前登录管理员</param>
		/// <param name="oldPwd">旧密码</param>
		/// <param name="newPwd">新密码</param>
		/// <returns></returns>
		Task<string> ModifyPassword(ClaimsPrincipal claimsPrincipal,string oldPwd,string newPwd);
		#endregion

		#region 添加、修改、删除管理员
		/// <summary>
		/// 添加管理员，并设置所属角色。成功返回“ok”，失败返回错误消息。
		/// </summary>
		/// <param name="adminDTO"></param>
		/// <returns></returns>
		Task<string> AddAdminFull(AdminDTO adminDTO);

		/// <summary>
		/// 修改管理员，并设置所属角色。成功返回“ok”，失败返回错误消息。
		/// </summary>
		/// <param name="adminDTO"></param>
		/// <returns></returns>
		Task<string> UpdateAdminFull(AdminDTO adminDTO);

		/// <summary>
		/// 删除管理员。
		/// 1 当前登录管理员不能删除。
		/// 2 同时要删除角色关系。
		/// </summary>
		/// <param name="claimsPrincipal"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		bool DelAdminFull(ClaimsPrincipal claimsPrincipal, int id);
		/// <summary>
		/// 删除管理员。
		/// 1 当前登录管理员不能删除。
		/// 2 同时要删除角色关系。
		/// </summary>
		/// <param name="claimsPrincipal"></param>
		/// <param name="ids"></param>
		void BatchDel(ClaimsPrincipal claimsPrincipal, string ids);
		#endregion

		/// <summary>
		/// 设置管理员的锁定/启用状态
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		bool SetAdminStatus(int id);
	}
}