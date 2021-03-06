﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：U_Provide 的DTO类.
	/// </summary>
	public partial class U_ProvideDTO
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		///  (主键)
		/// </summary>
		public System.Int32 ID
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.String _pCategory = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String PCategory
		{
			get {return _pCategory;}
			set {_pCategory = value;}
		}
		private System.String _buyAmount = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String BuyAmount
		{
			get {return _buyAmount;}
			set {_buyAmount = value;}
		}
		private System.String _consultNumber = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String ConsultNumber
		{
			get {return _consultNumber;}
			set {_consultNumber = value;}
		}
		private System.String _applyType = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String ApplyType
		{
			get {return _applyType;}
			set {_applyType = value;}
		}
		private System.String _oENumber = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String OENumber
		{
			get {return _oENumber;}
			set {_oENumber = value;}
		}
		private System.String _agoraType = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String AgoraType
		{
			get {return _agoraType;}
			set {_agoraType = value;}
		}
		private System.String _periodOfValidity = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String PeriodOfValidity
		{
			get {return _periodOfValidity;}
			set {_periodOfValidity = value;}
		}
		private System.String _selfParameter = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String SelfParameter
		{
			get {return _selfParameter;}
			set {_selfParameter = value;}
		}
		private System.String _orderInfo = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String OrderInfo
		{
			get {return _orderInfo;}
			set {_orderInfo = value;}
		}
		private System.String _packExplain = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String PackExplain
		{
			get {return _packExplain;}
			set {_packExplain = value;}
		}
		private System.String _intro = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Intro
		{
			get {return _intro;}
			set {_intro = value;}
		}
		private System.String _content = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Content
		{
			get {return _content;}
			set {_content = value;}
		}
		#endregion
	}
}
