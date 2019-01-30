using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatBrowser 的DTO类.
	/// </summary>
	public partial class StatBrowserDTO
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
