// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: ContentPermission.cs
// 修改时间：2017/12/26 17:33:28
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：ContentPermission 的实体类.
	/// </summary>
	public partial class ContentPermission
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
