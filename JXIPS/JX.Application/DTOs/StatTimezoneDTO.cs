using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatTimezone 的DTO类.
	/// </summary>
	public partial class StatTimezoneDTO
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
