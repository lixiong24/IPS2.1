using AutoMapper;
using JX.Application.DTOs;
using JX.Core;
using JX.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：StatTimezone 的应用层服务接口实现类.
	/// </summary>
	public partial class StatTimezoneServiceAppADO : IStatTimezoneServiceAppADO
	{
		#region 仓储接口
		private readonly IStatTimezoneRepositoryADO _repository;
		/// <summary>
		/// 构造器注入
		/// </summary>
		/// <param name="repository"></param>
		public StatTimezoneServiceAppADO(IStatTimezoneRepositoryADO repository)
		{
			_repository = repository;
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
			return _repository.GetScalar(statistic, strWhere, dict);
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
			return await _repository.GetScalarAsync(statistic, strWhere, dict);
		}
		#endregion
		
		#region 得到所有行数
		/// <summary>
		/// 得到所有行数
		/// </summary>
		/// <returns></returns>
		public virtual int GetCount()
		{
			return _repository.GetCount();
		}
		/// <summary>
		/// 得到所有行数（异步方式）
		/// </summary>
		/// <returns></returns>
		public virtual async Task<int> GetCountAsync()
		{
			return await _repository.GetCountAsync();
		}

		/// <summary>
		/// 得到所有行数
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual int GetCount(string strWhere, Dictionary<string, object> dict = null)
		{
			return _repository.GetCount(strWhere, dict);
		}
		/// <summary>
		/// 得到所有行数（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<int> GetCountAsync(string strWhere, Dictionary<string, object> dict = null)
		{
			return await _repository.GetCountAsync(strWhere, dict);
		}
		#endregion
		
		#region 得到最大ID、最新ID
		/// <summary>
		/// 得到数据表中第一个主键的最大数值
		/// </summary>
		/// <returns></returns>
		public virtual int GetMaxID()
		{
			return _repository.GetMaxID();
		}
		/// <summary>
		/// 得到数据表中第一个主键的最大数值（异步方式）
		/// </summary>
		/// <returns></returns>
		public virtual async Task<int> GetMaxIDAsync()
		{
			return await _repository.GetMaxIDAsync();
		}

		/// <summary>
		/// 得到数据表中第一个主键的最大数值加1
		/// </summary>
		/// <returns></returns>
		public virtual int GetNewID()
		{
			return _repository.GetNewID();
		}
		/// <summary>
		/// 得到数据表中第一个主键的最大数值加1（异步方式）
		/// </summary>
		/// <returns></returns>
		public virtual async Task<int> GetNewIDAsync()
		{
			return await _repository.GetNewIDAsync();
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
			return _repository.IsExist(strWhere, dict);
		}

		/// <summary>
		/// 检查数据是否存在（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<bool> IsExistAsync(string strWhere, Dictionary<string, object> dict = null)
		{
			return await _repository.IsExistAsync(strWhere, dict);
		}
		#endregion
		
		#region 添加
		/// <summary>
		/// 增加一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		public virtual bool Add(StatTimezoneDTO dto)
		{
			return _repository.Add(Mapper.Map<StatTimezone>(dto));
		}
		/// <summary>
		/// 增加一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		public virtual async Task<bool> AddAsync(StatTimezoneDTO dto)
		{
			return await _repository.AddAsync(Mapper.Map<StatTimezone>(dto));
		}

		/// <summary>
		/// 增加一条记录，返回新的ID号。需要有一个单一主键，并且开启有标识符属性
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		public virtual int Insert(StatTimezoneDTO dto)
		{
			return _repository.Insert(Mapper.Map<StatTimezone>(dto));
		}
		/// <summary>
		/// 增加一条记录，返回新的ID号。需要有一个单一主键，并且开启有标识符属性（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		public virtual async Task<int> InsertAsync(StatTimezoneDTO dto)
		{
			return await _repository.InsertAsync(Mapper.Map<StatTimezone>(dto));
		}

		/// <summary>
		/// 增加或更新一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsSave">是否增加</param>
		/// <returns></returns>
		public virtual bool AddOrUpdate(StatTimezoneDTO dto, bool IsSave)
		{
			return IsSave ? Add(dto) : Update(dto);
		}
		/// <summary>
		/// 增加或更新一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsSave">是否增加</param>
		/// <returns></returns>
		public virtual async Task<bool> AddOrUpdateAsync(StatTimezoneDTO dto, bool IsSave)
		{
			return IsSave ? await AddAsync(dto) : await UpdateAsync(dto);
		}
		#endregion
		
		#region 删除
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		public bool Delete(System.String tTimezone)
		{
			return _repository.Delete(tTimezone );
		}
		/// <summary>
		/// 通过主键删除
		/// </summary>
		/// <returns></returns>
		public async Task<bool> DeleteAsync(System.String tTimezone)
		{
			return await _repository.DeleteAsync(tTimezone );
		}
		
		/// <summary>
		/// 删除一条或多条记录
		/// </summary>
		/// <param name="strWhere">参数化删除条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual bool Delete(string strWhere, Dictionary<string, object> dict = null)
		{
			return _repository.Delete(strWhere, dict);
		}
		/// <summary>
		/// 删除一条或多条记录（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化删除条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<bool> DeleteAsync(string strWhere, Dictionary<string, object> dict = null)
		{
			return await _repository.DeleteAsync(strWhere, dict);
		}
		#endregion
		
		#region 修改
		/// <summary>
		/// 更新一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		public virtual bool Update(StatTimezoneDTO dto)
		{
			return _repository.Update(Mapper.Map<StatTimezone>(dto));
		}
		/// <summary>
		/// 更新一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		public virtual async Task<bool> UpdateAsync(StatTimezoneDTO dto)
		{
			return await _repository.UpdateAsync(Mapper.Map<StatTimezone>(dto));
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
			return _repository.Update(strColumns, dictColumns, strWhere, dictWhere);
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
			return await _repository.UpdateAsync(strColumns, dictColumns, strWhere, dictWhere);
		}
		#endregion
		
		#region 得到DTO
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		public StatTimezoneDTO GetDTO(System.String tTimezone)
		{
			var entity = _repository.GetEntity(tTimezone );
			return Mapper.Map<StatTimezoneDTO>(entity);
		}
		/// <summary>
		/// 通过主键返回第一条信息的DTO类。
		/// </summary>
		/// <returns></returns>
		public async Task<StatTimezoneDTO> GetDTOAsync(System.String tTimezone)
		{
			var entity = await _repository.GetEntityAsync(tTimezone );
			return Mapper.Map<StatTimezoneDTO>(entity);
		}

		/// <summary>
		/// 获取DTO
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual StatTimezoneDTO GetDTO(string strWhere, Dictionary<string, object> dict = null)
		{
			var entity = _repository.GetEntity(strWhere, dict);
			return Mapper.Map<StatTimezoneDTO>(entity);
		}
		/// <summary>
		/// 获取DTO（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<StatTimezoneDTO> GetDTOAsync(string strWhere, Dictionary<string, object> dict = null)
		{
			var entity = await _repository.GetEntityAsync(strWhere, dict);
			return Mapper.Map<StatTimezoneDTO>(entity);
		}
		#endregion
		
		#region 得到DTO列表
		/// <summary>
		/// 得到DTO列表
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual IList<StatTimezoneDTO> GetDTOList(string strWhere = "", Dictionary<string, object> dict = null)
		{
			var entity = _repository.GetEntityList(strWhere, dict);
			return Mapper.Map<List<StatTimezoneDTO>>(entity);
		}
		/// <summary>
		/// 得到DTO列表（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		public virtual async Task<IList<StatTimezoneDTO>> GetDTOListAsync(string strWhere = "", Dictionary<string, object> dict = null)
		{
			var entity = await _repository.GetEntityListAsync(strWhere, dict);
			return Mapper.Map<List<StatTimezoneDTO>>(entity);
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
		public IList<StatTimezoneDTO> GetList(int startRowIndexId, int maxNumberRows, string Filter, out int Total)
		{
			Total = 0;
			return GetList(startRowIndexId, maxNumberRows, "", "", "", Filter, "", out Total);
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
		public virtual IList<StatTimezoneDTO> GetList(int startRowIndexId, int maxNumberRows, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total)
		{
			Total = 0;
			var entity = _repository.GetList(startRowIndexId, maxNumberRows, SortColumn, StrColumn, Sorts, Filter, TableName,out Total);
			return Mapper.Map<List<StatTimezoneDTO>>(entity);
		}

		/// <summary>
		/// 通过存储过程"Common_GetListBySortColumn"，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		public IList<StatTimezoneDTO> GetListBySortColumn(int startRowIndexId, int maxNumberRows, string Filter, out int Total)
		{
			Total = 0;
			return GetListBySortColumn(startRowIndexId, maxNumberRows, "", "", "", "", "", Filter, "", out Total);
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
		public IList<StatTimezoneDTO> GetListBySortColumn(int startRowIndexId, int maxNumberRows, string Sorts, string Filter, out int Total)
		{
			Total = 0;
			return GetListBySortColumn(startRowIndexId, maxNumberRows, "", "", "", "", Sorts, Filter, "", out Total);
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
		public virtual IList<StatTimezoneDTO> GetListBySortColumn(int startRowIndexId, int maxNumberRows, string PrimaryColumn, string SortColumnDbType, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total)
		{
			Total = 0;
			var entity = _repository.GetListBySortColumn(startRowIndexId, maxNumberRows, PrimaryColumn, SortColumnDbType, SortColumn, StrColumn, Sorts, Filter, TableName,out Total);
			return Mapper.Map<List<StatTimezoneDTO>>(entity);
		}
		#endregion
		
	}
}