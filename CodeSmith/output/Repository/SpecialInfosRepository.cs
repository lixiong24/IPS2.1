﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JX.Core;
using JX.Core.Entity;

namespace JX.EF.Repository
{
	/// <summary>
	/// 数据库表：SpecialInfos 的仓储实现类.
	/// </summary>
	public partial class SpecialInfosRepository : Repository<SpecialInfos>, ISpecialInfosRepository
	{
		/// <summary>
		/// 构造器注入
		/// </summary>
		public SpecialInfosRepository(ApplicationDbContext Context) : base(Context)
		{
		}
		
	}
}