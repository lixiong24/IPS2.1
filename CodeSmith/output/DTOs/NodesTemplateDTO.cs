using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：NodesTemplate 的DTO类.
	/// </summary>
	public partial class NodesTemplateDTO
	{
		#region Properties
		private System.Int32 _nodeID = 0;
		/// <summary>
		/// 节点ID (主键)
		/// </summary>
		public System.Int32 NodeID
		{
			get {return _nodeID;}
			set {_nodeID = value;}
		}
		private System.Int32 _templateID = 0;
		/// <summary>
		/// 列表模板ID (主键)
		/// </summary>
		public System.Int32 TemplateID
		{
			get {return _templateID;}
			set {_templateID = value;}
		}
		private System.Boolean _isDefault = false;
		/// <summary>
		/// 是否默认 
		/// </summary>
		public System.Boolean IsDefault
		{
			get {return _isDefault;}
			set {_isDefault = value;}
		}
		#endregion
	}
}
