using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatRefer 的DTO类.
	/// </summary>
	public partial class StatReferDTO
	{
		#region Properties
		private System.String _tRefer = string.Empty;
		/// <summary>
		/// 引用地址 (主键)
		/// </summary>
		public System.String TRefer
		{
			get {return _tRefer;}
			set {_tRefer = value;}
		}
		private System.Int32 _tRefNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TRefNum
		{
			get {return _tRefNum;}
			set {_tRefNum = value;}
		}
		#endregion
	}
}
