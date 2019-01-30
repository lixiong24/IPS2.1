using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatColor 的DTO类.
	/// </summary>
	public partial class StatColorDTO
	{
		#region Properties
		private System.String _tColor = string.Empty;
		/// <summary>
		/// 颜色 (主键)
		/// </summary>
		public System.String TColor
		{
			get {return _tColor;}
			set {_tColor = value;}
		}
		private System.Int32 _tColNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TColNum
		{
			get {return _tColNum;}
			set {_tColNum = value;}
		}
		#endregion
	}
}
