﻿using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：DeliverType 的应用层服务接口.
	/// </summary>
	public partial interface IDeliverTypeServiceAppADO : IServiceAppADO<DeliverTypeDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 typeID);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 typeID);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		DeliverTypeDTO GetDTO(System.Int32 typeID);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<DeliverTypeDTO> GetDTOAsync(System.Int32 typeID);
	}
}