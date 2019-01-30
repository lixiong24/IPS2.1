using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JX.Infrastructure.Common;
using JX.Infrastructure;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JXWebHost.Controllers
{
    public class CommonController : Controller
    {
		[HttpPost]
		public async Task<IActionResult> UploadHandle()
		{
			var formFile = Request.Form.Files[0];
			ResultInfo resultInfo = await Utility.FileUploadSaveAs(formFile);
			return Json(resultInfo);
		}

		public IActionResult ValidateCode()
		{
			string code = "";
			System.IO.MemoryStream ms = ValidateCodeHelper.CreateValidateCode(out code);
			Utility.SetSession("LoginValidateCode", code);
			Response.Body.Dispose();
			return File(ms.ToArray(), @"image/png");
		}

		private IActionResult RedirectToLocal(string returnUrl)
		{
			if (Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			else
			{
				return RedirectToAction(nameof(HomeController.Index), "Home");
			}
		}
	}
}
