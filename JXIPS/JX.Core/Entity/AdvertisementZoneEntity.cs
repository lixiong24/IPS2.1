// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: AdvertisementZone.cs
// 修改时间：2017/12/26 17:33:25
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：AdvertisementZone 的实体类.
	/// </summary>
	public partial class AdvertisementZone
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
