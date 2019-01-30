using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：RoleNodePermissions 的应用层服务接口.
	/// </summary>
	public partial interface IRoleNodePermissionsServiceAppADO : IServiceAppADO<RoleNodePermissionsDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 roleID, System.Int32 nodeID, System.String operateCode);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 roleID, System.Int32 nodeID, System.String operateCode);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		RoleNodePermissionsDTO GetDTO(System.Int32 roleID, System.Int32 nodeID, System.String operateCode);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<RoleNodePermissionsDTO> GetDTOAsync(System.Int32 roleID, System.Int32 nodeID, System.String operateCode);
	}
}