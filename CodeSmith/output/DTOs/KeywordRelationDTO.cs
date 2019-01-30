using System;

namespace JX.Application.DTOs
{
	/// <summary>
	/// 数据库表：KeywordRelation 的DTO类.
	/// </summary>
	public partial class KeywordRelationDTO
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		///  (主键)(自增长)
		/// </summary>
		public System.Int32 ID
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.Int32 _keywordID = 0;
		/// <summary>
		/// 关键字ID 
		/// </summary>
		public System.Int32 KeywordID
		{
			get {return _keywordID;}
			set {_keywordID = value;}
		}
		private System.Int32 _generalID = 0;
		/// <summary>
		/// 信息ID 
		/// </summary>
		public System.Int32 GeneralID
		{
			get {return _generalID;}
			set {_generalID = value;}
		}
		#endregion
	}
}
