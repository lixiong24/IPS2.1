using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatWeburl 的DTO类.
	/// </summary>
	public partial class StatWeburlDTO
	{
		#region Properties
		private System.String _tWeburl = string.Empty;
		/// <summary>
		/// 用户来自何网址 (主键)
		/// </summary>
		public System.String TWeburl
		{
			get {return _tWeburl;}
			set {_tWeburl = value;}
		}
		private System.Int32 _tWebNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TWebNum
		{
			get {return _tWebNum;}
			set {_tWebNum = value;}
		}
		#endregion
	}
}
