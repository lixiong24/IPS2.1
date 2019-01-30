using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：Roles 的DTO类.
	/// </summary>
	public partial class RolesDTO
	{
		#region Properties
		private System.Int32 _roleID = 0;
		/// <summary>
		/// 角色ID (主键)
		/// </summary>
		public System.Int32 RoleID
		{
			get {return _roleID;}
			set {_roleID = value;}
		}
		private System.String _roleName = string.Empty;
		/// <summary>
		/// 角色名 
		/// </summary>
		public System.String RoleName
		{
			get {return _roleName;}
			set {_roleName = value;}
		}
		private System.String _description = string.Empty;
		/// <summary>
		/// 角色说明 
		/// </summary>
		public System.String Description
		{
			get {return _description;}
			set {_description = value;}
		}
		#endregion
	}
}
