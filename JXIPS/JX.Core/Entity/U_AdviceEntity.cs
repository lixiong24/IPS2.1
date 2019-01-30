// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: U_Advice.cs
// 修改时间：2017/12/26 17:33:35
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：U_Advice 的实体类.
	/// </summary>
	public partial class U_Advice
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		///  (主键)
		/// </summary>
		public System.Int32 ID
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.String _content = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Content
		{
			get {return _content;}
			set {_content = value;}
		}
		private System.String _replyContent = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String ReplyContent
		{
			get {return _replyContent;}
			set {_replyContent = value;}
		}
		#endregion
	}
}
