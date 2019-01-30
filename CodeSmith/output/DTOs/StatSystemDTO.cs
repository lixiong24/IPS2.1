using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：StatSystem 的DTO类.
	/// </summary>
	public partial class StatSystemDTO
	{
		#region Properties
		private System.String _tSystem = string.Empty;
		/// <summary>
		/// 操作系统 (主键)
		/// </summary>
		public System.String TSystem
		{
			get {return _tSystem;}
			set {_tSystem = value;}
		}
		private System.Int32 _tSysNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TSysNum
		{
			get {return _tSysNum;}
			set {_tSysNum = value;}
		}
		#endregion
	}
}
