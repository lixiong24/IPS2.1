using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：GroupSpecialPermissions 的DTO类.
	/// </summary>
	public partial class GroupSpecialPermissionsDTO
	{
		#region Properties
		private System.Int32 _groupID = 0;
		/// <summary>
		/// 用户组ID (主键)
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
		private System.Int32 _specialID = 0;
		/// <summary>
		/// 专题ID (主键)
		/// </summary>
		public System.Int32 SpecialID
		{
			get {return _specialID;}
			set {_specialID = value;}
		}
		private System.Int32 _iDType = 0;
		/// <summary>
		/// ID类型 0 用户 1 用户组 (主键)
		/// </summary>
		public System.Int32 IDType
		{
			get {return _iDType;}
			set {_iDType = value;}
		}
		#endregion
	}
}
