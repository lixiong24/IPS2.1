﻿// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: StatKeyword.cs
// 修改时间：2017/12/26 17:33:34
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：StatKeyword 的实体类.
	/// </summary>
	public partial class StatKeyword
	{
		#region Properties
		private System.String _tKeyword = string.Empty;
		/// <summary>
		/// 关键字 (主键)
		/// </summary>
		public System.String TKeyword
		{
			get {return _tKeyword;}
			set {_tKeyword = value;}
		}
		private System.Int32 _tKeywordNum = 0;
		/// <summary>
		/// 数量 
		/// </summary>
		public System.Int32 TKeywordNum
		{
			get {return _tKeywordNum;}
			set {_tKeywordNum = value;}
		}
		#endregion
	}
}
