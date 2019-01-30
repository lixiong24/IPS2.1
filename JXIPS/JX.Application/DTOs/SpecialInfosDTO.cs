using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：SpecialInfos 的DTO类.
	/// </summary>
	public partial class SpecialInfosDTO
	{
		#region Properties
		private System.Int32 _specialInfoID = 0;
		/// <summary>
		/// 专题信息ID (主键)
		/// </summary>
		public System.Int32 SpecialInfoID
		{
			get {return _specialInfoID;}
			set {_specialInfoID = value;}
		}
		private System.Int32 _specialID = 0;
		/// <summary>
		/// 所属专题ID (主键)
		/// </summary>
		public System.Int32 SpecialID
		{
			get {return _specialID;}
			set {_specialID = value;}
		}
		private System.Int32 _generalID = 0;
		/// <summary>
		/// 所属实链接ID (主键)
		/// </summary>
		public System.Int32 GeneralID
		{
			get {return _generalID;}
			set {_generalID = value;}
		}
		#endregion
	}
}
