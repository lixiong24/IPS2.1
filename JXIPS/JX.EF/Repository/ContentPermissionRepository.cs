﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JX.Core;
using JX.Core.Entity;

namespace JX.EF.Repository
{
	/// <summary>
	/// 数据库表：ContentPermission 的仓储实现类.
	/// </summary>
	public partial class ContentPermissionRepository : Repository<ContentPermission>, IContentPermissionRepository
	{
		/// <summary>
		/// 构造器注入
		/// </summary>
		public ContentPermissionRepository(ApplicationDbContext Context) : base(Context)
		{
		}
		
	}
}