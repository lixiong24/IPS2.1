// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: StatTimezone.cs
// 修改时间：2017/12/26 17:33:34
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：StatTimezone 的实体类.
	/// </summary>
	public partial class StatTimezone
	{
		#region Properties
		private System.String _tTimezone = string.Empty;
		/// <summary>
		/// 时区 (主键)
		/// </summary>
		public System.String TTimezone
		{
			get {return _tTimezone;}
			set {_tTimezone = value;}
		}
		private System.Int32 _tTimNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TTimNum
		{
			get {return _tTimNum;}
			set {_tTimNum = value;}
		}
		#endregion
	}
}
