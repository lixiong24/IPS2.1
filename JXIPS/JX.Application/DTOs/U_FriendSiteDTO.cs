using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：U_FriendSite 的DTO类.
	/// </summary>
	public partial class U_FriendSiteDTO
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
		private System.String _siteUrl = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String SiteUrl
		{
			get {return _siteUrl;}
			set {_siteUrl = value;}
		}
		private System.String _siteIntro = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String SiteIntro
		{
			get {return _siteIntro;}
			set {_siteIntro = value;}
		}
		private System.String _siteAdmin = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String SiteAdmin
		{
			get {return _siteAdmin;}
			set {_siteAdmin = value;}
		}
		private System.String _siteEmail = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String SiteEmail
		{
			get {return _siteEmail;}
			set {_siteEmail = value;}
		}
		private System.String _sitePassword = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String SitePassword
		{
			get {return _sitePassword;}
			set {_sitePassword = value;}
		}
		private System.String _confirmPassword = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String ConfirmPassword
		{
			get {return _confirmPassword;}
			set {_confirmPassword = value;}
		}
		#endregion
	}
}
