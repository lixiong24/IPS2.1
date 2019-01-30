using JX.Application.DTOs;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：CollectionFieldRules 的应用层服务接口.
	/// </summary>
	public partial interface ICollectionFieldRulesServiceAppADO : IServiceAppADO<CollectionFieldRulesDTO>
	{
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		bool Delete(System.Int32 fieldRuleID);
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		Task<bool> DeleteAsync(System.Int32 fieldRuleID);
		
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		CollectionFieldRulesDTO GetDTO(System.Int32 fieldRuleID);
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		Task<CollectionFieldRulesDTO> GetDTOAsync(System.Int32 fieldRuleID);
	}
}