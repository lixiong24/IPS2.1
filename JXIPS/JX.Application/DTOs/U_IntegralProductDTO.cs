﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：U_IntegralProduct 的DTO类.
	/// </summary>
	public partial class U_IntegralProductDTO
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
		private System.String _price = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Price
		{
			get {return _price;}
			set {_price = value;}
		}
		private System.String _needIntegral = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String NeedIntegral
		{
			get {return _needIntegral;}
			set {_needIntegral = value;}
		}
		private System.String _stocks = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Stocks
		{
			get {return _stocks;}
			set {_stocks = value;}
		}
		private System.String _description = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Description
		{
			get {return _description;}
			set {_description = value;}
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
		private System.String _keyword = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Keyword
		{
			get {return _keyword;}
			set {_keyword = value;}
		}
		#endregion
	}
}
