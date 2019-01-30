using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：ProcessStatusCode 的DTO类.
	/// </summary>
	public partial class ProcessStatusCodeDTO
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
		private System.Int32 _statusCode = 0;
		/// <summary>
		/// 状态码 (主键)
		/// </summary>
		public System.Int32 StatusCode
		{
			get {return _statusCode;}
			set {_statusCode = value;}
		}
		#endregion
	}
}
