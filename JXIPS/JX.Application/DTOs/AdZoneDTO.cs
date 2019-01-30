using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：AdZone 的DTO类.
	/// </summary>
	public partial class AdZoneDTO
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
		private System.String _zoneName = string.Empty;
		/// <summary>
		/// 版位名称 
		/// </summary>
		public System.String ZoneName
		{
			get {return _zoneName;}
			set {_zoneName = value;}
		}
		private System.String _zoneJSName = string.Empty;
		/// <summary>
		/// 版位JS文件名 
		/// </summary>
		public System.String ZoneJSName
		{
			get {return _zoneJSName;}
			set {_zoneJSName = value;}
		}
		private System.String _zoneIntro = string.Empty;
		/// <summary>
		/// 版位简介 
		/// </summary>
		public System.String ZoneIntro
		{
			get {return _zoneIntro;}
			set {_zoneIntro = value;}
		}
		private System.Int32 _zoneType = 0;
		/// <summary>
		/// 版位广告显示类型 
		/// </summary>
		public System.Int32 ZoneType
		{
			get {return _zoneType;}
			set {_zoneType = value;}
		}
		private System.Boolean _isDefaultSetting = false;
		/// <summary>
		/// 是否默认设置 
		/// </summary>
		public System.Boolean IsDefaultSetting
		{
			get {return _isDefaultSetting;}
			set {_isDefaultSetting = value;}
		}
		private System.String _zoneSetting = string.Empty;
		/// <summary>
		/// 版位设置参数 
		/// </summary>
		public System.String ZoneSetting
		{
			get {return _zoneSetting;}
			set {_zoneSetting = value;}
		}
		private System.Int32 _zoneWidth = 0;
		/// <summary>
		/// 版位的宽度 
		/// </summary>
		public System.Int32 ZoneWidth
		{
			get {return _zoneWidth;}
			set {_zoneWidth = value;}
		}
		private System.Int32 _zoneHeight = 0;
		/// <summary>
		/// 版位的高度 
		/// </summary>
		public System.Int32 ZoneHeight
		{
			get {return _zoneHeight;}
			set {_zoneHeight = value;}
		}
		private System.Boolean _isActive = false;
		/// <summary>
		/// 是否活跃 
		/// </summary>
		public System.Boolean IsActive
		{
			get {return _isActive;}
			set {_isActive = value;}
		}
		private System.Int32 _showType = 0;
		/// <summary>
		/// 版位显示的类型 
		/// </summary>
		public System.Int32 ShowType
		{
			get {return _showType;}
			set {_showType = value;}
		}
		private DateTime? _updateTime = DateTime.MaxValue;
		/// <summary>
		/// 添加版位的时间 
		/// </summary>
		public DateTime? UpdateTime
		{
			get {return _updateTime;}
			set {_updateTime = value;}
		}
		#endregion
	}
}
