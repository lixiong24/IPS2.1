using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：RoleSpecialPermissions 的应用层服务接口.
	/// </summary>
	public partial interface IRoleSpecialPermissionsServiceAppADO : IServiceAppADO<RoleSpecialPermissionsDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 roleID, System.Int32 specialID, System.String operateCode);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 roleID, System.Int32 specialID, System.String operateCode);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		RoleSpecialPermissionsDTO GetDTO(System.Int32 roleID, System.Int32 specialID, System.String operateCode);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<RoleSpecialPermissionsDTO> GetDTOAsync(System.Int32 roleID, System.Int32 specialID, System.String operateCode);
	}
}