﻿// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: MailList.cs
// 修改时间：2017/12/26 17:33:31
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：MailList 的实体类.
	/// </summary>
	public partial class MailList
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
