using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：InfoNextProcessRoles 的DTO类.
	/// </summary>
	public partial class InfoNextProcessRolesDTO
	{
		#region Properties
		private System.Int32 _generalID = 0;
		/// <summary>
		/// 信息ID (主键)
		/// </summary>
		public System.Int32 GeneralID
		{
			get {return _generalID;}
			set {_generalID = value;}
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
