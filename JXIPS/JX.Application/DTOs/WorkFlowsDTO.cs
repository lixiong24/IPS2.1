using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：WorkFlows 的DTO类.
	/// </summary>
	public partial class WorkFlowsDTO
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
		private System.String _flowName = string.Empty;
		/// <summary>
		/// 流程名称 
		/// </summary>
		public System.String FlowName
		{
			get {return _flowName;}
			set {_flowName = value;}
		}
		private System.String _description = string.Empty;
		/// <summary>
		/// 步骤说明 
		/// </summary>
		public System.String Description
		{
			get {return _description;}
			set {_description = value;}
		}
		#endregion
	}
}
