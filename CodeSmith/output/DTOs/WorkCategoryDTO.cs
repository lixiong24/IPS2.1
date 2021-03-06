﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：WorkCategory 的DTO类.
	/// </summary>
	public partial class WorkCategoryDTO
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		/// 自定义表单类别ID (主键)
		/// </summary>
		public System.Int32 ID
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.Int32 _parentID = 0;
		/// <summary>
		/// 父类别ID 
		/// </summary>
		public System.Int32 ParentID
		{
			get {return _parentID;}
			set {_parentID = value;}
		}
		private System.String _name = string.Empty;
		/// <summary>
		/// 类别名称 
		/// </summary>
		public System.String Name
		{
			get {return _name;}
			set {_name = value;}
		}
		private System.String _description = string.Empty;
		/// <summary>
		/// 描述 
		/// </summary>
		public System.String Description
		{
			get {return _description;}
			set {_description = value;}
		}
		private System.Int32 _orderSort = 0;
		/// <summary>
		/// 排序ID 
		/// </summary>
		public System.Int32 OrderSort
		{
			get {return _orderSort;}
			set {_orderSort = value;}
		}
		private System.Int32 _flowID = 0;
		/// <summary>
		/// 流程ID 
		/// </summary>
		public System.Int32 FlowID
		{
			get {return _flowID;}
			set {_flowID = value;}
		}
		#endregion
	}
}
