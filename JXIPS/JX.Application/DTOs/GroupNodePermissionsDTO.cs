using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：GroupNodePermissions 的DTO类.
	/// </summary>
	public partial class GroupNodePermissionsDTO
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
		private System.Int32 _nodeID = 0;
		/// <summary>
		/// 栏目ID (主键)
		/// </summary>
		public System.Int32 NodeID
		{
			get {return _nodeID;}
			set {_nodeID = value;}
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
