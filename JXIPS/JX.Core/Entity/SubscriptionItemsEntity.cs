// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: SubscriptionItems.cs
// 修改时间：2017/12/26 17:33:35
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：SubscriptionItems 的实体类.
	/// </summary>
	public partial class SubscriptionItems
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
