using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：ModelTemplates 的DTO类.
	/// </summary>
	public partial class ModelTemplatesDTO
	{
		#region Properties
		private System.Int32 _templateID = 0;
		/// <summary>
		/// 模型模板ID (主键)
		/// </summary>
		public System.Int32 TemplateID
		{
			get {return _templateID;}
			set {_templateID = value;}
		}
		private System.String _templateName = string.Empty;
		/// <summary>
		/// 模型模板名 
		/// </summary>
		public System.String TemplateName
		{
			get {return _templateName;}
			set {_templateName = value;}
		}
		private System.String _templateDescription = string.Empty;
		/// <summary>
		/// 模型模板描述 
		/// </summary>
		public System.String TemplateDescription
		{
			get {return _templateDescription;}
			set {_templateDescription = value;}
		}
		private System.String _field = string.Empty;
		/// <summary>
		/// 模型模板XML 
		/// </summary>
		public System.String Field
		{
			get {return _field;}
			set {_field = value;}
		}
		private System.Boolean _isEshop = false;
		/// <summary>
		/// 模型类型 
		/// </summary>
		public System.Boolean IsEshop
		{
			get {return _isEshop;}
			set {_isEshop = value;}
		}
		#endregion
	}
}
