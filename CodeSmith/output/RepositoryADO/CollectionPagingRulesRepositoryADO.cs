﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using JX.Core;
using JX.Core.Entity;
using JX.Infrastructure.Common;
using MyADO;

namespace JX.ADO
{
	/// <summary>
	/// 数据库表：CollectionPagingRules 的仓储实现类.
	/// </summary>
	public partial class CollectionPagingRulesRepositoryADO : ICollectionPagingRulesRepositoryADO
	{
		#region 数据上下文
		/// <summary>
		/// 数据上下文
		/// </summary>
		private IDBOperator _DB;

		/// <summary>
		/// 构造器注入
		/// </summary>
		/// <param name="DB"></param>
		public CollectionPagingRulesRepositoryADO(IDBOperator DB)
		{
			_DB = DB;
		}
		#endregion
		
		#region 得到第一行第一列的值
		/// <summary>
		/// 得到第一行第一列的值
		/// </summary>
		/// <param name="statistic">要返回的字段（如：count(*) 或者 UserName）</param>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual string GetScalar(string statistic, string strWhere = "", Dictionary<string, object> dict = null)
		{
			string strSQL = "select " + statistic + " from CollectionPagingRules where 1=1 ";
			if (!string.IsNullOrEmpty(strWhere))
			{
				strSQL += strWhere;
			}
			return _DB.ExeSQLScalar(strSQL, dict);
		}
		/// <summary>
		/// 得到第一行第一列的值（异步方式）
		/// </summary>
		/// <param name="statistic">要返回的字段（如：count(*) 或者 UserName）</param>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<string> GetScalarAsync(string statistic, string strWhere = "", Dictionary<string, object> dict = null)
		{
			string strSQL = "select " + statistic + " from CollectionPagingRules where 1=1 ";
			if (!string.IsNullOrEmpty(strWhere))
			{
				strSQL += strWhere;
			}
			return await Task.Run(() => _DB.ExeSQLScalar(strSQL, dict));
		}
		#endregion
		
		#region 得到所有行数
		/// <summary>
		/// 得到所有行数
		/// </summary>
		/// <returns></returns>
		public virtual int GetCount()
		{
			return DataConverter.CLng(GetScalar("count(*)"), 0);
		}
		/// <summary>
		/// 得到所有行数（异步方式）
		/// </summary>
		/// <returns></returns>
		public virtual async Task<int> GetCountAsync()
		{
			return DataConverter.CLng(await GetScalarAsync("count(*)"), 0);
		}

		/// <summary>
		/// 得到所有行数
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual int GetCount(string strWhere, Dictionary<string, object> dict = null)
		{
			return DataConverter.CLng(GetScalar("count(*)", strWhere, dict), 0);
		}
		/// <summary>
		/// 得到所有行数（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<int> GetCountAsync(string strWhere, Dictionary<string, object> dict = null)
		{
			return DataConverter.CLng(await GetScalarAsync("count(*)", strWhere, dict), 0);
		}
		#endregion
		
		#region 得到最大ID、最新ID
		/// <summary>
		/// 得到数据表中第一个主键的最大数值
		/// </summary>
		/// <returns></returns>
		public virtual int GetMaxID()
		{
			return _DB.GetMaxID("CollectionPagingRules", "PagingRuleID");
		}
		/// <summary>
		/// 得到数据表中第一个主键的最大数值（异步方式）
		/// </summary>
		/// <returns></returns>
		public virtual async Task<int> GetMaxIDAsync()
		{
			return await Task.Run(() => _DB.GetMaxID("CollectionPagingRules", "PagingRuleID"));
		}

		/// <summary>
		/// 得到数据表中第一个主键的最大数值加1
		/// </summary>
		/// <returns></returns>
		public virtual int GetNewID()
		{
			return GetMaxID() + 1;
		}
		/// <summary>
		/// 得到数据表中第一个主键的最大数值加1（异步方式）
		/// </summary>
		/// <returns></returns>
		public virtual async Task<int> GetNewIDAsync()
		{
			return await GetMaxIDAsync() + 1;
		}
		#endregion
		
