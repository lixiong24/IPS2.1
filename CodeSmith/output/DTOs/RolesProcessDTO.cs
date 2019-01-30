using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：RolesProcess 的DTO类.
	/// </summary>
	public partial class RolesProcessDTO
	{
		#region Properties
		private System.Int32 _flowID = 0;
		/// <summary>
		/// 流程ID (主键)
		/// </summary>
		public System.Int32 FlowID
		{
			get {return _flowID;}
			set {_flowID = value;}
		}
		private System.Int32 _processID = 0;
		/// <summary>
		/// 步骤ID (主键)
		/// </summary>
		public System.Int32 ProcessID
		{
			get {return _processID;}
			set {_processID = value;}
		}
		private System.Int32 _roleID = 0;
		/// <summary>
		/// 角色ID (主键)
		/// </summary>
		public System.Int32 RoleID
		{
			get {return _roleID;}
			set {_roleID = value;}
		}
		#endregion
	}
}
