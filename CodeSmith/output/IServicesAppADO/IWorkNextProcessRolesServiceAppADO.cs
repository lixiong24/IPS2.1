﻿using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：WorkNextProcessRoles 的应用层服务接口.
	/// </summary>
	public partial interface IWorkNextProcessRolesServiceAppADO : IServiceAppADO<WorkNextProcessRolesDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 workID, System.Int32 roleID);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 workID, System.Int32 roleID);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		WorkNextProcessRolesDTO GetDTO(System.Int32 workID, System.Int32 roleID);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<WorkNextProcessRolesDTO> GetDTOAsync(System.Int32 workID, System.Int32 roleID);
	}
}