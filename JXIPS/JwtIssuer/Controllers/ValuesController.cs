using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JX.Infrastructure.Common;

namespace JwtIssuer.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
			//var redisConfig = ConfigHelper.GetAppSettingSection<RedisConfig>();
			//var instance = CacheHelper.CacheServiceProvider.Get<SiteOptionConfig>("CK_SiteConfigCode_SiteOptionConfig");
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
