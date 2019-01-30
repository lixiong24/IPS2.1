using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：GroupSpecialPermissions 的应用层服务接口.
	/// </summary>
	public partial interface IGroupSpecialPermissionsServiceAppADO : IServiceAppADO<GroupSpecialPermissionsDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 groupID, System.Int32 operateCode, System.Int32 specialID, System.Int32 iDType);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 groupID, System.Int32 operateCode, System.Int32 specialID, System.Int32 iDType);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		GroupSpecialPermissionsDTO GetDTO(System.Int32 groupID, System.Int32 operateCode, System.Int32 specialID, System.Int32 iDType);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<GroupSpecialPermissionsDTO> GetDTOAsync(System.Int32 groupID, System.Int32 operateCode, System.Int32 specialID, System.Int32 iDType);
	}
}