		#region 验证是否存在
		/// <summary>
		/// 检查数据是否存在
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual bool IsExist(string strWhere, Dictionary<string, object> dict = null)
		{
			if (GetCount(strWhere, dict) == 0)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// 检查数据是否存在（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<bool> IsExistAsync(string strWhere, Dictionary<string, object> dict = null)
		{
			int count = await GetCountAsync(strWhere, dict);
			if (count == 0)
			{
				return false;
			}
			return true;
		}
		#endregion
		
		#region 添加
		/// <summary>
		/// 增加一条记录
		/// </summary>
		/// <param name="entity">实体模型</param>
		/// <returns></returns>
		public virtual bool Add(CollectionPagingRules entity)
		{
			if(entity.PagingRuleID <= 0) entity.PagingRuleID=GetNewID();
			Dictionary<string, object> dict = new Dictionary<string, object>();
			GetParameters(entity,dict);

			string strSQL = "insert into CollectionPagingRules ("+
							"PagingRuleID,"+
							"ItemID,"+
							"RuleType,"+
							"PagingType,"+
							"PagingBeginCode,"+
							"PagingEndCode,"+
							"LinkBeginCode,"+
							"LinkEndCode,"+
							"DesignatedUrl,"+
							"ScopeBegin,"+
							"ScopeEnd,"+
							"PagingUrlList,"+
							"CorrelationRuleId) "+
							"values("+
							"@PagingRuleID,"+
							"@ItemID,"+
							"@RuleType,"+
							"@PagingType,"+
							"@PagingBeginCode,"+
							"@PagingEndCode,"+
							"@LinkBeginCode,"+
							"@LinkEndCode,"+
							"@DesignatedUrl,"+
							"@ScopeBegin,"+
							"@ScopeEnd,"+
							"@PagingUrlList,"+
							"@CorrelationRuleId)";
			
			return _DB.ExeSQLResult(strSQL,dict);
		}
		/// <summary>
		/// 增加一条记录（异步方式）
		/// </summary>
		/// <param name="entity">实体模型</param>
		/// <returns></returns>
		public virtual async Task<bool> AddAsync(CollectionPagingRules entity)
		{
			if(entity.PagingRuleID <= 0) entity.PagingRuleID=GetNewID();
			Dictionary<string, object> dict = new Dictionary<string, object>();
			GetParameters(entity, dict);

			string strSQL = "insert into CollectionPagingRules ("+
							"PagingRuleID,"+
							"ItemID,"+
							"RuleType,"+
							"PagingType,"+
							"PagingBeginCode,"+
							"PagingEndCode,"+
							"LinkBeginCode,"+
							"LinkEndCode,"+
							"DesignatedUrl,"+
							"ScopeBegin,"+
							"ScopeEnd,"+
							"PagingUrlList,"+
							"CorrelationRuleId) "+
							"values("+
							"@PagingRuleID,"+
							"@ItemID,"+
							"@RuleType,"+
							"@PagingType,"+
							"@PagingBeginCode,"+
							"@PagingEndCode,"+
							"@LinkBeginCode,"+
							"@LinkEndCode,"+
							"@DesignatedUrl,"+
							"@ScopeBegin,"+
							"@ScopeEnd,"+
							"@PagingUrlList,"+
							"@CorrelationRuleId)";
			
			return await Task.Run(() => _DB.ExeSQLResult(strSQL, dict));
		}

		/// <summary>
		/// 增加一条记录，返回新的ID号。需要有一个单一主键，并且开启有标识符属性
		/// </summary>
		/// <param name="entity">实体模型</param>
		/// <returns></returns>
		public virtual int Insert(CollectionPagingRules entity)
		{
			if(entity.PagingRuleID <= 0) entity.PagingRuleID=GetNewID();			
			Dictionary<string, object> dict = new Dictionary<string, object>();
			GetParameters(entity,dict);

			string strSQL = "insert into CollectionPagingRules ("+
							"PagingRuleID,"+
							"ItemID,"+
							"RuleType,"+
							"PagingType,"+
							"PagingBeginCode,"+
							"PagingEndCode,"+
							"LinkBeginCode,"+
							"LinkEndCode,"+
							"DesignatedUrl,"+
							"ScopeBegin,"+
							"ScopeEnd,"+
							"PagingUrlList,"+
							"CorrelationRuleId) "+
							"values("+
							"@PagingRuleID,"+
							"@ItemID,"+
							"@RuleType,"+
							"@PagingType,"+
							"@PagingBeginCode,"+
							"@PagingEndCode,"+
							"@LinkBeginCode,"+
							"@LinkEndCode,"+
							"@DesignatedUrl,"+
							"@ScopeBegin,"+
							"@ScopeEnd,"+
							"@PagingUrlList,"+
							"@CorrelationRuleId)";
			if(_DB.ExeSQLResult(strSQL,dict))
			{
				return DataConverter.CLng(entity.PagingRuleID);
			}
			return -1;
		}
		/// <summary>
		/// 增加一条记录，返回新的ID号。需要有一个单一主键，并且开启有标识符属性（异步方式）
		/// </summary>
		/// <param name="entity">实体模型</param>
		/// <returns></returns>
		public virtual async Task<int> InsertAsync(CollectionPagingRules entity)
		{
			if(entity.PagingRuleID <= 0) entity.PagingRuleID=GetNewID();			
			Dictionary<string, object> dict = new Dictionary<string, object>();
			GetParameters(entity,dict);

			string strSQL = "insert into CollectionPagingRules ("+
							"PagingRuleID,"+
							"ItemID,"+
							"RuleType,"+
							"PagingType,"+
							"PagingBeginCode,"+
							"PagingEndCode,"+
							"LinkBeginCode,"+
							"LinkEndCode,"+
							"DesignatedUrl,"+
							"ScopeBegin,"+
							"ScopeEnd,"+
							"PagingUrlList,"+
							"CorrelationRuleId) "+
							"values("+
							"@PagingRuleID,"+
							"@ItemID,"+
							"@RuleType,"+
							"@PagingType,"+
							"@PagingBeginCode,"+
							"@PagingEndCode,"+
							"@LinkBeginCode,"+
							"@LinkEndCode,"+
							"@DesignatedUrl,"+
							"@ScopeBegin,"+
							"@ScopeEnd,"+
							"@PagingUrlList,"+
							"@CorrelationRuleId)";
			if(await Task.Run(() => _DB.ExeSQLResult(strSQL, dict)))
			{
				return DataConverter.CLng(entity.PagingRuleID);
			}
			return -1;
		}

		/// <summary>
		/// 增加或更新一条记录
		/// </summary>
		/// <param name="entity">实体模型</param>
		/// <param name="IsSave">是否增加</param>
		/// <returns></returns>
		public virtual bool AddOrUpdate(CollectionPagingRules entity, bool IsSave)
		{
			return IsSave ? Add(entity) : Update(entity);
		}
		/// <summary>
		/// 增加或更新一条记录（异步方式）
		/// </summary>
		/// <param name="entity">实体模型</param>
		/// <param name="IsSave">是否增加</param>
		/// <returns></returns>
		public virtual async Task<bool> AddOrUpdateAsync(CollectionPagingRules entity, bool IsSave)
		{
			return IsSave ? await AddAsync(entity) : await UpdateAsync(entity);
		}
		#endregion
		
		#region 删除
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		public bool Delete(System.Int32 pagingRuleID)
		{
			string strSQL = "delete from CollectionPagingRules where " +
			
			"PagingRuleID = @PagingRuleID"; 
			
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("PagingRuleID", pagingRuleID);
			
			return _DB.ExeSQLResult(strSQL, dict);
		}
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		public async Task<bool> DeleteAsync(System.Int32 pagingRuleID)
		{
			string strSQL = "delete from CollectionPagingRules where " +
			
			"PagingRuleID = @PagingRuleID"; 
			
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("PagingRuleID", pagingRuleID);
			
			return await Task.Run(() => _DB.ExeSQLResult(strSQL, dict));
		}
		
		/// <summary>
		/// 删除一条或多条记录
		/// </summary>
		/// <param name="strWhere">参数化删除条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual bool Delete(string strWhere, Dictionary<string, object> dict = null)
		{
			string strSQL = "delete from CollectionPagingRules where 1=1 " + strWhere;
			return _DB.ExeSQLResult(strSQL, dict);
		}
		/// <summary>
		/// 删除一条或多条记录（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化删除条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<bool> DeleteAsync(string strWhere, Dictionary<string, object> dict = null)
		{
			string strSQL = "delete from CollectionPagingRules where 1=1 " + strWhere;
			return await Task.Run(() => _DB.ExeSQLResult(strSQL, dict));
		}
		#endregion
		
		#region 修改
		/// <summary>
		/// 更新一条记录
		/// </summary>
		/// <param name="entity">实体模型</param>
		/// <returns></returns>
		public virtual bool Update(CollectionPagingRules entity)
		{
			Dictionary<string, object> dict = new Dictionary<string, object>();
			GetParameters(entity, dict);
			string strSQL = "Update CollectionPagingRules SET "+
			"ItemID = @ItemID,"+
			"RuleType = @RuleType,"+
			"PagingType = @PagingType,"+
			"PagingBeginCode = @PagingBeginCode,"+
			"PagingEndCode = @PagingEndCode,"+
			"LinkBeginCode = @LinkBeginCode,"+
			"LinkEndCode = @LinkEndCode,"+
			"DesignatedUrl = @DesignatedUrl,"+
			"ScopeBegin = @ScopeBegin,"+
			"ScopeEnd = @ScopeEnd,"+
			"PagingUrlList = @PagingUrlList,"+
			"CorrelationRuleId = @CorrelationRuleId"+
			" WHERE "+
			
			"PagingRuleID = @PagingRuleID"; 
			
			return _DB.ExeSQLResult(strSQL, dict);
		}
		/// <summary>
		/// 更新一条记录（异步方式）
		/// </summary>
		/// <param name="entity">实体模型</param>
		/// <returns></returns>
		public virtual async Task<bool> UpdateAsync(CollectionPagingRules entity)
		{
			Dictionary<string, object> dict = new Dictionary<string, object>();
			GetParameters(entity, dict);
			string strSQL = "Update CollectionPagingRules SET "+
			"ItemID = @ItemID,"+
			"RuleType = @RuleType,"+
			"PagingType = @PagingType,"+
			"PagingBeginCode = @PagingBeginCode,"+
			"PagingEndCode = @PagingEndCode,"+
			"LinkBeginCode = @LinkBeginCode,"+
			"LinkEndCode = @LinkEndCode,"+
			"DesignatedUrl = @DesignatedUrl,"+
			"ScopeBegin = @ScopeBegin,"+
			"ScopeEnd = @ScopeEnd,"+
			"PagingUrlList = @PagingUrlList,"+
			"CorrelationRuleId = @CorrelationRuleId"+
			" WHERE "+
			
			"PagingRuleID = @PagingRuleID"; 
			return await Task.Run(() => _DB.ExeSQLResult(strSQL, dict));
		}

		/// <summary>
		/// 修改一条或多条记录
		/// </summary>
		/// <param name="strColumns">参数化要修改的列（如：ID = @ID,Name = @Name）</param>
		/// <param name="dictColumns">包含要修改的名称和值的集合,对应strColumns参数中要修改列的值</param>
		/// <param name="strWhere">参数化修改条件(例如: and ID = @ID)</param>
		/// <param name="dictWhere">包含查询名称和值的集合,对应strWhere参数中的值</param>
		/// <returns></returns>
		public virtual bool Update(string strColumns, Dictionary<string, object> dictColumns = null, string strWhere = "", Dictionary<string, object> dictWhere = null)
		{
			if (string.IsNullOrEmpty(strColumns))
				return false;

			strColumns = StringHelper.ReplaceIgnoreCase(strColumns, "@", "@UP_");
			string strSQL = "Update CollectionPagingRules SET " + strColumns + " where 1=1 " + strWhere;

			Dictionary<string, object> dict = new Dictionary<string, object>();
			//生成要修改列的参数
			foreach (KeyValuePair<string, object> kvp in dictColumns)
			{
				dict.Add("@UP_" + kvp.Key,kvp.Value);
			}
			//生成查询条件的参数
			foreach (KeyValuePair<string, object> kvp in dictWhere)
			{
				dict.Add(kvp.Key, kvp.Value);
			}

			return _DB.ExeSQLResult(strSQL, dict);
		}
		/// <summary>
		/// 修改一条或多条记录（异步方式）
		/// </summary>
		/// <param name="strColumns">参数化要修改的列（如：ID = @ID,Name = @Name）</param>
		/// <param name="dictColumns">包含要修改的名称和值的集合,对应strColumns参数中要修改列的值</param>
		/// <param name="strWhere">参数化修改条件(例如: and ID = @ID)</param>
		/// <param name="dictWhere">包含查询名称和值的集合,对应strWhere参数中的值</param>
		/// <returns></returns>
		public virtual async Task<bool> UpdateAsync(string strColumns, Dictionary<string, object> dictColumns = null, string strWhere = "", Dictionary<string, object> dictWhere = null)
		{
			if (string.IsNullOrEmpty(strColumns))
				return false;

			strColumns = StringHelper.ReplaceIgnoreCase(strColumns, "@", "@UP_");
			string strSQL = "Update CollectionPagingRules SET " + strColumns + " where 1=1 " + strWhere;

			Dictionary<string, object> dict = new Dictionary<string, object>();
			//生成要修改列的参数
			foreach (KeyValuePair<string, object> kvp in dictColumns)
			{
				dict.Add("@UP_" + kvp.Key, kvp.Value);
			}
			//生成查询条件的参数
			foreach (KeyValuePair<string, object> kvp in dictWhere)
			{
				dict.Add(kvp.Key, kvp.Value);
			}
			return await Task.Run(() => _DB.ExeSQLResult(strSQL, dict));
		}
		#endregion
		
		#region 得到实体
		/// <summary>
		/// 通过主键返回第一条信息的实体类。
		/// </summary>
		/// <returns></returns>
		public CollectionPagingRules GetEntity(System.Int32 pagingRuleID)
		{
			string strCondition = string.Empty;
			strCondition += " and PagingRuleID = @PagingRuleID";
			
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("PagingRuleID", pagingRuleID);
			
			return GetEntity(strCondition,dict);
		}
		/// <summary>
		/// 通过主键返回第一条信息的实体类。
		/// </summary>
		/// <returns></returns>
		public async Task<CollectionPagingRules> GetEntityAsync(System.Int32 pagingRuleID)
		{
			string strCondition = string.Empty;
			strCondition += " and PagingRuleID = @PagingRuleID";
			
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("PagingRuleID", pagingRuleID);
			
			return await GetEntityAsync(strCondition,dict);
		}
		
		/// <summary>
		/// 获取实体
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual CollectionPagingRules GetEntity(string strWhere, Dictionary<string, object> dict = null)
		{
			CollectionPagingRules obj = null;
			string strSQL = "select top 1 * from CollectionPagingRules where 1=1 " + strWhere;
			using (NullableDataReader reader = _DB.GetDataReader(strSQL, dict))
			{
				if (reader.Read())
				{
					obj = GetEntityFromrdr(reader);
				}
			}
			return obj;
		}
		/// <summary>
		/// 获取实体（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<CollectionPagingRules> GetEntityAsync(string strWhere, Dictionary<string, object> dict = null)
		{
			CollectionPagingRules obj = null;
			string strSQL = "select top 1 * from CollectionPagingRules where 1=1 " + strWhere;
			using (NullableDataReader reader = await Task.Run(() => _DB.GetDataReader(strSQL, dict)))
			{
				if (reader.Read())
				{
					obj = GetEntityFromrdr(reader);
				}
			}
			return obj;
		}
		#endregion
		
		#region 得到实体列表
		/// <summary>
		/// 得到实体列表
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual IList<CollectionPagingRules> GetEntityList(string strWhere="", Dictionary<string, object> dict = null)
		{
			IList<CollectionPagingRules> list = new List<CollectionPagingRules>();
			string strSQL = "select * from CollectionPagingRules where 1=1 ";
			if(!string.IsNullOrEmpty(strWhere))
			{
				strSQL += strWhere;
			}
			using (NullableDataReader reader = _DB.GetDataReader(strSQL, dict))
			{
				while (reader.Read())
				{
					list.Add(GetEntityFromrdr(reader));
				}
			}
			return list;
		}
		/// <summary>
		/// 得到实体列表（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<IList<CollectionPagingRules>> GetEntityListAsync(string strWhere = "", Dictionary<string, object> dict = null)
		{
			IList<CollectionPagingRules> list = new List<CollectionPagingRules>();
			string strSQL = "select * from CollectionPagingRules where 1=1 ";
			if (!string.IsNullOrEmpty(strWhere))
			{
				strSQL += strWhere;
			}
			using (NullableDataReader reader = await Task.Run(() => _DB.GetDataReader(strSQL, dict)))
			{
				while (reader.Read())
				{
					list.Add(GetEntityFromrdr(reader));
				}
			}
			return list;
		}
		#endregion
		
		#region 得到数据列表
		/// <summary>
		/// 返回所有信息
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual DataTable GetAllData(string strWhere = "", Dictionary<string, object> dict = null)
		{
			string strSQL = "select * from CollectionPagingRules where 1=1 ";
			if(!string.IsNullOrEmpty(strWhere))
			{
				strSQL += strWhere;
			}
			return _DB.GetDataTable(strSQL, dict);
		}
		/// <summary>
		/// 返回所有信息（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<DataTable> GetAllDataAsync(string strWhere = "", Dictionary<string, object> dict = null)
		{
			string strSQL = "select * from CollectionPagingRules where 1=1 ";
			if(!string.IsNullOrEmpty(strWhere))
			{
				strSQL += strWhere;
			}
			return await Task.Run(() => _DB.GetDataTable(strSQL, dict));
		}

		/// <summary>
		/// 返回所有信息
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <param name="strExtended">返回的指定列(例如: extended = id + name 或 distinct name)</param>
		/// <returns></returns>
		public virtual DataTable GetAllData(string strWhere = "", Dictionary<string, object> dict = null, string strExtended="*")
		{
			string strSQL = "select " + strExtended + " from CollectionPagingRules where 1=1 ";
			if(!string.IsNullOrEmpty(strWhere))
			{
				strSQL += strWhere;
			}
			return _DB.GetDataTable(strSQL, dict);
		}
		/// <summary>
		/// 返回所有信息（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <param name="strExtended">返回的指定列(例如: extended = id + name 或 distinct name)</param>
		/// <returns></returns>
		public virtual async Task<DataTable> GetAllDataAsync(string strWhere = "", Dictionary<string, object> dict = null, string strExtended = "*")
		{
			string strSQL = "select " + strExtended + " from CollectionPagingRules where 1=1 ";
			if(!string.IsNullOrEmpty(strWhere))
			{
				strSQL += strWhere;
			}
			return await Task.Run(() => _DB.GetDataTable(strSQL, dict));
		}
		#endregion
		
		#region 分页
		/// <summary>
		/// 通过存储过程"Common_GetList"，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
        /// <param name="maxNumberRows">每页最大显示数量</param>
        /// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		public IList<CollectionPagingRules> GetList(int startRowIndexId, int maxNumberRows,string Filter, out int Total)
		{
			Total = 0;
			return GetList(startRowIndexId,maxNumberRows,"","","",Filter,"",out Total);
		}
		/// <summary>
		/// 通过存储过程“Common_GetList”，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="SortColumn">排序字段名，只能指定一个字段</param>
		/// <param name="StrColumn">返回列名</param>
		/// <param name="Sorts">排序方式（DESC,ASC）</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="TableName">查询表名，可以指定联合查询的SQL语句(例如: Comment LEFT JOIN Users ON Comment.UserName = Users.UserName)</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		public virtual IList<CollectionPagingRules> GetList(int startRowIndexId, int maxNumberRows, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total)
		{
			IList<CollectionPagingRules> list = new List<CollectionPagingRules>();
			if (string.IsNullOrEmpty(SortColumn))
			{
				SortColumn = "PagingRuleID";
			}
			if (string.IsNullOrEmpty(StrColumn))
			{
				StrColumn = "*";
			}
			if (string.IsNullOrEmpty(Sorts))
			{
				Sorts = "DESC";
			}
			if (string.IsNullOrEmpty(TableName))
			{
				TableName = "CollectionPagingRules";
			}
			string storedProcedureName = "Common_GetList";
			SqlParameter parmStartRows = new SqlParameter("StartRows", startRowIndexId);
			SqlParameter parmPageSize = new SqlParameter("PageSize", maxNumberRows);
			SqlParameter parmSortColumn = new SqlParameter("SortColumn", SortColumn);
			SqlParameter parmStrColumn = new SqlParameter("StrColumn", StrColumn);
			SqlParameter parmSorts = new SqlParameter("Sorts", Sorts);
			SqlParameter parmTableName = new SqlParameter("TableName", TableName);
			SqlParameter parmFilter = new SqlParameter("Filter", Filter);
			SqlParameter parmTotal = new SqlParameter("Total", SqlDbType.Int);
			parmTotal.Direction = ParameterDirection.Output;
			IDataParameter[] parameterArray = new IDataParameter[8];
			parameterArray[0] = parmStartRows;
			parameterArray[1] = parmPageSize;
			parameterArray[2] = parmSortColumn;
			parameterArray[3] = parmStrColumn;
			parameterArray[4] = parmSorts;
			parameterArray[5] = parmTableName;
			parameterArray[6] = parmFilter;
			parameterArray[7] = parmTotal;
			using (NullableDataReader reader = _DB.GetDataReaderByProc(storedProcedureName, parameterArray))
			{
				while (reader.Read())
				{
					list.Add(GetEntityFromrdr(reader));
				}
			}
			Total = (int)parmTotal.Value;
			return list;
		}

		/// <summary>
		/// 通过存储过程"Common_GetListBySortColumn"，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
        /// <param name="maxNumberRows">每页最大显示数量</param>
        /// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		public IList<CollectionPagingRules> GetListBySortColumn(int startRowIndexId, int maxNumberRows,string Filter, out int Total)
		{
			Total = 0;
			return GetListBySortColumn(startRowIndexId,maxNumberRows,"","","","","",Filter,"",out Total);
		}
		/// <summary>
		/// 通过存储过程"Common_GetListBySortColumn"，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
        /// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="Sorts">排序方式（DESC,ASC）</param>
        /// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		public IList<CollectionPagingRules> GetListBySortColumn(int startRowIndexId, int maxNumberRows,string Sorts,string Filter, out int Total)
		{
			Total = 0;
			return GetListBySortColumn(startRowIndexId,maxNumberRows,"","","","",Sorts,Filter,"",out Total);
		}
		/// <summary>
		/// 通过存储过程“Common_GetListBySortColumn”，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="PrimaryColumn">主键字段名</param>
		/// <param name="SortColumnDbType">排序字段的数据类型(如：int)</param>
		/// <param name="SortColumn">排序字段名，只能指定一个字段</param>
		/// <param name="StrColumn">返回列名</param>
		/// <param name="Sorts">排序方式（DESC,ASC）</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="TableName">查询表名，可以指定联合查询的SQL语句(例如: Comment LEFT JOIN Users ON Comment.UserName = Users.UserName)</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		public virtual IList<CollectionPagingRules> GetListBySortColumn(int startRowIndexId, int maxNumberRows, string PrimaryColumn, string SortColumnDbType, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total)
		{
			IList<CollectionPagingRules> list = new List<CollectionPagingRules>();
			if (string.IsNullOrEmpty(PrimaryColumn))
			{
				PrimaryColumn = "PagingRuleID";
			}
			if (string.IsNullOrEmpty(SortColumnDbType))
			{
				SortColumnDbType = "int";
			}
			if (string.IsNullOrEmpty(SortColumn))
			{
				SortColumn = "PagingRuleID";
			}
			if (string.IsNullOrEmpty(StrColumn))
			{
				StrColumn = "*";
			}
			if (string.IsNullOrEmpty(Sorts))
			{
				Sorts = "DESC";
			}
			if (string.IsNullOrEmpty(TableName))
			{
				TableName = "CollectionPagingRules";
			}
			string storedProcedureName = "Common_GetListBySortColumn";
			SqlParameter parmStartRows = new SqlParameter("StartRows", startRowIndexId);
			SqlParameter parmPageSize = new SqlParameter("PageSize", maxNumberRows);
			SqlParameter parmPrimaryColumn = new SqlParameter("PrimaryColumn", PrimaryColumn);
			SqlParameter parmSortColumnDbType = new SqlParameter("SortColumnDbType", SortColumnDbType);
			SqlParameter parmSortColumn = new SqlParameter("SortColumn", SortColumn);
			SqlParameter parmStrColumn = new SqlParameter("StrColumn", StrColumn);
			SqlParameter parmSorts = new SqlParameter("Sorts", Sorts);
			SqlParameter parmTableName = new SqlParameter("TableName", TableName);
			SqlParameter parmFilter = new SqlParameter("Filter", Filter);
			SqlParameter parmTotal = new SqlParameter("Total", SqlDbType.Int);
			parmTotal.Direction = ParameterDirection.Output;
			IDataParameter[] parameterArray = new IDataParameter[10];
			parameterArray[0] = parmStartRows;
			parameterArray[1] = parmPageSize;
			parameterArray[2] = parmPrimaryColumn;
			parameterArray[3] = parmSortColumnDbType;
			parameterArray[4] = parmSortColumn;
			parameterArray[5] = parmStrColumn;
			parameterArray[6] = parmSorts;
			parameterArray[7] = parmTableName;
			parameterArray[8] = parmFilter;
			parameterArray[9] = parmTotal;
			using (NullableDataReader reader = _DB.GetDataReaderByProc(storedProcedureName, parameterArray))
			{
				while (reader.Read())
				{
					list.Add(GetEntityFromrdr(reader));
				}
			}
			Total = (int)parmTotal.Value;
			return list;
		}
		#endregion
		
		#region 辅助方法
		/// <summary>
		/// 把实体类转换成键/值对集合
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="dict"></param>
		private static void GetParameters(CollectionPagingRules entity, Dictionary<string, object> dict)
		{
			dict.Add("PagingRuleID", entity.PagingRuleID);
			dict.Add("ItemID", entity.ItemID);
			dict.Add("RuleType", entity.RuleType);
			dict.Add("PagingType", entity.PagingType);
			dict.Add("PagingBeginCode", entity.PagingBeginCode);
			dict.Add("PagingEndCode", entity.PagingEndCode);
			dict.Add("LinkBeginCode", entity.LinkBeginCode);
			dict.Add("LinkEndCode", entity.LinkEndCode);
			dict.Add("DesignatedUrl", entity.DesignatedUrl);
			dict.Add("ScopeBegin", entity.ScopeBegin);
			dict.Add("ScopeEnd", entity.ScopeEnd);
			dict.Add("PagingUrlList", entity.PagingUrlList);
			dict.Add("CorrelationRuleId", entity.CorrelationRuleId);
		}
		/// <summary>
		/// 通过数据读取器生成实体类
		/// </summary>
		/// <param name="rdr"></param>
		/// <returns></returns>
		private static CollectionPagingRules GetEntityFromrdr(NullableDataReader rdr)
		{
			CollectionPagingRules info = new CollectionPagingRules();
			info.PagingRuleID = rdr.GetInt32("PagingRuleID");
			info.ItemID = rdr.GetInt32("ItemID");
			info.RuleType = rdr.GetInt32("RuleType");
			info.PagingType = rdr.GetInt32("PagingType");
			info.PagingBeginCode = rdr.GetString("PagingBeginCode");
			info.PagingEndCode = rdr.GetString("PagingEndCode");
			info.LinkBeginCode = rdr.GetString("LinkBeginCode");
			info.LinkEndCode = rdr.GetString("LinkEndCode");
			info.DesignatedUrl = rdr.GetString("DesignatedUrl");
			info.ScopeBegin = rdr.GetInt32("ScopeBegin");
			info.ScopeEnd = rdr.GetInt32("ScopeEnd");
			info.PagingUrlList = rdr.GetString("PagingUrlList");
			info.CorrelationRuleId = rdr.GetInt32("CorrelationRuleId");
			return info;
		}
		#endregion
	}
}