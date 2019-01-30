using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using JX.Infrastructure.Common;
using Microsoft.AspNetCore.Cors;

namespace JwtAudience.Controllers
{
	[EnableCors("any")]//设置跨域处理的 代理
	[Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
		[Authorize("Bearer",Roles = "SuperAdmin,AdministratorManage")]
		public IActionResult Get()
        {
			SiteOptionConfig siteOptionConfig = ConfigHelper.Get<SiteOptionConfig>();
			return Json(siteOptionConfig);
		}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
