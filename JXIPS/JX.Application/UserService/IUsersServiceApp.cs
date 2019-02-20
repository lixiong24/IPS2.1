using JX.Application.DTOs;
using JX.Core;

namespace JX.Application
{
	/// <summary>
	/// 会员模块相关的应用层服务接口.
	/// </summary>
	public partial interface IUsersServiceApp : IServiceApp<UsersDTO>
	{
		/// <summary>
		/// 会员登录
		/// </summary>
		/// <param name="userName"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		UserStatusEnum Login(string userName, string password);

		/// <summary>
		/// 得到会员状态
		/// </summary>
		/// <param name="userID">会员ID</param>
		/// <returns></returns>
		UserStatusEnum GetUserStatus(int userID);
		/// <summary>
		/// 得到会员状态
		/// </summary>
		/// <param name="userName">会员名称</param>
		/// <returns></returns>
		UserStatusEnum GetUserStatus(string userName);

		/// <summary>
		/// 通过会员名得到会员DTO类
		/// </summary>
		/// <param name="userName"></param>
		/// <returns></returns>
		UsersDTO GetDTOByUserName(string userName);
	}
}