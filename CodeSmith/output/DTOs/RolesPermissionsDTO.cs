using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：RolesPermissions 的DTO类.
	/// </summary>
	public partial class RolesPermissionsDTO
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
		private System.String _operateCode = string.Empty;
		/// <summary>
		/// 权限操作码 (主键)
		/// </summary>
		public System.String OperateCode
		{
			get {return _operateCode;}
			set {_operateCode = value;}
		}
		#endregion
	}
}
