// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: WorkNextProcessRoles.cs
// 修改时间：2017/12/26 17:33:37
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：WorkNextProcessRoles 的实体类.
	/// </summary>
	public partial class WorkNextProcessRoles
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
