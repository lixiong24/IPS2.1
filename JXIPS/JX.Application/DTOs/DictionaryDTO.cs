﻿using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：Dictionary 的DTO类.
	/// </summary>
	public partial class DictionaryDTO
	{
		#region Properties
		private System.Int32 _fieldID = 0;
		/// <summary>
		/// 字段ID (主键)(自增长)
		/// </summary>
		public System.Int32 FieldID
		{
			get {return _fieldID;}
			set {_fieldID = value;}
		}
		private System.String _title = string.Empty;
		/// <summary>
		/// 字段标题 
		/// </summary>
		public System.String Title
		{
			get {return _title;}
			set {_title = value;}
		}
		private System.String _tableName = string.Empty;
		/// <summary>
		/// 字段所属的表名 
		/// </summary>
		public System.String TableName
		{
			get {return _tableName;}
			set {_tableName = value;}
		}
		private System.String _fieldName = string.Empty;
		/// <summary>
		/// 字段名 
		/// </summary>
		public System.String FieldName
		{
			get {return _fieldName;}
			set {_fieldName = value;}
		}
		private System.String _fieldValue = string.Empty;
		/// <summary>
		/// 字段值（选项名|是否启用值|默认值） 
		/// </summary>
		public System.String FieldValue
		{
			get {return _fieldValue;}
			set {_fieldValue = value;}
		}
		#endregion
	}
}