// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: FileRelationInfo.cs
// 修改时间：2017/12/26 17:33:29
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：FileRelationInfo 的实体类.
	/// </summary>
	public partial class FileRelationInfo
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
		private System.Int32 _infoID = 0;
		/// <summary>
		/// 信息ID 
		/// </summary>
		public System.Int32 InfoID
		{
			get {return _infoID;}
			set {_infoID = value;}
		}
		private System.Int32 _infoType = 0;
		/// <summary>
		/// 信息类型 
		/// </summary>
		public System.Int32 InfoType
		{
			get {return _infoType;}
			set {_infoType = value;}
		}
		private System.String _path = string.Empty;
		/// <summary>
		/// 文件路径 
		/// </summary>
		public System.String Path
		{
			get {return _path;}
			set {_path = value;}
		}
		#endregion
	}
}
