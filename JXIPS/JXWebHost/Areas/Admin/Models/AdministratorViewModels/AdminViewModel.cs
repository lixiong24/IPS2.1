using JX.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JXWebHost.Areas.Admin.Models.AdministratorViewModels
{
    public class AdminViewModel
    {
		public int AdminID { get; set; }

		[Required(ErrorMessage = "管理员名不能为空")]
		public string AdminName { get; set; }

		[Required(ErrorMessage = "密码不能为空")]
		[DataType(DataType.Password)]
		public string AdminPassword { get; set; }

		[Required(ErrorMessage = "确认密码不能为空")]
		[DataType(DataType.Password)]
		[Compare("AdminPassword", ErrorMessage = "两次输入的密码不对")]
		public string ConfirmPwd { get; set; }

		[Required(ErrorMessage = "前台会员名不能为空")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "所属角色不能为空")]
		public string RoleIDs { get; set; }

		public Boolean IsMultiLogin { get; set; }

		public Boolean IsLock { get; set; }

		public Boolean IsModifyPassword { get; set; }

		/// <summary>
		/// 返回给客户端的标识，用于客户端判断是否提交成功。
		/// </summary>
		public string result { get; set; } 
	}
}
