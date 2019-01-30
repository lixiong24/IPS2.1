using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：MailList 的DTO类.
	/// </summary>
	public partial class MailListDTO
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		/// 邮件ID (主键)(自增长)
		/// </summary>
		public System.Int32 ID
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.String _email = string.Empty;
		/// <summary>
		/// 邮件地址 
		/// </summary>
		public System.String Email
		{
			get {return _email;}
			set {_email = value;}
		}
		#endregion
	}
}
