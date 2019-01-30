using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatIp 的DTO类.
	/// </summary>
	public partial class StatIpDTO
	{
		#region Properties
		private System.String _tIp = string.Empty;
		/// <summary>
		/// Ip地址 (主键)
		/// </summary>
		public System.String TIp
		{
			get {return _tIp;}
			set {_tIp = value;}
		}
		private System.Int32 _tIpNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TIpNum
		{
			get {return _tIpNum;}
			set {_tIpNum = value;}
		}
		#endregion
	}
}
