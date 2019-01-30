// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: ProcessStatusCode.cs
// 修改时间：2017/12/26 17:33:32
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：ProcessStatusCode 的实体类.
	/// </summary>
	public partial class ProcessStatusCode
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
