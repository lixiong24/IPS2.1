using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：SubscriptionItems 的DTO类.
	/// </summary>
	public partial class SubscriptionItemsDTO
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		/// 订阅项ID (主键)(自增长)
		/// </summary>
		public System.Int32 Id
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.String _name = string.Empty;
		/// <summary>
		/// 订阅项名称 
		/// </summary>
		public System.String Name
		{
			get {return _name;}
			set {_name = value;}
		}
		#endregion
	}
}
