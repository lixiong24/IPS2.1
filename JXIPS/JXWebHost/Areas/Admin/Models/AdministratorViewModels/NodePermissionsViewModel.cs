using JX.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JXWebHost.Areas.Admin.Models.AdministratorViewModels
{
    public class NodePermissionsViewModel
    {
		/// <summary>
		/// 栏目节点列表
		/// </summary>
		public IList<NodesDTO> NodeList { set; get; }
		/// <summary>
		/// 角色-节点权限列表
		/// </summary>
		public IList<RoleNodePermissionsDTO> RoleNodePermissionsList { get; set; }
	}
}
