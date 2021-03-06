﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JX.Core.Entity
{
	/// <summary>
	/// SiteMap实体类
	/// </summary>
	public class SiteMapEntity
    {
		/// <summary>
		/// 名称
		/// </summary>
		public string Title { get; set; }
		
		/// <summary>
		/// URL
		/// </summary>
		public string Url { get; set; }
		
		/// <summary>
		/// 描述
		/// </summary>
		public string Description { get; set; }
		
		/// <summary>
		/// 子菜单项
		/// </summary>
		public IList<SiteMapEntity> SiteMapItem { get; set; }
	}
}
