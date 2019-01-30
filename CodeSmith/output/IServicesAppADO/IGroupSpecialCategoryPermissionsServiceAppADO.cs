using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：GroupSpecialCategoryPermissions 的应用层服务接口.
	/// </summary>
	public partial interface IGroupSpecialCategoryPermissionsServiceAppADO : IServiceAppADO<GroupSpecialCategoryPermissionsDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 groupID, System.Int32 operateCode, System.Int32 specialCategoryID, System.Int32 iDType);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 groupID, System.Int32 operateCode, System.Int32 specialCategoryID, System.Int32 iDType);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		GroupSpecialCategoryPermissionsDTO GetDTO(System.Int32 groupID, System.Int32 operateCode, System.Int32 specialCategoryID, System.Int32 iDType);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<GroupSpecialCategoryPermissionsDTO> GetDTOAsync(System.Int32 groupID, System.Int32 operateCode, System.Int32 specialCategoryID, System.Int32 iDType);
	}
}