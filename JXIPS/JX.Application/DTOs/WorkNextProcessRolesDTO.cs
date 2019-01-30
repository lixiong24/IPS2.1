using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：WorkNextProcessRoles 的DTO类.
	/// </summary>
	public partial class WorkNextProcessRolesDTO
	{
		#region Properties
		private System.Int32 _workID = 0;
		/// <summary>
		/// 自定义表单数据ID (主键)
		/// </summary>
		public System.Int32 WorkID
		{
			get {return _workID;}
			set {_workID = value;}
		}
		private System.Int32 _roleID = 0;
		/// <summary>
		/// 角色ID (主键)
		/// </summary>
		public System.Int32 RoleID
		{
			get {return _roleID;}
			set {_roleID = value;}
		}
		#endregion
	}
}
