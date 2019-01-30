using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：StatWeburl 的应用层服务接口.
	/// </summary>
	public partial interface IStatWeburlServiceAppADO : IServiceAppADO<StatWeburlDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.String tWeburl);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.String tWeburl);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		StatWeburlDTO GetDTO(System.String tWeburl);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<StatWeburlDTO> GetDTOAsync(System.String tWeburl);
	}
}