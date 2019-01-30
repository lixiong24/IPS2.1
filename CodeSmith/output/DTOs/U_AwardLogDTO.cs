using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：U_AwardLog 的DTO类.
	/// </summary>
	public partial class U_AwardLogDTO
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
		private System.String _guestName = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String GuestName
		{
			get {return _guestName;}
			set {_guestName = value;}
		}
		#endregion
	}
}
