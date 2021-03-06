﻿using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：U_Article 的应用层服务接口.
	/// </summary>
	public partial interface IU_ArticleServiceAppADO : IServiceAppADO<U_ArticleDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 id);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 id);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		U_ArticleDTO GetDTO(System.Int32 id);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<U_ArticleDTO> GetDTOAsync(System.Int32 id);
	}
}