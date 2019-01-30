using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JX.Application;
using JX.Application.DTOs;
using Microsoft.AspNetCore.Cors;
using JwtIssuer.TokenProvider;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using JX.Core;
using JX.Infrastructure.Log;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JwtIssuer.Controllers
{
	[EnableCors("any")]//设置跨域处理的 代理
	[Route("api/[controller]")]
    public class TokenController : Controller
    {
		private TokenProviderOptions _tokenOptions;
		private IAdminServiceApp _AdminService;
		public TokenController(TokenProviderOptions tokenOptions,IAdminServiceApp adminService)
		{
			_tokenOptions = tokenOptions;
			_AdminService = adminService;
		}

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post(string username, string password)
        {
			try
			{


				if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
				{
					return ReturnErrorMsg("用户名或密码不能为空");
				}
				var identityResult = await _AdminService.Login(username, password);
				if (!identityResult.IsSuccess)
				{
					return ReturnErrorMsg(identityResult.ErrorString);
				}

				var now = DateTime.UtcNow;
				var claims = identityResult.User.Claims;
				claims.Append(new Claim(JwtRegisteredClaimNames.Sub, username));
				claims.Append(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
				claims.Append(new Claim(JwtRegisteredClaimNames.Iat, now.ToUniversalTime().ToString(), ClaimValueTypes.Integer64));

				var jwt = new JwtSecurityToken(
					issuer: _tokenOptions.Issuer,
					audience: _tokenOptions.Audience,
					claims: claims,
					notBefore: now,
					expires: now.Add(_tokenOptions.Expiration),
					signingCredentials: _tokenOptions.SigningCredentials
				);
				var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

				var response = new
				{
					Status = true,
					access_token = encodedJwt,
					expires_in = (int)_tokenOptions.Expiration.TotalSeconds,
					token_type = "Bearer"
				};
				return Json(response);
			}
			catch(Exception ex)
			{
				return Json(new { Status=false,Message= ex.Message });
			}
		}

		/// <summary>
		/// 返回认证失败消息
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		private IActionResult ReturnErrorMsg(string errMsg)
		{
			return Json(new { Status = false, Message = errMsg });
		}
	}
}
