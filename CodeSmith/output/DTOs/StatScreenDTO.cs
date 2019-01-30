using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatScreen 的DTO类.
	/// </summary>
	public partial class StatScreenDTO
	{
		#region Properties
		private System.String _tScreen = string.Empty;
		/// <summary>
		/// 分辨率 (主键)
		/// </summary>
		public System.String TScreen
		{
			get {return _tScreen;}
			set {_tScreen = value;}
		}
		private System.Int32 _tScrNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TScrNum
		{
			get {return _tScrNum;}
			set {_tScrNum = value;}
		}
		#endregion
	}
}
