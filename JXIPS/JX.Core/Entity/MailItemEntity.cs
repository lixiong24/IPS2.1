// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: MailItem.cs
// 修改时间：2017/12/26 17:33:31
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：MailItem 的实体类.
	/// </summary>
	public partial class MailItem
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
