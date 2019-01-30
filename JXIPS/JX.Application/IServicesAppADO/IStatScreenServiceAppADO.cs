using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：StatScreen 的应用层服务接口.
	/// </summary>
	public partial interface IStatScreenServiceAppADO : IServiceAppADO<StatScreenDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.String tScreen);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.String tScreen);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		StatScreenDTO GetDTO(System.String tScreen);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<StatScreenDTO> GetDTOAsync(System.String tScreen);
	}
}