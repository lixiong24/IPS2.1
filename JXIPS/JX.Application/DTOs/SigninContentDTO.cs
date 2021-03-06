﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：SigninContent 的DTO类.
	/// </summary>
	public partial class SigninContentDTO
	{
		#region Properties
		private System.Int32 _generalID = 0;
		/// <summary>
		/// 内容ID (主键)
		/// </summary>
		public System.Int32 GeneralID
		{
			get {return _generalID;}
			set {_generalID = value;}
		}
		private System.String _title = string.Empty;
		/// <summary>
		/// 内容标题 
		/// </summary>
		public System.String Title
		{
			get {return _title;}
			set {_title = value;}
		}
		private System.Int32 _signinType = 0;
		/// <summary>
		/// 签收类型 
		/// </summary>
		public System.Int32 SigninType
		{
			get {return _signinType;}
			set {_signinType = value;}
		}
		private System.Int32 _priority = 0;
		/// <summary>
		/// 优先级 
		/// </summary>
		public System.Int32 Priority
		{
			get {return _priority;}
			set {_priority = value;}
		}
		private DateTime? _endTime = DateTime.MaxValue;
		/// <summary>
		/// 签收截止时间 
		/// </summary>
		public DateTime? EndTime
		{
			get {return _endTime;}
			set {_endTime = value;}
		}
		private System.Int32 _status = 0;
		/// <summary>
		/// 签收状态 
		/// </summary>
		public System.Int32 Status
		{
			get {return _status;}
			set {_status = value;}
		}
		#endregion
	}
}
