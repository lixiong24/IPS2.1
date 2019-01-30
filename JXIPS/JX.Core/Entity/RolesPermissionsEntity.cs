// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: RolesPermissions.cs
// 修改时间：2017/12/26 17:33:33
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：RolesPermissions 的实体类.
	/// </summary>
	public partial class RolesPermissions
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
