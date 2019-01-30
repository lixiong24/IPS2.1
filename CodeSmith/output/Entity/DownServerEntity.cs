﻿// =================================================================== 
// 项目说明,功能实体类,用CodeSmith自动生成。
// =================================================================== 
// 文件名: DownServer.cs
// 修改时间：2018/1/4 19:07:45
// 修改人: lixiong
// =================================================================== 
using System;

namespace JX.Core.Entity
{
	/// <summary>
	/// 数据库表：DownServer 的实体类.
	/// </summary>
	public partial class DownServer
	{
		#region Properties
		private System.Int32 _serverID = 0;
		/// <summary>
		/// 镜像服务器ID (主键)
		/// </summary>
		public System.Int32 ServerID
		{
			get {return _serverID;}
			set {_serverID = value;}
		}
		private System.String _serverName = string.Empty;
		/// <summary>
		/// 镜像服务器名 
		/// </summary>
		public System.String ServerName
		{
			get {return _serverName;}
			set {_serverName = value;}
		}
		private System.String _serverUrl = string.Empty;
		/// <summary>
		/// 镜像服务器地址 
		/// </summary>
		public System.String ServerUrl
		{
			get {return _serverUrl;}
			set {_serverUrl = value;}
		}
		private System.String _serverLogo = string.Empty;
		/// <summary>
		/// 镜像服务器Logo 
		/// </summary>
		public System.String ServerLogo
		{
			get {return _serverLogo;}
			set {_serverLogo = value;}
		}
		private System.Int32 _orderSort = 0;
		/// <summary>
		/// 镜像服务器排序ID 
		/// </summary>
		public System.Int32 OrderSort
		{
			get {return _orderSort;}
			set {_orderSort = value;}
		}
		private System.Int32 _showType = 0;
		/// <summary>
		/// 镜像服务器显示方式 
		/// </summary>
		public System.Int32 ShowType
		{
			get {return _showType;}
			set {_showType = value;}
		}
		#endregion
	}
}