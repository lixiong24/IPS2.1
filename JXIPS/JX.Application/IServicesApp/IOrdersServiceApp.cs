using JX.Application.DTOs;

namespace JX.Application
{
	/// <summary>
	/// 数据库表：Orders 的应用层服务接口.
	/// </summary>
	public partial interface IOrdersServiceApp : IServiceApp<OrdersDTO>
	{
	}
}