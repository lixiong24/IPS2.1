using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：U_IntegralProductLog 的DTO类.
	/// </summary>
	public partial class U_IntegralProductLogDTO
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
		private System.String _productID = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String ProductID
		{
			get {return _productID;}
			set {_productID = value;}
		}
		private System.String _userID = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String UserID
		{
			get {return _userID;}
			set {_userID = value;}
		}
		private System.String _needS = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String NeedS
		{
			get {return _needS;}
			set {_needS = value;}
		}
		private DateTime? _buyTime = DateTime.MaxValue;
		/// <summary>
		///  
		/// </summary>
		public DateTime? BuyTime
		{
			get {return _buyTime;}
			set {_buyTime = value;}
		}
		private System.String _buyCounts = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String BuyCounts
		{
			get {return _buyCounts;}
			set {_buyCounts = value;}
		}
		private System.Boolean _buyState = false;
		/// <summary>
		///  
		/// </summary>
		public System.Boolean BuyState
		{
			get {return _buyState;}
			set {_buyState = value;}
		}
		#endregion
	}
}
