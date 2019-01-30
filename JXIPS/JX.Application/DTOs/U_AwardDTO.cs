using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：U_Award 的DTO类.
	/// </summary>
	public partial class U_AwardDTO
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
		private System.Double _weight = 0.0f;
		/// <summary>
		///  
		/// </summary>
		public System.Double Weight
		{
			get {return _weight;}
			set {_weight = value;}
		}
		private System.String _number = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Number
		{
			get {return _number;}
			set {_number = value;}
		}
		#endregion
	}
}
