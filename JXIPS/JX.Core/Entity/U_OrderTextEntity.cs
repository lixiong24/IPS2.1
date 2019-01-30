// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: U_OrderText.cs
// 修改时间：2017/12/26 17:33:36
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：U_OrderText 的实体类.
	/// </summary>
	public partial class U_OrderText
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
		private System.String _deliverTime = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String DeliverTime
		{
			get {return _deliverTime;}
			set {_deliverTime = value;}
		}
		private System.String _outOfStockProject = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String OutOfStockProject
		{
			get {return _outOfStockProject;}
			set {_outOfStockProject = value;}
		}
		private System.String _remark = string.Empty;
		/// <summary>
		///  
		/// </summary>
		public System.String Remark
		{
			get {return _remark;}
			set {_remark = value;}
		}
		#endregion
	}
}
