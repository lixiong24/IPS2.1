using JX.Application.DTOs;
using JX.Core;
using JX.Infrastructure;
using JX.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JX.Application
{
	public partial class UsersServiceAppADO : IUsersServiceAppADO
	{
		/// <summary>
		/// 会员登录
		/// </summary>
		/// <param name="userName"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public UserStatusEnum Login(string userName, string password)
		{
			UserStatusEnum result = UserStatusEnum.NoExist;
			string encryptedValue = StringHelper.MD5(password);
			if (password.Length == 32)
			{
				encryptedValue = password;
			}
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("UserName", userName);
			dict.Add("UserPassword", encryptedValue);
			var entity = _repository.GetEntity(" and UserName=@UserName and UserPassword=@UserPassword",dict);
			if (entity == null)
			{
				return result;
			}
			switch ((UserStatusEnum)entity.UserStatus)
			{
				case UserStatusEnum.None:
					entity.LoginTimes++;
					entity.LoginTime = new DateTime?(DateTime.Now);
					entity.LoginIP = Utility.GetClientIP();
					entity.LastPassword = DataSecurity.MakeRandomString(10);
					_repository.Update(entity);
					result = UserStatusEnum.None;
					break;
				default:
					result = (UserStatusEnum)entity.UserStatus;
					break;
			}
			return result;
		}

		/// <summary>
		/// 得到会员状态
		/// </summary>
		/// <param name="userID"></param>
		/// <returns></returns>
		public UserStatusEnum GetUserStatus(int userID)
		{
			UserStatusEnum result = UserStatusEnum.NoExist;
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("UserID", userID);
			string strResult = _repository.GetScalar(" UserStatus "," and UserID=@UserID ", dict);
			if(!string.IsNullOrEmpty(strResult))
			{
				result = (UserStatusEnum)DataConverter.CLng(strResult,16);
			}
			return result;
		}
		/// <summary>
		/// 得到会员状态
		/// </summary>
		/// <param name="userName"></param>
		/// <returns></returns>
		public UserStatusEnum GetUserStatus(string userName)
		{
			UserStatusEnum result = UserStatusEnum.NoExist;
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("UserName", userName);
			string strResult = _repository.GetScalar(" UserStatus ", " and UserName=@UserName ", dict);
			if (!string.IsNullOrEmpty(strResult))
			{
				result = (UserStatusEnum)DataConverter.CLng(strResult, 16);
			}
			return result;
		}

		/// <summary>
		/// 通过会员名得到会员的DTO类
		/// </summary>
		/// <param name="userName"></param>
		/// <returns></returns>
		public UsersDTO GetDTOByUserName(string userName)
		{
			Dictionary<string, object> dict = new Dictionary<string, object>();
			dict.Add("UserName", userName);
			return GetDTO(" and UserName=@UserName", dict);
		}
	}
}
