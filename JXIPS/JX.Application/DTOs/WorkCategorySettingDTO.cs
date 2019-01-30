using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：WorkCategorySetting 的DTO类.
	/// </summary>
	public partial class WorkCategorySettingDTO
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
		private System.Int32 _workCategoryID = 0;
		/// <summary>
		/// 类别ID 
		/// </summary>
		public System.Int32 WorkCategoryID
		{
			get {return _workCategoryID;}
			set {_workCategoryID = value;}
		}
		private System.Int32 _customFormID = 0;
		/// <summary>
		/// 自定义表单ID 
		/// </summary>
		public System.Int32 CustomFormID
		{
			get {return _customFormID;}
			set {_customFormID = value;}
		}
		private System.String _templateOfAdmin = string.Empty;
		/// <summary>
		/// 后台表单提交页布局模板 
		/// </summary>
		public System.String TemplateOfAdmin
		{
			get {return _templateOfAdmin;}
			set {_templateOfAdmin = value;}
		}
		private System.String _templateOfUser = string.Empty;
		/// <summary>
		/// 前台表单提交页布局模板 
		/// </summary>
		public System.String TemplateOfUser
		{
			get {return _templateOfUser;}
			set {_templateOfUser = value;}
		}
		#endregion
	}
}
