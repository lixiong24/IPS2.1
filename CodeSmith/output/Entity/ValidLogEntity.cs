﻿// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: ValidLog.cs
// 修改时间：2018/1/4 19:07:49
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：ValidLog 的实体类.
	/// </summary>
	public partial class ValidLog
	{
		#region Properties
		private System.Int32 _logID = 0;
		/// <summary>
		/// 有效期明细记录ID (主键)(自增长)
		/// </summary>
		public System.Int32 LogID
		{
			get {return _logID;}
			set {_logID = value;}
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
		private System.Int32 _validNum = 0;
		/// <summary>
		/// 有效期数量 
		/// </summary>
		public System.Int32 ValidNum
		{
			get {return _validNum;}
			set {_validNum = value;}
		}
		private System.Int32 _incomePayout = 0;
		/// <summary>
		/// 有效期类型  1--收入  2--支出 
		/// </summary>
		public System.Int32 IncomePayout
		{
			get {return _incomePayout;}
			set {_incomePayout = value;}
		}
		private DateTime? _logTime = DateTime.MaxValue;
		/// <summary>
		/// 记录时间 
		/// </summary>
		public DateTime? LogTime
		{
			get {return _logTime;}
			set {_logTime = value;}
		}
		private System.String _remark = string.Empty;
		/// <summary>
		/// 备注/说明 
		/// </summary>
		public System.String Remark
		{
			get {return _remark;}
			set {_remark = value;}
		}
		private System.String _ip = string.Empty;
		/// <summary>
		/// IP地址 
		/// </summary>
		public System.String IP
		{
			get {return _ip;}
			set {_ip = value;}
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
		private System.String _memo = string.Empty;
		/// <summary>
		/// 内部记录 
		/// </summary>
		public System.String Memo
		{
			get {return _memo;}
			set {_memo = value;}
		}
		#endregion
	}
}
