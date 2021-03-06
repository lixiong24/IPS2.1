﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JX.Core.Entity
{
	/// <summary>
	/// 菜单实体类
	/// </summary>
	public class MenuEntity
    {
		/// <summary>
		/// 菜单ID
		/// </summary>
		public string ID { get; set; }
		
		/// <summary>
		/// 菜单节点名称
		/// </summary>
		public string NodeName { get; set; }

		/// <summary>
		/// 菜单名称
		/// </summary>
		public string Title { get; set; }
		
		/// <summary>
		/// 权限码
		/// </summary>
		public string OperateCode { get; set; }
		
		/// <summary>
		/// 菜单URL
		/// </summary>
		public string Url { get; set; }
		
		/// <summary>
		/// 菜单描述
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// 菜单类型
		/// </summary>
		public string MenuType { get; set; }

		/// <summary>
		/// 菜单图标
		/// </summary>
		public string MenuIcon { get; set; }

		/// <summary>
		/// 在权限配置时，是否显示
		/// </summary>
		public bool ShowOnForm { get; set; }
		
		/// <summary>
		/// 在菜单页面中，是否显示
		/// </summary>
		public bool ShowOnMenu { get; set; }
		
		/// <summary>
		/// 子菜单项
		/// </summary>
		public IList<MenuEntity> MenuItem { get; set; }
	}
}
