using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：StatMozilla 的应用层服务接口.
	/// </summary>
	public partial interface IStatMozillaServiceAppADO : IServiceAppADO<StatMozillaDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.String tMozilla);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.String tMozilla);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		StatMozillaDTO GetDTO(System.String tMozilla);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<StatMozillaDTO> GetDTOAsync(System.String tMozilla);
	}
}