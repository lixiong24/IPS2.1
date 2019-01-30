using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：Admin 的DTO类.
	/// </summary>
	public partial class AdminDTO
	{
		/// <summary>
		/// 所属角色ID集合，多个ID用“,”分隔
		/// </summary>
		public string RoleIDs { get; set; }
		/// <summary>
		/// 所属角色名称集合，多个名称用“,”分隔
		/// </summary>
		public string RoleNames { get; set; }
	}
}
