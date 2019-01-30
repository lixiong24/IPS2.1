using AutoMapper;
using JX.Application.DTOs;
using JX.Core;
using JX.Core.Entity;
using JX.Infrastructure.Common;
using JX.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：Courier 的应用层服务接口实现类.
	/// </summary>
	public partial class CourierServiceApp : ICourierServiceApp
	{
		#region 仓储接口
		private readonly ICourierRepository _repository;
		/// <summary>
		/// 构造器注入
		/// </summary>
		/// <param name="repository"></param>
		public CourierServiceApp(ICourierRepository repository)
		{
			_repository = repository;
		}
		#endregion
		
		#region 获取特定字段的值
		/// <summary>
		/// 直接获取特定一个或者多个字段的值,多个字段需要声明Model。
		/// 例：var s = testDal.GetScalar《string,int》(m=>m.Name,m=>m.Code==1);
		/// var s = testDal.GetScalar《StoreM,int》(m=>new StoreM { Name1= m.Name, Code=m.Code },m=>m.Code==2);
		/// var s = testDal.GetScalar《dynamic,int》(m=>new { m.Name,m.Code },m=>m.Code==3);
		/// </summary>
		/// <typeparam name="TResult">数据结果</typeparam>
		/// <typeparam name="TOrderBy">排序字段</typeparam>
		/// <param name="scalar">要返回的结果，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <returns></returns>
		public virtual TResult GetScalar<TResult, TOrderBy>(Expression<Func<CourierDTO, TResult>> scalar, Expression<Func<CourierDTO, bool>> predicate = null, Expression<Func<CourierDTO, TOrderBy>> orderby = null, bool IsAsc = true)
		{
			return _repository.GetScalar<TResult, TOrderBy>(GetEntityLamada(scalar),GetEntityLamada(predicate),GetEntityLamada(orderby),IsAsc);
		}
		/// <summary>
		/// 直接获取特定一个或者多个字段的值,多个字段需要声明Model。
		/// 例：var s = testDal.GetScalar《string,int》(m=>m.Name,m=>m.Code==1);
		/// var s = testDal.GetScalar《StoreM,int》(m=>new StoreM { Name1= m.Name, Code=m.Code },m=>m.Code==2);
		/// var s = testDal.GetScalar《dynamic,int》(m=>new { m.Name,m.Code },m=>m.Code==3);
		/// </summary>
		/// <typeparam name="TResult">数据结果</typeparam>
		/// <typeparam name="TOrderBy">排序字段</typeparam>
		/// <param name="scalar">要返回的结果，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <returns></returns>
		public virtual async Task<TResult> GetScalarAsync<TResult, TOrderBy>(Expression<Func<CourierDTO, TResult>> scalar, Expression<Func<CourierDTO, bool>> predicate = null, Expression<Func<CourierDTO, TOrderBy>> orderby = null, bool IsAsc = true)
		{
			return await _repository.GetScalarAsync<TResult, TOrderBy>(GetEntityLamada(scalar),GetEntityLamada(predicate),GetEntityLamada(orderby),IsAsc);
		}

		/// <summary>
		/// 得到最大值
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="max">最大值字段，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual TResult GetMax<TResult>(Expression<Func<CourierDTO, TResult>> max, Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return _repository.GetMax<TResult>(GetEntityLamada(max),GetEntityLamada(predicate));
		}
		/// <summary>
		/// 得到最大值
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="max">最大值字段，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual async Task<TResult> GetMaxAsync<TResult>(Expression<Func<CourierDTO, TResult>> max, Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return await _repository.GetMaxAsync<TResult>(GetEntityLamada(max),GetEntityLamada(predicate));
		}
		
		/// <summary>
		/// 得到最小值
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="min">最小值字段，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual TResult GetMin<TResult>(Expression<Func<CourierDTO, TResult>> min, Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return _repository.GetMin<TResult>(GetEntityLamada(min),GetEntityLamada(predicate));
		}
		/// <summary>
		/// 得到最小值
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="min">最小值字段，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual async Task<TResult> GetMinAsync<TResult>(Expression<Func<CourierDTO, TResult>> min, Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return await _repository.GetMinAsync<TResult>(GetEntityLamada(min),GetEntityLamada(predicate));
		}
		
		/// <summary>
		/// 得到平均值
		/// </summary>
		/// <param name="avg">平均值字段，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual decimal GetAvg(Expression<Func<CourierDTO, decimal>> avg, Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return _repository.GetAvg(GetEntityLamada(avg),GetEntityLamada(predicate));
		}
		/// <summary>
		/// 得到平均值
		/// </summary>
		/// <param name="avg">平均值字段，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual async Task<decimal> GetAvgAsync(Expression<Func<CourierDTO, decimal>> avg, Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return await _repository.GetAvgAsync(GetEntityLamada(avg),GetEntityLamada(predicate));
		}
		
		/// <summary>
		/// 得到求和值
		/// </summary>
		/// <param name="sum">求和值字段，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual decimal GetSum(Expression<Func<CourierDTO, decimal>> sum, Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return _repository.GetSum(GetEntityLamada(sum),GetEntityLamada(predicate));
		}
		/// <summary>
		/// 得到求和值
		/// </summary>
		/// <param name="sum">求和值字段，Lamda表达式（p=>p.Id）</param>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual async Task<decimal> GetSumAsync(Expression<Func<CourierDTO, decimal>> sum, Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return await _repository.GetSumAsync(GetEntityLamada(sum),GetEntityLamada(predicate));
		}
		
		/// <summary>
		/// 得到总数值
		/// </summary>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual int GetCount(Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return _repository.GetCount(GetEntityLamada(predicate));
		}
		/// <summary>
		/// 得到总数值
		/// </summary>
		/// <param name="predicate">查询条件，Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual async Task<int> GetCountAsync(Expression<Func<CourierDTO, bool>> predicate = null)
		{
			return await _repository.GetCountAsync(GetEntityLamada(predicate));
		}
		#endregion
		
		#region 验证是否存在

		/// <summary>
		/// 验证当前条件是否存在相同项
		/// </summary>
		public virtual bool IsExist(Expression<Func<CourierDTO, bool>> predicate)
		{
			return _repository.IsExist(GetEntityLamada(predicate));
		}
		/// <summary>
		/// 验证当前条件是否存在相同项（异步方式）
		/// </summary>
		public virtual async Task<bool> IsExistAsync(Expression<Func<CourierDTO, bool>> predicate)
		{
			return await _repository.IsExistAsync(GetEntityLamada(predicate));
		}
		#endregion
		
		#region 添加
		/// <summary>
		/// 增加一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual bool Add(CourierDTO dto, bool IsCommit = true)
		{
			
			return _repository.Add(Mapper.Map<Courier>(dto), IsCommit);
		}
		/// <summary>
		/// 增加一条记录(异步方式)
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual async Task<bool> AddAsync(CourierDTO dto, bool IsCommit = true)
		{
			
			return await _repository.AddAsync(Mapper.Map<Courier>(dto), IsCommit);
		}

		/// <summary>
		/// 增加多条记录，同一模型
		/// </summary>
		/// <param name="dtoList">dto模型集合</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual bool AddList(IList<CourierDTO> dtoList, bool IsCommit = true)
		{
			if (dtoList == null || dtoList.Count == 0) return false;
			dtoList.ToList().ForEach(item =>
			{
				Add(item);
			});
			return true;
		}
		/// <summary>
		/// 增加多条记录，同一模型（异步方式）
		/// </summary>
		/// <param name="dtoList">dto模型集合</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual async Task<bool> AddListAsync(IList<CourierDTO> dtoList, bool IsCommit = true)
		{
			if (dtoList == null || dtoList.Count == 0) return await Task.Run(() => false);
			dtoList.ToList().ForEach(async item =>
			{
				await AddAsync(item);
			});
			return true;
		}

		/// <summary>
		/// 增加或更新一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsSave">是否增加</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual bool AddOrUpdate(CourierDTO dto, bool IsSave, bool IsCommit = true)
		{
			return IsSave ? Add(dto, IsCommit) : Update(dto, IsCommit);
		}
		/// <summary>
		/// 增加或更新一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsSave">是否增加</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual async Task<bool> AddOrUpdateAsync(CourierDTO dto, bool IsSave, bool IsCommit = true)
		{
			return IsSave ? await AddAsync(dto, IsCommit) : await UpdateAsync(dto, IsCommit);
		}
		#endregion
		
		#region 删除
		/// <summary>
		/// 删除一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual bool Delete(CourierDTO dto, bool IsCommit = true)
		{
			if (dto == null) return false;
			return _repository.Delete(Mapper.Map<Courier>(dto), IsCommit);
		}
		/// <summary>
		/// 删除一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual async Task<bool> DeleteAsync(CourierDTO dto, bool IsCommit = true)
		{
			if (dto == null) return await Task.Run(() => false);

			return await _repository.DeleteAsync(Mapper.Map<Courier>(dto), IsCommit);
		}

		/// <summary>
		/// 删除多条记录，同一模型
		/// </summary>
		/// <param name="dtoList">dto模型集合</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual bool DeleteList(IList<CourierDTO> dtoList, bool IsCommit = true)
		{
			if (dtoList == null || dtoList.Count == 0) return false;

			return _repository.DeleteList(Mapper.Map<IList<Courier>>(dtoList), IsCommit);
		}
		/// <summary>
		/// 删除多条记录，同一模型（异步方式）
		/// </summary>
		/// <param name="dtoList">dto模型集合</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual async Task<bool> DeleteListAsync(IList<CourierDTO> dtoList, bool IsCommit = true)
		{
			if (dtoList == null || dtoList.Count == 0) return await Task.Run(() => false);

			return await _repository.DeleteListAsync(Mapper.Map<IList<Courier>>(dtoList), IsCommit);
		}

		/// <summary>
		/// 通过Lamda表达式，删除一条或多条记录
		/// </summary>
		/// <param name="predicate"></param>
		/// <param name="IsCommit"></param>
		/// <returns></returns>
		public virtual bool Delete(Expression<Func<CourierDTO, bool>> predicate, bool IsCommit = true)
		{
			return _repository.Delete(GetEntityLamada(predicate), IsCommit);
		}
		/// <summary>
		/// 通过Lamda表达式，删除一条或多条记录（异步方式）
		/// </summary>
		/// <param name="predicate"></param>
		/// <param name="IsCommit"></param>
		/// <returns></returns>
		public virtual async Task<bool> DeleteAsync(Expression<Func<CourierDTO, bool>> predicate, bool IsCommit = true)
		{
			return await _repository.DeleteAsync(GetEntityLamada(predicate), IsCommit);
		}

		/// <summary>
		/// 根据SQL删除一条或多条记录
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="para"></param>
		/// <returns></returns>
		public virtual bool Delete(string sql, params DbParameter[] para)
		{
			return _repository.Delete(sql, para);
		}
		/// <summary>
		/// 根据SQL删除一条或多条记录（异步方式）
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="para"></param>
		/// <returns></returns>
		public virtual async Task<bool> DeleteAsync(string sql, params DbParameter[] para)
		{
			return await _repository.DeleteAsync(sql, para);
		}
		#endregion
		
		#region 修改
		/// <summary>
		/// 更新一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual bool Update(CourierDTO dto, bool IsCommit = true)
		{
			return _repository.Update(Mapper.Map<Courier>(dto), IsCommit);
		}
		/// <summary>
		/// 更新一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual async Task<bool> UpdateAsync(CourierDTO dto, bool IsCommit = true)
		{
			return await _repository.UpdateAsync(Mapper.Map<Courier>(dto), IsCommit);
		}

		/// <summary>
		/// 更新多条记录，同一模型
		/// </summary>
		/// <param name="dtoList">dto模型集合</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual bool UpdateList(IList<CourierDTO> dtoList, bool IsCommit = true)
		{
			if (dtoList == null || dtoList.Count == 0) return false;

			return _repository.UpdateList(Mapper.Map<IList<Courier>>(dtoList), IsCommit);
		}
		/// <summary>
		/// 更新多条记录，同一模型（异步方式）
		/// </summary>
		/// <param name="dtoList">dto模型集合</param>
		/// <param name="IsCommit">是否提交（默认提交）</param>
		/// <returns></returns>
		public virtual async Task<bool> UpdateListAsync(IList<CourierDTO> dtoList, bool IsCommit = true)
		{
			if (dtoList == null || dtoList.Count == 0) return await Task.Run(() => false);

			return await _repository.UpdateListAsync(Mapper.Map<IList<Courier>>(dtoList), IsCommit);
		}

		/// <summary>
		/// 根据SQL修改一条或多条记录
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="para"></param>
		/// <returns></returns>
		public virtual bool Update(string sql, params DbParameter[] para)
		{
			return _repository.Update(sql, para);
		}
		/// <summary>
		/// 根据SQL修改一条或多条记录（异步方式）
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="para"></param>
		/// <returns></returns>
		public virtual async Task<bool> UpdateAsync(string sql, params DbParameter[] para)
		{
			return await _repository.UpdateAsync(sql, para);
		}
		#endregion
		
		#region 得到dto
		/// <summary>
		/// 通过Lamda表达式获取dto
		/// </summary>
		/// <param name="predicate">Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual CourierDTO Get(Expression<Func<CourierDTO, bool>> predicate)
		{
			var entity = _repository.Get(GetEntityLamada(predicate));
			return Mapper.Map<CourierDTO>(entity);
		}
		/// <summary>
		/// 通过Lamda表达式获取dto（异步方式）
		/// </summary>
		/// <param name="predicate">Lamda表达式（p=>p.Id==Id）</param>
		/// <returns></returns>
		public virtual async Task<CourierDTO> GetAsync(Expression<Func<CourierDTO, bool>> predicate)
		{
			var entity = await _repository.GetAsync(GetEntityLamada(predicate));
			return Mapper.Map<CourierDTO>(entity);
		}
		#endregion
		
		#region 得到dto列表

		/// <summary>
		/// 返回IQueryable集合，延时加载数据
		/// </summary>
		/// <param name="predicate">Lamda表达式（p=>p.Id==Id）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual IQueryable<CourierDTO> LoadAll(Expression<Func<CourierDTO, bool>> predicate, params SortModelField[] orderByExpression)
		{
			var entity = _repository.LoadAll(GetEntityLamada(predicate),orderByExpression);
			return Mapper.Map<IQueryable<CourierDTO>>(entity);
		}
		/// <summary>
		/// 返回IQueryable集合，延时加载数据（异步方式）
		/// </summary>
		/// <param name="predicate">Lamda表达式（p=>p.Id==Id）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual async Task<IQueryable<CourierDTO>> LoadAllAsync(Expression<Func<CourierDTO, bool>> predicate, params SortModelField[] orderByExpression)
		{
			var entity = await _repository.LoadAllAsync(GetEntityLamada(predicate),orderByExpression);
			return Mapper.Map<IQueryable<CourierDTO>>(entity);
		}

		/// <summary>
		/// 返回集合,不采用延时加载
		/// </summary>
		/// <param name="predicate">Lamda表达式（p=>p.Id==Id）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual List<CourierDTO> LoadListAll(Expression<Func<CourierDTO, bool>> predicate, params SortModelField[] orderByExpression)
		{
			var entity = _repository.LoadListAll(GetEntityLamada(predicate),orderByExpression);
			return Mapper.Map<List<CourierDTO>>(entity);
		}
		/// <summary>
		/// 返回集合,不采用延时加载（异步方式）
		/// </summary>
		/// <param name="predicate">Lamda表达式（p=>p.Id==Id）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual async Task<List<CourierDTO>> LoadListAllAsync(Expression<Func<CourierDTO, bool>> predicate, params SortModelField[] orderByExpression)
		{
			var entity = await _repository.LoadListAllAsync(GetEntityLamada(predicate),orderByExpression);
			return Mapper.Map<List<CourierDTO>>(entity);
		}
		
		/// <summary>
		/// T-Sql方式：返回IQueryable集合
		/// </summary>
		/// <param name="sql">SQL语句</param>
		/// <param name="para">Parameters参数</param>
		/// <returns></returns>
		public virtual IQueryable<CourierDTO> LoadAllBySql(string sql, params DbParameter[] para)
		{
			var entity = _repository.LoadAllBySql(sql,para);
			return Mapper.Map<IQueryable<CourierDTO>>(entity);
		}
		/// <summary>
		/// T-Sql方式：返回IQueryable集合（异步方式）
		/// </summary>
		/// <param name="sql">SQL语句</param>
		/// <param name="para">Parameters参数</param>
		/// <returns></returns>
		public virtual async Task<IQueryable<CourierDTO>> LoadAllBySqlAsync(string sql, params DbParameter[] para)
		{
			var entity = await _repository.LoadAllBySqlAsync(sql,para);
			return Mapper.Map<IQueryable<CourierDTO>>(entity);
		}

		/// <summary>
		/// Sql方式：返回List集合
		/// </summary>
		/// <param name="sql">SQL语句</param>
		/// <param name="para">Parameters参数</param>
		/// <returns></returns>
		public virtual List<CourierDTO> LoadListAllBySql(string sql, params DbParameter[] para)
		{
			var entity = _repository.LoadListAllBySql(sql, para);
			return Mapper.Map<List<CourierDTO>>(entity);
		}
		/// <summary>
		/// Sql方式：返回List集合（异步方式）
		/// </summary>
		/// <param name="sql">SQL语句</param>
		/// <param name="para">Parameters参数</param>
		/// <returns></returns>
		public virtual async Task<List<CourierDTO>> LoadListAllBySqlAsync(string sql, params DbParameter[] para)
		{
			var entity = await _repository.LoadListAllBySqlAsync(sql, para);
			return Mapper.Map<List<CourierDTO>>(entity);
		}
		#endregion
		
		#region 得到数据列表
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回实体对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <typeparam name="TResult">数据结果，与TEntity一致</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <returns>实体集合</returns>
		public virtual List<TResult> QueryEntity<TEntity, TOrderBy, TResult>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TOrderBy>> orderby,
			Expression<Func<TEntity, TResult>> selector,
			bool IsAsc=true)
			where TEntity : class
			where TResult : class
		{
			return _repository.QueryEntity<TEntity, TOrderBy, TResult>(where,orderby,selector,IsAsc);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回实体对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TResult">数据结果，与TEntity一致</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual List<TResult> QueryEntity<TEntity, TResult>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TResult>> selector,
			params SortModelField[] orderByExpression)
			where TEntity : class
			where TResult : class
		{
			return _repository.QueryEntity<TEntity, TResult>(where, selector, orderByExpression);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回实体对象集合（异步方式）
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <typeparam name="TResult">数据结果，与TEntity一致</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <returns>实体集合</returns>
		public virtual async Task<List<TResult>> QueryEntityAsync<TEntity, TOrderBy, TResult>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TOrderBy>> orderby,
			Expression<Func<TEntity, TResult>> selector,
			bool IsAsc = true)
			where TEntity : class
			where TResult : class
		{
			return await _repository.QueryEntityAsync<TEntity, TOrderBy, TResult>(where,orderby,selector,IsAsc);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回实体对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TResult">数据结果，与TEntity一致</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual async Task<List<TResult>> QueryEntityAsync<TEntity, TResult>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TResult>> selector,
			params SortModelField[] orderByExpression)
			where TEntity : class
			where TResult : class
		{
			return await _repository.QueryEntityAsync<TEntity, TResult>(where,selector,orderByExpression);
		}

		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回Object对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <returns>自定义实体集合</returns>
		public virtual List<object> QueryObject<TEntity, TOrderBy>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TOrderBy>> orderby,
			Func<IQueryable<TEntity>,List<object>> selector,
			bool IsAsc = true)
			where TEntity : class
		{
			return _repository.QueryObject<TEntity, TOrderBy>(where,orderby,selector,IsAsc);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回Object对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual List<object> QueryObject<TEntity>
			(Expression<Func<TEntity, bool>> where, 
			Func<IQueryable<TEntity>, List<object>> selector, 
			params SortModelField[] orderByExpression)
			where TEntity : class
		{
			return _repository.QueryObject<TEntity>(where,selector,orderByExpression);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回Object对象集合（异步方式）
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <returns>自定义实体集合</returns>
		public virtual async Task<List<object>> QueryObjectAsync<TEntity, TOrderBy>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TOrderBy>> orderby,
			Func<IQueryable<TEntity>,List<object>> selector,
			bool IsAsc = true)
			where TEntity : class
		{
			return await _repository.QueryObjectAsync<TEntity, TOrderBy>(where,orderby,selector,IsAsc);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回Object对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual async Task<List<object>> QueryObjectAsync<TEntity>
			(Expression<Func<TEntity, bool>> where,
			Func<IQueryable<TEntity>, List<object>> selector,
			params SortModelField[] orderByExpression)
			where TEntity : class
		{
			return await _repository.QueryObjectAsync<TEntity>(where,selector,orderByExpression);
		}

		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回dynamic对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <returns></returns>
		public virtual List<dynamic> QueryDynamic<TEntity, TOrderBy>
			(Expression<Func<TEntity, bool>> where, 
			Expression<Func<TEntity, TOrderBy>> orderby, 
			Expression<Func<TEntity, dynamic>> selector, 
			bool IsAsc = true)
			where TEntity : class
		{
			return _repository.QueryDynamic<TEntity, TOrderBy>(where,orderby,selector,IsAsc);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回dynamic对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual List<dynamic> QueryDynamic<TEntity>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, dynamic>> selector,
			params SortModelField[] orderByExpression)
			where TEntity : class
		{
			return _repository.QueryDynamic<TEntity>(where,selector,orderByExpression);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回dynamic对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <returns></returns>
		public virtual async Task<List<dynamic>> QueryDynamicAsync<TEntity, TOrderBy>
			(Expression<Func<TEntity, bool>> where, 
			Expression<Func<TEntity, TOrderBy>> orderby, 
			Expression<Func<TEntity, dynamic>> selector, 
			bool IsAsc = true)
			where TEntity : class
		{
			return await _repository.QueryDynamicAsync<TEntity, TOrderBy>(where,orderby,selector,IsAsc);
		}
		/// <summary>
		/// 可指定返回结果、排序、查询条件的通用查询方法，返回dynamic对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <returns></returns>
		public virtual async Task<List<dynamic>> QueryDynamicAsync<TEntity>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, dynamic>> selector,
			params SortModelField[] orderByExpression)
			where TEntity : class
		{
			return await _repository.QueryDynamicAsync<TEntity>(where,selector,orderByExpression);
		}
		#endregion
		
		#region 分页
		/// <summary>
		/// 分页查询，可指定返回结果、排序、查询条件的通用分页查询方法，返回dto对象集合
		/// </summary>
		/// <typeparam name="TEntity">dto对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <typeparam name="TResult">数据结果，与TEntity一致</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <param name="pageIndex">分页索引，从1开始</param>
		/// <param name="pageSize">每页数量</param>
		/// <param name="Total">查询总数</param>
		/// <returns></returns>
		public virtual IList<TResult> QueryEntity<TEntity, TOrderBy, TResult>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TOrderBy>> orderby,
			Expression<Func<TEntity, TResult>> selector,
			bool IsAsc, int pageIndex, int pageSize, out int Total)
			where TEntity : class
			where TResult : class
		{
			Total = 0;
			return _repository.QueryEntity<TEntity, TOrderBy, TResult>(where, orderby, selector, IsAsc, pageIndex, pageSize,out Total);
		}
		/// <summary>
		/// 分页查询，可指定返回结果、排序、查询条件的通用分页查询方法，返回实体对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TResult">数据结果，与TEntity一致</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="pageIndex">分页索引，从1开始</param>
		/// <param name="pageSize">每页数量</param>
		/// <param name="Total">查询总数</param>
		/// <returns></returns>
		public virtual IList<TResult> QueryEntity<TEntity, TResult>
			(Expression<Func<TEntity, bool>> where,
			SortModelField[] orderByExpression,
			Expression<Func<TEntity, TResult>> selector,
			int pageIndex, int pageSize, out int Total)
			where TEntity : class
			where TResult : class
		{
			Total = 0;
			return _repository.QueryEntity<TEntity, TResult>(where, orderByExpression, selector, pageIndex, pageSize,out Total);
		}

		/// <summary>
		/// 分页查询，可指定返回结果、排序、查询条件的通用分页查询方法，返回dynamic对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <param name="pageIndex">分页索引，从1开始</param>
		/// <param name="pageSize">每页数量</param>
		/// <param name="Total">查询总数</param>
		/// <returns></returns>
		public virtual IList<dynamic> QueryDynamic<TEntity, TOrderBy>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TOrderBy>> orderby,
			Expression<Func<TEntity, dynamic>> selector,
			bool IsAsc, int pageIndex, int pageSize, out int Total)
			where TEntity : class
		{
			Total = 0;
			return _repository.QueryDynamic<TEntity, TOrderBy>(where, orderby, selector, IsAsc, pageIndex, pageSize,out Total);	
		}
		/// <summary>
		/// 分页查询，可指定返回结果、排序、查询条件的通用分页查询方法，返回dynamic对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="pageIndex">分页索引，从1开始</param>
		/// <param name="pageSize">每页数量</param>
		/// <param name="Total">查询总数</param>
		/// <returns></returns>
		public virtual IList<dynamic> QueryDynamic<TEntity>
			(Expression<Func<TEntity, bool>> where,
			SortModelField[] orderByExpression,
			Expression<Func<TEntity, dynamic>> selector,
			int pageIndex, int pageSize, out int Total)
			where TEntity : class
		{
			Total = 0;
			return _repository.QueryDynamic<TEntity>(where, orderByExpression, selector, pageIndex, pageSize,out Total);	
		}
			
		/// <summary>
		/// 分页查询，可指定返回结果、排序、查询条件的通用查询方法，返回Object对象集合
		/// </summary>
		/// <typeparam name="TEntity">dto对象</typeparam>
		/// <typeparam name="TOrderBy">排序字段类型</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderby">排序字段</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="IsAsc">排序方向，true为正序false为倒序</param>
		/// <param name="pageIndex">分页索引，从1开始</param>
		/// <param name="pageSize">每页数量</param>
		/// <param name="Total">查询总数</param>
		/// <returns>自定义dto集合</returns>
		public virtual IList<object> QueryObject<TEntity, TOrderBy>
			(Expression<Func<TEntity, bool>> where,
			Expression<Func<TEntity, TOrderBy>> orderby,
			Func<IQueryable<TEntity>, List<object>> selector,
			bool IsAsc, int pageIndex, int pageSize, out int Total)
			where TEntity : class
		{
			Total = 0;
			return _repository.QueryObject<TEntity, TOrderBy>(where, orderby, selector, IsAsc, pageIndex, pageSize, out Total);
		}
		/// <summary>
		/// 分页查询，可指定返回结果、排序、查询条件的通用查询方法，返回Object对象集合
		/// </summary>
		/// <typeparam name="TEntity">实体对象</typeparam>
		/// <param name="where">过滤条件，需要用到类型转换的需要提前处理与数据表一致的</param>
		/// <param name="orderByExpression">多字段排序</param>
		/// <param name="selector">返回结果（必须是模型中存在的字段）</param>
		/// <param name="pageIndex">分页索引，从1开始</param>
		/// <param name="pageSize">每页数量</param>
		/// <param name="Total">查询总数</param>
		/// <returns>自定义实体集合</returns>
		public virtual IList<object> QueryObject<TEntity>
			(Expression<Func<TEntity, bool>> where,
			SortModelField[] orderByExpression,
			Func<IQueryable<TEntity>, List<object>> selector,
			int pageIndex, int pageSize, out int Total)
			where TEntity : class
		{
			Total = 0;
			return _repository.QueryObject<TEntity>(where, orderByExpression, selector, pageIndex, pageSize, out Total);
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
		public virtual IList<CourierDTO> GetList(int startRowIndexId, int maxNumberRows, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total)
		{
			Total=0;
			var entity = _repository.GetList(startRowIndexId,maxNumberRows,SortColumn,StrColumn,Sorts,Filter,TableName,out Total);
			return Mapper.Map<List<CourierDTO>>(entity);
		}
		/// <summary>
		/// 通过存储过程“Common_GetList”，得到分页后的数据
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="startRowIndexId">开始行索引</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="SortColumn">排序字段名，只能指定一个字段</param>
		/// <param name="StrColumn">返回列名</param>
		/// <param name="Sorts">排序方式（DESC,ASC）</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="TableName">查询表名，可以指定联合查询的SQL语句(例如: Comment LEFT JOIN Users ON Comment.UserName = Users.UserName)</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		public virtual IList<TResult> GetList<TResult>(int startRowIndexId, int maxNumberRows, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total) where TResult : new()
		{
			Total=0;
			return _repository.GetList<TResult>(startRowIndexId,maxNumberRows,SortColumn,StrColumn,Sorts,Filter,TableName,out Total);
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
		public virtual IList<CourierDTO> GetListBySortColumn(int startRowIndexId, int maxNumberRows, string PrimaryColumn, string SortColumnDbType, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total)
		{
			Total=0;
			var entity = _repository.GetListBySortColumn(startRowIndexId, maxNumberRows, PrimaryColumn, SortColumnDbType,SortColumn, StrColumn, Sorts, Filter, TableName,out Total);
			return Mapper.Map<List<CourierDTO>>(entity);
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
		public virtual IList<TResult> GetListBySortColumn<TResult>(int startRowIndexId, int maxNumberRows, string PrimaryColumn, string SortColumnDbType, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total) where TResult : new()
		{
			Total=0;
			return _repository.GetListBySortColumn<TResult>(startRowIndexId, maxNumberRows, PrimaryColumn, SortColumnDbType,SortColumn, StrColumn, Sorts, Filter, TableName,out Total);
		}
		
		/// <summary>
		/// 通过存储过程“Common_GetList”，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引，从0开始</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="SortColumn">排序字段名，只能指定一个字段</param>
		/// <param name="StrColumn">返回列名</param>
		/// <param name="Sorts">排序方式（DESC,ASC）</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="TableName">查询表名，可以指定联合查询的SQL语句(例如: Comment LEFT JOIN Users ON Comment.UserName = Users.UserName)</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		public virtual DataTable GetDataTable(int startRowIndexId, int maxNumberRows, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total)
		{
			Total=0;
			return _repository.GetDataTable(startRowIndexId,maxNumberRows,SortColumn,StrColumn,Sorts,Filter,TableName,out Total);
		}
		/// <summary>
		/// 通过存储过程“Common_GetListBySortColumn”，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引，从0开始</param>
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
		public virtual DataTable GetDataTableBySortColumn(int startRowIndexId, int maxNumberRows, string PrimaryColumn, string SortColumnDbType, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total)
		{
			Total=0;
			return _repository.GetDataTableBySortColumn(startRowIndexId,maxNumberRows,PrimaryColumn,SortColumnDbType,SortColumn,StrColumn,Sorts,Filter,TableName,out Total);
		}
		#endregion
		
		#region 直接执行SQL语句
		/// <summary>
		/// 执行SQL语句，返回受影响的行数
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="para"></param>
		/// <returns></returns>
		public virtual int ExeSQL(string sql, params DbParameter[] para)
		{
			return _repository.ExeSQL(sql, para);
		}
		/// <summary>
		/// 执行SQL语句，返回受影响的行数
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="para"></param>
		/// <returns></returns>
		public virtual async Task<int> ExeSQLAsync(string sql, params DbParameter[] para)
		{
			return await _repository.ExeSQLAsync(sql, para);
		}
		
		/// <summary>
		/// 执行SQL语句，返回受影响的行数
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="paraName"></param>
		/// <param name="paraValue"></param>
		/// <returns></returns>
		public virtual int ExeSQL(string sql, string[] paraName, object[] paraValue)
		{
			return _repository.ExeSQL(sql, paraName,paraValue);
		}
		/// <summary>
		/// 执行SQL语句，返回受影响的行数
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="paraName"></param>
		/// <param name="paraValue"></param>
		/// <returns></returns>
		public virtual async Task<int> ExeSQLAsync(string sql, string[] paraName, object[] paraValue)
		{
			return await _repository.ExeSQLAsync(sql, paraName,paraValue);
		}
		
		/// <summary>
		/// 执行SQL语句，返回受影响的行数
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="dict"></param>
		/// <returns></returns>
		public virtual int ExeSQL(string sql, Dictionary<string, object> dict)
		{
			return _repository.ExeSQL(sql, dict);
		}
		/// <summary>
		/// 执行SQL语句，返回受影响的行数
		/// </summary>
		/// <param name="sql"></param>
		/// <param name="dict"></param>
		/// <returns></returns>
		public virtual async Task<int> ExeSQLAsync(string sql, Dictionary<string, object> dict)
		{
			return await _repository.ExeSQLAsync(sql, dict);
		}
		#endregion
		
		#region 执行SQL，返回结果
		/// <summary>
		/// 执行SQL，返回结果。
		/// 例：var s = testDal.GetBySQL《string》("select name from tablename",m=>m.Name);
		/// var s = testDal.GetBySQL《StoreM》("select * from tablename where name=@name",m=>m,new SqlParameter("name", "1"));
		/// var s = testDal.GetBySQL《dynamic》("select name,Code from tablename",m=>new { m.Name,m.Code });
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="sql"></param>
		/// <param name="scalar"></param>
		/// <param name="para"></param>
		/// <returns></returns>
		public virtual TResult GetBySQL<TResult>(string sql, Expression<Func<CourierDTO, TResult>> scalar, params DbParameter[] para)
		{
			return _repository.GetBySQL<TResult>(sql, GetEntityLamada(scalar),para);
		}
		/// <summary>
		/// 执行SQL，返回结果。
		/// 例：var s = testDal.GetBySQL《string》("select name from tablename",m=>m.Name);
		/// var s = testDal.GetBySQL《StoreM》("select * from tablename where name=@name",m=>m,new SqlParameter("name", "1"));
		/// var s = testDal.GetBySQL《dynamic》("select name,Code from tablename",m=>new { m.Name,m.Code });
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="sql"></param>
		/// <param name="scalar"></param>
		/// <param name="para"></param>
		/// <returns></returns>
		public virtual async Task<TResult> GetBySQLAsync<TResult>(string sql, Expression<Func<CourierDTO, TResult>> scalar, params DbParameter[] para)
		{
			return await _repository.GetBySQLAsync<TResult>(sql, GetEntityLamada(scalar),para);
		}
		#endregion
		
		private Expression<Func<Courier, bool>> GetEntityLamada(Expression<Func<CourierDTO, bool>> predicate)
		{
			//得到领域Model相关的lamada
			if (predicate == null) return null;
			Expression<Func<Courier, bool>> lamada = predicate.Cast<CourierDTO, Courier>();
			return lamada;
		}
		private Expression<Func<Courier, TResult>> GetEntityLamada<TResult>(Expression<Func<CourierDTO, TResult>> predicate)
		{
			//得到领域Model相关的lamada
			if (predicate == null) return null;
			Expression<Func<Courier, TResult>> lamada = predicate.Cast<CourierDTO, Courier,TResult>();
			return lamada;
		}
	}
}