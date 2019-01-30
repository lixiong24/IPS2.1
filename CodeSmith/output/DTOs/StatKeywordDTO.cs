using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatKeyword 的DTO类.
	/// </summary>
	public partial class StatKeywordDTO
	{
		#region Properties
		private System.String _tKeyword = string.Empty;
		/// <summary>
		/// 关键字 (主键)
		/// </summary>
		public System.String TKeyword
		{
			get {return _tKeyword;}
			set {_tKeyword = value;}
		}
		private System.Int32 _tKeywordNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TKeywordNum
		{
			get {return _tKeywordNum;}
			set {_tKeywordNum = value;}
		}
		#endregion
	}
}
