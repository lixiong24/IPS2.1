﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：Work 的DTO类.
	/// </summary>
	public partial class WorkDTO
	{
		#region Properties
		private System.Int32 _workID = 0;
		/// <summary>
		/// ID (主键)
		/// </summary>
		public System.Int32 WorkID
		{
			get {return _workID;}
			set {_workID = value;}
		}
		private System.String _workName = string.Empty;
		/// <summary>
		/// 标题 
		/// </summary>
		public System.String WorkName
		{
			get {return _workName;}
			set {_workName = value;}
		}
		private System.Int32 _workCategoryID = 0;
		/// <summary>
		/// 类别ID 
		/// </summary>
		public System.Int32 WorkCategoryID
		{
			get {return _workCategoryID;}
			set {_workCategoryID = value;}
		}
		private System.String _userName = string.Empty;
		/// <summary>
		/// 用户名 
		/// </summary>
		public System.String UserName
		{
			get {return _userName;}
			set {_userName = value;}
		}
		private System.String _ip = string.Empty;
		/// <summary>
		/// IP 
		/// </summary>
		public System.String IP
		{
			get {return _ip;}
			set {_ip = value;}
		}
		private DateTime? _inputTime = DateTime.MaxValue;
		/// <summary>
		/// 提交时间 
		/// </summary>
		public DateTime? InputTime
		{
			get {return _inputTime;}
			set {_inputTime = value;}
		}
		private System.Int32 _formID = 0;
		/// <summary>
		/// 自定义表单ID 
		/// </summary>
		public System.Int32 FormID
		{
			get {return _formID;}
			set {_formID = value;}
		}
		private System.String _formTable = string.Empty;
		/// <summary>
		/// 自定义表单表名 
		/// </summary>
		public System.String FormTable
		{
			get {return _formTable;}
			set {_formTable = value;}
		}
		private System.String _flowID = string.Empty;
		/// <summary>
		/// 流程ID 
		/// </summary>
		public System.String FlowID
		{
			get {return _flowID;}
			set {_flowID = value;}
		}
		private System.Int32 _status = 0;
		/// <summary>
		/// 状态 
		/// </summary>
		public System.Int32 Status
		{
			get {return _status;}
			set {_status = value;}
		}
		#endregion
	}
}
