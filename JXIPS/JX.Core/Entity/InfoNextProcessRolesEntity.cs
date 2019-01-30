// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: InfoNextProcessRoles.cs
// 修改时间：2017/12/26 17:33:30
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：InfoNextProcessRoles 的实体类.
	/// </summary>
	public partial class InfoNextProcessRoles
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
