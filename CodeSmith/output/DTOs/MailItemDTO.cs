using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：MailItem 的DTO类.
	/// </summary>
	public partial class MailItemDTO
	{
		#region Properties
		private System.Int32 _mailListId = 0;
		/// <summary>
		/// 邮件ID (主键)
		/// </summary>
		public System.Int32 MailListId
		{
			get {return _mailListId;}
			set {_mailListId = value;}
		}
		private System.Int32 _subscriptionItemId = 0;
		/// <summary>
		/// 订阅项ID (主键)
		/// </summary>
		public System.Int32 SubscriptionItemId
		{
			get {return _subscriptionItemId;}
			set {_subscriptionItemId = value;}
		}
		#endregion
	}
}
