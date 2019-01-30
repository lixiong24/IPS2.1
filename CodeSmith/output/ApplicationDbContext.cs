using JX.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace JX.EF
{
	/// <summary>
	/// EF数据操作上下文。
	/// 使用方法：在展示层的Startup.cs文件的ConfigureServices方法中，添加services.AddDbContext《ApplicationDbContext》(options =>options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));
	/// </summary>
	public class ApplicationDbContext: DbContext
	{
		/// <summary>
		/// 构造器注入
		/// </summary>
		/// <param name="options"></param>
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		
		#region 数据库表对应属性
		/// <summary>
		/// Address表
		/// </summary>
		public virtual DbSet<Address> Address { get; set; }
		/// <summary>
		/// Admin表
		/// </summary>
		public virtual DbSet<Admin> Admin { get; set; }
		/// <summary>
		/// AdminRoles表
		/// </summary>
		public virtual DbSet<AdminRoles> AdminRoles { get; set; }
		/// <summary>
		/// Advertisement表
		/// </summary>
		public virtual DbSet<Advertisement> Advertisement { get; set; }
		/// <summary>
		/// AdvertisementZone表
		/// </summary>
		public virtual DbSet<AdvertisementZone> AdvertisementZone { get; set; }
		/// <summary>
		/// AdZone表
		/// </summary>
		public virtual DbSet<AdZone> AdZone { get; set; }
		/// <summary>
		/// Author表
		/// </summary>
		public virtual DbSet<Author> Author { get; set; }
		/// <summary>
		/// Bank表
		/// </summary>
		public virtual DbSet<Bank> Bank { get; set; }
		/// <summary>
		/// BankrollLog表
		/// </summary>
		public virtual DbSet<BankrollLog> BankrollLog { get; set; }
		/// <summary>
		/// Cards表
		/// </summary>
		public virtual DbSet<Cards> Cards { get; set; }
		/// <summary>
		/// Clerk表
		/// </summary>
		public virtual DbSet<Clerk> Clerk { get; set; }
		/// <summary>
		/// Client表
		/// </summary>
		public virtual DbSet<Client> Client { get; set; }
		/// <summary>
		/// ClientLog表
		/// </summary>
		public virtual DbSet<ClientLog> ClientLog { get; set; }
		/// <summary>
		/// CollectionExclosion表
		/// </summary>
		public virtual DbSet<CollectionExclosion> CollectionExclosion { get; set; }
		/// <summary>
		/// CollectionFieldRules表
		/// </summary>
		public virtual DbSet<CollectionFieldRules> CollectionFieldRules { get; set; }
		/// <summary>
		/// CollectionFilterRules表
		/// </summary>
		public virtual DbSet<CollectionFilterRules> CollectionFilterRules { get; set; }
		/// <summary>
		/// CollectionHistory表
		/// </summary>
		public virtual DbSet<CollectionHistory> CollectionHistory { get; set; }
		/// <summary>
		/// CollectionItem表
		/// </summary>
		public virtual DbSet<CollectionItem> CollectionItem { get; set; }
		/// <summary>
		/// CollectionListRules表
		/// </summary>
		public virtual DbSet<CollectionListRules> CollectionListRules { get; set; }
		/// <summary>
		/// CollectionPagingRules表
		/// </summary>
		public virtual DbSet<CollectionPagingRules> CollectionPagingRules { get; set; }
		/// <summary>
		/// Comment表
		/// </summary>
		public virtual DbSet<Comment> Comment { get; set; }
		/// <summary>
		/// CommentPK表
		/// </summary>
		public virtual DbSet<CommentPK> CommentPK { get; set; }
		/// <summary>
		/// CommonInfo表
		/// </summary>
		public virtual DbSet<CommonInfo> CommonInfo { get; set; }
		/// <summary>
		/// CommonProduct表
		/// </summary>
		public virtual DbSet<CommonProduct> CommonProduct { get; set; }
		/// <summary>
		/// Company表
		/// </summary>
		public virtual DbSet<Company> Company { get; set; }
		/// <summary>
		/// ComplainLog表
		/// </summary>
		public virtual DbSet<ComplainLog> ComplainLog { get; set; }
		/// <summary>
		/// Complaints表
		/// </summary>
		public virtual DbSet<Complaints> Complaints { get; set; }
		/// <summary>
		/// ComplaintsResults表
		/// </summary>
		public virtual DbSet<ComplaintsResults> ComplaintsResults { get; set; }
		/// <summary>
		/// ComplaintsType表
		/// </summary>
		public virtual DbSet<ComplaintsType> ComplaintsType { get; set; }
		/// <summary>
		/// Contacter表
		/// </summary>
		public virtual DbSet<Contacter> Contacter { get; set; }
		/// <summary>
		/// ContentCharge表
		/// </summary>
		public virtual DbSet<ContentCharge> ContentCharge { get; set; }
		/// <summary>
		/// ContentPermission表
		/// </summary>
		public virtual DbSet<ContentPermission> ContentPermission { get; set; }
		/// <summary>
		/// CorrelativeInfo表
		/// </summary>
		public virtual DbSet<CorrelativeInfo> CorrelativeInfo { get; set; }
		/// <summary>
		/// Coupon表
		/// </summary>
		public virtual DbSet<Coupon> Coupon { get; set; }
		/// <summary>
		/// CouponLog表
		/// </summary>
		public virtual DbSet<CouponLog> CouponLog { get; set; }
		/// <summary>
		/// Courier表
		/// </summary>
		public virtual DbSet<Courier> Courier { get; set; }
		/// <summary>
		/// CreditLinesLog表
		/// </summary>
		public virtual DbSet<CreditLinesLog> CreditLinesLog { get; set; }
		/// <summary>
		/// DeliverCharge表
		/// </summary>
		public virtual DbSet<DeliverCharge> DeliverCharge { get; set; }
		/// <summary>
		/// DeliverLog表
		/// </summary>
		public virtual DbSet<DeliverLog> DeliverLog { get; set; }
		/// <summary>
		/// DeliverType表
		/// </summary>
		public virtual DbSet<DeliverType> DeliverType { get; set; }
		/// <summary>
		/// Dictionary表
		/// </summary>
		public virtual DbSet<Dictionary> Dictionary { get; set; }
		/// <summary>
		/// DownloadErrorLog表
		/// </summary>
		public virtual DbSet<DownloadErrorLog> DownloadErrorLog { get; set; }
		/// <summary>
		/// DownServer表
		/// </summary>
		public virtual DbSet<DownServer> DownServer { get; set; }
		/// <summary>
		/// ExpLog表
		/// </summary>
		public virtual DbSet<ExpLog> ExpLog { get; set; }
		/// <summary>
		/// Favorite表
		/// </summary>
		public virtual DbSet<Favorite> Favorite { get; set; }
		/// <summary>
		/// FileRelationInfo表
		/// </summary>
		public virtual DbSet<FileRelationInfo> FileRelationInfo { get; set; }
		/// <summary>
		/// Files表
		/// </summary>
		public virtual DbSet<Files> Files { get; set; }
		/// <summary>
		/// FlowProcess表
		/// </summary>
		public virtual DbSet<FlowProcess> FlowProcess { get; set; }
		/// <summary>
		/// Friend表
		/// </summary>
		public virtual DbSet<Friend> Friend { get; set; }
		/// <summary>
		/// GroupFieldPermissions表
		/// </summary>
		public virtual DbSet<GroupFieldPermissions> GroupFieldPermissions { get; set; }
		/// <summary>
		/// GroupNodePermissions表
		/// </summary>
		public virtual DbSet<GroupNodePermissions> GroupNodePermissions { get; set; }
		/// <summary>
		/// GroupSpecialCategoryPermissions表
		/// </summary>
		public virtual DbSet<GroupSpecialCategoryPermissions> GroupSpecialCategoryPermissions { get; set; }
		/// <summary>
		/// GroupSpecialPermissions表
		/// </summary>
		public virtual DbSet<GroupSpecialPermissions> GroupSpecialPermissions { get; set; }
		/// <summary>
		/// HirePurchase表
		/// </summary>
		public virtual DbSet<HirePurchase> HirePurchase { get; set; }
		/// <summary>
		/// IncludeFile表
		/// </summary>
		public virtual DbSet<IncludeFile> IncludeFile { get; set; }
		/// <summary>
		/// InfoNextProcessRoles表
		/// </summary>
		public virtual DbSet<InfoNextProcessRoles> InfoNextProcessRoles { get; set; }
		/// <summary>
		/// IntegralProduct表
		/// </summary>
		public virtual DbSet<IntegralProduct> IntegralProduct { get; set; }
		/// <summary>
		/// IntegralProductType表
		/// </summary>
		public virtual DbSet<IntegralProductType> IntegralProductType { get; set; }
		/// <summary>
		/// InvoiceLog表
		/// </summary>
		public virtual DbSet<InvoiceLog> InvoiceLog { get; set; }
		/// <summary>
		/// KeywordRelation表
		/// </summary>
		public virtual DbSet<KeywordRelation> KeywordRelation { get; set; }
		/// <summary>
		/// Keywords表
		/// </summary>
		public virtual DbSet<Keywords> Keywords { get; set; }
		/// <summary>
		/// Log表
		/// </summary>
		public virtual DbSet<Log> Log { get; set; }
		/// <summary>
		/// MailItem表
		/// </summary>
		public virtual DbSet<MailItem> MailItem { get; set; }
		/// <summary>
		/// MailList表
		/// </summary>
		public virtual DbSet<MailList> MailList { get; set; }
		/// <summary>
		/// MentionLog表
		/// </summary>
		public virtual DbSet<MentionLog> MentionLog { get; set; }
		/// <summary>
		/// Merchant表
		/// </summary>
		public virtual DbSet<Merchant> Merchant { get; set; }
		/// <summary>
		/// Models表
		/// </summary>
		public virtual DbSet<Models> Models { get; set; }
		/// <summary>
		/// ModelTemplates表
		/// </summary>
		public virtual DbSet<ModelTemplates> ModelTemplates { get; set; }
		/// <summary>
		/// Nodes表
		/// </summary>
		public virtual DbSet<Nodes> Nodes { get; set; }
		/// <summary>
		/// NodesModelTemplate表
		/// </summary>
		public virtual DbSet<NodesModelTemplate> NodesModelTemplate { get; set; }
		/// <summary>
		/// NodesTemplate表
		/// </summary>
		public virtual DbSet<NodesTemplate> NodesTemplate { get; set; }
		/// <summary>
		/// OrderFeedback表
		/// </summary>
		public virtual DbSet<OrderFeedback> OrderFeedback { get; set; }
		/// <summary>
		/// OrderItem表
		/// </summary>
		public virtual DbSet<OrderItem> OrderItem { get; set; }
		/// <summary>
		/// OrderLog表
		/// </summary>
		public virtual DbSet<OrderLog> OrderLog { get; set; }
		/// <summary>
		/// Orders表
		/// </summary>
		public virtual DbSet<Orders> Orders { get; set; }
		/// <summary>
		/// Package表
		/// </summary>
		public virtual DbSet<Package> Package { get; set; }
		/// <summary>
		/// PaymentLog表
		/// </summary>
		public virtual DbSet<PaymentLog> PaymentLog { get; set; }
		/// <summary>
		/// PaymentType表
		/// </summary>
		public virtual DbSet<PaymentType> PaymentType { get; set; }
		/// <summary>
		/// PayPlatForm表
		/// </summary>
		public virtual DbSet<PayPlatForm> PayPlatForm { get; set; }
		/// <summary>
		/// PointLog表
		/// </summary>
		public virtual DbSet<PointLog> PointLog { get; set; }
		/// <summary>
		/// Present表
		/// </summary>
		public virtual DbSet<Present> Present { get; set; }
		/// <summary>
		/// PresentBuyLog表
		/// </summary>
		public virtual DbSet<PresentBuyLog> PresentBuyLog { get; set; }
		/// <summary>
		/// PresentProject表
		/// </summary>
		public virtual DbSet<PresentProject> PresentProject { get; set; }
		/// <summary>
		/// ProcessStatusCode表
		/// </summary>
		public virtual DbSet<ProcessStatusCode> ProcessStatusCode { get; set; }
		/// <summary>
		/// Producer表
		/// </summary>
		public virtual DbSet<Producer> Producer { get; set; }
		/// <summary>
		/// ProductData表
		/// </summary>
		public virtual DbSet<ProductData> ProductData { get; set; }
		/// <summary>
		/// ProductPrice表
		/// </summary>
		public virtual DbSet<ProductPrice> ProductPrice { get; set; }
		/// <summary>
		/// Region表
		/// </summary>
		public virtual DbSet<Region> Region { get; set; }
		/// <summary>
		/// Region_C表
		/// </summary>
		public virtual DbSet<Region_C> Region_C { get; set; }
		/// <summary>
		/// RemindItem表
		/// </summary>
		public virtual DbSet<RemindItem> RemindItem { get; set; }
		/// <summary>
		/// Repayment表
		/// </summary>
		public virtual DbSet<Repayment> Repayment { get; set; }
		/// <summary>
		/// RoleFieldPermissions表
		/// </summary>
		public virtual DbSet<RoleFieldPermissions> RoleFieldPermissions { get; set; }
		/// <summary>
		/// RoleNodePermissions表
		/// </summary>
		public virtual DbSet<RoleNodePermissions> RoleNodePermissions { get; set; }
		/// <summary>
		/// Roles表
		/// </summary>
		public virtual DbSet<Roles> Roles { get; set; }
		/// <summary>
		/// RoleSpecialPermissions表
		/// </summary>
		public virtual DbSet<RoleSpecialPermissions> RoleSpecialPermissions { get; set; }
		/// <summary>
		/// RolesPermissions表
		/// </summary>
		public virtual DbSet<RolesPermissions> RolesPermissions { get; set; }
		/// <summary>
		/// RolesProcess表
		/// </summary>
		public virtual DbSet<RolesProcess> RolesProcess { get; set; }
		/// <summary>
		/// ServiceLog表
		/// </summary>
		public virtual DbSet<ServiceLog> ServiceLog { get; set; }
		/// <summary>
		/// ShoppingCarts表
		/// </summary>
		public virtual DbSet<ShoppingCarts> ShoppingCarts { get; set; }
		/// <summary>
		/// SigninContent表
		/// </summary>
		public virtual DbSet<SigninContent> SigninContent { get; set; }
		/// <summary>
		/// SigninLog表
		/// </summary>
		public virtual DbSet<SigninLog> SigninLog { get; set; }
		/// <summary>
		/// SiteLink表
		/// </summary>
		public virtual DbSet<SiteLink> SiteLink { get; set; }
		/// <summary>
		/// SortingLog表
		/// </summary>
		public virtual DbSet<SortingLog> SortingLog { get; set; }
		/// <summary>
		/// Source表
		/// </summary>
		public virtual DbSet<Source> Source { get; set; }
		/// <summary>
		/// SpecialCategory表
		/// </summary>
		public virtual DbSet<SpecialCategory> SpecialCategory { get; set; }
		/// <summary>
		/// SpecialInfos表
		/// </summary>
		public virtual DbSet<SpecialInfos> SpecialInfos { get; set; }
		/// <summary>
		/// Specials表
		/// </summary>
		public virtual DbSet<Specials> Specials { get; set; }
		/// <summary>
		/// StatAddress表
		/// </summary>
		public virtual DbSet<StatAddress> StatAddress { get; set; }
		/// <summary>
		/// StatBrowser表
		/// </summary>
		public virtual DbSet<StatBrowser> StatBrowser { get; set; }
		/// <summary>
		/// StatColor表
		/// </summary>
		public virtual DbSet<StatColor> StatColor { get; set; }
		/// <summary>
		/// StatDay表
		/// </summary>
		public virtual DbSet<StatDay> StatDay { get; set; }
		/// <summary>
		/// StatInfoList表
		/// </summary>
		public virtual DbSet<StatInfoList> StatInfoList { get; set; }
		/// <summary>
		/// StatIp表
		/// </summary>
		public virtual DbSet<StatIp> StatIp { get; set; }
		/// <summary>
		/// StatIpInfo表
		/// </summary>
		public virtual DbSet<StatIpInfo> StatIpInfo { get; set; }
		/// <summary>
		/// StatKeyword表
		/// </summary>
		public virtual DbSet<StatKeyword> StatKeyword { get; set; }
		/// <summary>
		/// StatMonth表
		/// </summary>
		public virtual DbSet<StatMonth> StatMonth { get; set; }
		/// <summary>
		/// StatMozilla表
		/// </summary>
		public virtual DbSet<StatMozilla> StatMozilla { get; set; }
		/// <summary>
		/// StatOnline表
		/// </summary>
		public virtual DbSet<StatOnline> StatOnline { get; set; }
		/// <summary>
		/// StatRefer表
		/// </summary>
		public virtual DbSet<StatRefer> StatRefer { get; set; }
		/// <summary>
		/// StatScreen表
		/// </summary>
		public virtual DbSet<StatScreen> StatScreen { get; set; }
		/// <summary>
		/// StatSystem表
		/// </summary>
		public virtual DbSet<StatSystem> StatSystem { get; set; }
		/// <summary>
		/// StatTimezone表
		/// </summary>
		public virtual DbSet<StatTimezone> StatTimezone { get; set; }
		/// <summary>
		/// Status表
		/// </summary>
		public virtual DbSet<Status> Status { get; set; }
		/// <summary>
		/// StatVisit表
		/// </summary>
		public virtual DbSet<StatVisit> StatVisit { get; set; }
		/// <summary>
		/// StatVisitor表
		/// </summary>
		public virtual DbSet<StatVisitor> StatVisitor { get; set; }
		/// <summary>
		/// StatWeburl表
		/// </summary>
		public virtual DbSet<StatWeburl> StatWeburl { get; set; }
		/// <summary>
		/// StatWeek表
		/// </summary>
		public virtual DbSet<StatWeek> StatWeek { get; set; }
		/// <summary>
		/// StatYear表
		/// </summary>
		public virtual DbSet<StatYear> StatYear { get; set; }
		/// <summary>
		/// Stock表
		/// </summary>
		public virtual DbSet<Stock> Stock { get; set; }
		/// <summary>
		/// StockItem表
		/// </summary>
		public virtual DbSet<StockItem> StockItem { get; set; }
		/// <summary>
		/// StockOut表
		/// </summary>
		public virtual DbSet<StockOut> StockOut { get; set; }
		/// <summary>
		/// Store表
		/// </summary>
		public virtual DbSet<Store> Store { get; set; }
		/// <summary>
		/// SubscriptionItems表
		/// </summary>
		public virtual DbSet<SubscriptionItems> SubscriptionItems { get; set; }
		/// <summary>
		/// Survey表
		/// </summary>
		public virtual DbSet<Survey> Survey { get; set; }
		/// <summary>
		/// SurveyVote表
		/// </summary>
		public virtual DbSet<SurveyVote> SurveyVote { get; set; }
		/// <summary>
		/// Trademark表
		/// </summary>
		public virtual DbSet<Trademark> Trademark { get; set; }
		/// <summary>
		/// TransferLog表
		/// </summary>
		public virtual DbSet<TransferLog> TransferLog { get; set; }
		/// <summary>
		/// U_Advice表
		/// </summary>
		public virtual DbSet<U_Advice> U_Advice { get; set; }
		/// <summary>
		/// U_Answer表
		/// </summary>
		public virtual DbSet<U_Answer> U_Answer { get; set; }
		/// <summary>
		/// U_Article表
		/// </summary>
		public virtual DbSet<U_Article> U_Article { get; set; }
		/// <summary>
		/// U_Award表
		/// </summary>
		public virtual DbSet<U_Award> U_Award { get; set; }
		/// <summary>
		/// U_AwardLog表
		/// </summary>
		public virtual DbSet<U_AwardLog> U_AwardLog { get; set; }
		/// <summary>
		/// U_Buy表
		/// </summary>
		public virtual DbSet<U_Buy> U_Buy { get; set; }
		/// <summary>
		/// U_Buying表
		/// </summary>
		public virtual DbSet<U_Buying> U_Buying { get; set; }
		/// <summary>
		/// U_CompanyText表
		/// </summary>
		public virtual DbSet<U_CompanyText> U_CompanyText { get; set; }
		/// <summary>
		/// U_FriendSite表
		/// </summary>
		public virtual DbSet<U_FriendSite> U_FriendSite { get; set; }
		/// <summary>
		/// U_GuestBook表
		/// </summary>
		public virtual DbSet<U_GuestBook> U_GuestBook { get; set; }
		/// <summary>
		/// U_IntegralProduct表
		/// </summary>
		public virtual DbSet<U_IntegralProduct> U_IntegralProduct { get; set; }
		/// <summary>
		/// U_IntegralProductLog表
		/// </summary>
		public virtual DbSet<U_IntegralProductLog> U_IntegralProductLog { get; set; }
		/// <summary>
		/// U_Manufacture表
		/// </summary>
		public virtual DbSet<U_Manufacture> U_Manufacture { get; set; }
		/// <summary>
		/// U_OrderText表
		/// </summary>
		public virtual DbSet<U_OrderText> U_OrderText { get; set; }
		/// <summary>
		/// U_Product表
		/// </summary>
		public virtual DbSet<U_Product> U_Product { get; set; }
		/// <summary>
		/// U_Provide表
		/// </summary>
		public virtual DbSet<U_Provide> U_Provide { get; set; }
		/// <summary>
		/// U_Question表
		/// </summary>
		public virtual DbSet<U_Question> U_Question { get; set; }
		/// <summary>
		/// U_UserText表
		/// </summary>
		public virtual DbSet<U_UserText> U_UserText { get; set; }
		/// <summary>
		/// UserGroups表
		/// </summary>
		public virtual DbSet<UserGroups> UserGroups { get; set; }
		/// <summary>
		/// UserMessage表
		/// </summary>
		public virtual DbSet<UserMessage> UserMessage { get; set; }
		/// <summary>
		/// Users表
		/// </summary>
		public virtual DbSet<Users> Users { get; set; }
		/// <summary>
		/// ValidLog表
		/// </summary>
		public virtual DbSet<ValidLog> ValidLog { get; set; }
		/// <summary>
		/// Vote表
		/// </summary>
		public virtual DbSet<Vote> Vote { get; set; }
		/// <summary>
		/// WordReplaceItem表
		/// </summary>
		public virtual DbSet<WordReplaceItem> WordReplaceItem { get; set; }
		/// <summary>
		/// Work表
		/// </summary>
		public virtual DbSet<Work> Work { get; set; }
		/// <summary>
		/// WorkCategory表
		/// </summary>
		public virtual DbSet<WorkCategory> WorkCategory { get; set; }
		/// <summary>
		/// WorkCategorySetting表
		/// </summary>
		public virtual DbSet<WorkCategorySetting> WorkCategorySetting { get; set; }
		/// <summary>
		/// WorkFlows表
		/// </summary>
		public virtual DbSet<WorkFlows> WorkFlows { get; set; }
		/// <summary>
		/// WorkNextProcessRoles表
		/// </summary>
		public virtual DbSet<WorkNextProcessRoles> WorkNextProcessRoles { get; set; }
		#endregion
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="modelBuilder"></param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region 数据库表属性设置
			modelBuilder.Entity<Address>(entity =>
			{
				entity.HasKey(e => new { e.AddressID });
			});
			modelBuilder.Entity<Admin>(entity =>
			{
				entity.HasKey(e => new { e.AdminID });
			});
			modelBuilder.Entity<AdminRoles>(entity =>
			{
				entity.HasKey(e => new { e.AdminID, e.RoleID });
			});
			modelBuilder.Entity<Advertisement>(entity =>
			{
				entity.HasKey(e => new { e.ADID });
			});
			modelBuilder.Entity<AdvertisementZone>(entity =>
			{
				entity.HasKey(e => new { e.ZoneID, e.ADID });
			});
			modelBuilder.Entity<AdZone>(entity =>
			{
				entity.HasKey(e => new { e.ZoneID });
			});
			modelBuilder.Entity<Author>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Bank>(entity =>
			{
				entity.HasKey(e => new { e.BankID });
			});
			modelBuilder.Entity<BankrollLog>(entity =>
			{
				entity.HasKey(e => new { e.ItemID });
			});
			modelBuilder.Entity<Cards>(entity =>
			{
				entity.HasKey(e => new { e.CardID });
			});
			modelBuilder.Entity<Clerk>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Client>(entity =>
			{
				entity.HasKey(e => new { e.ClientID });
			});
			modelBuilder.Entity<ClientLog>(entity =>
			{
				entity.HasKey(e => new { e.ClientLogID });
			});
			modelBuilder.Entity<CollectionExclosion>(entity =>
			{
				entity.HasKey(e => new { e.ExclosionID });
			});
			modelBuilder.Entity<CollectionFieldRules>(entity =>
			{
				entity.HasKey(e => new { e.FieldRuleID });
			});
			modelBuilder.Entity<CollectionFilterRules>(entity =>
			{
				entity.HasKey(e => new { e.FilterRuleID });
			});
			modelBuilder.Entity<CollectionHistory>(entity =>
			{
				entity.HasKey(e => new { e.HistoryID });
			});
			modelBuilder.Entity<CollectionItem>(entity =>
			{
				entity.HasKey(e => new { e.ItemID });
			});
			modelBuilder.Entity<CollectionListRules>(entity =>
			{
				entity.HasKey(e => new { e.ItemID });
			});
			modelBuilder.Entity<CollectionPagingRules>(entity =>
			{
				entity.HasKey(e => new { e.PagingRuleID });
			});
			modelBuilder.Entity<Comment>(entity =>
			{
				entity.HasKey(e => new { e.CommentID });
			});
			modelBuilder.Entity<CommentPK>(entity =>
			{
				entity.HasKey(e => new { e.PKID });
			});
			modelBuilder.Entity<CommonInfo>(entity =>
			{
				entity.HasKey(e => new { e.GeneralID });
			});
			modelBuilder.Entity<CommonProduct>(entity =>
			{
				entity.HasKey(e => new { e.ProductID });
			});
			modelBuilder.Entity<Company>(entity =>
			{
				entity.HasKey(e => new { e.CompanyID });
			});
			modelBuilder.Entity<ComplainLog>(entity =>
			{
				entity.HasKey(e => new { e.ItemID });
			});
			modelBuilder.Entity<Complaints>(entity =>
			{
				entity.HasKey(e => new { e.CID });
			});
			modelBuilder.Entity<ComplaintsResults>(entity =>
			{
				entity.HasKey(e => new { e.RID });
			});
			modelBuilder.Entity<ComplaintsType>(entity =>
			{
				entity.HasKey(e => new { e.CID });
			});
			modelBuilder.Entity<Contacter>(entity =>
			{
				entity.HasKey(e => new { e.ContacterID });
			});
			modelBuilder.Entity<ContentCharge>(entity =>
			{
				entity.HasKey(e => new { e.GeneralID });
			});
			modelBuilder.Entity<ContentPermission>(entity =>
			{
				entity.HasKey(e => new { e.GeneralID });
			});
			modelBuilder.Entity<CorrelativeInfo>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Coupon>(entity =>
			{
				entity.HasKey(e => new { e.CouponID });
			});
			modelBuilder.Entity<CouponLog>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Courier>(entity =>
			{
				entity.HasKey(e => new { e.CourierID });
			});
			modelBuilder.Entity<CreditLinesLog>(entity =>
			{
				entity.HasKey(e => new { e.LogID });
			});
			modelBuilder.Entity<DeliverCharge>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<DeliverLog>(entity =>
			{
				entity.HasKey(e => new { e.DeliverID });
			});
			modelBuilder.Entity<DeliverType>(entity =>
			{
				entity.HasKey(e => new { e.TypeID });
			});
			modelBuilder.Entity<Dictionary>(entity =>
			{
				entity.HasKey(e => new { e.FieldID });
			});
			modelBuilder.Entity<DownloadErrorLog>(entity =>
			{
				entity.HasKey(e => new { e.ErrorID });
			});
			modelBuilder.Entity<DownServer>(entity =>
			{
				entity.HasKey(e => new { e.ServerID });
			});
			modelBuilder.Entity<ExpLog>(entity =>
			{
				entity.HasKey(e => new { e.LogID });
			});
			modelBuilder.Entity<Favorite>(entity =>
			{
				entity.HasKey(e => new { e.FavoriteID });
			});
			modelBuilder.Entity<FileRelationInfo>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Files>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<FlowProcess>(entity =>
			{
				entity.HasKey(e => new { e.ProcessID });
			});
			modelBuilder.Entity<Friend>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<GroupFieldPermissions>(entity =>
			{
				entity.HasKey(e => new { e.GroupID, e.OperateCode, e.ModelID, e.FieldName, e.IdType });
			});
			modelBuilder.Entity<GroupNodePermissions>(entity =>
			{
				entity.HasKey(e => new { e.GroupID, e.OperateCode, e.NodeID, e.IdType });
			});
			modelBuilder.Entity<GroupSpecialCategoryPermissions>(entity =>
			{
				entity.HasKey(e => new { e.GroupID, e.OperateCode, e.SpecialCategoryID, e.IDType });
			});
			modelBuilder.Entity<GroupSpecialPermissions>(entity =>
			{
				entity.HasKey(e => new { e.GroupID, e.OperateCode, e.SpecialID, e.IDType });
			});
			modelBuilder.Entity<HirePurchase>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<IncludeFile>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<InfoNextProcessRoles>(entity =>
			{
				entity.HasKey(e => new { e.GeneralID, e.RoleID });
			});
			modelBuilder.Entity<IntegralProduct>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<IntegralProductType>(entity =>
			{
				entity.HasKey(e => new { e.TypeID });
			});
			modelBuilder.Entity<InvoiceLog>(entity =>
			{
				entity.HasKey(e => new { e.InvoiceID });
			});
			modelBuilder.Entity<KeywordRelation>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Keywords>(entity =>
			{
				entity.HasKey(e => new { e.KeywordID });
			});
			modelBuilder.Entity<Log>(entity =>
			{
				entity.HasKey(e => new { e.LogID });
			});
			modelBuilder.Entity<MailItem>(entity =>
			{
				entity.HasKey(e => new { e.MailListId, e.SubscriptionItemId });
			});
			modelBuilder.Entity<MailList>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<MentionLog>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Merchant>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Models>(entity =>
			{
				entity.HasKey(e => new { e.ModelID });
			});
			modelBuilder.Entity<ModelTemplates>(entity =>
			{
				entity.HasKey(e => new { e.TemplateID });
			});
			modelBuilder.Entity<Nodes>(entity =>
			{
				entity.HasKey(e => new { e.NodeID });
			});
			modelBuilder.Entity<NodesModelTemplate>(entity =>
			{
				entity.HasKey(e => new { e.NodeID, e.ModelID });
			});
			modelBuilder.Entity<NodesTemplate>(entity =>
			{
				entity.HasKey(e => new { e.NodeID, e.TemplateID });
			});
			modelBuilder.Entity<OrderFeedback>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<OrderItem>(entity =>
			{
				entity.HasKey(e => new { e.ItemID });
			});
			modelBuilder.Entity<OrderLog>(entity =>
			{
				entity.HasKey(e => new { e.OrderLogID });
			});
			modelBuilder.Entity<Orders>(entity =>
			{
				entity.HasKey(e => new { e.OrderID });
			});
			modelBuilder.Entity<Package>(entity =>
			{
				entity.HasKey(e => new { e.PackageID });
			});
			modelBuilder.Entity<PaymentLog>(entity =>
			{
				entity.HasKey(e => new { e.PaymentLogID });
			});
			modelBuilder.Entity<PaymentType>(entity =>
			{
				entity.HasKey(e => new { e.TypeID });
			});
			modelBuilder.Entity<PayPlatForm>(entity =>
			{
				entity.HasKey(e => new { e.PayPlatformID });
			});
			modelBuilder.Entity<PointLog>(entity =>
			{
				entity.HasKey(e => new { e.LogID });
			});
			modelBuilder.Entity<Present>(entity =>
			{
				entity.HasKey(e => new { e.PresentID });
			});
			modelBuilder.Entity<PresentBuyLog>(entity =>
			{
				entity.HasKey(e => new { e.LogID });
			});
			modelBuilder.Entity<PresentProject>(entity =>
			{
				entity.HasKey(e => new { e.ProjectID });
			});
			modelBuilder.Entity<ProcessStatusCode>(entity =>
			{
				entity.HasKey(e => new { e.FlowID, e.ProcessID, e.StatusCode });
			});
			modelBuilder.Entity<Producer>(entity =>
			{
				entity.HasKey(e => new { e.ProducerID });
			});
			modelBuilder.Entity<ProductData>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<ProductPrice>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Region>(entity =>
			{
				entity.HasKey(e => new { e.RegionID });
			});
			modelBuilder.Entity<Region_C>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<RemindItem>(entity =>
			{
				entity.HasKey(e => new { e.RemindID });
			});
			modelBuilder.Entity<Repayment>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<RoleFieldPermissions>(entity =>
			{
				entity.HasKey(e => new { e.RoleID, e.ModelID, e.FieldName, e.OperateCode });
			});
			modelBuilder.Entity<RoleNodePermissions>(entity =>
			{
				entity.HasKey(e => new { e.RoleID, e.NodeID, e.OperateCode });
			});
			modelBuilder.Entity<Roles>(entity =>
			{
				entity.HasKey(e => new { e.RoleID });
			});
			modelBuilder.Entity<RoleSpecialPermissions>(entity =>
			{
				entity.HasKey(e => new { e.RoleID, e.SpecialID, e.OperateCode });
			});
			modelBuilder.Entity<RolesPermissions>(entity =>
			{
				entity.HasKey(e => new { e.RoleID, e.OperateCode });
			});
			modelBuilder.Entity<RolesProcess>(entity =>
			{
				entity.HasKey(e => new { e.FlowID, e.ProcessID, e.RoleID });
			});
			modelBuilder.Entity<ServiceLog>(entity =>
			{
				entity.HasKey(e => new { e.ItemID });
			});
			modelBuilder.Entity<ShoppingCarts>(entity =>
			{
				entity.HasKey(e => new { e.CartItemID });
			});
			modelBuilder.Entity<SigninContent>(entity =>
			{
				entity.HasKey(e => new { e.GeneralID });
			});
			modelBuilder.Entity<SigninLog>(entity =>
			{
				entity.HasKey(e => new { e.GeneralID, e.UserName });
			});
			modelBuilder.Entity<SiteLink>(entity =>
			{
				entity.HasKey(e => new { e.InsideLinkID });
			});
			modelBuilder.Entity<SortingLog>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Source>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<SpecialCategory>(entity =>
			{
				entity.HasKey(e => new { e.SpecialCategoryID });
			});
			modelBuilder.Entity<SpecialInfos>(entity =>
			{
				entity.HasKey(e => new { e.SpecialInfoID, e.SpecialID, e.GeneralID });
			});
			modelBuilder.Entity<Specials>(entity =>
			{
				entity.HasKey(e => new { e.SpecialID });
			});
			modelBuilder.Entity<StatAddress>(entity =>
			{
				entity.HasKey(e => new { e.TAddress });
			});
			modelBuilder.Entity<StatBrowser>(entity =>
			{
				entity.HasKey(e => new { e.TBrowser });
			});
			modelBuilder.Entity<StatColor>(entity =>
			{
				entity.HasKey(e => new { e.TColor });
			});
			modelBuilder.Entity<StatDay>(entity =>
			{
				entity.HasKey(e => new { e.TDay });
			});
			modelBuilder.Entity<StatInfoList>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<StatIp>(entity =>
			{
				entity.HasKey(e => new { e.TIp });
			});
			modelBuilder.Entity<StatIpInfo>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<StatKeyword>(entity =>
			{
				entity.HasKey(e => new { e.TKeyword });
			});
			modelBuilder.Entity<StatMonth>(entity =>
			{
				entity.HasKey(e => new { e.TMonth });
			});
			modelBuilder.Entity<StatMozilla>(entity =>
			{
				entity.HasKey(e => new { e.TMozilla });
			});
			modelBuilder.Entity<StatOnline>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<StatRefer>(entity =>
			{
				entity.HasKey(e => new { e.TRefer });
			});
			modelBuilder.Entity<StatScreen>(entity =>
			{
				entity.HasKey(e => new { e.TScreen });
			});
			modelBuilder.Entity<StatSystem>(entity =>
			{
				entity.HasKey(e => new { e.TSystem });
			});
			modelBuilder.Entity<StatTimezone>(entity =>
			{
				entity.HasKey(e => new { e.TTimezone });
			});
			modelBuilder.Entity<Status>(entity =>
			{
				entity.HasKey(e => new { e.StatusID });
			});
			modelBuilder.Entity<StatVisit>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<StatVisitor>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<StatWeburl>(entity =>
			{
				entity.HasKey(e => new { e.TWeburl });
			});
			modelBuilder.Entity<StatWeek>(entity =>
			{
				entity.HasKey(e => new { e.TWeek });
			});
			modelBuilder.Entity<StatYear>(entity =>
			{
				entity.HasKey(e => new { e.TYear });
			});
			modelBuilder.Entity<Stock>(entity =>
			{
				entity.HasKey(e => new { e.StockID });
			});
			modelBuilder.Entity<StockItem>(entity =>
			{
				entity.HasKey(e => new { e.ItemID });
			});
			modelBuilder.Entity<StockOut>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Store>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<SubscriptionItems>(entity =>
			{
				entity.HasKey(e => new { e.Id });
			});
			modelBuilder.Entity<Survey>(entity =>
			{
				entity.HasKey(e => new { e.SurveyID });
			});
			modelBuilder.Entity<SurveyVote>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<Trademark>(entity =>
			{
				entity.HasKey(e => new { e.TrademarkID });
			});
			modelBuilder.Entity<TransferLog>(entity =>
			{
				entity.HasKey(e => new { e.TransferLogID });
			});
			modelBuilder.Entity<U_Advice>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Answer>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Article>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Award>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_AwardLog>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Buy>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Buying>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_CompanyText>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_FriendSite>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_GuestBook>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_IntegralProduct>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_IntegralProductLog>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Manufacture>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_OrderText>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Product>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Provide>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_Question>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<U_UserText>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<UserGroups>(entity =>
			{
				entity.HasKey(e => new { e.GroupID });
			});
			modelBuilder.Entity<UserMessage>(entity =>
			{
				entity.HasKey(e => new { e.MessageID });
			});
			modelBuilder.Entity<Users>(entity =>
			{
				entity.HasKey(e => new { e.UserID });
			});
			modelBuilder.Entity<ValidLog>(entity =>
			{
				entity.HasKey(e => new { e.LogID });
			});
			modelBuilder.Entity<Vote>(entity =>
			{
				entity.HasKey(e => new { e.GeneralId });
			});
			modelBuilder.Entity<WordReplaceItem>(entity =>
			{
				entity.HasKey(e => new { e.ItemID });
			});
			modelBuilder.Entity<Work>(entity =>
			{
				entity.HasKey(e => new { e.WorkID });
			});
			modelBuilder.Entity<WorkCategory>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<WorkCategorySetting>(entity =>
			{
				entity.HasKey(e => new { e.ID });
			});
			modelBuilder.Entity<WorkFlows>(entity =>
			{
				entity.HasKey(e => new { e.FlowID });
			});
			modelBuilder.Entity<WorkNextProcessRoles>(entity =>
			{
				entity.HasKey(e => new { e.WorkID, e.RoleID });
			});
			#endregion
			base.OnModelCreating(modelBuilder);
		}
	}
}