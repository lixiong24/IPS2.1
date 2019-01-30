using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：SigninLog 的DTO类.
	/// </summary>
	public partial class SigninLogDTO
	{
		#region Properties
		private System.Int32 _generalID = 0;
		/// <summary>
		/// 内容ID (主键)
		/// </summary>
		public System.Int32 GeneralID
		{
			get {return _generalID;}
			set {_generalID = value;}
		}
		private System.String _userName = string.Empty;
		/// <summary>
		/// 签收用户 (主键)
		/// </summary>
		public System.String UserName
		{
			get {return _userName;}
			set {_userName = value;}
		}
		private System.Boolean _isSignin = false;
		/// <summary>
		/// 是否签收 
		/// </summary>
		public System.Boolean IsSignin
		{
			get {return _isSignin;}
			set {_isSignin = value;}
		}
		private DateTime? _signinTime = DateTime.MaxValue;
		/// <summary>
		/// 签收时间 
		/// </summary>
		public DateTime? SigninTime
		{
			get {return _signinTime;}
			set {_signinTime = value;}
		}
		private System.String _ip = string.Empty;
		/// <summary>
		/// 签收IP 
		/// </summary>
		public System.String IP
		{
			get {return _ip;}
			set {_ip = value;}
		}
		#endregion
	}
}
