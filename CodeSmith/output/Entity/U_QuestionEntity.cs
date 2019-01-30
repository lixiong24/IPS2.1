// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: U_Question.cs
// 修改时间：2018/1/4 19:07:49
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：U_Question 的实体类.
	/// </summary>
	public partial class U_Question
	{
		#region Properties
		private System.Int32 _id = 0;
		/// <summary>
		///  (主键)
		/// </summary>
		public System.Int32 ID
		{
			get {return _id;}
			set {_id = value;}
		}
		private System.String _problemState = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String ProblemState
		{
			get {return _problemState;}
			set {_problemState = value;}
		}
		private DateTime? _solveProblemTime = DateTime.MaxValue;
		/// <summary>
		///  
		/// </summary>
		public DateTime? SolveProblemTime
		{
			get {return _solveProblemTime;}
			set {_solveProblemTime = value;}
		}
		private System.String _problemDesc = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String ProblemDesc
		{
			get {return _problemDesc;}
			set {_problemDesc = value;}
		}
		#endregion
	}
}
