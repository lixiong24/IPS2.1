using Microsoft.AspNetCore.DataProtection.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace JX.Infrastructure.Common
{
	/// <summary>
	/// 用于多个应用程序之间共享Cookie
	/// </summary>
	public class XmlRepository : IXmlRepository
	{
		private readonly string _KeyContentPath = "";
		/// <summary>
		/// 初始化KEY文件的路径。应用程序根目录/Config/ShareKeys.xml
		/// </summary>
		public XmlRepository()
		{
			_KeyContentPath = Path.Combine(Directory.GetCurrentDirectory(), "Config", "ShareKeys.xml");
		}

		/// <summary>
		/// 读取用于Cookie加解密的所有KEY
		/// </summary>
		/// <returns></returns>
		public IReadOnlyCollection<XElement> GetAllElements()
		{
			var elements = new List<XElement>() { XElement.Load(_KeyContentPath) };
			return elements;
		}
		/// <summary>
		/// 保存用于Cookie加解密的KEY(未实现)
		/// </summary>
		/// <param name="element"></param>
		/// <param name="friendlyName"></param>
		public void StoreElement(XElement element, string friendlyName)
		{

		}
	}
}
