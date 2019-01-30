// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: RoleSpecialPermissions.cs
// 修改时间：2018/1/4 19:07:47
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：RoleSpecialPermissions 的实体类.
	/// </summary>
	public partial class RoleSpecialPermissions
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
		private System.Int32 _specialID = 0;
		/// <summary>
		/// 专题ID (主键)
		/// </summary>
		public System.Int32 SpecialID
		{
			get {return _specialID;}
			set {_specialID = value;}
		}
		private System.String _operateCode = string.Empty;
		/// <summary>
		/// 权限操作码值 (主键)
		/// </summary>
		public System.String OperateCode
		{
			get {return _operateCode;}
			set {_operateCode = value;}
		}
		#endregion
	}
}
