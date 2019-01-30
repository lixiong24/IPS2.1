namespace JX.Core
{
	/// <summary>
	/// 会员权限检查定义接口。
	/// 1、计费方式（只判断金币、只判断有效期、同时判断金币和有效期）。
	/// 2、发表评论的权限。
	/// 3、上传权限。
	/// 4、购物权限（折扣率、透支的最大额度）。
	/// 5、扣金币方式。
	/// 6、发表信息的权限。
	/// 7、收藏信息数量。
	/// 8、发送站内信数量。
	/// 9、能够访问的会员中心页面的权限码。
	/// </summary>
	public interface IUserPurviewInfo
	{
		#region 权限码
		/// <summary>
		/// 会员组或会员能够访问的，会员中心页面的权限码，以“,”分割。
		/// </summary>
		string AllCheckCode { get; set; }
		/// <summary>
		/// 会员组或会员对数据有操作权限的数据权限码，以“,”分割。
		/// </summary>
		string AllDataCheckCode { get; set; }
		/// <summary>
		/// 会员组或会员对数据有操作权限的数据权限码，以“,”分割。
		/// </summary>
		string AllDataCheckCode1 { get; set; }
		/// <summary>
		/// 会员组或会员对数据有操作权限的数据权限码，以“,”分割。
		/// </summary>
		string AllDataCheckCode2 { get; set; }
		#endregion

		#region 计费方式
		/// <summary>
		/// 计费方式：只判断金币：有金币时，即使有效期已经到期，仍可以查看收费内容；金币用完后，即使有效期没有到期，也不能查看收费内容。
		/// </summary>
		bool ChargeByPoint { get; set; }
		/// <summary>
		/// 计费方式：同时判断金币和有效期：金币用完并且有效期到期后，才不能查看收费内容。
		/// </summary>
		bool ChargeByPointAndValidDate { get; set; }
		/// <summary>
		/// 计费方式：同时判断金币和有效期：金币用完或有效期到期后，就不可查看收费内容。
		/// </summary>
		bool ChargeByPointOrValidDate { get; set; }
		/// <summary>
		/// 计费方式：只判断有效期：只要在有效期内，金币用完后仍可以查看收费内容；过期后，即使会员有金币也不能查看收费内容。
		/// </summary>
		bool ChargeByValidDate { get; set; }
		#endregion

		#region 评论权限
		/// <summary>
		/// 在评论需要审核的栏目里发表评论不需要审核
		/// </summary>
		bool CommentNeedCheck { get; set; }
		/// <summary>
		/// 在禁止发表评论的栏目里仍然可发表评论
		/// </summary>
		bool EnableComment { get; set; }
		#endregion

		#region 上传权限
		/// <summary>
		/// 允许在开放上传的模型中上传文件
		/// </summary>
		bool EnableUpload { get; set; }
		/// <summary>
		/// 允许上传文件的最大KB数
		/// </summary>
		int UploadSize { get; set; }
		/// <summary>
		/// 允许上传用户头像
		/// </summary>
		bool EnableUploadUserPic { get; set; }
		/// <summary>
		/// 上传用户头像需要花费的金币数（此数量为消费金币加剩余金币的总和）
		/// </summary>
		int UploadCondition { get; set; }
		#endregion

		#region 商店权限
		/// <summary>
		/// 购物时可以享受的折扣率
		/// </summary>
		double Discount { get; set; }
		/// <summary>
		/// 购物时允许透支的最大额度
		/// </summary>
		double Overdraft { get; set; }
		/// <summary>
		/// 会员中心添加商品时候，是否指定为立即销售
		/// </summary>
		bool SetEnableSale { get; set; }
		#endregion

		#region 扣金币方式
		/// <summary>
		/// 扣金币方式：有效期内，每天可以查看收费信息的最大数（如果为0，则不限制） 
		/// </summary>
		int ViewInfoNumberOneDay { get; set; }
		/// <summary>
		/// 扣金币方式：有效期内，查看收费内容不扣金币，但做记录。
		/// </summary>
		bool WriteToLog { get; set; }
		/// <summary>
		/// 扣金币方式：有效期内，查看收费内容是否扣金币。
		/// </summary>
		bool MinusPoint { get; set; }
		/// <summary>
		/// 扣金币方式：有效期内，查看收费内容不扣金币，也不做记录。
		/// </summary>
		bool NotMinusPointNotWriteToLog { get; set; }
		/// <summary>
		/// 扣金币方式：有效期内，总共可以查看的收费信息最大数量（如果为0，则不限制）
		/// </summary>
		int TotalViewInfoNumber { get; set; }
		#endregion

		#region 发布权限
		/// <summary>
		/// 发表信息时HTML编辑器是否为高级模式（默认为简洁模式）
		/// </summary>
		bool SetEditor { get; set; }
		/// <summary>
		/// 发布信息时获取积分为栏目设置的多少倍
		/// </summary>
		int GetExp { get; set; }
		/// <summary>
		/// 发布信息时获取点券为栏目设置的多少倍
		/// </summary>
		int GetPoint { get; set; }
		/// <summary>
		/// 会员发表信息时是否启用防止XSS（跨站攻击）
		/// </summary>
		bool IsXssFilter { get; set; }
		/// <summary>
		/// 每天发布信息最大数（不想限制请设置为0）
		/// </summary>
		int MaxPublicInfoOneDay { get; set; }
		/// <summary>
		/// 总共发布信息最大数（不想限制请设置为0）
		/// </summary>
		int MaxPublicInfo { get; set; }
		#endregion

		/// <summary>
		/// 会员收藏夹内可收录信息的最大数（如果为0，则没有收藏权限）
		/// </summary>
		int MaxSaveInfos { get; set; }
		/// <summary>
		/// 每次发送站内信可同时发送的最大人数（如果为0，则不允许发送短消息）
		/// </summary>
		int MaxSendToUsers { get; set; }
	}
}
