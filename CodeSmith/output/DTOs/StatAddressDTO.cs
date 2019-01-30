using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatAddress 的DTO类.
	/// </summary>
	public partial class StatAddressDTO
	{
		#region Properties
		private System.String _tAddress = string.Empty;
		/// <summary>
		/// 地区名称 (主键)
		/// </summary>
		public System.String TAddress
		{
			get {return _tAddress;}
			set {_tAddress = value;}
		}
		private System.Int32 _tAddNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TAddNum
		{
			get {return _tAddNum;}
			set {_tAddNum = value;}
		}
		#endregion
	}
}
