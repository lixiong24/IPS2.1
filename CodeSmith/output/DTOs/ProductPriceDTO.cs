using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：ProductPrice 的DTO类.
	/// </summary>
	public partial class ProductPriceDTO
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		/// ID (主键)(自增长)
		/// </summary>
		public System.Int32 ID
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.Int32 _productID = 0;
		/// <summary>
		/// 商品ID 
		/// </summary>
		public System.Int32 ProductID
		{
			get {return _productID;}
			set {_productID = value;}
		}
		private System.String _propertyValue = string.Empty;
		/// <summary>
		/// 属性值 
		/// </summary>
		public System.String PropertyValue
		{
			get {return _propertyValue;}
			set {_propertyValue = value;}
		}
		private System.String _tableName = string.Empty;
		/// <summary>
		/// 表名 
		/// </summary>
		public System.String TableName
		{
			get {return _tableName;}
			set {_tableName = value;}
		}
		private System.Int32 _groupID = 0;
		/// <summary>
		/// 会员组ID 
		/// </summary>
		public System.Int32 GroupID
		{
			get {return _groupID;}
			set {_groupID = value;}
		}
		private System.Decimal _price = 0;
		/// <summary>
		/// 价格 
		/// </summary>
		public System.Decimal Price
		{
			get {return _price;}
			set {_price = value;}
		}
		#endregion
	}
}
