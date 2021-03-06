﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：Stock 的DTO类.
	/// </summary>
	public partial class StockDTO
	{
		#region Properties
		private System.Int32 _stockID = 0;
		/// <summary>
		/// ID (主键)
		/// </summary>
		public System.Int32 StockID
		{
			get {return _stockID;}
			set {_stockID = value;}
		}
		private System.String _stockNum = string.Empty;
		/// <summary>
		/// 库单编号 
		/// </summary>
		public System.String StockNum
		{
			get {return _stockNum;}
			set {_stockNum = value;}
		}
		private DateTime? _inputTime = DateTime.MaxValue;
		/// <summary>
		/// 录入时间 
		/// </summary>
		public DateTime? InputTime
		{
			get {return _inputTime;}
			set {_inputTime = value;}
		}
		private System.String _inputer = string.Empty;
		/// <summary>
		/// 录入者 
		/// </summary>
		public System.String Inputer
		{
			get {return _inputer;}
			set {_inputer = value;}
		}
		private System.Int32 _stockType = 0;
		/// <summary>
		/// 库单类型 
		/// </summary>
		public System.Int32 StockType
		{
			get {return _stockType;}
			set {_stockType = value;}
		}
		private System.String _remark = string.Empty;
		/// <summary>
		/// 备注 
		/// </summary>
		public System.String Remark
		{
			get {return _remark;}
			set {_remark = value;}
		}
		#endregion
	}
}
