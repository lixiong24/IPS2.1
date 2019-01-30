using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace JX.Core
{
	/// <summary>
	/// 节点类型
	/// </summary>
	[Flags]
	public enum NodeType
	{
		/// <summary>
		/// 所有
		/// </summary>
		[Description("所有")]
		None,
		/// <summary>
		/// 容器
		/// </summary>
		[Description("容器")]
		Container,
		/// <summary>
		/// 专题
		/// </summary>
		[Description("专题")]
		Special,
		/// <summary>
		/// 单页节点
		/// </summary>
		[Description("单页节点")]
		Single,
		/// <summary>
		/// 链接节点
		/// </summary>
		[Description("链接节点")]
		Link
	}
}
