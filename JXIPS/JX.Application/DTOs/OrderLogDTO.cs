using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：OrderLog 的DTO类.
	/// </summary>
	public partial class OrderLogDTO
	{
		#region Properties
		private System.Int32 _orderLogID = 0;
		/// <summary>
		/// 订单历史记录ID (主键)(自增长)
		/// </summary>
		public System.Int32 OrderLogID
		{
			get {return _orderLogID;}
			set {_orderLogID = value;}
		}
		private System.String _orderNum = string.Empty;
		/// <summary>
		/// 订单编号 
		/// </summary>
		public System.String OrderNum
		{
			get {return _orderNum;}
			set {_orderNum = value;}
		}
		private System.String _actionName = string.Empty;
		/// <summary>
		/// 操作名称 
		/// </summary>
		public System.String ActionName
		{
			get {return _actionName;}
			set {_actionName = value;}
		}
		private DateTime? _actionTime = DateTime.MaxValue;
		/// <summary>
		/// 操作时间 
		/// </summary>
		public DateTime? ActionTime
		{
			get {return _actionTime;}
			set {_actionTime = value;}
		}
		private System.String _userIP = string.Empty;
		/// <summary>
		/// 用户IP 
		/// </summary>
		public System.String UserIP
		{
			get {return _userIP;}
			set {_userIP = value;}
		}
		private System.String _userName = string.Empty;
		/// <summary>
		/// 操作员名称 
		/// </summary>
		public System.String UserName
		{
			get {return _userName;}
			set {_userName = value;}
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
