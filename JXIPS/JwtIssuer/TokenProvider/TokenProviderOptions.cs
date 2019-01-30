using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtIssuer.TokenProvider
{
    public class TokenProviderOptions
    {
		/// <summary>
		/// 发布人
		/// </summary>
		public string Issuer { get; set; }

		/// <summary>
		/// 订阅人
		/// </summary>
		public string Audience { get; set; }

		/// <summary>
		/// 过期时间(默认30分钟)
		/// </summary>
		public TimeSpan Expiration { get; set; } = TimeSpan.FromMinutes(30);

		/// <summary>
		/// 签名验证
		/// </summary>
		public SigningCredentials SigningCredentials { get; set; }
	}
}
