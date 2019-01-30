using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatMozilla 的DTO类.
	/// </summary>
	public partial class StatMozillaDTO
	{
		#region Properties
		private System.String _tMozilla = string.Empty;
		/// <summary>
		/// URL字段 (主键)
		/// </summary>
		public System.String TMozilla
		{
			get {return _tMozilla;}
			set {_tMozilla = value;}
		}
		private System.Int32 _tMozNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TMozNum
		{
			get {return _tMozNum;}
			set {_tMozNum = value;}
		}
		#endregion
	}
}
