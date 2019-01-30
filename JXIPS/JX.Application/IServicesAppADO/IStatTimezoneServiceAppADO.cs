using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：StatTimezone 的应用层服务接口.
	/// </summary>
	public partial interface IStatTimezoneServiceAppADO : IServiceAppADO<StatTimezoneDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.String tTimezone);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.String tTimezone);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		StatTimezoneDTO GetDTO(System.String tTimezone);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<StatTimezoneDTO> GetDTOAsync(System.String tTimezone);
	}
}