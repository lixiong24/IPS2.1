﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：Package 的DTO类.
	/// </summary>
	public partial class PackageDTO
	{
		#region Properties
		private System.Int32 _packageID = 0;
		/// <summary>
		/// 包装ID (主键)(自增长)
		/// </summary>
		public System.Int32 PackageID
		{
			get {return _packageID;}
			set {_packageID = value;}
		}
		private System.String _packageName = string.Empty;
		/// <summary>
		/// 包装名称 
		/// </summary>
		public System.String PackageName
		{
			get {return _packageName;}
			set {_packageName = value;}
		}
		private System.Double _packageWeight = 0.0f;
		/// <summary>
		/// 包装重量(kg) 
		/// </summary>
		public System.Double PackageWeight
		{
			get {return _packageWeight;}
			set {_packageWeight = value;}
		}
		private System.Double _goodsWeightMin = 0.0f;
		/// <summary>
		/// 货物重量上限 
		/// </summary>
		public System.Double GoodsWeightMin
		{
			get {return _goodsWeightMin;}
			set {_goodsWeightMin = value;}
		}
		private System.Double _goodsWeightMax = 0.0f;
		/// <summary>
		/// 货物重量下限 
		/// </summary>
		public System.Double GoodsWeightMax
		{
			get {return _goodsWeightMax;}
			set {_goodsWeightMax = value;}
		}
		#endregion
	}
}
