using JX.Application.DTOs;
using JX.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JXWebHost.Areas.Admin.Models.AdministratorViewModels
{
    public class PermissionsViewModels
    {
		/// <summary>
		/// 菜单列表
		/// </summary>
		public IList<MenuEntity> MenuEntityList { get; set; }
		/// <summary>
		/// 角色的权限码
		/// </summary>
		public IList<RolesPermissionsDTO> RolesPermissionsList { get; set; }

	}
}
