using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：MailItem 的应用层服务接口.
	/// </summary>
	public partial interface IMailItemServiceAppADO : IServiceAppADO<MailItemDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 mailListId, System.Int32 subscriptionItemId);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 mailListId, System.Int32 subscriptionItemId);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		MailItemDTO GetDTO(System.Int32 mailListId, System.Int32 subscriptionItemId);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<MailItemDTO> GetDTOAsync(System.Int32 mailListId, System.Int32 subscriptionItemId);
	}
}