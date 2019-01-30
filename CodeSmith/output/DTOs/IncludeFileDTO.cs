using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：IncludeFile 的DTO类.
	/// </summary>
	public partial class IncludeFileDTO
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		/// ID (主键)
		/// </summary>
		public System.Int32 ID
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.String _name = string.Empty;
		/// <summary>
		/// 名称 
		/// </summary>
		public System.String Name
		{
			get {return _name;}
			set {_name = value;}
		}
		private System.String _description = string.Empty;
		/// <summary>
		/// 说明 
		/// </summary>
		public System.String Description
		{
			get {return _description;}
			set {_description = value;}
		}
		private System.Int32 _includeType = 0;
		/// <summary>
		/// 类型 
		/// </summary>
		public System.Int32 IncludeType
		{
			get {return _includeType;}
			set {_includeType = value;}
		}
		private System.Int32 _associateType = 0;
		/// <summary>
		/// 关联生成类型，0-不关联，1-关联节点，2-关联专题 
		/// </summary>
		public System.Int32 AssociateType
		{
			get {return _associateType;}
			set {_associateType = value;}
		}
		private System.String _fileName = string.Empty;
		/// <summary>
		/// 文件名 
		/// </summary>
		public System.String FileName
		{
			get {return _fileName;}
			set {_fileName = value;}
		}
		private System.String _template = string.Empty;
		/// <summary>
		/// 模板 
		/// </summary>
		public System.String Template
		{
			get {return _template;}
			set {_template = value;}
		}
		#endregion
	}
}
