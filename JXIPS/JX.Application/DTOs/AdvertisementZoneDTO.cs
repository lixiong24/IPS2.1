using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：AdvertisementZone 的DTO类.
	/// </summary>
	public partial class AdvertisementZoneDTO
	{
		#region Properties
		private System.Int32 _zoneID = 0;
		/// <summary>
		/// 版位ID (主键)
		/// </summary>
		public System.Int32 ZoneID
		{
			get {return _zoneID;}
			set {_zoneID = value;}
		}
		private System.Int32 _adid = 0;
		/// <summary>
		/// 广告ID (主键)
		/// </summary>
		public System.Int32 ADID
		{
			get {return _adid;}
			set {_adid = value;}
		}
		#endregion
	}
}
