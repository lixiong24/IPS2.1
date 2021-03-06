﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JX.Core;
using JX.Core.Entity;

namespace JX.EF.Repository
{
	/// <summary>
	/// 数据库表：Merchant 的仓储实现类.
	/// </summary>
	public partial class MerchantRepository : Repository<Merchant>, IMerchantRepository
	{
		/// <summary>
		/// 构造器注入
		/// </summary>
		public MerchantRepository(ApplicationDbContext Context) : base(Context)
		{
		}
		
	}
}