using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JX.Application
{
	/// <summary>
	/// 应用层服务接口(基于ADO.NET)
	/// </summary>
	public interface IServiceAppADO<T> where T : class
	{
		#region 得到第一行第一列的值
		/// <summary>
		/// 得到第一行第一列的值
		/// </summary>
		/// <param name="statistic">要返回的字段（如：count(*) 或者 UserName）</param>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		string GetScalar(string statistic, string strWhere = "", Dictionary<string, object> dict = null);
		/// <summary>
		/// 得到第一行第一列的值（异步方式）
		/// </summary>
		/// <param name="statistic">要返回的字段（如：count(*) 或者 UserName）</param>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		Task<string> GetScalarAsync(string statistic, string strWhere = "", Dictionary<string, object> dict = null);
		#endregion

		#region 得到所有行数
		/// <summary>
		/// 得到所有行数
		/// </summary>
		/// <returns></returns>
		int GetCount();
		/// <summary>
		/// 得到所有行数（异步方式）
		/// </summary>
		/// <returns></returns>
		Task<int> GetCountAsync();

		/// <summary>
		/// 得到所有行数
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		int GetCount(string strWhere, Dictionary<string, object> dict = null);
		/// <summary>
		/// 得到所有行数（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		Task<int> GetCountAsync(string strWhere, Dictionary<string, object> dict = null);
		#endregion

		#region 得到最大ID、最新ID
		/// <summary>
		/// 得到数据表中第一个主键的最大数值
		/// </summary>
		/// <returns></returns>
		int GetMaxID();
		/// <summary>
		/// 得到数据表中第一个主键的最大数值（异步方式）
		/// </summary>
		/// <returns></returns>
		Task<int> GetMaxIDAsync();

		/// <summary>
		/// 得到数据表中第一个主键的最大数值加1
		/// </summary>
		/// <returns></returns>
		int GetNewID();
		/// <summary>
		/// 得到数据表中第一个主键的最大数值加1（异步方式）
		/// </summary>
		/// <returns></returns>
		Task<int> GetNewIDAsync();
		#endregion

		#region 验证是否存在

		/// <summary>
		/// 检查数据是否存在
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		bool IsExist(string strWhere, Dictionary<string, object> dict = null);

		/// <summary>
		/// 检查数据是否存在（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		Task<bool> IsExistAsync(string strWhere, Dictionary<string, object> dict = null);
		#endregion

		#region 添加
		/// <summary>
		/// 增加一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		bool Add(T dto);
		/// <summary>
		/// 增加一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		Task<bool> AddAsync(T dto);

		/// <summary>
		/// 增加一条记录，返回新的ID号。需要有一个单一主键，并且开启有标识符属性
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		int Insert(T dto);
		/// <summary>
		/// 增加一条记录，返回新的ID号。需要有一个单一主键，并且开启有标识符属性（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		Task<int> InsertAsync(T dto);

		/// <summary>
		/// 增加或更新一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsSave">是否增加</param>
		/// <returns></returns>
		bool AddOrUpdate(T dto, bool IsSave);
		/// <summary>
		/// 增加或更新一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <param name="IsSave">是否增加</param>
		/// <returns></returns>
		Task<bool> AddOrUpdateAsync(T dto, bool IsSave);
		#endregion

		#region 删除
		/// <summary>
		/// 删除一条或多条记录
		/// </summary>
		/// <param name="strWhere">参数化删除条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		bool Delete(string strWhere, Dictionary<string, object> dict = null);
		/// <summary>
		/// 删除一条或多条记录（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化删除条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		Task<bool> DeleteAsync(string strWhere, Dictionary<string, object> dict = null);
		#endregion

		#region 修改
		/// <summary>
		/// 更新一条记录
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		bool Update(T dto);
		/// <summary>
		/// 更新一条记录（异步方式）
		/// </summary>
		/// <param name="dto">dto模型</param>
		/// <returns></returns>
		Task<bool> UpdateAsync(T dto);

		/// <summary>
		/// 修改一条或多条记录
		/// </summary>
		/// <param name="strColumns">参数化要修改的列（如：ID = @ID,Name = @Name）</param>
		/// <param name="dictColumns">包含要修改的名称和值的集合,对应strColumns参数中要修改列的值</param>
		/// <param name="strWhere">参数化修改条件(例如: and ID = @ID)</param>
		/// <param name="dictWhere">包含查询名称和值的集合,对应strWhere参数中的值</param>
		/// <returns></returns>
		bool Update(string strColumns, Dictionary<string, object> dictColumns = null, string strWhere = "", Dictionary<string, object> dictWhere = null);
		/// <summary>
		/// 修改一条或多条记录（异步方式）
		/// </summary>
		/// <param name="strColumns">参数化要修改的列（如：ID = @ID,Name = @Name）</param>
		/// <param name="dictColumns">包含要修改的名称和值的集合,对应strColumns参数中要修改列的值</param>
		/// <param name="strWhere">参数化修改条件(例如: and ID = @ID)</param>
		/// <param name="dictWhere">包含查询名称和值的集合,对应strWhere参数中的值</param>
		/// <returns></returns>
		Task<bool> UpdateAsync(string strColumns, Dictionary<string, object> dictColumns = null, string strWhere = "", Dictionary<string, object> dictWhere = null);
		#endregion

		#region 得到dto
		/// <summary>
		/// 获取dto
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		T GetDTO(string strWhere, Dictionary<string, object> dict = null);
		/// <summary>
		/// 获取dto（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		Task<T> GetDTOAsync(string strWhere, Dictionary<string, object> dict = null);
		#endregion

		#region 得到dto列表
		/// <summary>
		/// 得到dto列表
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		IList<T> GetDTOList(string strWhere = "", Dictionary<string, object> dict = null);
		/// <summary>
		/// 得到dto列表（异步方式）
		/// </summary>
		/// <param name="strWhere">参数化查询条件(例如: and Name = @Name )</param>
		/// <param name="dict">参数的名/值集合</param>
		/// <returns></returns>
		Task<IList<T>> GetDTOListAsync(string strWhere = "", Dictionary<string, object> dict = null);
		#endregion

		#region 分页
		/// <summary>
		/// 通过存储过程“Common_GetList”，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		IList<T> GetList(int startRowIndexId, int maxNumberRows, string Filter, out int Total);
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
		IList<T> GetList(int startRowIndexId, int maxNumberRows, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total);

		/// <summary>
		/// 通过存储过程“Common_GetListBySortColumn”，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		IList<T> GetListBySortColumn(int startRowIndexId, int maxNumberRows, string Filter, out int Total);
		/// <summary>
		/// 通过存储过程“Common_GetListBySortColumn”，得到分页后的数据
		/// </summary>
		/// <param name="startRowIndexId">开始行索引</param>
		/// <param name="maxNumberRows">每页最大显示数量</param>
		/// <param name="Sorts">排序方式（DESC,ASC）</param>
		/// <param name="Filter">查询条件(例如: Name = 'name' and id=1 )</param>
		/// <param name="Total">输出参数：查询总数</param>
		/// <returns></returns>
		IList<T> GetListBySortColumn(int startRowIndexId, int maxNumberRows, string Sorts, string Filter, out int Total);
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
		IList<T> GetListBySortColumn(int startRowIndexId, int maxNumberRows, string PrimaryColumn, string SortColumnDbType, string SortColumn, string StrColumn, string Sorts, string Filter, string TableName, out int Total);

		#endregion
	}
}
