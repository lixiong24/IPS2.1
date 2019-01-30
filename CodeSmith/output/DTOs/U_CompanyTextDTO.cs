using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：U_CompanyText 的DTO类.
	/// </summary>
	public partial class U_CompanyTextDTO
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
		#endregion
	}
}
