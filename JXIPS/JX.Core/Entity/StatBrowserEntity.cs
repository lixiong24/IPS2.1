// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: StatBrowser.cs
// 修改时间：2017/12/26 17:33:34
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：StatBrowser 的实体类.
	/// </summary>
	public partial class StatBrowser
	{
		#region Properties
		private System.String _tBrowser = string.Empty;
		/// <summary>
		/// 浏览器 (主键)
		/// </summary>
		public System.String TBrowser
		{
			get {return _tBrowser;}
			set {_tBrowser = value;}
		}
		private System.Int32 _tBrwNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TBrwNum
		{
			get {return _tBrwNum;}
			set {_tBrwNum = value;}
		}
		#endregion
	}
}
