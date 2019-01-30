using JX.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JXWebHost.Areas.Admin.Models.AdministratorViewModels
{
    public class RoleMemberViewModel
    {
		public IList<AdminDTO> MemberByRole { set; get; }
		public IList<AdminDTO> MemberByNotRole { set; get; }
	}
}
