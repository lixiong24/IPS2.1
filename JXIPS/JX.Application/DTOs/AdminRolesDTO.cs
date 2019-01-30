using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：AdminRoles 的DTO类.
	/// </summary>
	public partial class AdminRolesDTO
	{
		#region Properties
		private System.Int32 _adminID = 0;
		/// <summary>
		/// 管理员ID (主键)
		/// </summary>
		public System.Int32 AdminID
		{
			get {return _adminID;}
			set {_adminID = value;}
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
