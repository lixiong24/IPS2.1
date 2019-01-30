// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: StatRefer.cs
// 修改时间：2017/12/26 17:33:34
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：StatRefer 的实体类.
	/// </summary>
	public partial class StatRefer
	{
		#region Properties
		private System.String _tRefer = string.Empty;
		/// <summary>
		/// 引用地址 (主键)
		/// </summary>
		public System.String TRefer
		{
			get {return _tRefer;}
			set {_tRefer = value;}
		}
		private System.Int32 _tRefNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TRefNum
		{
			get {return _tRefNum;}
			set {_tRefNum = value;}
		}
		#endregion
	}
}
