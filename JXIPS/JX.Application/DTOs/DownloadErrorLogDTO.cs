﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：DownloadErrorLog 的DTO类.
	/// </summary>
	public partial class DownloadErrorLogDTO
	{
		#region Properties
		private System.Int32 _errorID = 0;
		/// <summary>
		/// 错误ID (主键)
		/// </summary>
		public System.Int32 ErrorID
		{
			get {return _errorID;}
			set {_errorID = value;}
		}
		private System.Int32 _infoID = 0;
		/// <summary>
		/// 错误信息ID 
		/// </summary>
		public System.Int32 InfoID
		{
			get {return _infoID;}
			set {_infoID = value;}
		}
		private System.String _errorUrl = string.Empty;
		/// <summary>
		/// 用$$$分割的错误下载地址序号 
		/// </summary>
		public System.String ErrorUrl
		{
			get {return _errorUrl;}
			set {_errorUrl = value;}
		}
		private System.Int32 _errorTimes = 0;
		/// <summary>
		/// 报错次数 
		/// </summary>
		public System.Int32 ErrorTimes
		{
			get {return _errorTimes;}
			set {_errorTimes = value;}
		}
		private DateTime? _errorDate = DateTime.MaxValue;
		/// <summary>
		/// 报错日期 
		/// </summary>
		public DateTime? ErrorDate
		{
			get {return _errorDate;}
			set {_errorDate = value;}
		}
		#endregion
	}
}
