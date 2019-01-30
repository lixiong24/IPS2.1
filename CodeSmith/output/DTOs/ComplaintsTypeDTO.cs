using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：ComplaintsType 的DTO类.
	/// </summary>
	public partial class ComplaintsTypeDTO
	{
		#region Properties
		private System.Int32 _cid = 0;
		/// <summary>
		/// 类别ID (主键)
		/// </summary>
		public System.Int32 CID
		{
			get {return _cid;}
			set {_cid = value;}
		}
		private System.Int32 _cDType = 0;
		/// <summary>
		/// 属于那一类 投诉/举报 
		/// </summary>
		public System.Int32 CDType
		{
			get {return _cDType;}
			set {_cDType = value;}
		}
		private System.String _cName = string.Empty;
		/// <summary>
		/// 类型名称 
		/// </summary>
		public System.String CName
		{
			get {return _cName;}
			set {_cName = value;}
		}
		#endregion
	}
}
