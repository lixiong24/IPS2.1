using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：ContentPermission 的DTO类.
	/// </summary>
	public partial class ContentPermissionDTO
	{
		#region Properties
		private System.Int32 _generalID = 0;
		/// <summary>
		/// 内容ID (主键)
		/// </summary>
		public System.Int32 GeneralID
		{
			get {return _generalID;}
			set {_generalID = value;}
		}
		private System.Int32 _permissionType = 0;
		/// <summary>
		/// 权限类型 
		/// </summary>
		public System.Int32 PermissionType
		{
			get {return _permissionType;}
			set {_permissionType = value;}
		}
		private System.String _arrGroupID = string.Empty;
		/// <summary>
		/// 用户组数组 
		/// </summary>
		public System.String ArrGroupID
		{
			get {return _arrGroupID;}
			set {_arrGroupID = value;}
		}
		#endregion
	}
}
