using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using JX.Application;
using JX.EF;
using Microsoft.EntityFrameworkCore;
using MyADO;
using JX.Core;
using JX.EF.Repository;
using JX.ADO;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using JX.Infrastructure.Common;
using Microsoft.AspNetCore.Http;
using JwtIssuer.TokenProvider;
using Microsoft.AspNetCore.Authorization;

namespace JwtAudience
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
			JXMapper.Initialize();
		}

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddMyHttpContextAccessor();
			//添加GZIP压缩服务
			services.AddResponseCompression();

			//添加EF，保证上下文线程唯一
			services.AddDbContext<ApplicationDbContext>(options =>
			{
				options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

			}, ServiceLifetime.Scoped);

			//添加ADO，保证上下文线程唯一
			services.AddScoped<IDBOperator>(
				(ISP) => new SqlDBOperator(Configuration.GetConnectionString("DefaultConnection"))
			);

			#region 依赖注入
			services.AddScoped<IAddressRepository, AddressRepository>();

			services.AddScoped<IAddressRepositoryADO, AddressRepositoryADO>();

			services.AddScoped<IAddressServiceApp, AddressServiceApp>();

			services.AddScoped<IAddressServiceAppADO, AddressServiceAppADO>();

			services.AddScoped<IAdminRepository, AdminRepository>();

			services.AddScoped<IAdminRepositoryADO, AdminRepositoryADO>();

			services.AddScoped<IAdminServiceApp, AdminServiceApp>();

			services.AddScoped<IAdminServiceAppADO, AdminServiceAppADO>();

			services.AddScoped<IAdminRolesRepository, AdminRolesRepository>();

			services.AddScoped<IAdminRolesRepositoryADO, AdminRolesRepositoryADO>();

			services.AddScoped<IAdminRolesServiceApp, AdminRolesServiceApp>();

			services.AddScoped<IAdminRolesServiceAppADO, AdminRolesServiceAppADO>();

			services.AddScoped<IAdvertisementRepository, AdvertisementRepository>();

			services.AddScoped<IAdvertisementRepositoryADO, AdvertisementRepositoryADO>();

			services.AddScoped<IAdvertisementServiceApp, AdvertisementServiceApp>();

			services.AddScoped<IAdvertisementServiceAppADO, AdvertisementServiceAppADO>();

			services.AddScoped<IAdvertisementZoneRepository, AdvertisementZoneRepository>();

			services.AddScoped<IAdvertisementZoneRepositoryADO, AdvertisementZoneRepositoryADO>();

			services.AddScoped<IAdvertisementZoneServiceApp, AdvertisementZoneServiceApp>();

			services.AddScoped<IAdvertisementZoneServiceAppADO, AdvertisementZoneServiceAppADO>();

			services.AddScoped<IAdZoneRepository, AdZoneRepository>();

			services.AddScoped<IAdZoneRepositoryADO, AdZoneRepositoryADO>();

			services.AddScoped<IAdZoneServiceApp, AdZoneServiceApp>();

			services.AddScoped<IAdZoneServiceAppADO, AdZoneServiceAppADO>();

			services.AddScoped<IAuthorRepository, AuthorRepository>();

			services.AddScoped<IAuthorRepositoryADO, AuthorRepositoryADO>();

			services.AddScoped<IAuthorServiceApp, AuthorServiceApp>();

			services.AddScoped<IAuthorServiceAppADO, AuthorServiceAppADO>();

			services.AddScoped<IBankRepository, BankRepository>();

			services.AddScoped<IBankRepositoryADO, BankRepositoryADO>();

			services.AddScoped<IBankServiceApp, BankServiceApp>();

			services.AddScoped<IBankServiceAppADO, BankServiceAppADO>();

			services.AddScoped<IBankrollLogRepository, BankrollLogRepository>();

			services.AddScoped<IBankrollLogRepositoryADO, BankrollLogRepositoryADO>();

			services.AddScoped<IBankrollLogServiceApp, BankrollLogServiceApp>();

			services.AddScoped<IBankrollLogServiceAppADO, BankrollLogServiceAppADO>();

			services.AddScoped<ICardsRepository, CardsRepository>();

			services.AddScoped<ICardsRepositoryADO, CardsRepositoryADO>();

			services.AddScoped<ICardsServiceApp, CardsServiceApp>();

			services.AddScoped<ICardsServiceAppADO, CardsServiceAppADO>();

			services.AddScoped<IClerkRepository, ClerkRepository>();

			services.AddScoped<IClerkRepositoryADO, ClerkRepositoryADO>();

			services.AddScoped<IClerkServiceApp, ClerkServiceApp>();

			services.AddScoped<IClerkServiceAppADO, ClerkServiceAppADO>();

			services.AddScoped<IClientRepository, ClientRepository>();

			services.AddScoped<IClientRepositoryADO, ClientRepositoryADO>();

			services.AddScoped<IClientServiceApp, ClientServiceApp>();

			services.AddScoped<IClientServiceAppADO, ClientServiceAppADO>();

			services.AddScoped<IClientLogRepository, ClientLogRepository>();

			services.AddScoped<IClientLogRepositoryADO, ClientLogRepositoryADO>();

			services.AddScoped<IClientLogServiceApp, ClientLogServiceApp>();

			services.AddScoped<IClientLogServiceAppADO, ClientLogServiceAppADO>();

			services.AddScoped<ICollectionExclosionRepository, CollectionExclosionRepository>();

			services.AddScoped<ICollectionExclosionRepositoryADO, CollectionExclosionRepositoryADO>();

			services.AddScoped<ICollectionExclosionServiceApp, CollectionExclosionServiceApp>();

			services.AddScoped<ICollectionExclosionServiceAppADO, CollectionExclosionServiceAppADO>();

			services.AddScoped<ICollectionFieldRulesRepository, CollectionFieldRulesRepository>();

			services.AddScoped<ICollectionFieldRulesRepositoryADO, CollectionFieldRulesRepositoryADO>();

			services.AddScoped<ICollectionFieldRulesServiceApp, CollectionFieldRulesServiceApp>();

			services.AddScoped<ICollectionFieldRulesServiceAppADO, CollectionFieldRulesServiceAppADO>();

			services.AddScoped<ICollectionFilterRulesRepository, CollectionFilterRulesRepository>();

			services.AddScoped<ICollectionFilterRulesRepositoryADO, CollectionFilterRulesRepositoryADO>();

			services.AddScoped<ICollectionFilterRulesServiceApp, CollectionFilterRulesServiceApp>();

			services.AddScoped<ICollectionFilterRulesServiceAppADO, CollectionFilterRulesServiceAppADO>();

			services.AddScoped<ICollectionHistoryRepository, CollectionHistoryRepository>();

			services.AddScoped<ICollectionHistoryRepositoryADO, CollectionHistoryRepositoryADO>();

			services.AddScoped<ICollectionHistoryServiceApp, CollectionHistoryServiceApp>();

			services.AddScoped<ICollectionHistoryServiceAppADO, CollectionHistoryServiceAppADO>();

			services.AddScoped<ICollectionItemRepository, CollectionItemRepository>();

			services.AddScoped<ICollectionItemRepositoryADO, CollectionItemRepositoryADO>();

			services.AddScoped<ICollectionItemServiceApp, CollectionItemServiceApp>();

			services.AddScoped<ICollectionItemServiceAppADO, CollectionItemServiceAppADO>();

			services.AddScoped<ICollectionListRulesRepository, CollectionListRulesRepository>();

			services.AddScoped<ICollectionListRulesRepositoryADO, CollectionListRulesRepositoryADO>();

			services.AddScoped<ICollectionListRulesServiceApp, CollectionListRulesServiceApp>();

			services.AddScoped<ICollectionListRulesServiceAppADO, CollectionListRulesServiceAppADO>();

			services.AddScoped<ICollectionPagingRulesRepository, CollectionPagingRulesRepository>();

			services.AddScoped<ICollectionPagingRulesRepositoryADO, CollectionPagingRulesRepositoryADO>();

			services.AddScoped<ICollectionPagingRulesServiceApp, CollectionPagingRulesServiceApp>();

			services.AddScoped<ICollectionPagingRulesServiceAppADO, CollectionPagingRulesServiceAppADO>();

			services.AddScoped<ICommentRepository, CommentRepository>();

			services.AddScoped<ICommentRepositoryADO, CommentRepositoryADO>();

			services.AddScoped<ICommentServiceApp, CommentServiceApp>();

			services.AddScoped<ICommentServiceAppADO, CommentServiceAppADO>();

			services.AddScoped<ICommentPKRepository, CommentPKRepository>();

			services.AddScoped<ICommentPKRepositoryADO, CommentPKRepositoryADO>();

			services.AddScoped<ICommentPKServiceApp, CommentPKServiceApp>();

			services.AddScoped<ICommentPKServiceAppADO, CommentPKServiceAppADO>();

			services.AddScoped<ICommonInfoRepository, CommonInfoRepository>();

			services.AddScoped<ICommonInfoRepositoryADO, CommonInfoRepositoryADO>();

			services.AddScoped<ICommonInfoServiceApp, CommonInfoServiceApp>();

			services.AddScoped<ICommonInfoServiceAppADO, CommonInfoServiceAppADO>();

			services.AddScoped<ICommonProductRepository, CommonProductRepository>();

			services.AddScoped<ICommonProductRepositoryADO, CommonProductRepositoryADO>();

			services.AddScoped<ICommonProductServiceApp, CommonProductServiceApp>();

			services.AddScoped<ICommonProductServiceAppADO, CommonProductServiceAppADO>();

			services.AddScoped<ICompanyRepository, CompanyRepository>();

			services.AddScoped<ICompanyRepositoryADO, CompanyRepositoryADO>();

			services.AddScoped<ICompanyServiceApp, CompanyServiceApp>();

			services.AddScoped<ICompanyServiceAppADO, CompanyServiceAppADO>();

			services.AddScoped<IComplainLogRepository, ComplainLogRepository>();

			services.AddScoped<IComplainLogRepositoryADO, ComplainLogRepositoryADO>();

			services.AddScoped<IComplainLogServiceApp, ComplainLogServiceApp>();

			services.AddScoped<IComplainLogServiceAppADO, ComplainLogServiceAppADO>();

			services.AddScoped<IComplaintsRepository, ComplaintsRepository>();

			services.AddScoped<IComplaintsRepositoryADO, ComplaintsRepositoryADO>();

			services.AddScoped<IComplaintsServiceApp, ComplaintsServiceApp>();

			services.AddScoped<IComplaintsServiceAppADO, ComplaintsServiceAppADO>();

			services.AddScoped<IComplaintsResultsRepository, ComplaintsResultsRepository>();

			services.AddScoped<IComplaintsResultsRepositoryADO, ComplaintsResultsRepositoryADO>();

			services.AddScoped<IComplaintsResultsServiceApp, ComplaintsResultsServiceApp>();

			services.AddScoped<IComplaintsResultsServiceAppADO, ComplaintsResultsServiceAppADO>();

			services.AddScoped<IComplaintsTypeRepository, ComplaintsTypeRepository>();

			services.AddScoped<IComplaintsTypeRepositoryADO, ComplaintsTypeRepositoryADO>();

			services.AddScoped<IComplaintsTypeServiceApp, ComplaintsTypeServiceApp>();

			services.AddScoped<IComplaintsTypeServiceAppADO, ComplaintsTypeServiceAppADO>();

			services.AddScoped<IContacterRepository, ContacterRepository>();

			services.AddScoped<IContacterRepositoryADO, ContacterRepositoryADO>();

			services.AddScoped<IContacterServiceApp, ContacterServiceApp>();

			services.AddScoped<IContacterServiceAppADO, ContacterServiceAppADO>();

			services.AddScoped<IContentChargeRepository, ContentChargeRepository>();

			services.AddScoped<IContentChargeRepositoryADO, ContentChargeRepositoryADO>();

			services.AddScoped<IContentChargeServiceApp, ContentChargeServiceApp>();

			services.AddScoped<IContentChargeServiceAppADO, ContentChargeServiceAppADO>();

			services.AddScoped<IContentPermissionRepository, ContentPermissionRepository>();

			services.AddScoped<IContentPermissionRepositoryADO, ContentPermissionRepositoryADO>();

			services.AddScoped<IContentPermissionServiceApp, ContentPermissionServiceApp>();

			services.AddScoped<IContentPermissionServiceAppADO, ContentPermissionServiceAppADO>();

			services.AddScoped<ICorrelativeInfoRepository, CorrelativeInfoRepository>();

			services.AddScoped<ICorrelativeInfoRepositoryADO, CorrelativeInfoRepositoryADO>();

			services.AddScoped<ICorrelativeInfoServiceApp, CorrelativeInfoServiceApp>();

			services.AddScoped<ICorrelativeInfoServiceAppADO, CorrelativeInfoServiceAppADO>();

			services.AddScoped<ICouponRepository, CouponRepository>();

			services.AddScoped<ICouponRepositoryADO, CouponRepositoryADO>();

			services.AddScoped<ICouponServiceApp, CouponServiceApp>();

			services.AddScoped<ICouponServiceAppADO, CouponServiceAppADO>();

			services.AddScoped<ICouponLogRepository, CouponLogRepository>();

			services.AddScoped<ICouponLogRepositoryADO, CouponLogRepositoryADO>();

			services.AddScoped<ICouponLogServiceApp, CouponLogServiceApp>();

			services.AddScoped<ICouponLogServiceAppADO, CouponLogServiceAppADO>();

			services.AddScoped<ICourierRepository, CourierRepository>();

			services.AddScoped<ICourierRepositoryADO, CourierRepositoryADO>();

			services.AddScoped<ICourierServiceApp, CourierServiceApp>();

			services.AddScoped<ICourierServiceAppADO, CourierServiceAppADO>();

			services.AddScoped<ICreditLinesLogRepository, CreditLinesLogRepository>();

			services.AddScoped<ICreditLinesLogRepositoryADO, CreditLinesLogRepositoryADO>();

			services.AddScoped<ICreditLinesLogServiceApp, CreditLinesLogServiceApp>();

			services.AddScoped<ICreditLinesLogServiceAppADO, CreditLinesLogServiceAppADO>();

			services.AddScoped<IDeliverChargeRepository, DeliverChargeRepository>();

			services.AddScoped<IDeliverChargeRepositoryADO, DeliverChargeRepositoryADO>();

			services.AddScoped<IDeliverChargeServiceApp, DeliverChargeServiceApp>();

			services.AddScoped<IDeliverChargeServiceAppADO, DeliverChargeServiceAppADO>();

			services.AddScoped<IDeliverLogRepository, DeliverLogRepository>();

			services.AddScoped<IDeliverLogRepositoryADO, DeliverLogRepositoryADO>();

			services.AddScoped<IDeliverLogServiceApp, DeliverLogServiceApp>();

			services.AddScoped<IDeliverLogServiceAppADO, DeliverLogServiceAppADO>();

			services.AddScoped<IDeliverTypeRepository, DeliverTypeRepository>();

			services.AddScoped<IDeliverTypeRepositoryADO, DeliverTypeRepositoryADO>();

			services.AddScoped<IDeliverTypeServiceApp, DeliverTypeServiceApp>();

			services.AddScoped<IDeliverTypeServiceAppADO, DeliverTypeServiceAppADO>();

			services.AddScoped<IDictionaryRepository, DictionaryRepository>();

			services.AddScoped<IDictionaryRepositoryADO, DictionaryRepositoryADO>();

			services.AddScoped<IDictionaryServiceApp, DictionaryServiceApp>();

			services.AddScoped<IDictionaryServiceAppADO, DictionaryServiceAppADO>();

			services.AddScoped<IDownloadErrorLogRepository, DownloadErrorLogRepository>();

			services.AddScoped<IDownloadErrorLogRepositoryADO, DownloadErrorLogRepositoryADO>();

			services.AddScoped<IDownloadErrorLogServiceApp, DownloadErrorLogServiceApp>();

			services.AddScoped<IDownloadErrorLogServiceAppADO, DownloadErrorLogServiceAppADO>();

			services.AddScoped<IDownServerRepository, DownServerRepository>();

			services.AddScoped<IDownServerRepositoryADO, DownServerRepositoryADO>();

			services.AddScoped<IDownServerServiceApp, DownServerServiceApp>();

			services.AddScoped<IDownServerServiceAppADO, DownServerServiceAppADO>();

			services.AddScoped<IExpLogRepository, ExpLogRepository>();

			services.AddScoped<IExpLogRepositoryADO, ExpLogRepositoryADO>();

			services.AddScoped<IExpLogServiceApp, ExpLogServiceApp>();

			services.AddScoped<IExpLogServiceAppADO, ExpLogServiceAppADO>();

			services.AddScoped<IFavoriteRepository, FavoriteRepository>();

			services.AddScoped<IFavoriteRepositoryADO, FavoriteRepositoryADO>();

			services.AddScoped<IFavoriteServiceApp, FavoriteServiceApp>();

			services.AddScoped<IFavoriteServiceAppADO, FavoriteServiceAppADO>();

			services.AddScoped<IFileRelationInfoRepository, FileRelationInfoRepository>();

			services.AddScoped<IFileRelationInfoRepositoryADO, FileRelationInfoRepositoryADO>();

			services.AddScoped<IFileRelationInfoServiceApp, FileRelationInfoServiceApp>();

			services.AddScoped<IFileRelationInfoServiceAppADO, FileRelationInfoServiceAppADO>();

			services.AddScoped<IFilesRepository, FilesRepository>();

			services.AddScoped<IFilesRepositoryADO, FilesRepositoryADO>();

			services.AddScoped<IFilesServiceApp, FilesServiceApp>();

			services.AddScoped<IFilesServiceAppADO, FilesServiceAppADO>();

			services.AddScoped<IFlowProcessRepository, FlowProcessRepository>();

			services.AddScoped<IFlowProcessRepositoryADO, FlowProcessRepositoryADO>();

			services.AddScoped<IFlowProcessServiceApp, FlowProcessServiceApp>();

			services.AddScoped<IFlowProcessServiceAppADO, FlowProcessServiceAppADO>();

			services.AddScoped<IFriendRepository, FriendRepository>();

			services.AddScoped<IFriendRepositoryADO, FriendRepositoryADO>();

			services.AddScoped<IFriendServiceApp, FriendServiceApp>();

			services.AddScoped<IFriendServiceAppADO, FriendServiceAppADO>();

			services.AddScoped<IGroupFieldPermissionsRepository, GroupFieldPermissionsRepository>();

			services.AddScoped<IGroupFieldPermissionsRepositoryADO, GroupFieldPermissionsRepositoryADO>();

			services.AddScoped<IGroupFieldPermissionsServiceApp, GroupFieldPermissionsServiceApp>();

			services.AddScoped<IGroupFieldPermissionsServiceAppADO, GroupFieldPermissionsServiceAppADO>();

			services.AddScoped<IGroupNodePermissionsRepository, GroupNodePermissionsRepository>();

			services.AddScoped<IGroupNodePermissionsRepositoryADO, GroupNodePermissionsRepositoryADO>();

			services.AddScoped<IGroupNodePermissionsServiceApp, GroupNodePermissionsServiceApp>();

			services.AddScoped<IGroupNodePermissionsServiceAppADO, GroupNodePermissionsServiceAppADO>();

			services.AddScoped<IGroupSpecialCategoryPermissionsRepository, GroupSpecialCategoryPermissionsRepository>();

			services.AddScoped<IGroupSpecialCategoryPermissionsRepositoryADO, GroupSpecialCategoryPermissionsRepositoryADO>();

			services.AddScoped<IGroupSpecialCategoryPermissionsServiceApp, GroupSpecialCategoryPermissionsServiceApp>();

			services.AddScoped<IGroupSpecialCategoryPermissionsServiceAppADO, GroupSpecialCategoryPermissionsServiceAppADO>();

			services.AddScoped<IGroupSpecialPermissionsRepository, GroupSpecialPermissionsRepository>();

			services.AddScoped<IGroupSpecialPermissionsRepositoryADO, GroupSpecialPermissionsRepositoryADO>();

			services.AddScoped<IGroupSpecialPermissionsServiceApp, GroupSpecialPermissionsServiceApp>();

			services.AddScoped<IGroupSpecialPermissionsServiceAppADO, GroupSpecialPermissionsServiceAppADO>();

			services.AddScoped<IHirePurchaseRepository, HirePurchaseRepository>();

			services.AddScoped<IHirePurchaseRepositoryADO, HirePurchaseRepositoryADO>();

			services.AddScoped<IHirePurchaseServiceApp, HirePurchaseServiceApp>();

			services.AddScoped<IHirePurchaseServiceAppADO, HirePurchaseServiceAppADO>();

			services.AddScoped<IIncludeFileRepository, IncludeFileRepository>();

			services.AddScoped<IIncludeFileRepositoryADO, IncludeFileRepositoryADO>();

			services.AddScoped<IIncludeFileServiceApp, IncludeFileServiceApp>();

			services.AddScoped<IIncludeFileServiceAppADO, IncludeFileServiceAppADO>();

			services.AddScoped<IInfoNextProcessRolesRepository, InfoNextProcessRolesRepository>();

			services.AddScoped<IInfoNextProcessRolesRepositoryADO, InfoNextProcessRolesRepositoryADO>();

			services.AddScoped<IInfoNextProcessRolesServiceApp, InfoNextProcessRolesServiceApp>();

			services.AddScoped<IInfoNextProcessRolesServiceAppADO, InfoNextProcessRolesServiceAppADO>();

			services.AddScoped<IIntegralProductRepository, IntegralProductRepository>();

			services.AddScoped<IIntegralProductRepositoryADO, IntegralProductRepositoryADO>();

			services.AddScoped<IIntegralProductServiceApp, IntegralProductServiceApp>();

			services.AddScoped<IIntegralProductServiceAppADO, IntegralProductServiceAppADO>();

			services.AddScoped<IIntegralProductTypeRepository, IntegralProductTypeRepository>();

			services.AddScoped<IIntegralProductTypeRepositoryADO, IntegralProductTypeRepositoryADO>();

			services.AddScoped<IIntegralProductTypeServiceApp, IntegralProductTypeServiceApp>();

			services.AddScoped<IIntegralProductTypeServiceAppADO, IntegralProductTypeServiceAppADO>();

			services.AddScoped<IInvoiceLogRepository, InvoiceLogRepository>();

			services.AddScoped<IInvoiceLogRepositoryADO, InvoiceLogRepositoryADO>();

			services.AddScoped<IInvoiceLogServiceApp, InvoiceLogServiceApp>();

			services.AddScoped<IInvoiceLogServiceAppADO, InvoiceLogServiceAppADO>();

			services.AddScoped<IKeywordRelationRepository, KeywordRelationRepository>();

			services.AddScoped<IKeywordRelationRepositoryADO, KeywordRelationRepositoryADO>();

			services.AddScoped<IKeywordRelationServiceApp, KeywordRelationServiceApp>();

			services.AddScoped<IKeywordRelationServiceAppADO, KeywordRelationServiceAppADO>();

			services.AddScoped<IKeywordsRepository, KeywordsRepository>();

			services.AddScoped<IKeywordsRepositoryADO, KeywordsRepositoryADO>();

			services.AddScoped<IKeywordsServiceApp, KeywordsServiceApp>();

			services.AddScoped<IKeywordsServiceAppADO, KeywordsServiceAppADO>();

			services.AddScoped<ILogRepository, LogRepository>();

			services.AddScoped<ILogRepositoryADO, LogRepositoryADO>();

			services.AddScoped<ILogServiceApp, LogServiceApp>();

			services.AddScoped<ILogServiceAppADO, LogServiceAppADO>();

			services.AddScoped<IMailItemRepository, MailItemRepository>();

			services.AddScoped<IMailItemRepositoryADO, MailItemRepositoryADO>();

			services.AddScoped<IMailItemServiceApp, MailItemServiceApp>();

			services.AddScoped<IMailItemServiceAppADO, MailItemServiceAppADO>();

			services.AddScoped<IMailListRepository, MailListRepository>();

			services.AddScoped<IMailListRepositoryADO, MailListRepositoryADO>();

			services.AddScoped<IMailListServiceApp, MailListServiceApp>();

			services.AddScoped<IMailListServiceAppADO, MailListServiceAppADO>();

			services.AddScoped<IMentionLogRepository, MentionLogRepository>();

			services.AddScoped<IMentionLogRepositoryADO, MentionLogRepositoryADO>();

			services.AddScoped<IMentionLogServiceApp, MentionLogServiceApp>();

			services.AddScoped<IMentionLogServiceAppADO, MentionLogServiceAppADO>();

			services.AddScoped<IMerchantRepository, MerchantRepository>();

			services.AddScoped<IMerchantRepositoryADO, MerchantRepositoryADO>();

			services.AddScoped<IMerchantServiceApp, MerchantServiceApp>();

			services.AddScoped<IMerchantServiceAppADO, MerchantServiceAppADO>();

			services.AddScoped<IModelsRepository, ModelsRepository>();

			services.AddScoped<IModelsRepositoryADO, ModelsRepositoryADO>();

			services.AddScoped<IModelsServiceApp, ModelsServiceApp>();

			services.AddScoped<IModelsServiceAppADO, ModelsServiceAppADO>();

			services.AddScoped<IModelTemplatesRepository, ModelTemplatesRepository>();

			services.AddScoped<IModelTemplatesRepositoryADO, ModelTemplatesRepositoryADO>();

			services.AddScoped<IModelTemplatesServiceApp, ModelTemplatesServiceApp>();

			services.AddScoped<IModelTemplatesServiceAppADO, ModelTemplatesServiceAppADO>();

			services.AddScoped<INodesRepository, NodesRepository>();

			services.AddScoped<INodesRepositoryADO, NodesRepositoryADO>();

			services.AddScoped<INodesServiceApp, NodesServiceApp>();

			services.AddScoped<INodesServiceAppADO, NodesServiceAppADO>();

			services.AddScoped<INodesModelTemplateRepository, NodesModelTemplateRepository>();

			services.AddScoped<INodesModelTemplateRepositoryADO, NodesModelTemplateRepositoryADO>();

			services.AddScoped<INodesModelTemplateServiceApp, NodesModelTemplateServiceApp>();

			services.AddScoped<INodesModelTemplateServiceAppADO, NodesModelTemplateServiceAppADO>();

			services.AddScoped<INodesTemplateRepository, NodesTemplateRepository>();

			services.AddScoped<INodesTemplateRepositoryADO, NodesTemplateRepositoryADO>();

			services.AddScoped<INodesTemplateServiceApp, NodesTemplateServiceApp>();

			services.AddScoped<INodesTemplateServiceAppADO, NodesTemplateServiceAppADO>();

			services.AddScoped<IOrderFeedbackRepository, OrderFeedbackRepository>();

			services.AddScoped<IOrderFeedbackRepositoryADO, OrderFeedbackRepositoryADO>();

			services.AddScoped<IOrderFeedbackServiceApp, OrderFeedbackServiceApp>();

			services.AddScoped<IOrderFeedbackServiceAppADO, OrderFeedbackServiceAppADO>();

			services.AddScoped<IOrderItemRepository, OrderItemRepository>();

			services.AddScoped<IOrderItemRepositoryADO, OrderItemRepositoryADO>();

			services.AddScoped<IOrderItemServiceApp, OrderItemServiceApp>();

			services.AddScoped<IOrderItemServiceAppADO, OrderItemServiceAppADO>();

			services.AddScoped<IOrderLogRepository, OrderLogRepository>();

			services.AddScoped<IOrderLogRepositoryADO, OrderLogRepositoryADO>();

			services.AddScoped<IOrderLogServiceApp, OrderLogServiceApp>();

			services.AddScoped<IOrderLogServiceAppADO, OrderLogServiceAppADO>();

			services.AddScoped<IOrdersRepository, OrdersRepository>();

			services.AddScoped<IOrdersRepositoryADO, OrdersRepositoryADO>();

			services.AddScoped<IOrdersServiceApp, OrdersServiceApp>();

			services.AddScoped<IOrdersServiceAppADO, OrdersServiceAppADO>();

			services.AddScoped<IPackageRepository, PackageRepository>();

			services.AddScoped<IPackageRepositoryADO, PackageRepositoryADO>();

			services.AddScoped<IPackageServiceApp, PackageServiceApp>();

			services.AddScoped<IPackageServiceAppADO, PackageServiceAppADO>();

			services.AddScoped<IPaymentLogRepository, PaymentLogRepository>();

			services.AddScoped<IPaymentLogRepositoryADO, PaymentLogRepositoryADO>();

			services.AddScoped<IPaymentLogServiceApp, PaymentLogServiceApp>();

			services.AddScoped<IPaymentLogServiceAppADO, PaymentLogServiceAppADO>();

			services.AddScoped<IPaymentTypeRepository, PaymentTypeRepository>();

			services.AddScoped<IPaymentTypeRepositoryADO, PaymentTypeRepositoryADO>();

			services.AddScoped<IPaymentTypeServiceApp, PaymentTypeServiceApp>();

			services.AddScoped<IPaymentTypeServiceAppADO, PaymentTypeServiceAppADO>();

			services.AddScoped<IPayPlatFormRepository, PayPlatFormRepository>();

			services.AddScoped<IPayPlatFormRepositoryADO, PayPlatFormRepositoryADO>();

			services.AddScoped<IPayPlatFormServiceApp, PayPlatFormServiceApp>();

			services.AddScoped<IPayPlatFormServiceAppADO, PayPlatFormServiceAppADO>();

			services.AddScoped<IPointLogRepository, PointLogRepository>();

			services.AddScoped<IPointLogRepositoryADO, PointLogRepositoryADO>();

			services.AddScoped<IPointLogServiceApp, PointLogServiceApp>();

			services.AddScoped<IPointLogServiceAppADO, PointLogServiceAppADO>();

			services.AddScoped<IPresentRepository, PresentRepository>();

			services.AddScoped<IPresentRepositoryADO, PresentRepositoryADO>();

			services.AddScoped<IPresentServiceApp, PresentServiceApp>();

			services.AddScoped<IPresentServiceAppADO, PresentServiceAppADO>();

			services.AddScoped<IPresentBuyLogRepository, PresentBuyLogRepository>();

			services.AddScoped<IPresentBuyLogRepositoryADO, PresentBuyLogRepositoryADO>();

			services.AddScoped<IPresentBuyLogServiceApp, PresentBuyLogServiceApp>();

			services.AddScoped<IPresentBuyLogServiceAppADO, PresentBuyLogServiceAppADO>();

			services.AddScoped<IPresentProjectRepository, PresentProjectRepository>();

			services.AddScoped<IPresentProjectRepositoryADO, PresentProjectRepositoryADO>();

			services.AddScoped<IPresentProjectServiceApp, PresentProjectServiceApp>();

			services.AddScoped<IPresentProjectServiceAppADO, PresentProjectServiceAppADO>();

			services.AddScoped<IProcessStatusCodeRepository, ProcessStatusCodeRepository>();

			services.AddScoped<IProcessStatusCodeRepositoryADO, ProcessStatusCodeRepositoryADO>();

			services.AddScoped<IProcessStatusCodeServiceApp, ProcessStatusCodeServiceApp>();

			services.AddScoped<IProcessStatusCodeServiceAppADO, ProcessStatusCodeServiceAppADO>();

			services.AddScoped<IProducerRepository, ProducerRepository>();

			services.AddScoped<IProducerRepositoryADO, ProducerRepositoryADO>();

			services.AddScoped<IProducerServiceApp, ProducerServiceApp>();

			services.AddScoped<IProducerServiceAppADO, ProducerServiceAppADO>();

			services.AddScoped<IProductDataRepository, ProductDataRepository>();

			services.AddScoped<IProductDataRepositoryADO, ProductDataRepositoryADO>();

			services.AddScoped<IProductDataServiceApp, ProductDataServiceApp>();

			services.AddScoped<IProductDataServiceAppADO, ProductDataServiceAppADO>();

			services.AddScoped<IProductPriceRepository, ProductPriceRepository>();

			services.AddScoped<IProductPriceRepositoryADO, ProductPriceRepositoryADO>();

			services.AddScoped<IProductPriceServiceApp, ProductPriceServiceApp>();

			services.AddScoped<IProductPriceServiceAppADO, ProductPriceServiceAppADO>();

			services.AddScoped<IRegionRepository, RegionRepository>();

			services.AddScoped<IRegionRepositoryADO, RegionRepositoryADO>();

			services.AddScoped<IRegionServiceApp, RegionServiceApp>();

			services.AddScoped<IRegionServiceAppADO, RegionServiceAppADO>();

			services.AddScoped<IRegion_CRepository, Region_CRepository>();

			services.AddScoped<IRegion_CRepositoryADO, Region_CRepositoryADO>();

			services.AddScoped<IRegion_CServiceApp, Region_CServiceApp>();

			services.AddScoped<IRegion_CServiceAppADO, Region_CServiceAppADO>();

			services.AddScoped<IRemindItemRepository, RemindItemRepository>();

			services.AddScoped<IRemindItemRepositoryADO, RemindItemRepositoryADO>();

			services.AddScoped<IRemindItemServiceApp, RemindItemServiceApp>();

			services.AddScoped<IRemindItemServiceAppADO, RemindItemServiceAppADO>();

			services.AddScoped<IRepaymentRepository, RepaymentRepository>();

			services.AddScoped<IRepaymentRepositoryADO, RepaymentRepositoryADO>();

			services.AddScoped<IRepaymentServiceApp, RepaymentServiceApp>();

			services.AddScoped<IRepaymentServiceAppADO, RepaymentServiceAppADO>();

			services.AddScoped<IRoleFieldPermissionsRepository, RoleFieldPermissionsRepository>();

			services.AddScoped<IRoleFieldPermissionsRepositoryADO, RoleFieldPermissionsRepositoryADO>();

			services.AddScoped<IRoleFieldPermissionsServiceApp, RoleFieldPermissionsServiceApp>();

			services.AddScoped<IRoleFieldPermissionsServiceAppADO, RoleFieldPermissionsServiceAppADO>();

			services.AddScoped<IRoleNodePermissionsRepository, RoleNodePermissionsRepository>();

			services.AddScoped<IRoleNodePermissionsRepositoryADO, RoleNodePermissionsRepositoryADO>();

			services.AddScoped<IRoleNodePermissionsServiceApp, RoleNodePermissionsServiceApp>();

			services.AddScoped<IRoleNodePermissionsServiceAppADO, RoleNodePermissionsServiceAppADO>();

			services.AddScoped<IRolesRepository, RolesRepository>();

			services.AddScoped<IRolesRepositoryADO, RolesRepositoryADO>();

			services.AddScoped<IRolesServiceApp, RolesServiceApp>();

			services.AddScoped<IRolesServiceAppADO, RolesServiceAppADO>();

			services.AddScoped<IRoleSpecialPermissionsRepository, RoleSpecialPermissionsRepository>();

			services.AddScoped<IRoleSpecialPermissionsRepositoryADO, RoleSpecialPermissionsRepositoryADO>();

			services.AddScoped<IRoleSpecialPermissionsServiceApp, RoleSpecialPermissionsServiceApp>();

			services.AddScoped<IRoleSpecialPermissionsServiceAppADO, RoleSpecialPermissionsServiceAppADO>();

			services.AddScoped<IRolesPermissionsRepository, RolesPermissionsRepository>();

			services.AddScoped<IRolesPermissionsRepositoryADO, RolesPermissionsRepositoryADO>();

			services.AddScoped<IRolesPermissionsServiceApp, RolesPermissionsServiceApp>();

			services.AddScoped<IRolesPermissionsServiceAppADO, RolesPermissionsServiceAppADO>();

			services.AddScoped<IRolesProcessRepository, RolesProcessRepository>();

			services.AddScoped<IRolesProcessRepositoryADO, RolesProcessRepositoryADO>();

			services.AddScoped<IRolesProcessServiceApp, RolesProcessServiceApp>();

			services.AddScoped<IRolesProcessServiceAppADO, RolesProcessServiceAppADO>();

			services.AddScoped<IServiceLogRepository, ServiceLogRepository>();

			services.AddScoped<IServiceLogRepositoryADO, ServiceLogRepositoryADO>();

			services.AddScoped<IServiceLogServiceApp, ServiceLogServiceApp>();

			services.AddScoped<IServiceLogServiceAppADO, ServiceLogServiceAppADO>();

			services.AddScoped<IShoppingCartsRepository, ShoppingCartsRepository>();

			services.AddScoped<IShoppingCartsRepositoryADO, ShoppingCartsRepositoryADO>();

			services.AddScoped<IShoppingCartsServiceApp, ShoppingCartsServiceApp>();

			services.AddScoped<IShoppingCartsServiceAppADO, ShoppingCartsServiceAppADO>();

			services.AddScoped<ISigninContentRepository, SigninContentRepository>();

			services.AddScoped<ISigninContentRepositoryADO, SigninContentRepositoryADO>();

			services.AddScoped<ISigninContentServiceApp, SigninContentServiceApp>();

			services.AddScoped<ISigninContentServiceAppADO, SigninContentServiceAppADO>();

			services.AddScoped<ISigninLogRepository, SigninLogRepository>();

			services.AddScoped<ISigninLogRepositoryADO, SigninLogRepositoryADO>();

			services.AddScoped<ISigninLogServiceApp, SigninLogServiceApp>();

			services.AddScoped<ISigninLogServiceAppADO, SigninLogServiceAppADO>();

			services.AddScoped<ISiteLinkRepository, SiteLinkRepository>();

			services.AddScoped<ISiteLinkRepositoryADO, SiteLinkRepositoryADO>();

			services.AddScoped<ISiteLinkServiceApp, SiteLinkServiceApp>();

			services.AddScoped<ISiteLinkServiceAppADO, SiteLinkServiceAppADO>();

			services.AddScoped<ISortingLogRepository, SortingLogRepository>();

			services.AddScoped<ISortingLogRepositoryADO, SortingLogRepositoryADO>();

			services.AddScoped<ISortingLogServiceApp, SortingLogServiceApp>();

			services.AddScoped<ISortingLogServiceAppADO, SortingLogServiceAppADO>();

			services.AddScoped<ISourceRepository, SourceRepository>();

			services.AddScoped<ISourceRepositoryADO, SourceRepositoryADO>();

			services.AddScoped<ISourceServiceApp, SourceServiceApp>();

			services.AddScoped<ISourceServiceAppADO, SourceServiceAppADO>();

			services.AddScoped<ISpecialCategoryRepository, SpecialCategoryRepository>();

			services.AddScoped<ISpecialCategoryRepositoryADO, SpecialCategoryRepositoryADO>();

			services.AddScoped<ISpecialCategoryServiceApp, SpecialCategoryServiceApp>();

			services.AddScoped<ISpecialCategoryServiceAppADO, SpecialCategoryServiceAppADO>();

			services.AddScoped<ISpecialInfosRepository, SpecialInfosRepository>();

			services.AddScoped<ISpecialInfosRepositoryADO, SpecialInfosRepositoryADO>();

			services.AddScoped<ISpecialInfosServiceApp, SpecialInfosServiceApp>();

			services.AddScoped<ISpecialInfosServiceAppADO, SpecialInfosServiceAppADO>();

			services.AddScoped<ISpecialsRepository, SpecialsRepository>();

			services.AddScoped<ISpecialsRepositoryADO, SpecialsRepositoryADO>();

			services.AddScoped<ISpecialsServiceApp, SpecialsServiceApp>();

			services.AddScoped<ISpecialsServiceAppADO, SpecialsServiceAppADO>();

			services.AddScoped<IStatAddressRepository, StatAddressRepository>();

			services.AddScoped<IStatAddressRepositoryADO, StatAddressRepositoryADO>();

			services.AddScoped<IStatAddressServiceApp, StatAddressServiceApp>();

			services.AddScoped<IStatAddressServiceAppADO, StatAddressServiceAppADO>();

			services.AddScoped<IStatBrowserRepository, StatBrowserRepository>();

			services.AddScoped<IStatBrowserRepositoryADO, StatBrowserRepositoryADO>();

			services.AddScoped<IStatBrowserServiceApp, StatBrowserServiceApp>();

			services.AddScoped<IStatBrowserServiceAppADO, StatBrowserServiceAppADO>();

			services.AddScoped<IStatColorRepository, StatColorRepository>();

			services.AddScoped<IStatColorRepositoryADO, StatColorRepositoryADO>();

			services.AddScoped<IStatColorServiceApp, StatColorServiceApp>();

			services.AddScoped<IStatColorServiceAppADO, StatColorServiceAppADO>();

			services.AddScoped<IStatDayRepository, StatDayRepository>();

			services.AddScoped<IStatDayRepositoryADO, StatDayRepositoryADO>();

			services.AddScoped<IStatDayServiceApp, StatDayServiceApp>();

			services.AddScoped<IStatDayServiceAppADO, StatDayServiceAppADO>();

			services.AddScoped<IStatInfoListRepository, StatInfoListRepository>();

			services.AddScoped<IStatInfoListRepositoryADO, StatInfoListRepositoryADO>();

			services.AddScoped<IStatInfoListServiceApp, StatInfoListServiceApp>();

			services.AddScoped<IStatInfoListServiceAppADO, StatInfoListServiceAppADO>();

			services.AddScoped<IStatIpRepository, StatIpRepository>();

			services.AddScoped<IStatIpRepositoryADO, StatIpRepositoryADO>();

			services.AddScoped<IStatIpServiceApp, StatIpServiceApp>();

			services.AddScoped<IStatIpServiceAppADO, StatIpServiceAppADO>();

			services.AddScoped<IStatIpInfoRepository, StatIpInfoRepository>();

			services.AddScoped<IStatIpInfoRepositoryADO, StatIpInfoRepositoryADO>();

			services.AddScoped<IStatIpInfoServiceApp, StatIpInfoServiceApp>();

			services.AddScoped<IStatIpInfoServiceAppADO, StatIpInfoServiceAppADO>();

			services.AddScoped<IStatKeywordRepository, StatKeywordRepository>();

			services.AddScoped<IStatKeywordRepositoryADO, StatKeywordRepositoryADO>();

			services.AddScoped<IStatKeywordServiceApp, StatKeywordServiceApp>();

			services.AddScoped<IStatKeywordServiceAppADO, StatKeywordServiceAppADO>();

			services.AddScoped<IStatMonthRepository, StatMonthRepository>();

			services.AddScoped<IStatMonthRepositoryADO, StatMonthRepositoryADO>();

			services.AddScoped<IStatMonthServiceApp, StatMonthServiceApp>();

			services.AddScoped<IStatMonthServiceAppADO, StatMonthServiceAppADO>();

			services.AddScoped<IStatMozillaRepository, StatMozillaRepository>();

			services.AddScoped<IStatMozillaRepositoryADO, StatMozillaRepositoryADO>();

			services.AddScoped<IStatMozillaServiceApp, StatMozillaServiceApp>();

			services.AddScoped<IStatMozillaServiceAppADO, StatMozillaServiceAppADO>();

			services.AddScoped<IStatOnlineRepository, StatOnlineRepository>();

			services.AddScoped<IStatOnlineRepositoryADO, StatOnlineRepositoryADO>();

			services.AddScoped<IStatOnlineServiceApp, StatOnlineServiceApp>();

			services.AddScoped<IStatOnlineServiceAppADO, StatOnlineServiceAppADO>();

			services.AddScoped<IStatReferRepository, StatReferRepository>();

			services.AddScoped<IStatReferRepositoryADO, StatReferRepositoryADO>();

			services.AddScoped<IStatReferServiceApp, StatReferServiceApp>();

			services.AddScoped<IStatReferServiceAppADO, StatReferServiceAppADO>();

			services.AddScoped<IStatScreenRepository, StatScreenRepository>();

			services.AddScoped<IStatScreenRepositoryADO, StatScreenRepositoryADO>();

			services.AddScoped<IStatScreenServiceApp, StatScreenServiceApp>();

			services.AddScoped<IStatScreenServiceAppADO, StatScreenServiceAppADO>();

			services.AddScoped<IStatSystemRepository, StatSystemRepository>();

			services.AddScoped<IStatSystemRepositoryADO, StatSystemRepositoryADO>();

			services.AddScoped<IStatSystemServiceApp, StatSystemServiceApp>();

			services.AddScoped<IStatSystemServiceAppADO, StatSystemServiceAppADO>();

			services.AddScoped<IStatTimezoneRepository, StatTimezoneRepository>();

			services.AddScoped<IStatTimezoneRepositoryADO, StatTimezoneRepositoryADO>();

			services.AddScoped<IStatTimezoneServiceApp, StatTimezoneServiceApp>();

			services.AddScoped<IStatTimezoneServiceAppADO, StatTimezoneServiceAppADO>();

			services.AddScoped<IStatusRepository, StatusRepository>();

			services.AddScoped<IStatusRepositoryADO, StatusRepositoryADO>();

			services.AddScoped<IStatusServiceApp, StatusServiceApp>();

			services.AddScoped<IStatusServiceAppADO, StatusServiceAppADO>();

			services.AddScoped<IStatVisitRepository, StatVisitRepository>();

			services.AddScoped<IStatVisitRepositoryADO, StatVisitRepositoryADO>();

			services.AddScoped<IStatVisitServiceApp, StatVisitServiceApp>();

			services.AddScoped<IStatVisitServiceAppADO, StatVisitServiceAppADO>();

			services.AddScoped<IStatVisitorRepository, StatVisitorRepository>();

			services.AddScoped<IStatVisitorRepositoryADO, StatVisitorRepositoryADO>();

			services.AddScoped<IStatVisitorServiceApp, StatVisitorServiceApp>();

			services.AddScoped<IStatVisitorServiceAppADO, StatVisitorServiceAppADO>();

			services.AddScoped<IStatWeburlRepository, StatWeburlRepository>();

			services.AddScoped<IStatWeburlRepositoryADO, StatWeburlRepositoryADO>();

			services.AddScoped<IStatWeburlServiceApp, StatWeburlServiceApp>();

			services.AddScoped<IStatWeburlServiceAppADO, StatWeburlServiceAppADO>();

			services.AddScoped<IStatWeekRepository, StatWeekRepository>();

			services.AddScoped<IStatWeekRepositoryADO, StatWeekRepositoryADO>();

			services.AddScoped<IStatWeekServiceApp, StatWeekServiceApp>();

			services.AddScoped<IStatWeekServiceAppADO, StatWeekServiceAppADO>();

			services.AddScoped<IStatYearRepository, StatYearRepository>();

			services.AddScoped<IStatYearRepositoryADO, StatYearRepositoryADO>();

			services.AddScoped<IStatYearServiceApp, StatYearServiceApp>();

			services.AddScoped<IStatYearServiceAppADO, StatYearServiceAppADO>();

			services.AddScoped<IStockRepository, StockRepository>();

			services.AddScoped<IStockRepositoryADO, StockRepositoryADO>();

			services.AddScoped<IStockServiceApp, StockServiceApp>();

			services.AddScoped<IStockServiceAppADO, StockServiceAppADO>();

			services.AddScoped<IStockItemRepository, StockItemRepository>();

			services.AddScoped<IStockItemRepositoryADO, StockItemRepositoryADO>();

			services.AddScoped<IStockItemServiceApp, StockItemServiceApp>();

			services.AddScoped<IStockItemServiceAppADO, StockItemServiceAppADO>();

			services.AddScoped<IStockOutRepository, StockOutRepository>();

			services.AddScoped<IStockOutRepositoryADO, StockOutRepositoryADO>();

			services.AddScoped<IStockOutServiceApp, StockOutServiceApp>();

			services.AddScoped<IStockOutServiceAppADO, StockOutServiceAppADO>();

			services.AddScoped<IStoreRepository, StoreRepository>();

			services.AddScoped<IStoreRepositoryADO, StoreRepositoryADO>();

			services.AddScoped<IStoreServiceApp, StoreServiceApp>();

			services.AddScoped<IStoreServiceAppADO, StoreServiceAppADO>();

			services.AddScoped<ISubscriptionItemsRepository, SubscriptionItemsRepository>();

			services.AddScoped<ISubscriptionItemsRepositoryADO, SubscriptionItemsRepositoryADO>();

			services.AddScoped<ISubscriptionItemsServiceApp, SubscriptionItemsServiceApp>();

			services.AddScoped<ISubscriptionItemsServiceAppADO, SubscriptionItemsServiceAppADO>();

			services.AddScoped<ISurveyRepository, SurveyRepository>();

			services.AddScoped<ISurveyRepositoryADO, SurveyRepositoryADO>();

			services.AddScoped<ISurveyServiceApp, SurveyServiceApp>();

			services.AddScoped<ISurveyServiceAppADO, SurveyServiceAppADO>();

			services.AddScoped<ISurveyVoteRepository, SurveyVoteRepository>();

			services.AddScoped<ISurveyVoteRepositoryADO, SurveyVoteRepositoryADO>();

			services.AddScoped<ISurveyVoteServiceApp, SurveyVoteServiceApp>();

			services.AddScoped<ISurveyVoteServiceAppADO, SurveyVoteServiceAppADO>();

			services.AddScoped<ITrademarkRepository, TrademarkRepository>();

			services.AddScoped<ITrademarkRepositoryADO, TrademarkRepositoryADO>();

			services.AddScoped<ITrademarkServiceApp, TrademarkServiceApp>();

			services.AddScoped<ITrademarkServiceAppADO, TrademarkServiceAppADO>();

			services.AddScoped<ITransferLogRepository, TransferLogRepository>();

			services.AddScoped<ITransferLogRepositoryADO, TransferLogRepositoryADO>();

			services.AddScoped<ITransferLogServiceApp, TransferLogServiceApp>();

			services.AddScoped<ITransferLogServiceAppADO, TransferLogServiceAppADO>();

			services.AddScoped<IU_AdviceRepository, U_AdviceRepository>();

			services.AddScoped<IU_AdviceRepositoryADO, U_AdviceRepositoryADO>();

			services.AddScoped<IU_AdviceServiceApp, U_AdviceServiceApp>();

			services.AddScoped<IU_AdviceServiceAppADO, U_AdviceServiceAppADO>();

			services.AddScoped<IU_AnswerRepository, U_AnswerRepository>();

			services.AddScoped<IU_AnswerRepositoryADO, U_AnswerRepositoryADO>();

			services.AddScoped<IU_AnswerServiceApp, U_AnswerServiceApp>();

			services.AddScoped<IU_AnswerServiceAppADO, U_AnswerServiceAppADO>();

			services.AddScoped<IU_ArticleRepository, U_ArticleRepository>();

			services.AddScoped<IU_ArticleRepositoryADO, U_ArticleRepositoryADO>();

			services.AddScoped<IU_ArticleServiceApp, U_ArticleServiceApp>();

			services.AddScoped<IU_ArticleServiceAppADO, U_ArticleServiceAppADO>();

			services.AddScoped<IU_AwardRepository, U_AwardRepository>();

			services.AddScoped<IU_AwardRepositoryADO, U_AwardRepositoryADO>();

			services.AddScoped<IU_AwardServiceApp, U_AwardServiceApp>();

			services.AddScoped<IU_AwardServiceAppADO, U_AwardServiceAppADO>();

			services.AddScoped<IU_AwardLogRepository, U_AwardLogRepository>();

			services.AddScoped<IU_AwardLogRepositoryADO, U_AwardLogRepositoryADO>();

			services.AddScoped<IU_AwardLogServiceApp, U_AwardLogServiceApp>();

			services.AddScoped<IU_AwardLogServiceAppADO, U_AwardLogServiceAppADO>();

			services.AddScoped<IU_BuyRepository, U_BuyRepository>();

			services.AddScoped<IU_BuyRepositoryADO, U_BuyRepositoryADO>();

			services.AddScoped<IU_BuyServiceApp, U_BuyServiceApp>();

			services.AddScoped<IU_BuyServiceAppADO, U_BuyServiceAppADO>();

			services.AddScoped<IU_BuyingRepository, U_BuyingRepository>();

			services.AddScoped<IU_BuyingRepositoryADO, U_BuyingRepositoryADO>();

			services.AddScoped<IU_BuyingServiceApp, U_BuyingServiceApp>();

			services.AddScoped<IU_BuyingServiceAppADO, U_BuyingServiceAppADO>();

			services.AddScoped<IU_CompanyTextRepository, U_CompanyTextRepository>();

			services.AddScoped<IU_CompanyTextRepositoryADO, U_CompanyTextRepositoryADO>();

			services.AddScoped<IU_CompanyTextServiceApp, U_CompanyTextServiceApp>();

			services.AddScoped<IU_CompanyTextServiceAppADO, U_CompanyTextServiceAppADO>();

			services.AddScoped<IU_FriendSiteRepository, U_FriendSiteRepository>();

			services.AddScoped<IU_FriendSiteRepositoryADO, U_FriendSiteRepositoryADO>();

			services.AddScoped<IU_FriendSiteServiceApp, U_FriendSiteServiceApp>();

			services.AddScoped<IU_FriendSiteServiceAppADO, U_FriendSiteServiceAppADO>();

			services.AddScoped<IU_GuestBookRepository, U_GuestBookRepository>();

			services.AddScoped<IU_GuestBookRepositoryADO, U_GuestBookRepositoryADO>();

			services.AddScoped<IU_GuestBookServiceApp, U_GuestBookServiceApp>();

			services.AddScoped<IU_GuestBookServiceAppADO, U_GuestBookServiceAppADO>();

			services.AddScoped<IU_IntegralProductRepository, U_IntegralProductRepository>();

			services.AddScoped<IU_IntegralProductRepositoryADO, U_IntegralProductRepositoryADO>();

			services.AddScoped<IU_IntegralProductServiceApp, U_IntegralProductServiceApp>();

			services.AddScoped<IU_IntegralProductServiceAppADO, U_IntegralProductServiceAppADO>();

			services.AddScoped<IU_IntegralProductLogRepository, U_IntegralProductLogRepository>();

			services.AddScoped<IU_IntegralProductLogRepositoryADO, U_IntegralProductLogRepositoryADO>();

			services.AddScoped<IU_IntegralProductLogServiceApp, U_IntegralProductLogServiceApp>();

			services.AddScoped<IU_IntegralProductLogServiceAppADO, U_IntegralProductLogServiceAppADO>();

			services.AddScoped<IU_ManufactureRepository, U_ManufactureRepository>();

			services.AddScoped<IU_ManufactureRepositoryADO, U_ManufactureRepositoryADO>();

			services.AddScoped<IU_ManufactureServiceApp, U_ManufactureServiceApp>();

			services.AddScoped<IU_ManufactureServiceAppADO, U_ManufactureServiceAppADO>();

			services.AddScoped<IU_OrderTextRepository, U_OrderTextRepository>();

			services.AddScoped<IU_OrderTextRepositoryADO, U_OrderTextRepositoryADO>();

			services.AddScoped<IU_OrderTextServiceApp, U_OrderTextServiceApp>();

			services.AddScoped<IU_OrderTextServiceAppADO, U_OrderTextServiceAppADO>();

			services.AddScoped<IU_ProductRepository, U_ProductRepository>();

			services.AddScoped<IU_ProductRepositoryADO, U_ProductRepositoryADO>();

			services.AddScoped<IU_ProductServiceApp, U_ProductServiceApp>();

			services.AddScoped<IU_ProductServiceAppADO, U_ProductServiceAppADO>();

			services.AddScoped<IU_ProvideRepository, U_ProvideRepository>();

			services.AddScoped<IU_ProvideRepositoryADO, U_ProvideRepositoryADO>();

			services.AddScoped<IU_ProvideServiceApp, U_ProvideServiceApp>();

			services.AddScoped<IU_ProvideServiceAppADO, U_ProvideServiceAppADO>();

			services.AddScoped<IU_QuestionRepository, U_QuestionRepository>();

			services.AddScoped<IU_QuestionRepositoryADO, U_QuestionRepositoryADO>();

			services.AddScoped<IU_QuestionServiceApp, U_QuestionServiceApp>();

			services.AddScoped<IU_QuestionServiceAppADO, U_QuestionServiceAppADO>();

			services.AddScoped<IU_UserTextRepository, U_UserTextRepository>();

			services.AddScoped<IU_UserTextRepositoryADO, U_UserTextRepositoryADO>();

			services.AddScoped<IU_UserTextServiceApp, U_UserTextServiceApp>();

			services.AddScoped<IU_UserTextServiceAppADO, U_UserTextServiceAppADO>();

			services.AddScoped<IUserGroupsRepository, UserGroupsRepository>();

			services.AddScoped<IUserGroupsRepositoryADO, UserGroupsRepositoryADO>();

			services.AddScoped<IUserGroupsServiceApp, UserGroupsServiceApp>();

			services.AddScoped<IUserGroupsServiceAppADO, UserGroupsServiceAppADO>();

			services.AddScoped<IUserMessageRepository, UserMessageRepository>();

			services.AddScoped<IUserMessageRepositoryADO, UserMessageRepositoryADO>();

			services.AddScoped<IUserMessageServiceApp, UserMessageServiceApp>();

			services.AddScoped<IUserMessageServiceAppADO, UserMessageServiceAppADO>();

			services.AddScoped<IUsersRepository, UsersRepository>();

			services.AddScoped<IUsersRepositoryADO, UsersRepositoryADO>();

			services.AddScoped<IUsersServiceApp, UsersServiceApp>();

			services.AddScoped<IUsersServiceAppADO, UsersServiceAppADO>();

			services.AddScoped<IValidLogRepository, ValidLogRepository>();

			services.AddScoped<IValidLogRepositoryADO, ValidLogRepositoryADO>();

			services.AddScoped<IValidLogServiceApp, ValidLogServiceApp>();

			services.AddScoped<IValidLogServiceAppADO, ValidLogServiceAppADO>();

			services.AddScoped<IVoteRepository, VoteRepository>();

			services.AddScoped<IVoteRepositoryADO, VoteRepositoryADO>();

			services.AddScoped<IVoteServiceApp, VoteServiceApp>();

			services.AddScoped<IVoteServiceAppADO, VoteServiceAppADO>();

			services.AddScoped<IWordReplaceItemRepository, WordReplaceItemRepository>();

			services.AddScoped<IWordReplaceItemRepositoryADO, WordReplaceItemRepositoryADO>();

			services.AddScoped<IWordReplaceItemServiceApp, WordReplaceItemServiceApp>();

			services.AddScoped<IWordReplaceItemServiceAppADO, WordReplaceItemServiceAppADO>();

			services.AddScoped<IWorkRepository, WorkRepository>();

			services.AddScoped<IWorkRepositoryADO, WorkRepositoryADO>();

			services.AddScoped<IWorkServiceApp, WorkServiceApp>();

			services.AddScoped<IWorkServiceAppADO, WorkServiceAppADO>();

			services.AddScoped<IWorkCategoryRepository, WorkCategoryRepository>();

			services.AddScoped<IWorkCategoryRepositoryADO, WorkCategoryRepositoryADO>();

			services.AddScoped<IWorkCategoryServiceApp, WorkCategoryServiceApp>();

			services.AddScoped<IWorkCategoryServiceAppADO, WorkCategoryServiceAppADO>();

			services.AddScoped<IWorkCategorySettingRepository, WorkCategorySettingRepository>();

			services.AddScoped<IWorkCategorySettingRepositoryADO, WorkCategorySettingRepositoryADO>();

			services.AddScoped<IWorkCategorySettingServiceApp, WorkCategorySettingServiceApp>();

			services.AddScoped<IWorkCategorySettingServiceAppADO, WorkCategorySettingServiceAppADO>();

			services.AddScoped<IWorkFlowsRepository, WorkFlowsRepository>();

			services.AddScoped<IWorkFlowsRepositoryADO, WorkFlowsRepositoryADO>();

			services.AddScoped<IWorkFlowsServiceApp, WorkFlowsServiceApp>();

			services.AddScoped<IWorkFlowsServiceAppADO, WorkFlowsServiceAppADO>();

			services.AddScoped<IWorkNextProcessRolesRepository, WorkNextProcessRolesRepository>();

			services.AddScoped<IWorkNextProcessRolesRepositoryADO, WorkNextProcessRolesRepositoryADO>();

			services.AddScoped<IWorkNextProcessRolesServiceApp, WorkNextProcessRolesServiceApp>();

			services.AddScoped<IWorkNextProcessRolesServiceAppADO, WorkNextProcessRolesServiceAppADO>();

			#endregion

			//配置跨域处理
			services.AddCors(options =>
			{
				options.AddPolicy("any", builder =>
				{
					builder.AllowAnyOrigin() //允许任何来源的主机访问
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials();//指定处理cookie
				});
			});

			#region token验证配置
			var audienceConfig = Configuration.GetSection("Audience");
			//自定义密钥
			var symmetricKeyAsBase64 = audienceConfig["Secret"];
			//生成SymmetricSecurityKey密钥
			var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(symmetricKeyAsBase64));
			var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
			services.AddScoped(
				(ISP) => new TokenProviderOptions
				{
					Issuer = audienceConfig["Issuer"],
					Audience = audienceConfig["Audience"],
					SigningCredentials = signingCredentials
				}
			);
			//令牌验证参数
			var tokenValidationParameters = new TokenValidationParameters
			{
				// The signing key must match!
				//ValidateIssuerSigningKey = true,
				IssuerSigningKey = signingKey,

				// Validate the JWT Issuer (iss) claim
				//ValidateIssuer = true,
				ValidIssuer = audienceConfig["Issuer"],

				// Validate the JWT Audience (aud) claim
				//ValidateAudience = true,
				ValidAudience = audienceConfig["Audience"],

				// Validate the token expiry
				ValidateLifetime = true,
				ClockSkew = TimeSpan.Zero
			};
			services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(o =>
			{
				//不使用https
				//o.RequireHttpsMetadata = false;
				o.TokenValidationParameters = tokenValidationParameters;
			});
			services.AddAuthorization(auth =>
			{
				auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
					.AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
					.RequireAuthenticatedUser()
					.Build());
			});
			#endregion

			services.AddSession();
			services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
			//使网站支持中文编码
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

			//使用GZIP压缩
			app.UseResponseCompression();

			if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
			//添加依赖注入的自定义扩展
			app.UseExtensionsDI();
			//添加对HttpContext的扩展
			app.UseStaticMyHttpContext();
			app.UseSession();

			app.UseMvc();
        }
    }
}
