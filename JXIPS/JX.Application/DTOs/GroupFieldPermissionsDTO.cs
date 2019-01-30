using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：GroupFieldPermissions 的DTO类.
	/// </summary>
	public partial class GroupFieldPermissionsDTO
	{
		#region Properties
		private System.Int32 _groupID = 0;
		/// <summary>
		/// 会员组ID (主键)
		/// </summary>
		public System.Int32 GroupID
		{
			get {return _groupID;}
			set {_groupID = value;}
		}
		private System.Int32 _operateCode = 0;
		/// <summary>
		/// 权限操作码 (主键)
		/// </summary>
		public System.Int32 OperateCode
		{
			get {return _operateCode;}
			set {_operateCode = value;}
		}
		private System.Int32 _modelID = 0;
		/// <summary>
		/// 模型ID (主键)
		/// </summary>
		public System.Int32 ModelID
		{
			get {return _modelID;}
			set {_modelID = value;}
		}
		private System.String _fieldName = string.Empty;
		/// <summary>
		/// 模型字段名称 (主键)
		/// </summary>
		public System.String FieldName
		{
			get {return _fieldName;}
			set {_fieldName = value;}
		}
		private System.Int32 _idType = 0;
		/// <summary>
		/// ID类型 0 用户 1 用户组 (主键)
		/// </summary>
		public System.Int32 IdType
		{
			get {return _idType;}
			set {_idType = value;}
		}
		#endregion
	}
}
