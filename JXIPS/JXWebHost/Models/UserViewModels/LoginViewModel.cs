using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JXWebHost.Models.UserViewModels
{
    public class LoginViewModel
    {
		[Required(ErrorMessage = "会员名不能为空")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "密码不能为空")]
		[DataType(DataType.Password)]
		public string UserPassword { get; set; }

		public string ValidateCode { get; set; }
	}
}
