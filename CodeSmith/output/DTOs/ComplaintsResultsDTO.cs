﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：ComplaintsResults 的DTO类.
	/// </summary>
	public partial class ComplaintsResultsDTO
	{
		#region Properties
		private System.Int32 _rid = 0;
		/// <summary>
		/// 处理结果ID (主键)
		/// </summary>
		public System.Int32 RID
		{
			get {return _rid;}
			set {_rid = value;}
		}
		private System.Int32 _cid = 0;
		/// <summary>
		/// 投诉ID 
		/// </summary>
		public System.Int32 CID
		{
			get {return _cid;}
			set {_cid = value;}
		}
		private System.Int32 _rAdminID = 0;
		/// <summary>
		/// 处理人ID 
		/// </summary>
		public System.Int32 RAdminID
		{
			get {return _rAdminID;}
			set {_rAdminID = value;}
		}
		private System.String _rContent = string.Empty;
		/// <summary>
		/// 处理描述 
		/// </summary>
		public System.String RContent
		{
			get {return _rContent;}
			set {_rContent = value;}
		}
		private DateTime? _rTime = DateTime.MaxValue;
		/// <summary>
		/// 处理时间 
		/// </summary>
		public DateTime? RTime
		{
			get {return _rTime;}
			set {_rTime = value;}
		}
		private System.String _rState = string.Empty;
		/// <summary>
		/// 内部状态 
		/// </summary>
		public System.String RState
		{
			get {return _rState;}
			set {_rState = value;}
		}
		#endregion
	}
}
