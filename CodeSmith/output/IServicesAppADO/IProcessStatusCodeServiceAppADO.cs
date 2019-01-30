﻿using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：ProcessStatusCode 的应用层服务接口.
	/// </summary>
	public partial interface IProcessStatusCodeServiceAppADO : IServiceAppADO<ProcessStatusCodeDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 flowID, System.Int32 processID, System.Int32 statusCode);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 flowID, System.Int32 processID, System.Int32 statusCode);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		ProcessStatusCodeDTO GetDTO(System.Int32 flowID, System.Int32 processID, System.Int32 statusCode);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<ProcessStatusCodeDTO> GetDTOAsync(System.Int32 flowID, System.Int32 processID, System.Int32 statusCode);
	}
}