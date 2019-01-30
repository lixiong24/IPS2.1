using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：U_Buying 的DTO类.
	/// </summary>
	public partial class U_BuyingDTO
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
		private DateTime? _beginTime = DateTime.MaxValue;
		/// <summary>
		///  
		/// </summary>
		public DateTime? BeginTime
		{
			get {return _beginTime;}
			set {_beginTime = value;}
		}
		private DateTime? _endTime = DateTime.MaxValue;
		/// <summary>
		///  
		/// </summary>
		public DateTime? EndTime
		{
			get {return _endTime;}
			set {_endTime = value;}
		}
		#endregion
	}
}
