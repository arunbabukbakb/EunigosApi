using EunigosApi.Data.Entities;
using EunigosApi.Models.Dto;
using EunigosApi.Models.Entity;
using EunigosApi.Models.Entity.AllocationManagements;
using EunigosApi.Models.Entity.AppManagement;
using EunigosApi.Models.Entity.BankManagement;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.CustomManagement;
using EunigosApi.Models.Entity.EmployeeManagement;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.Finance;
using EunigosApi.Models.Entity.Invoicemanagement;
using EunigosApi.Models.Entity.JobCardManagement;
using EunigosApi.Models.Entity.JobCardManagement.EunigosApi.Models.Entity.JobManagement;
using EunigosApi.Models.Entity.MilestoneManagement;
using EunigosApi.Models.Entity.NotificationManagement;
using EunigosApi.Models.Entity.Organization;
using EunigosApi.Models.Entity.PartManagement;
using EunigosApi.Models.Entity.PurchaseManagement;
using EunigosApi.Models.Entity.QC;
using EunigosApi.Models.Entity.RepairKitManagement;
using EunigosApi.Models.Entity.ResourceManagement;
using EunigosApi.Models.Entity.RoleManagement;
using EunigosApi.Models.Entity.ScheduleManagement;
using EunigosApi.Models.Entity.ServiceManagement;
using EunigosApi.Models.Entity.SocialMedias;
using EunigosApi.Models.Entity.StockManagement;
using EunigosApi.Models.Entity.StoreManagement;
using EunigosApi.Models.Entity.SupplierManagement;
using EunigosApi.Models.Entity.TaskManagement;
using EunigosApi.Models.Entity.TenantManagement;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Models.Entity.VehicleServiceManagement;
using EunigosApi.Models.Entity.Work;
using AutoMapper;

namespace EunigosApi.Models.AutoMappers
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {

            var mappingConfig = new MapperConfiguration(config =>
            {

                config.AddProfile<ItemServiceMapping>();
                config.AddProfile<SourceOfPartsMapping>();
                config.AddProfile<TypesOfPartsMapping>();
                config.AddProfile<TicketMapping>();
                config.AddProfile<EstimateMapping>();
                config.AddProfile<TaxMapping>();
                config.AddProfile<EstimateApproveMapping>();
                config.AddProfile<EstimateArchiveMapping>();
                config.AddProfile<EstimateRevertMapping>();
                config.AddProfile<EstimateSaveMapping>();
                config.AddProfile<EstimateCopyMapping>();
                config.AddProfile<UserRoleMapping>();
				config.AddProfile<JobCardMapping>();

				#region Registration
				config.CreateMap<RegisterDto, User>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
               .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
               .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position));

                config.CreateMap<User, RegisterDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                    .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
                    .ForMember(dest => dest.Position, opt => opt.MapFrom(src => src.Position));
                #endregion
                #region Tenant
                config.CreateMap<TenantDto, Tenant>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Domain, opt => opt.MapFrom(src => src.Domain))
               .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
               .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));



                config.CreateMap<Tenant, TenantDto>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Domain, opt => opt.MapFrom(src => src.Domain))
               .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
               .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                #endregion
                #region Users
                config.CreateMap<User, UserDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.UserName))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.TwoFactorEnabled, opt => opt.MapFrom(src => src.TwoFactorEnabled))
                    // .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.PasswordHash))
                    .ForMember(dest => dest.LastLoggedIn, opt => opt.MapFrom(src => src.LastLoggedIn))
                    .ForMember(dest => dest.PasswordExpiryPeriod, opt => opt.MapFrom(src => src.PasswordExpiryPeriod))
                    .ForMember(dest => dest.ForcePasswordChange, opt => opt.MapFrom(src => src.ForcePasswordChange))
                    .ForMember(dest => dest.IsSystemDefined, opt => opt.MapFrom(src => src.IsSystemDefined))
                    .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                    .ForMember(dest => dest.Permission, opt => opt.MapFrom(src => src.Permission))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById));

                config.CreateMap<UserDto, User>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Username))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.TwoFactorEnabled, opt => opt.MapFrom(src => src.TwoFactorEnabled))
                    //.ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password))
                    .ForMember(dest => dest.LastLoggedIn, opt => opt.MapFrom(src => src.LastLoggedIn))
                    .ForMember(dest => dest.PasswordExpiryPeriod, opt => opt.MapFrom(src => src.PasswordExpiryPeriod))
                    .ForMember(dest => dest.ForcePasswordChange, opt => opt.MapFrom(src => src.ForcePasswordChange))
                    .ForMember(dest => dest.IsSystemDefined, opt => opt.MapFrom(src => src.IsSystemDefined))
                    .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                    .ForMember(dest => dest.Permission, opt => opt.MapFrom(src => src.Permission))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById));

                #endregion
                #region Currency
                config.CreateMap<CurrencyDto, Currency>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
               .ForMember(dest => dest.Symbol, opt => opt.MapFrom(src => src.Symbol))
               .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
               .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
               .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Currency, CurrencyDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
               .ForMember(dest => dest.Symbol, opt => opt.MapFrom(src => src.Symbol))
               .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
               .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
               .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));
                #endregion
                #region UserProfiles
                config.CreateMap<UserProfileDto, UserProfiles>()
                 .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                 .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                 .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                 .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                 .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                 .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                 .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                 .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                 .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                 .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<UserProfiles, UserProfileDto>()
                    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region UserProfilecategory
                config.CreateMap<UserProfileCategoryDto, UserProfileCategory>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                 .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<UserProfileCategory, UserProfileCategoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region Country
                config.CreateMap<CountryDto, Country>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.PhoneCode, opt => opt.MapFrom(src => src.PhoneCode))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
               .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Country, CountryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                .ForMember(dest => dest.PhoneCode, opt => opt.MapFrom(src => src.PhoneCode))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                #endregion
                #region State
                config.CreateMap<StateDto, State>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<State, StateDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
                .ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => src.Country.Name))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                #endregion
                #region City
                config.CreateMap<CityDto, City>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<City, CityDto>().ReverseMap();

				#endregion
				#region Customer

				config.CreateMap<CustomerDto, Customer>()
					.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
					.ForMember(dest => dest.CustomerCode, opt => opt.MapFrom(src => src.CustomerCode))
					.ForMember(dest => dest.CustomerCodeFormatted, opt => opt.MapFrom(src => src.CustomerCodeFormatted))
					.ForMember(dest => dest.CustomerCategoryId, opt => opt.MapFrom(src => src.CustomerCategoryId))
					.ForMember(dest => dest.Salutation, opt => opt.MapFrom(src => src.Salutation))
					.ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
					.ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
					.ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
					.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
					.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
					.ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
					.ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
					.ForMember(dest => dest.Zipcode, opt => opt.MapFrom(src => src.Zipcode))
					.ForMember(dest => dest.ContactNumber1, opt => opt.MapFrom(src => src.ContactNumber1))
					.ForMember(dest => dest.ContactNumber2, opt => opt.MapFrom(src => src.ContactNumber2))
					.ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.EmailId))
					.ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Photo))
					.ForMember(dest => dest.IsCreditPeriodApplicable, opt => opt.MapFrom(src => src.IsCreditPeriodApplicable))
					.ForMember(dest => dest.CreditPeriod, opt => opt.MapFrom(src => src.CreditPeriod))
					.ForMember(dest => dest.CreditAmount, opt => opt.MapFrom(src => src.CreditAmount))
					.ForMember(dest => dest.LockPeriod, opt => opt.MapFrom(src => src.LockPeriod))
					.ForMember(dest => dest.LockAmount, opt => opt.MapFrom(src => src.LockAmount))
					.ForMember(dest => dest.VAT, opt => opt.MapFrom(src => src.VAT))
					.ForMember(dest => dest.TRNGSTNumber, opt => opt.MapFrom(src => src.TRNGSTNumber))
					.ForMember(dest => dest.PaymentTerms, opt => opt.MapFrom(src => src.PaymentTerms))
					.ForMember(dest => dest.AvailabilityOfTime, opt => opt.MapFrom(src => src.AvailabilityOfTime))
					.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
					.ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
					.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
					.ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
					.ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
					.ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
					.ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
					.ForMember(dest => dest.CustomerContactPersons, opt => opt.MapFrom(src => src.ContactPersons));

				config.CreateMap<Customer, CustomerDto>()
					.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
					.ForMember(dest => dest.CustomerCode, opt => opt.MapFrom(src => src.CustomerCode))
					.ForMember(dest => dest.CustomerCodeFormatted, opt => opt.MapFrom(src => src.CustomerCodeFormatted))
					.ForMember(dest => dest.CustomerCategoryId, opt => opt.MapFrom(src => src.CustomerCategoryId))
					//.ForMember(dest => dest.CustomerCategoryName, opt => opt.MapFrom(src => src.customerCategory.Name))
					.ForMember(dest => dest.Salutation, opt => opt.MapFrom(src => src.Salutation))
					.ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
					.ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
					.ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
					.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
					.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
					.ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
					.ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
					.ForMember(dest => dest.Zipcode, opt => opt.MapFrom(src => src.Zipcode))
					.ForMember(dest => dest.ContactNumber1, opt => opt.MapFrom(src => src.ContactNumber1))
					.ForMember(dest => dest.ContactNumber2, opt => opt.MapFrom(src => src.ContactNumber2))
					.ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.EmailId))
					.ForMember(dest => dest.Photo, opt => opt.MapFrom(src => src.Photo))
					.ForMember(dest => dest.IsCreditPeriodApplicable, opt => opt.MapFrom(src => src.IsCreditPeriodApplicable))
					.ForMember(dest => dest.CreditPeriod, opt => opt.MapFrom(src => src.CreditPeriod))
					.ForMember(dest => dest.CreditAmount, opt => opt.MapFrom(src => src.CreditAmount))
					.ForMember(dest => dest.LockPeriod, opt => opt.MapFrom(src => src.LockPeriod))
					.ForMember(dest => dest.LockAmount, opt => opt.MapFrom(src => src.LockAmount))
					.ForMember(dest => dest.VAT, opt => opt.MapFrom(src => src.VAT))
					.ForMember(dest => dest.TRNGSTNumber, opt => opt.MapFrom(src => src.TRNGSTNumber))
					.ForMember(dest => dest.PaymentTerms, opt => opt.MapFrom(src => src.PaymentTerms))
					.ForMember(dest => dest.AvailabilityOfTime, opt => opt.MapFrom(src => src.AvailabilityOfTime))
					.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
					.ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
					.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
					.ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
					.ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
					.ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
					.ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
					.ForMember(dest => dest.ContactPersons, opt => opt.MapFrom(src => src.CustomerContactPersons));

				#endregion

				#region CustomerContactPerson
				// Entity → DTO
				config.CreateMap<CustomerContactPerson, CustomerContactPersonDto>()
					.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
					.ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
					.ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer_Nav.FirstName))
					.ForMember(dest => dest.Salutation, opt => opt.MapFrom(src => src.Salutation))
					.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
					.ForMember(dest => dest.ContactNumber, opt => opt.MapFrom(src => src.ContactNumber))
					.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
					.ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
					.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
					.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
					.ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
					.ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
					.ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
					.ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById));

				// DTO → Entity
				config.CreateMap<CustomerContactPersonDto, CustomerContactPerson>()
					.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
					.ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
					.ForMember(dest => dest.Salutation, opt => opt.MapFrom(src => src.Salutation))
					.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
					.ForMember(dest => dest.ContactNumber, opt => opt.MapFrom(src => src.ContactNumber))
					.ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
					.ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
					.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
					.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
					.ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
					.ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
					.ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
					.ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById));

				#endregion
				#region CustomerCategory 
				config.CreateMap<CustomerCategoryDto, CustomerCategory>()
					.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
					.ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.ParentId))
					.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
					.ForMember(dest => dest.CategoryCode, opt => opt.MapFrom(src => src.CategoryCode))
					.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
					.ForMember(dest => dest.ChildCategories, opt => opt.MapFrom(src => src.Childrens))
					.ForMember(dest => dest.Customers, opt => opt.MapFrom(src => src.Customers))
					.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
					.ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
					.ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
					.ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
					.ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
					.ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));

				config.CreateMap<CustomerCategory, CustomerCategoryDto>()
					 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
					 .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.ParentId))
					 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
					 .ForMember(dest => dest.CategoryCode, opt => opt.MapFrom(src => src.CategoryCode))
					 .ForMember(dest => dest.Childrens, opt => opt.MapFrom(src => src.ChildCategories))
					 .ForMember(dest => dest.Customers, opt => opt.MapFrom(src => src.Customers))

					.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
					.ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
					.ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
					.ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
					.ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
					.ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
			   .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));
				#endregion
				#region IdentityType
				config.CreateMap<IdentityTypeDto, IdentityType>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

                config.CreateMap<IdentityType, IdentityTypeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
                #endregion
                #region CustomerFinancial
                config.CreateMap<CustomerFinancial, CustomerFinancialDto>()
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.IsCreditPeriodApplicable, opt => opt.MapFrom(src => src.IsCreditPeriodApplicable))
                    .ForMember(dest => dest.CreditAmount, opt => opt.MapFrom(src => src.CreditAmount))
                    .ForMember(dest => dest.CreditPeriod, opt => opt.MapFrom(src => src.CreditPeriod))
                    .ForMember(dest => dest.LockAmount, opt => opt.MapFrom(src => src.LockAmount))
                    .ForMember(dest => dest.LockPeriod, opt => opt.MapFrom(src => src.LockPeriod))
                    .ForMember(dest => dest.PaymentTerms, opt => opt.MapFrom(src => src.PaymentTerms))
                    .ForMember(dest => dest.PriceCode, opt => opt.MapFrom(src => src.PriceCode))
                    .ForMember(dest => dest.IsPriceCodeApplicable, opt => opt.MapFrom(src => src.IsPriceCodeApplicable))
                    .ForMember(dest => dest.TaxRefund, opt => opt.MapFrom(src => src.TaxRefund))
                    .ForMember(dest => dest.ServiceTax, opt => opt.MapFrom(src => src.ServiceTax))
                    .ForMember(dest => dest.HasDiscount, opt => opt.MapFrom(src => src.HasDiscount))
                    .ForMember(dest => dest.DiscountId, opt => opt.MapFrom(src => src.DiscountId))
                    .ForMember(dest => dest.CustomFinanceCharge, opt => opt.MapFrom(src => src.CustomFinanceCharge))
                    .ForMember(dest => dest.IsFinanceChargeApplicable, opt => opt.MapFrom(src => src.IsFinanceChargeApplicable))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                   .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                   .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                   .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                   .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                   .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<CustomerFinancialDto, CustomerFinancial>().ReverseMap();
                #endregion
                #region Vehicle
                config.CreateMap<Vehicle, VehicleDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
                    .ForMember(dest => dest.Mileage, opt => opt.MapFrom(src => src.Mileage))
                    .ForMember(dest => dest.FuelLevel, opt => opt.MapFrom(src => src.FuelLevel))
                    .ForMember(dest => dest.RegistrationDate, opt => opt.MapFrom(src => src.RegistrationDate))
                    .ForMember(dest => dest.RegistrationExpiryDate, opt => opt.MapFrom(src => src.RegistrationExpiryDate))
                    .ForMember(dest => dest.InsuranceNumber, opt => opt.MapFrom(src => src.InsuranceNumber))
                    .ForMember(dest => dest.InsuranceExpiryDate, opt => opt.MapFrom(src => src.InsuranceExpiryDate))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<VehicleDto, Vehicle>().ReverseMap();
                #endregion
                #region Document
                config.CreateMap<DocumentDto, Document>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Files, opt => opt.MapFrom(src => src.Files))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.CanDownload, opt => opt.MapFrom(src => src.CanDownload))
                .ForMember(dest => dest.ExpiryDate, opt => opt.MapFrom(src => src.ExpiryDate))
                .ForMember(dest => dest.IssueDate, opt => opt.MapFrom(src => src.IssueDate))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<Document, DocumentDto>().ReverseMap();

                #endregion
                #region Location
                config.CreateMap<LocationDto, Location>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude))
                .ForMember(dest => dest.Altitude, opt => opt.MapFrom(src => src.Altitude))
                .ForMember(dest => dest.Accuracy, opt => opt.MapFrom(src => src.Accuracy))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<Location, LocationDto>().ReverseMap();

                #endregion
                #region CustomerVehicle
                config.CreateMap<CustomerVehicle, CustomerVehicleDto>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                  .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer_Nav.FirstName))
                  .ForMember(dest => dest.VehicleManufacturerId, opt => opt.MapFrom(src => src.VehicleManufacturerId))
                  .ForMember(dest => dest.VehicleManufacturerName, opt => opt.MapFrom(src => src.VehicleManufacturers.Name))
                  .ForMember(dest => dest.VehicleModelId, opt => opt.MapFrom(src => src.VehicleModelId))
                  .ForMember(dest => dest.VehicleModelName, opt => opt.MapFrom(src => src.VehicleModels.Name))
                  .ForMember(dest => dest.VehicleTypeId, opt => opt.MapFrom(src => src.VehicleTypeId))
                  .ForMember(dest => dest.VehicleTypeName, opt => opt.MapFrom(src => src.VehicleTypes.Name))
                  .ForMember(dest => dest.VehicleNumber, opt => opt.MapFrom(src => src.VehicleNumber))
                  .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                  .ForMember(dest => dest.VINNumber, opt => opt.MapFrom(src => src.VINNumber))
                  .ForMember(dest => dest.EngineCode, opt => opt.MapFrom(src => src.EngineCode))
                  //.ForMember(dest => dest.Tickets, opt => opt.MapFrom(src => src.Tickets.Select(i => i.Id).ToList()))
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                  .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));

                config.CreateMap<CustomerVehicleDto, CustomerVehicle>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                  //.ForMember(dest => dest.Tickets, opt => opt.MapFrom(src => src.Tickets.Select(i => i.Id).ToList()))
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                  .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));
                #endregion
                #region VehicleInventory
                config.CreateMap<VehicleInventory, VehicleInventoryDto>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                  .ForMember(dest => dest.ItemName, opt => opt.MapFrom(src => src.ItemName))

                  .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));

                config.CreateMap<VehicleInventoryDto, VehicleInventory>().ReverseMap();
                #endregion
                #region VehicleInspection
                config.CreateMap<VehicleInspectionDto, VehicleInspection>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.OdometerReading, opt => opt.MapFrom(src => src.OdometerReading))
                    .ForMember(dest => dest.MeterReadingType, opt => opt.MapFrom(src => src.MeterReadingType))
                    .ForMember(dest => dest.FuelLevel, opt => opt.MapFrom(src => src.FuelLevel))
                    .ForMember(dest => dest.InspectionComments, opt => opt.MapFrom(src => src.InspectionComments))
                    .ForMember(dest => dest.InventoryItems, opt => opt.MapFrom(src => src.InventoryItems))
                    .ForMember(dest => dest.InventoryNotes, opt => opt.MapFrom(src => src.InventoryNotes))
                    .ForMember(dest => dest.CustomerSignature, opt => opt.MapFrom(src => src.CustomerSignature))
                    .ForMember(dest => dest.TechnicianId, opt => opt.MapFrom(src => src.TechnicianId))
                    .ForMember(dest => dest.FuelTypeId, opt => opt.MapFrom(src => src.FuelTypeId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                // Optionally reverse map if needed
                config.CreateMap<VehicleInspection, VehicleInspectionDto>().ReverseMap();
                #endregion
                #region CustomerIdentity

                config.CreateMap<CustomerIdentityDto, CustomerIdentity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dest => dest.IdentityTypeId, opt => opt.MapFrom(src => src.IdentityTypeId))
                .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => src.DocumentId))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomerIdentity, CustomerIdentityDto>().ReverseMap();
                #endregion
                #region CustomerContact
                config.CreateMap<CustomerContact, CustomerContactDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                    .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));


                config.CreateMap<CustomerContactDto, CustomerContact>().ReverseMap();
                #endregion
                #region CustomerAddress
                config.CreateMap<CustomerAddress, CustomerAddressDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.AddressType))
                    .ForMember(dest => dest.BuildingName, opt => opt.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.StreetAddress, opt => opt.MapFrom(src => src.StreetAddress))
                    .ForMember(dest => dest.Landmark, opt => opt.MapFrom(src => src.Landmark))
                    .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.CityId))
                    .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
                    .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
                    .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                   .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                   .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                   .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                   .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                   .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                   .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                   .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));


                config.CreateMap<CustomerAddressDto, CustomerAddress>().ReverseMap();
                #endregion
                #region VehicleInspectionItem
                config.CreateMap<VehicleInspectionItem, VehicleInspectionItemDto>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                 .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                 .ForMember(dest => dest.InspectionId, opt => opt.MapFrom(src => src.InspectionId))
                 .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                 .ForMember(dest => dest.ItemName, opt => opt.MapFrom(src => src.ItemName))
                 .ForMember(dest => dest.Condition, opt => opt.MapFrom(src => src.Condition))
                 .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.IsAvailable));

                config.CreateMap<VehicleInspectionItemDto, VehicleInspectionItem>().ReverseMap();

                #endregion
                #region VehicleInventoryItem
                config.CreateMap<VehicleInventoryItem, VehicleInventoryItemDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ItemName, opt => opt.MapFrom(src => src.ItemName))
                    .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                    .ForMember(dest => dest.Condition, opt => opt.MapFrom(src => src.Condition))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));

                config.CreateMap<VehicleInventoryItemDto, VehicleInventoryItem>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ItemName, opt => opt.MapFrom(src => src.ItemName))
                    .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                    .ForMember(dest => dest.Condition, opt => opt.MapFrom(src => src.Condition))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ReverseMap(); // This allows bidirectional mapping.

                #endregion
                #region VehicleDocument
                config.CreateMap<VehicleDocumentDto, VehicleDocument>()
              .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
              .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
              .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
              .ForMember(dest => dest.CanDownload, opt => opt.MapFrom(src => src.CanDownload))
              .ForMember(dest => dest.ExpiryDate, opt => opt.MapFrom(src => src.ExpiryDate))
              .ForMember(dest => dest.IssueDate, opt => opt.MapFrom(src => src.IssueDate))
              .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
              .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
              .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
              .ForMember(dest => dest.VehicleId, opt => opt.MapFrom(src => src.VehicleId));
                config.CreateMap<VehicleDocument, VehicleDocumentDto>().ReverseMap();
                #endregion
                #region Image
                config.CreateMap<ImageDto, Image>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Width, opt => opt.MapFrom(src => src.Width))
                .ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.FileName, opt => opt.MapFrom(src => src.FileName))
                .ForMember(dest => dest.FileSize, opt => opt.MapFrom(src => src.FileSize))
                .ForMember(dest => dest.MimeType, opt => opt.MapFrom(src => src.MimeType))
                .ForMember(dest => dest.AltText, opt => opt.MapFrom(src => src.AltText))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));
                config.CreateMap<Image, ImageDto>().ReverseMap();
                #endregion
                #region Video
                config.CreateMap<VideoDto, Video>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                .ForMember(dest => dest.ThumbnailUrl, opt => opt.MapFrom(src => src.ThumbnailUrl))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.FileName, opt => opt.MapFrom(src => src.FileName))
                .ForMember(dest => dest.FileSize, opt => opt.MapFrom(src => src.FileSize))
                .ForMember(dest => dest.MimeType, opt => opt.MapFrom(src => src.MimeType))
                .ForMember(dest => dest.AltText, opt => opt.MapFrom(src => src.AltText))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
               .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));
                config.CreateMap<Video, VideoDto>().ReverseMap();
                #endregion
                #region Vehicleidentity
                config.CreateMap<VehicleIdentity, VehicleIdentityDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.VehicleId, opt => opt.MapFrom(src => src.VehicleId))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => src.DocumentId));
                config.CreateMap<VehicleIdentityDto, VehicleIdentity>().ReverseMap();

                #endregion
                #region VehicleServiceHistory
                config.CreateMap<VehicleServiceHistory, VehicleServiceHistoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.VehicleId, opt => opt.MapFrom(src => src.VehicleId))
                .ForMember(dest => dest.ServiceDate, opt => opt.MapFrom(src => src.ServiceDate))
                .ForMember(dest => dest.OdometerReading, opt => opt.MapFrom(src => src.OdometerReading))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.PerformedBy, opt => opt.MapFrom(src => src.PerformedBy))
                .ForMember(dest => dest.Cost, opt => opt.MapFrom(src => src.Cost));
                config.CreateMap<VehicleServiceHistoryDto, VehicleServiceHistory>().ReverseMap();
                #endregion
                #region VehicleBodyStyle
                config.CreateMap<VehicleBodyStyle, VehicleBodyStyleDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                 .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                 .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
               .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<VehicleBodyStyleDto, VehicleBodyStyle>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
               .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
               .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
               .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region VehicleManufacturer
                config.CreateMap<VehicleManufacturer, VehicleManufacturerDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                 .ForMember(dest => dest.VehicleModels, opt => opt.MapFrom(src => src.VehicleModels))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<VehicleManufacturerDto, VehicleManufacturer>().ReverseMap();
                

                #endregion
                #region VehicleDefect
                config.CreateMap<VehicleDefectDto, VehicleDefect>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.DefectName, opt => opt.MapFrom(src => src.DefectName))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<VehicleDefect, VehicleDefectDto>().ReverseMap();
                #endregion
                #region VehicleDefectComment
                config.CreateMap<VehicleDefectCommentDto, VehicleDefectComment>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.ParentId));

                config.CreateMap<VehicleDefectComment, VehicleDefectCommentDto>().ReverseMap();
                #endregion
                #region OfficeBranch
                config.CreateMap<OfficeBranch, OfficeBranchDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.IsMain, opt => opt.MapFrom(src => src.IsMain))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<OfficeBranchDto, OfficeBranch>().ReverseMap();

                #endregion
                #region OfficeBranchAddress
                config.CreateMap<OfficeBranchAddress, OfficeBranchAddressDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.OfficeBranchId, opt => opt.MapFrom(src => src.OfficeBranchId))
                    .ForMember(dest => dest.BuildingName, opt => opt.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.StreetAddress, opt => opt.MapFrom(src => src.StreetAddress))
                    .ForMember(dest => dest.Landmark, opt => opt.MapFrom(src => src.Landmark))
                    .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.CityId))
                    .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
                    .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
                    .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                     .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                     .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                     .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));


                config.CreateMap<OfficeBranchAddressDto, OfficeBranchAddress>().ReverseMap();
                #endregion
                #region OrganizationUnit
                config.CreateMap<OrganizationUnit, OrganizationUnitDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.ParentId))
                 .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<OrganizationUnitDto, OrganizationUnit>().ReverseMap();

                #endregion
                #region Department
                config.CreateMap<Department, DepartmentDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.LogoUrl, opt => opt.MapFrom(src => src.LogoUrl))
                .ForMember(dest => dest.BranchId, opt => opt.MapFrom(src => src.BranchId))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<DepartmentDto, Department>().ReverseMap();
                #endregion
                #region VehicleModel
                config.CreateMap<VehicleModel, VehicleModelDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ManufacturerId, opt => opt.MapFrom(src => src.ManufacturerId))
                .ForMember(dest => dest.ManufacturerName, opt => opt.MapFrom(src => src.Manufacturer_Nav.Name))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<VehicleModelDto, VehicleModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ManufacturerId, opt => opt.MapFrom(src => src.ManufacturerId))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region VehicleType
                config.CreateMap<VehicleType, VehicleTypeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<VehicleTypeDto, VehicleType>().ReverseMap();
                #endregion
                #region Designation
                config.CreateMap<Designation, DesignationDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.ReportingAuthorityId, opt => opt.MapFrom(src => src.ReportingAuthorityId))
                .ForMember(dest => dest.SubordinateIds, opt => opt.MapFrom(src => src.Subordinates.Select(sub => sub.Id.ToString())))
                .ForMember(dest => dest.IsDepartmentHead, opt => opt.MapFrom(src => src.IsDepartmentHead))
                 .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<DesignationDto, Designation>().ReverseMap();

                #endregion
             
                #region TicketAutocomplete
                config.CreateMap<Ticket, TicketAutoCompleteDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TicketNumber, opt => opt.MapFrom(src => src.TicketNumber));

                config.CreateMap<TicketAutoCompleteDto, Ticket>().ReverseMap();

                #endregion
                #region JobTypes
                config.CreateMap<JobType, JobTypeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<JobTypeDto, JobType>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                #endregion
                #region IdnetityInfo
                config.CreateMap<IdentityInfo, IdentityInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => src.DocumentId))
                .ForMember(dest => dest.IdentityTypeId, opt => opt.MapFrom(src => src.IdentityTypeId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<IdentityInfoDto, IdentityInfo>().ReverseMap();

                #endregion
                #region Employee
                config.CreateMap<Employee, EmployeeDto>()
            .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
            .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
            .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
            .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
            .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
            .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
            .ForMember(dest => dest.EmployeeCode, opt => opt.MapFrom(src => src.EmployeeCode))
            .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
            .ForMember(dest => dest.DesignationId, opt => opt.MapFrom(src => src.DesignationId))
            .ForMember(dest => dest.OrganizationUnitId, opt => opt.MapFrom(src => src.OrganizationUnitId))
            .ForMember(dest => dest.SalaryId, opt => opt.MapFrom(src => src.SalaryId))
            .ForMember(dest => dest.PersonalId, opt => opt.MapFrom(src => src.PersonalId))
            .ForMember(dest => dest.AdditionalInfoId, opt => opt.MapFrom(src => src.AdditionalInfoId))
            .ForMember(dest => dest.EmployeeDetailId, opt => opt.MapFrom(src => src.EmployeeDetailId))
            .ForMember(dest => dest.EmployeeContact, opt => opt.MapFrom(src => src.EmployeeContact.Select(c => c.Id).ToList()))
            .ForMember(dest => dest.EmployeeAddress, opt => opt.MapFrom(src => src.EmployeeAddress.Select(a => a.Id).ToList()))
            .ForMember(dest => dest.EmployeeIdentity, opt => opt.MapFrom(src => src.EmployeeIdentity.Select(i => i.Id).ToList()))
            .ForMember(dest => dest.Grade, opt => opt.MapFrom(src => src.Grade));

                config.CreateMap<EmployeeDto, Employee>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.EmployeeCode, opt => opt.MapFrom(src => src.EmployeeCode))
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                .ForMember(dest => dest.DesignationId, opt => opt.MapFrom(src => src.DesignationId))
                .ForMember(dest => dest.OrganizationUnitId, opt => opt.MapFrom(src => src.OrganizationUnitId))
                .ForMember(dest => dest.SalaryId, opt => opt.MapFrom(src => src.SalaryId))
                .ForMember(dest => dest.PersonalId, opt => opt.MapFrom(src => src.PersonalId))
                .ForMember(dest => dest.AdditionalInfoId, opt => opt.MapFrom(src => src.AdditionalInfoId))
                .ForMember(dest => dest.EmployeeDetailId, opt => opt.MapFrom(src => src.EmployeeDetailId))
                .ForMember(dest => dest.EmployeeContact, opt => opt.Ignore())
                .ForMember(dest => dest.EmployeeAddress, opt => opt.Ignore())
                .ForMember(dest => dest.EmployeeIdentity, opt => opt.Ignore())
                .ForMember(dest => dest.Grade, opt => opt.MapFrom(src => src.Grade));
                #endregion
                #region ServiceItem
                config.CreateMap<ServiceItem, ServiceItemDto>()
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                .ForMember(dest => dest.IsFlatRate, opt => opt.MapFrom(src => src.IsFlatRate))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src.ItemCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                 .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<ServiceItemDto, ServiceItem>()
               .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
               .ForMember(dest => dest.IsFlatRate, opt => opt.MapFrom(src => src.IsFlatRate))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src.ItemCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                #endregion
                #region OutsideWorkItem 
                config.CreateMap<OutsideWorkItem, OutsideWorkItemDto>()
               
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src.ItemCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<OutsideWorkItemDto, OutsideWorkItem>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src.ItemCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                
                #region RepairKit
                config.CreateMap<RepairKit, RepairKitDto>()
                .ForMember(dest => dest.RepairKitNumber, opt => opt.MapFrom(src => src.RepairKitNumber))
                .ForMember(dest => dest.QuotedAmount, opt => opt.MapFrom(src => src.QuotedAmount))
                .ForMember(dest => dest.EstimateId, opt => opt.MapFrom(src => src.EstimateId))
                .ForMember(dest => dest.JobCardId, opt => opt.MapFrom(src => src.JobCardId))
                .ForMember(dest => dest.JobAllocationId, opt => opt.MapFrom(src => src.JobAllocationId))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<RepairKitDto, RepairKit>().ReverseMap();
                #endregion
                #region RepairKitItem
                config.CreateMap<RepairKitItem, RepairKitItemDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.RepairKitId, opt => opt.MapFrom(src => src.RepairKitId))
                    .ForMember(dest => dest.ItemId, opt => opt.MapFrom(src => src.ItemId))
                    .ForMember(dest => dest.ItemType, opt => opt.MapFrom(src => src.ItemType.ToString())) // Enum to string
                    .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                    .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                    .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Quantity * src.UnitPrice))
                    .ForMember(dest => dest.IsMandatory, opt => opt.MapFrom(src => src.IsMandatory))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))

                    .ReverseMap();

                #endregion


                #region JobCards
                config.CreateMap<InsuranceDetail, InsuranceDetailDto>();

                config.CreateMap<InsuranceDetailDto, InsuranceDetail>().ReverseMap();
                #endregion
                #region Discount
                config.CreateMap<DiscountDto, Discount>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
               .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.DiscountType))
               .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.DiscountValue))
               .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
               .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
               .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
               .ForMember(dest => dest.MaxUsage, opt => opt.MapFrom(src => src.MaxUsage))
               .ForMember(dest => dest.CurrentUsage, opt => opt.MapFrom(src => src.CurrentUsage))
               .ForMember(dest => dest.MinPurchaseAmount, opt => opt.MapFrom(src => src.MinPurchaseAmount))
               .ForMember(dest => dest.MaxDiscountAmount, opt => opt.MapFrom(src => src.MaxDiscountAmount))
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
               .ForMember(dest => dest.AppliedDiscounts, opt => opt.MapFrom(src => src.AppliedDiscounts ?? new List<string>()))
               .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
               .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<Discount, DiscountDto>().ReverseMap();
                #endregion

                #region Estimate Approval and Archive
                config.CreateMap<EstimateApprovalDto, EstimateApproval>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.EstimateId, opt => opt.MapFrom(src => src.EstimateId))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.ApprovedById, opt => opt.MapFrom(src => src.ApprovedById))
                .ForMember(dest => dest.ApprovedDate, opt => opt.MapFrom(src => src.ApprovedDate))
                .ForMember(dest => dest.ApprovedAmount, opt => opt.MapFrom(src => src.ApprovedAmount))
                .ForMember(dest => dest.ApprovalNotes, opt => opt.MapFrom(src => src.ApprovalNotes))
                .ForMember(dest => dest.RevertedById, opt => opt.MapFrom(src => src.RevertedById))
                .ForMember(dest => dest.RevertDate, opt => opt.MapFrom(src => src.RevertDate))
                .ForMember(dest => dest.RevertNotes, opt => opt.MapFrom(src => src.RevertNotes))
                .ForMember(dest => dest.ArchivedById, opt => opt.MapFrom(src => src.ArchivedById))
                .ForMember(dest => dest.ArchivedDate, opt => opt.MapFrom(src => src.ArchivedDate));


                config.CreateMap<EstimateApproval, EstimateApprovalDto>().ReverseMap();
                #endregion
                #region InventoryItem Mapping
                config.CreateMap<InventoryItemDto, InventoryItem>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
           
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<InventoryItem, InventoryItemDto>().ReverseMap();
                #endregion
                #region ConsumableItem 
                config.CreateMap<ConsumableItemDto, ConsumableItem>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src.ItemCode))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                    .ForMember(dest => dest.UnitOfMeasure, opt => opt.MapFrom(src => src.UnitOfMeasure))
                    .ForMember(dest => dest.StockQuantity, opt => opt.MapFrom(src => src.StockQuantity))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ConsumableItem, ConsumableItemDto>().ReverseMap();
                #endregion
                #region RepairKitPart
                config.CreateMap<RepairKitPartDto, RepairKitPart>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src.ItemCode))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                    .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                    .ForMember(dest => dest.PartNumber, opt => opt.MapFrom(src => src.PartNumber))
                    .ForMember(dest => dest.StockQuantity, opt => opt.MapFrom(src => src.StockQuantity))
                    .ForMember(dest => dest.ReorderLevel, opt => opt.MapFrom(src => src.ReorderLevel))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<RepairKitPart, RepairKitPartDto>().ReverseMap();
                #endregion
                #region RepairKitService
                config.CreateMap<RepairKitServiceDto, RepairKitService>()
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                .ForMember(dest => dest.IsFlatRate, opt => opt.MapFrom(src => src.IsFlatRate))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.ItemCode, opt => opt.MapFrom(src => src.ItemCode))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                 .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<RepairKitService, RepairKitServiceDto>().ReverseMap();
                #endregion
                #region Salary
                config.CreateMap<SalaryDto, Salary>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.BasicAmount, opt => opt.MapFrom(src => src.BasicAmount))
                    .ForMember(dest => dest.AllowanceAmount, opt => opt.MapFrom(src => src.AllowanceAmount))
                    .ForMember(dest => dest.OtherAmount, opt => opt.MapFrom(src => src.OtherAmount))
                    .ForMember(dest => dest.SalaryTypeId, opt => opt.MapFrom(src => src.SalaryTypeId))
                    .ForMember(dest => dest.PaymentMode, opt => opt.MapFrom(src => src.PaymentMode))
                    .ForMember(dest => dest.PayPeriod, opt => opt.MapFrom(src => src.PayPeriod))
                    .ForMember(dest => dest.HasOvertime, opt => opt.MapFrom(src => src.HasOvertime))
                     .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                     .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                     .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<Salary, SalaryDto>().ReverseMap();
                #endregion
                #region Salary Type
                config.CreateMap<SalaryTypeDto, SalaryType>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                     .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                     .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<SalaryType, SalaryTypeDto>().ReverseMap();
                #endregion
                #region JobCard
                config.CreateMap<JobCard, JobCardDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                //.ForMember(dest => dest.JobCardNumber, opt => opt.MapFrom(src => src.JobCardNumber))
                .ForMember(dest => dest.EstimateId, opt => opt.MapFrom(src => src.EstimateId))
                //.ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                //.ForMember(dest => dest.CustomerVehicleId, opt => opt.MapFrom(src => src.CustomerVehicleId))
                //.ForMember(dest => dest.AssignedToId, opt => opt.MapFrom(src => src.AssignedToId))
                //.ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                //.ForMember(dest => dest.RepairKitId, opt => opt.MapFrom(src => src.RepairKitId))
                //.ForMember(dest => dest.AssignedTo, opt => opt.MapFrom(src => src.AssignedTo))
                //.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                //.ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                //.ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                //.ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                //.ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items ?? new List<string>()))
                 .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<JobCardDto, JobCard>().ReverseMap();
                #endregion
                #region JobCardItem 
                config.CreateMap<JobCardItem, JobCardItemDto>()
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.JobCardId, opt => opt.MapFrom(src => src.JobCardId))
              //  .ForMember(dest => dest.RepairKitItemId, opt => opt.MapFrom(src => src.RepairKitItemId))
               // .ForMember(dest => dest.ActualQuantity, opt => opt.MapFrom(src => src.ActualQuantity))
               // .ForMember(dest => dest.ActualPrice, opt => opt.MapFrom(src => src.ActualPrice))
               // .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                //.ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                //.ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                config.CreateMap<JobCardItemDto, JobCardItem>().ReverseMap();
                #endregion
                #region JobAllocation
                config.CreateMap<JobAllocationDto, JobAllocation>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ActualHours, opt => opt.MapFrom(src => src.ActualHours))
                    .ForMember(dest => dest.BayId, opt => opt.MapFrom(src => src.BayId))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.QualityScore, opt => opt.MapFrom(src => src.QualityScore))
                    .ForMember(dest => dest.ReasonForDelay, opt => opt.MapFrom(src => src.ReasonForDelay))
                    .ForMember(dest => dest.ReasonForHold, opt => opt.MapFrom(src => src.ReasonForHold))
                    .ForMember(dest => dest.ReasonForResume, opt => opt.MapFrom(src => src.ReasonForResume))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.ReworkReason, opt => opt.MapFrom(src => src.ReworkReason))
                    .ForMember(dest => dest.ReworkRequired, opt => opt.MapFrom(src => src.ReworkRequired))
                    .ForMember(dest => dest.StandardHours, opt => opt.MapFrom(src => src.StandardHours))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EfficiencyPercentage, opt => opt.MapFrom(src => src.EfficiencyPercentage))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.EstimatedHours, opt => opt.MapFrom(src => src.EstimatedHours))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.TaskId, opt => opt.MapFrom(src => src.TaskId))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.JobAllocationStatusHistory, opt => opt.MapFrom(src => src.StatusHistory ?? new List<string>()))
                    .ForMember(dest => dest.JobAllocationEmployee, opt => opt.MapFrom(src => src.Employees ?? new List<string>()))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                     .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));
                config.CreateMap<JobAllocation, JobAllocationDto>().ReverseMap();
                #endregion
                #region EmployeeContact

                config.CreateMap<EmployeeContactDto, EmployeeContact>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                    .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<EmployeeContact, EmployeeContactDto>().ReverseMap();
                #endregion
                #region EmployeePersonal

                config.CreateMap<EmployeePersonalDto, EmployeePersonal>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.Religion, opt => opt.MapFrom(src => src.Religion))
                    .ForMember(dest => dest.DoctorName, opt => opt.MapFrom(src => src.DoctorName))
                    .ForMember(dest => dest.DoctorPhone, opt => opt.MapFrom(src => src.DoctorPhone))
                    .ForMember(dest => dest.DoctorZip, opt => opt.MapFrom(src => src.DoctorZip))
                    .ForMember(dest => dest.DoctorAddress, opt => opt.MapFrom(src => src.DoctorAddress))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<EmployeePersonal, EmployeePersonalDto>().ReverseMap();

                #endregion
                #region EmployeeAddress

                config.CreateMap<EmployeeAddressDto, EmployeeAddress>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.AddressType, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.BuildingName, opt => opt.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.StreetAddress, opt => opt.MapFrom(src => src.StreetAddress))
                    .ForMember(dest => dest.Landmark, opt => opt.MapFrom(src => src.Landmark))
                    .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.CityId))
                    .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
                    .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
                    .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<EmployeeAddress, EmployeeAddressDto>().ReverseMap();

                #endregion
                #region EmployeeIdentity

                config.CreateMap<EmployeeIdentityDto, EmployeeIdentity>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
                    .ForMember(dest => dest.IdentityTypeId, opt => opt.MapFrom(src => src.IdentityTypeId))
                    .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => src.DocumentId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<EmployeeIdentity, EmployeeIdentityDto>().ReverseMap();

                #endregion
                #region EmployeeAdditionalInfo

                config.CreateMap<EmployeeAdditionalInfoDto, EmployeeAdditionalInfo>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.Sui, opt => opt.MapFrom(src => src.Sui))
                    .ForMember(dest => dest.EmpAliasName, opt => opt.MapFrom(src => src.EmpAliasName))
                    .ForMember(dest => dest.WpsNo, opt => opt.MapFrom(src => src.WpsNo))
                    .ForMember(dest => dest.ProbationPeriod, opt => opt.MapFrom(src => src.ProbationPeriod))
                    .ForMember(dest => dest.InTime, opt => opt.MapFrom(src => src.InTime))
                    .ForMember(dest => dest.OutTime, opt => opt.MapFrom(src => src.OutTime))
                    .ForMember(dest => dest.HowPaid, opt => opt.MapFrom(src => src.HowPaid))
                    .ForMember(dest => dest.IsEmpExemptOt, opt => opt.MapFrom(src => src.IsEmpExemptOt))
                    .ForMember(dest => dest.IsEmpExemptTax, opt => opt.MapFrom(src => src.IsEmpExemptTax))
                    .ForMember(dest => dest.Extension, opt => opt.MapFrom(src => src.Extension))
                    .ForMember(dest => dest.AuthorizedLeaveDays, opt => opt.MapFrom(src => src.AuthorizedLeaveDays))
                    .ForMember(dest => dest.OfficePhoneCode, opt => opt.MapFrom(src => src.OfficePhoneCode))
                    .ForMember(dest => dest.VisaNumber, opt => opt.MapFrom(src => src.VisaNumber))
                    .ForMember(dest => dest.HospitalName, opt => opt.MapFrom(src => src.HospitalName))
                    .ForMember(dest => dest.HospitalAddress, opt => opt.MapFrom(src => src.HospitalAddress))
                    .ForMember(dest => dest.LabourCardNo, opt => opt.MapFrom(src => src.LabourCardNo))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<EmployeeAdditionalInfo, EmployeeAdditionalInfoDto>().ReverseMap();

                #endregion
                #region EmploymentDetail

                config.CreateMap<EmploymentDetailDto, EmploymentDetail>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.DateOfJoin, opt => opt.MapFrom(src => src.DateOfJoin))
                    .ForMember(dest => dest.NoticePeriod, opt => opt.MapFrom(src => src.NoticePeriod))
                    .ForMember(dest => dest.OfferDate, opt => opt.MapFrom(src => src.OfferDate))
                    .ForMember(dest => dest.ConfirmationDate, opt => opt.MapFrom(src => src.ConfirmationDate))
                    .ForMember(dest => dest.ContractEndDate, opt => opt.MapFrom(src => src.ContractEndDate))
                    .ForMember(dest => dest.SpecialCondition, opt => opt.MapFrom(src => src.SpecialCondition))
                    .ForMember(dest => dest.DateOfRetirement, opt => opt.MapFrom(src => src.DateOfRetirement))
                    .ForMember(dest => dest.WorkingShift, opt => opt.MapFrom(src => src.WorkingShift))
                    .ForMember(dest => dest.DateOfTermination, opt => opt.MapFrom(src => src.DateOfTermination))
                    .ForMember(dest => dest.RelievingDate, opt => opt.MapFrom(src => src.RelievingDate))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<EmploymentDetail, EmploymentDetailDto>().ReverseMap();

                #endregion
                #region User Preference
                config.CreateMap<UserPreferenceDto, UserPreference>()
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.Theme, opt => opt.MapFrom(src => src.Theme))
                    .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId))
                    .ForMember(dest => dest.PrimaryColor, opt => opt.MapFrom(src => src.PrimaryColor))
                    .ForMember(dest => dest.SecondaryColor, opt => opt.MapFrom(src => src.SecondaryColor))
                    .ForMember(dest => dest.FontSize, opt => opt.MapFrom(src => src.FontSize))
                    .ForMember(dest => dest.NotificationsEnabled, opt => opt.MapFrom(src => src.NotificationsEnabled))
                    .ForMember(dest => dest.AnimationsEnabled, opt => opt.MapFrom(src => src.AnimationsEnabled))
                    .ForMember(dest => dest.DefaultCurrencyId, opt => opt.MapFrom(src => src.DefaultCurrencyId))
                    .ForMember(dest => dest.TimeZone, opt => opt.MapFrom(src => src.TimeZone))
                    .ForMember(dest => dest.DateFormat, opt => opt.MapFrom(src => src.DateFormat))
                    .ForMember(dest => dest.TimeFormat, opt => opt.MapFrom(src => src.TimeFormat))
                    .ForMember(dest => dest.StartOfWeek, opt => opt.MapFrom(src => src.StartOfWeek))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                     .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                     .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                     .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                     .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                     .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));

                config.CreateMap<UserPreference, UserPreferenceDto>().ReverseMap();
                #endregion
                #region Language
                config.CreateMap<LanguageDto, Language>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                     .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                     .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                     .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                     .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                     .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                     .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));

                config.CreateMap<Language, LanguageDto>().ReverseMap();
                #endregion
                #region CorporateCustomer
                config.CreateMap<CorporateCustomerDto, CorporateCustomer>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.CompanyName))
                    .ForMember(dest => dest.Industry, opt => opt.MapFrom(src => src.Industry))
                    .ForMember(dest => dest.AnnualRevenue, opt => opt.MapFrom(src => src.AnnualRevenue))
                    .ForMember(dest => dest.NumberOfEmployees, opt => opt.MapFrom(src => src.NumberOfEmployees))
                    .ForMember(dest => dest.AvailabilityOfTime, opt => opt.MapFrom(src => src.AvailabilityOfTime))
                    .ForMember(dest => dest.CustomerCode, opt => opt.MapFrom(src => src.CustomerCode))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));
                #endregion
                #region UserContact
                config.CreateMap<UserContactDto, UserContact>()
                     .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                     .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                     .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                     .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                     .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                     .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                     .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<UserContact, UserContactDto>().ReverseMap();

                config.CreateMap<CorporateCustomer, CorporateCustomerDto>().ReverseMap();
                #endregion
                #region Coupon
                config.CreateMap<CouponDto, Coupon>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.MaxUsage, opt => opt.MapFrom(src => src.MaxUsage))
                .ForMember(dest => dest.CurrentUsage, opt => opt.MapFrom(src => src.CurrentUsage))
                .ForMember(dest => dest.MinPurchaseAmount, opt => opt.MapFrom(src => src.MinPurchaseAmount))
                .ForMember(dest => dest.MaxDiscountAmount, opt => opt.MapFrom(src => src.MaxDiscountAmount))
                .ForMember(dest => dest.AppliedCoupons, opt => opt.MapFrom(src => src.AppliedCoupons ?? new List<string>()))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Coupon, CouponDto>().ReverseMap();
                #endregion
                #region CustomerCoupon
                config.CreateMap<CustomerCouponDto, CustomerCoupon>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dest => dest.CouponId, opt => opt.MapFrom(src => src.CouponId))
                .ForMember(dest => dest.AppliedAmount, opt => opt.MapFrom(src => src.AppliedAmount))
                .ForMember(dest => dest.AppliedDate, opt => opt.MapFrom(src => src.AppliedDate))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomerCoupon, CustomerCouponDto>().ReverseMap();
                #endregion
                #region CustomerDiscount
                config.CreateMap<CustomerDiscountDto, CustomerDiscount>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dest => dest.DiscountId, opt => opt.MapFrom(src => src.DiscountId))
                .ForMember(dest => dest.AppliedAmount, opt => opt.MapFrom(src => src.AppliedAmount))
                .ForMember(dest => dest.AppliedDate, opt => opt.MapFrom(src => src.AppliedDate))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomerDiscount, CustomerDiscountDto>().ReverseMap();
                #endregion
                #region CustomerServiceProfile
                config.CreateMap<CustomerServiceProfileDto, CustomerServiceProfile>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.PreferredServiceAdvisorId, opt => opt.MapFrom(src => src.PreferredServiceAdvisorId))
                    .ForMember(dest => dest.PreferredCommunicationChannel, opt => opt.MapFrom(src => src.PreferredCommunicationChannel))
                    .ForMember(dest => dest.PreferredServiceDay, opt => opt.MapFrom(src => src.PreferredServiceDay))
                    .ForMember(dest => dest.PreferredServiceTime, opt => opt.MapFrom(src => src.PreferredServiceTime))
                    .ForMember(dest => dest.SpecialInstructions, opt => opt.MapFrom(src => src.SpecialInstructions))
                    .ForMember(dest => dest.LoyaltyPoints, opt => opt.MapFrom(src => src.LoyaltyPoints))
                    .ForMember(dest => dest.LastServiceDate, opt => opt.MapFrom(src => src.LastServiceDate))
                    .ForMember(dest => dest.NextServiceDue, opt => opt.MapFrom(src => src.NextServiceDue))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomerServiceProfile, CustomerServiceProfileDto>().ReverseMap();
                #endregion
                #region CustomerCommunicationPreference
                config.CreateMap<CustomerCommunicationPreferenceDto, CustomerCommunicationPreference>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.MilestoneType, opt => opt.MapFrom(src => src.MilestoneType))
                    .ForMember(dest => dest.PreferredChannels, opt => opt.MapFrom(src => src.PreferredChannels))
                    .ForMember(dest => dest.PreferredLanguage, opt => opt.MapFrom(src => src.PreferredLanguage))
                    .ForMember(dest => dest.AllowMarketing, opt => opt.MapFrom(src => src.AllowMarketing))
                    .ForMember(dest => dest.QuietHoursStart, opt => opt.MapFrom(src => src.QuietHoursStart))
                    .ForMember(dest => dest.QuietHoursEnd, opt => opt.MapFrom(src => src.QuietHoursEnd))
                    .ForMember(dest => dest.Timezone, opt => opt.MapFrom(src => src.Timezone))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomerCommunicationPreference, CustomerCommunicationPreferenceDto>()
                    .ReverseMap();
                #endregion
                #region BankAccount
                config.CreateMap<BankAccountDto, BankAccount>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.BankId, opt => opt.MapFrom(src => src.BankId))
                    .ForMember(dest => dest.AccountNumber, opt => opt.MapFrom(src => src.AccountNumber))
                    .ForMember(dest => dest.AccountHolderId, opt => opt.MapFrom(src => src.AccountHolderId))
                    .ForMember(dest => dest.AccountHolderType, opt => opt.MapFrom(src => src.AccountHolderType))
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<BankAccount, BankAccountDto>().ReverseMap();
                #endregion
                #region Bank
                config.CreateMap<BankDto, Bank>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Branch, opt => opt.MapFrom(src => src.Branch))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Bank, BankDto>().ReverseMap();
                #endregion
                #region SocialMediaAccount
                config.CreateMap<SocialMediaAccountDto, SocialMediaAccount>()
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                    .ForMember(dest => dest.ProviderId, opt => opt.MapFrom(src => src.ProviderId))
                    .ForMember(dest => dest.AllowLogin, opt => opt.MapFrom(src => src.AllowLogin))
                    .ForMember(dest => dest.IsVerified, opt => opt.MapFrom(src => src.IsVerified))
                    .ForMember(dest => dest.IsPreferred, opt => opt.MapFrom(src => src.IsPreferred))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<SocialMediaAccount, SocialMediaAccountDto>()
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Username))
                    .ForMember(dest => dest.ProviderId, opt => opt.MapFrom(src => src.ProviderId))
                    .ForMember(dest => dest.AllowLogin, opt => opt.MapFrom(src => src.AllowLogin))
                    .ForMember(dest => dest.IsVerified, opt => opt.MapFrom(src => src.IsVerified))
                    .ForMember(dest => dest.IsPreferred, opt => opt.MapFrom(src => src.IsPreferred))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region UserAddress
                config.CreateMap<UserAddress, UserAddressDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.BuildingName, opt => opt.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.StreetAddress, opt => opt.MapFrom(src => src.StreetAddress))
                    .ForMember(dest => dest.Landmark, opt => opt.MapFrom(src => src.Landmark))
                    .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.CityId))
                    .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
                    .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
                    .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                   .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                   .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                   .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                   .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                   .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                   .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                   .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));


                config.CreateMap<UserAddressDto, UserAddress>().ReverseMap();
                #endregion
                #region EmployeeSchedule
                config.CreateMap<EmployeeScheduleDto, EmployeeSchedule>()
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.IsLeave, opt => opt.MapFrom(src => src.IsLeave))
                    .ForMember(dest => dest.LeaveType, opt => opt.MapFrom(src => src.LeaveType))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<EmployeeSchedule, EmployeeScheduleDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                     .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.IsLeave, opt => opt.MapFrom(src => src.IsLeave))
                    .ForMember(dest => dest.LeaveType, opt => opt.MapFrom(src => src.LeaveType))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region EmployeeAvailability

                config.CreateMap<EmployeeAvailabilityDto, EmployeeAvailability>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                .ForMember(dest => dest.AvailableHours, opt => opt.MapFrom(src => src.AvailableHours))
                .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.IsAvailable))
                .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                //.ForMember(dest => dest.UnavailabilityReason, opt => opt.MapFrom(src => src.UnavailabilityReason ?? new List<string>()))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<EmployeeAvailability, EmployeeAvailabilityDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.AvailableHours, opt => opt.MapFrom(src => src.AvailableHours))
                    .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.IsAvailable))
                    .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                        .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                        .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                        .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                        .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                        .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region EmployeeUnavailabilityReason
                config.CreateMap<EmployeeUnavailabilityReasonDto, EmployeeUnavailabilityReason>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AvailabilityId, opt => opt.MapFrom(src => src.AvailabilityId))
                    .ForMember(dest => dest.ReasonType, opt => opt.MapFrom(src => src.ReasonType))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                   .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                   .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                   .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                   .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                   .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                   .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                   .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                config.CreateMap<EmployeeUnavailabilityReason, EmployeeUnavailabilityReasonDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AvailabilityId, opt => opt.MapFrom(src => src.AvailabilityId))
                    .ForMember(dest => dest.ReasonType, opt => opt.MapFrom(src => src.ReasonType))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                     .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                     .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                     .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                     .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                     .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region WorkingShift
                config.CreateMap<WorkingShiftDto, WorkingShift>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.BreakStart, opt => opt.MapFrom(src => src.BreakStart))
                    .ForMember(dest => dest.BreakDuration, opt => opt.MapFrom(src => src.BreakDuration))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<WorkingShift, WorkingShiftDto>().ReverseMap();
                #endregion
                #region WorkingDay
                config.CreateMap<WorkingDayDto, WorkingDay>()
                    .ForMember(dest => dest.ShiftId, opt => opt.MapFrom(src => src.ShiftId))
                    .ForMember(dest => dest.DayOfWeek, opt => opt.MapFrom(src => src.DayOfWeek))
                    .ForMember(dest => dest.IsWorking, opt => opt.MapFrom(src => src.IsWorking))
                    .ForMember(dest => dest.StartTimeOverride, opt => opt.MapFrom(src => src.StartTimeOverride))
                    .ForMember(dest => dest.EndTimeOverride, opt => opt.MapFrom(src => src.EndTimeOverride))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<WorkingDay, WorkingDayDto>().ReverseMap();
                #endregion
                #region InsuranceCustomer
                config.CreateMap<InsuranceCustomerDto, InsuranceCustomer>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.InsuranceProvider, opt => opt.MapFrom(src => src.InsuranceProvider))
                    .ForMember(dest => dest.PolicyNumber, opt => opt.MapFrom(src => src.PolicyNumber))
                    .ForMember(dest => dest.CoverageType, opt => opt.MapFrom(src => src.CoverageType))
                    .ForMember(dest => dest.PremiumAmount, opt => opt.MapFrom(src => src.PremiumAmount))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<InsuranceCustomer, InsuranceCustomerDto>().ReverseMap();
                #endregion
                #region StandardRepairTime
                config.CreateMap<StandardRepairTimeDto, StandardRepairTime>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.JobTypeId, opt => opt.MapFrom(src => src.JobTypeId))
                    .ForMember(dest => dest.VehicleModelId, opt => opt.MapFrom(src => src.VehicleModelId))
                    .ForMember(dest => dest.StandardHours, opt => opt.MapFrom(src => src.StandardHours))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<StandardRepairTime, StandardRepairTimeDto>().ReverseMap();
                #endregion
                #region SocialMediaProvider
                // Mapping from SocialMediaProvider to SocialMediaProviderDto
                config.CreateMap<SocialMediaProvider, SocialMediaProviderDto>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                 .ForMember(dest => dest.ApiUrl, opt => opt.MapFrom(src => src.ApiUrl))
                 .ForMember(dest => dest.AuthStrategy, opt => opt.MapFrom(src => src.AuthStrategy))
                 .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                     .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                 .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                 .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

                // Mapping from SocialMediaProviderDto to SocialMediaProvider
                config.CreateMap<SocialMediaProviderDto, SocialMediaProvider>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                        .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.ApiUrl, opt => opt.MapFrom(src => src.ApiUrl))
                    .ForMember(dest => dest.AuthStrategy, opt => opt.MapFrom(src => src.AuthStrategy))
                     .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                 .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                 .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));
                #endregion
                #region Task 
                // Mapping from WorkTask to WorkTaskDto
                config.CreateMap<WorkTask, WorkTaskDto>()
                   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                     .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                     .ForMember(dest => dest.IsMandatory, opt => opt.MapFrom(src => src.IsMandatory))
                     .ForMember(dest => dest.IsSystemDefined, opt => opt.MapFrom(src => src.IsSystemDefined))
                     .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                     .ForMember(dest => dest.RequiresQc, opt => opt.MapFrom(src => src.RequiresQc))
                     .ForMember(dest => dest.StandardHours, opt => opt.MapFrom(src => src.StandardHours))
                     .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                     .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                     .ForMember(dest => dest.SequenceNumber, opt => opt.MapFrom(src => src.SequenceNumber))
                     .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.Employees))
                      .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                     .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
            .ForMember(dest => dest.Allocations, opt => opt.MapFrom(src => src.Allocations));

                // Mapping from WorkTaskDto to WorkTask
                config.CreateMap<WorkTaskDto, WorkTask>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.IsMandatory, opt => opt.MapFrom(src => src.IsMandatory))
                    .ForMember(dest => dest.IsSystemDefined, opt => opt.MapFrom(src => src.IsSystemDefined))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.RequiresQc, opt => opt.MapFrom(src => src.RequiresQc))
                    .ForMember(dest => dest.StandardHours, opt => opt.MapFrom(src => src.StandardHours))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.SequenceNumber, opt => opt.MapFrom(src => src.SequenceNumber))
                    .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.Employees))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                        .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
         .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
         .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
         .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
         .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
         .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
         .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
         .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
            .ForMember(dest => dest.Allocations, opt => opt.MapFrom(src => src.Allocations));
                #endregion
                #region TaskEmployee
                config.CreateMap<TaskEmployee, TaskEmployeeDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
               .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
               .ForMember(dest => dest.ProficiencyLevel, opt => opt.MapFrom(src => src.ProficiencyLevel))
               .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                 .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                 .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                 .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                 .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                 .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                 .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
           .ForMember(dest => dest.TaskId, opt => opt.MapFrom(src => src.TaskId));

                // Reverse mapping from TaskEmployeeDto to TaskEmployee
                config.CreateMap<TaskEmployeeDto, TaskEmployee>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                     .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                     .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                     .ForMember(dest => dest.ProficiencyLevel, opt => opt.MapFrom(src => src.ProficiencyLevel))
                     .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                  .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                  .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                  .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                  .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                     .ForMember(dest => dest.TaskId, opt => opt.MapFrom(src => src.TaskId));
                #endregion
                #region SchedulingRule
                config.CreateMap<SchedulingRuleDto, SchedulingRule>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.JobTypeId, opt => opt.MapFrom(src => src.JobTypeId))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.MinDuration, opt => opt.MapFrom(src => src.MinDuration))
                    .ForMember(dest => dest.MaxDuration, opt => opt.MapFrom(src => src.MaxDuration))
                    .ForMember(dest => dest.BufferBefore, opt => opt.MapFrom(src => src.BufferBefore))
                    .ForMember(dest => dest.BufferAfter, opt => opt.MapFrom(src => src.BufferAfter))
                    .ForMember(dest => dest.MaxConcurrentJobs, opt => opt.MapFrom(src => src.MaxConcurrentJobs))
                    .ForMember(dest => dest.RequireBayAllocation, opt => opt.MapFrom(src => src.RequireBayAllocation))
                    .ForMember(dest => dest.AllowOverlap, opt => opt.MapFrom(src => src.AllowOverlap))
                    .ForMember(dest => dest.PriorityLevel, opt => opt.MapFrom(src => src.PriorityLevel))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<SchedulingRule, SchedulingRuleDto>().ReverseMap();
                #endregion
                #region ScheduleSlot
                config.CreateMap<ScheduleSlotDto, ScheduleSlot>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.JobAllocationId, opt => opt.MapFrom(src => src.JobAllocationId))
                    .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    // Uncomment and modify the following lines if you need to map the collections
                    //.ForMember(dest => dest.Assignments, opt => opt.MapFrom(src => src.Assignments))
                    //.ForMember(dest => dest.SchedulingConflicts, opt => opt.MapFrom(src => src.SchedulingConflicts))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ScheduleSlot, ScheduleSlotDto>().ReverseMap();
                #endregion
                #region BlockedSlot
                config.CreateMap<BlockedSlotDto, BlockedSlot>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                    .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                    .ForMember(dest => dest.RepeatFrequency, opt => opt.MapFrom(src => src.RepeatFrequency))
                    .ForMember(dest => dest.RepeatUntil, opt => opt.MapFrom(src => src.RepeatUntil))
                    .ForMember(dest => dest.IsHoliday, opt => opt.MapFrom(src => src.IsHoliday))
                    .ForMember(dest => dest.DepartmentIds, opt => opt.MapFrom(src => src.DepartmentIds))
                    .ForMember(dest => dest.BayIds, opt => opt.MapFrom(src => src.BayIds))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<BlockedSlot, BlockedSlotDto>().ReverseMap();
                #endregion
                #region AllocationEmployee
                // Mapping from AllocationEmployee to AllocationEmployeeDto
                config.CreateMap<AllocationEmployee, AllocationEmployeeDto>()
                    .ForMember(dest => dest.AllocationId, opt => opt.MapFrom(src => src.AllocationId))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.AssignedById, opt => opt.MapFrom(src => src.AssignedById))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                     .ForMember(dest => dest.TimeLog, opt => opt.MapFrom(src => src.TimeLog))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                     .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));

                // Mapping from AllocationEmployeeDto to AllocationEmployee
                config.CreateMap<AllocationEmployeeDto, AllocationEmployee>()
                    .ForMember(dest => dest.AllocationId, opt => opt.MapFrom(src => src.AllocationId))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.AssignedById, opt => opt.MapFrom(src => src.AssignedById))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                       .ForMember(dest => dest.TimeLog, opt => opt.MapFrom(src => src.TimeLog))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                     .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
                #endregion
                #region AllocationEmployeeTimeLog
                // Mapping from AllocationEmployeeTimeLog to AllocationEmployeeTimeLogDto
                config.CreateMap<AllocationEmployeeTimeLog, AllocationEmployeeTimeLogDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AllocationEmployeeId, opt => opt.MapFrom(src => src.AllocationEmployeeId))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                // Mapping from AllocationEmployeeTimeLogDto to AllocationEmployeeTimeLog
                config.CreateMap<AllocationEmployeeTimeLogDto, AllocationEmployeeTimeLog>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AllocationEmployeeId, opt => opt.MapFrom(src => src.AllocationEmployeeId))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => src.Duration))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));
                #endregion
                #region AllocationStatusHistory
                config.CreateMap<AllocationStatusHistory, AllocationStatusHistoryDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AllocationId, opt => opt.MapFrom(src => src.AllocationId))
                    .ForMember(dest => dest.ChangedById, opt => opt.MapFrom(src => src.ChangedById))
                    .ForMember(dest => dest.FromStatus, opt => opt.MapFrom(src => src.FromStatus))
                    .ForMember(dest => dest.ToStatus, opt => opt.MapFrom(src => src.ToStatus))
                    .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<AllocationStatusHistoryDto, AllocationStatusHistory>().ReverseMap();
                #endregion
                #region SlotStatusHistory
                config.CreateMap<SlotStatusHistoryDto, SlotStatusHistory>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ChangedById, opt => opt.MapFrom(src => src.ChangedById))
                    .ForMember(dest => dest.FromStatus, opt => opt.MapFrom(src => src.FromStatus))
                    .ForMember(dest => dest.SlotId, opt => opt.MapFrom(src => src.SlotId))
                    .ForMember(dest => dest.ToStatus, opt => opt.MapFrom(src => src.ToStatus))
                    .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<SlotStatusHistory, SlotStatusHistoryDto>().ReverseMap();
                #endregion
                #region CapacityForecast
                config.CreateMap<CapacityForecastDto, CapacityForecast>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.ForecastDate, opt => opt.MapFrom(src => src.ForecastDate))
                    .ForMember(dest => dest.ForecastedHours, opt => opt.MapFrom(src => src.ForecastedHours))
                    .ForMember(dest => dest.ActualHours, opt => opt.MapFrom(src => src.ActualHours))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.Variance, opt => opt.MapFrom(src => src.Variance))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CapacityForecast, CapacityForecastDto>().ReverseMap();
                #endregion
                #region DepartmentAvailability
                config.CreateMap<DepartmentAvailabilityDto, DepartmentAvailability>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AvailableHours, opt => opt.MapFrom(src => src.AvailableHours))
                    .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.IsAvailable, opt => opt.MapFrom(src => src.IsAvailable))
                    .ForMember(dest => dest.ScheduledHours, opt => opt.MapFrom(src => src.ScheduledHours))
                    .ForMember(dest => dest.TotalCapacityHours, opt => opt.MapFrom(src => src.TotalCapacityHours))
                    .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                #region Tools
                config.CreateMap<Tool, ToolDto>()
                    .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.ToolCategory, opt => opt.MapFrom(src => src.ToolCategory))
                    .ForMember(dest => dest.Allocations, opt => opt.MapFrom(src => src.Allocations ?? new List<string>()))
                    .ForMember(dest => dest.MaintenanceSchedules, opt => opt.MapFrom(src => src.MaintenanceSchedules ?? new List<string>()))
                    .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.Reservations ?? new List<string>()))
                    .ForMember(dest => dest.CalibrationRequired, opt => opt.MapFrom(src => src.CalibrationRequired))
                    .ForMember(dest => dest.LastCalibrationDate, opt => opt.MapFrom(src => src.LastCalibrationDate))
                    .ForMember(dest => dest.NextCalibrationDate, opt => opt.MapFrom(src => src.NextCalibrationDate))
                    .ForMember(dest => dest.CalibrationFrequencyMonths, opt => opt.MapFrom(src => src.CalibrationFrequencyMonths))
                    .ForMember(dest => dest.IsShared, opt => opt.MapFrom(src => src.IsShared))
                    .ForMember(dest => dest.CurrentHolderId, opt => opt.MapFrom(src => src.CurrentHolderId))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    // Add missing properties
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.AcquisitionCost, opt => opt.MapFrom(src => src.AcquisitionCost))
                    .ForMember(dest => dest.AcquisitionDate, opt => opt.MapFrom(src => src.AcquisitionDate))
                    .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.Capacity))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.ExpectedLifetimeMonths, opt => opt.MapFrom(src => src.ExpectedLifetimeMonths))
                    .ForMember(dest => dest.LastMaintenanceDate, opt => opt.MapFrom(src => src.LastMaintenanceDate))
                    .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                    .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                    .ForMember(dest => dest.NextMaintenanceDate, opt => opt.MapFrom(src => src.NextMaintenanceDate))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.PhotoUrls ?? new List<string>()))
                    .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                    .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => src.SupplierId))
                    .ForMember(dest => dest.WarrantyExpiry, opt => opt.MapFrom(src => src.WarrantyExpiry));

                config.CreateMap<ToolDto, Tool>().ReverseMap();
                #endregion
                #region Equipment
                // Mapping from Equipment to EquipmentDto
                config.CreateMap<Equipment, EquipmentDto>()
                    .ForMember(dest => dest.EquipmentCategory, opt => opt.MapFrom(src => src.EquipmentCategory))
                    .ForMember(dest => dest.PowerRequirements, opt => opt.MapFrom(src => src.PowerRequirements))
                    .ForMember(dest => dest.OperationalHours, opt => opt.MapFrom(src => src.OperationalHours))
                    .ForMember(dest => dest.MaintenanceFrequencyHours, opt => opt.MapFrom(src => src.MaintenanceFrequencyHours))
                    .ForMember(dest => dest.LastMeterReading, opt => opt.MapFrom(src => src.LastMeterReading))
                    .ForMember(dest => dest.MeterReadingUnit, opt => opt.MapFrom(src => src.MeterReadingUnit))
                    .ForMember(dest => dest.RequiresCertification, opt => opt.MapFrom(src => src.RequiresCertification))
                    .ForMember(dest => dest.CertificationExpiry, opt => opt.MapFrom(src => src.CertificationExpiry))
                    .ForMember(dest => dest.Allocations, opt => opt.MapFrom(src => src.Allocations ?? new List<string>()))
                    .ForMember(dest => dest.MaintenanceSchedules, opt => opt.MapFrom(src => src.MaintenanceSchedules ?? new List<string>()))
                    .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.Reservations ?? new List<string>()))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.AcquisitionDate, opt => opt.MapFrom(src => src.AcquisitionDate))
                    .ForMember(dest => dest.AcquisitionCost, opt => opt.MapFrom(src => src.AcquisitionCost))
                    .ForMember(dest => dest.ExpectedLifetimeMonths, opt => opt.MapFrom(src => src.ExpectedLifetimeMonths))
                    .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => src.SupplierId))
                    .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                    .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                    .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                    .ForMember(dest => dest.WarrantyExpiry, opt => opt.MapFrom(src => src.WarrantyExpiry))
                    .ForMember(dest => dest.LastMaintenanceDate, opt => opt.MapFrom(src => src.LastMaintenanceDate))
                    .ForMember(dest => dest.NextMaintenanceDate, opt => opt.MapFrom(src => src.NextMaintenanceDate))
                    .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.Capacity))
                    .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.PhotoUrls ?? new List<string>()))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));

                // Reverse mapping from EquipmentDto to Equipment
                config.CreateMap<EquipmentDto, Equipment>()
                    .ForMember(dest => dest.EquipmentCategory, opt => opt.MapFrom(src => src.EquipmentCategory))
                    .ForMember(dest => dest.PowerRequirements, opt => opt.MapFrom(src => src.PowerRequirements))
                    .ForMember(dest => dest.OperationalHours, opt => opt.MapFrom(src => src.OperationalHours))
                    .ForMember(dest => dest.MaintenanceFrequencyHours, opt => opt.MapFrom(src => src.MaintenanceFrequencyHours))
                    .ForMember(dest => dest.LastMeterReading, opt => opt.MapFrom(src => src.LastMeterReading))
                    .ForMember(dest => dest.MeterReadingUnit, opt => opt.MapFrom(src => src.MeterReadingUnit))
                    .ForMember(dest => dest.RequiresCertification, opt => opt.MapFrom(src => src.RequiresCertification))
                    .ForMember(dest => dest.CertificationExpiry, opt => opt.MapFrom(src => src.CertificationExpiry))
                    .ForMember(dest => dest.Allocations, opt => opt.MapFrom(src => src.Allocations ?? new List<string>()))
                    .ForMember(dest => dest.MaintenanceSchedules, opt => opt.MapFrom(src => src.MaintenanceSchedules ?? new List<string>()))
                    .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.Reservations ?? new List<string>()))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.AcquisitionDate, opt => opt.MapFrom(src => src.AcquisitionDate))
                    .ForMember(dest => dest.AcquisitionCost, opt => opt.MapFrom(src => src.AcquisitionCost))
                    .ForMember(dest => dest.ExpectedLifetimeMonths, opt => opt.MapFrom(src => src.ExpectedLifetimeMonths))
                    .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => src.SupplierId))
                    .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                    .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                    .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                    .ForMember(dest => dest.WarrantyExpiry, opt => opt.MapFrom(src => src.WarrantyExpiry))
                    .ForMember(dest => dest.LastMaintenanceDate, opt => opt.MapFrom(src => src.LastMaintenanceDate))
                    .ForMember(dest => dest.NextMaintenanceDate, opt => opt.MapFrom(src => src.NextMaintenanceDate))
                    .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.Capacity))
                    .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.PhotoUrls ?? new List<string>()))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));
                #endregion
                #region Resource
                // Mapping from Resource to ResourceDto
                config.CreateMap<Resource, ResourceDto>()
                    .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.Reservations ?? new List<string>()))
                    .ForMember(dest => dest.Allocations, opt => opt.MapFrom(src => src.Allocations ?? new List<string>()))
                    .ForMember(dest => dest.MaintenanceSchedules, opt => opt.MapFrom(src => src.MaintenanceSchedules ?? new List<string>()))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.AcquisitionDate, opt => opt.MapFrom(src => src.AcquisitionDate))
                    .ForMember(dest => dest.AcquisitionCost, opt => opt.MapFrom(src => src.AcquisitionCost))
                    .ForMember(dest => dest.ExpectedLifetimeMonths, opt => opt.MapFrom(src => src.ExpectedLifetimeMonths))
                    .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => src.SupplierId))
                    .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                    .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                    .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                    .ForMember(dest => dest.WarrantyExpiry, opt => opt.MapFrom(src => src.WarrantyExpiry))
                    .ForMember(dest => dest.LastMaintenanceDate, opt => opt.MapFrom(src => src.LastMaintenanceDate))
                    .ForMember(dest => dest.NextMaintenanceDate, opt => opt.MapFrom(src => src.NextMaintenanceDate))
                    .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.Capacity))
                    .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.PhotoUrls ?? new List<string>()))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                // Mapping from ResourceDto to Resource
                config.CreateMap<ResourceDto, Resource>()
                    .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.Reservations ?? new List<string>()))
                    .ForMember(dest => dest.Allocations, opt => opt.MapFrom(src => src.Allocations ?? new List<string>()))
                    .ForMember(dest => dest.MaintenanceSchedules, opt => opt.MapFrom(src => src.MaintenanceSchedules ?? new List<string>()))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.AcquisitionDate, opt => opt.MapFrom(src => src.AcquisitionDate))
                    .ForMember(dest => dest.AcquisitionCost, opt => opt.MapFrom(src => src.AcquisitionCost))
                    .ForMember(dest => dest.ExpectedLifetimeMonths, opt => opt.MapFrom(src => src.ExpectedLifetimeMonths))
                    .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => src.SupplierId))
                    .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                    .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                    .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                    .ForMember(dest => dest.WarrantyExpiry, opt => opt.MapFrom(src => src.WarrantyExpiry))
                    .ForMember(dest => dest.LastMaintenanceDate, opt => opt.MapFrom(src => src.LastMaintenanceDate))
                    .ForMember(dest => dest.NextMaintenanceDate, opt => opt.MapFrom(src => src.NextMaintenanceDate))
                    .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.Capacity))
                    .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.PhotoUrls ?? new List<string>()))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                #endregion
                config.CreateMap<DepartmentAvailability, DepartmentAvailabilityDto>().ReverseMap();
                #endregion
                #region SlotAssignment
                config.CreateMap<SlotAssignmentDto, SlotAssignment>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AssignedById, opt => opt.MapFrom(src => src.AssignedById))
                    .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
                    .ForMember(dest => dest.SlotId, opt => opt.MapFrom(src => src.SlotId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<SlotAssignment, SlotAssignmentDto>().ReverseMap();
                #endregion
                #region SchedulingConflict
                config.CreateMap<SchedulingConflictDto, SchedulingConflict>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.SlotId, opt => opt.MapFrom(src => src.SlotId))
                    .ForMember(dest => dest.ConflictType, opt => opt.MapFrom(src => src.ConflictType))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Severity, opt => opt.MapFrom(src => src.Severity))
                    .ForMember(dest => dest.Resolved, opt => opt.MapFrom(src => src.Resolved))
                    .ForMember(dest => dest.ResolvedById, opt => opt.MapFrom(src => src.ResolvedById))
                    .ForMember(dest => dest.ResolutionNotes, opt => opt.MapFrom(src => src.ResolutionNotes))
                    .ForMember(dest => dest.ResolutionDate, opt => opt.MapFrom(src => src.ResolutionDate))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted)); // Assuming these fields are auto-handled

                config.CreateMap<SchedulingConflict, SchedulingConflictDto>().ReverseMap();
                #endregion
                #region SchedulingPreference
                config.CreateMap<SchedulingPreferenceDto, SchedulingPreference>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.PreferenceKey, opt => opt.MapFrom(src => src.PreferenceKey))
                    .ForMember(dest => dest.PreferenceValue, opt => opt.MapFrom(src => src.PreferenceValue))
                    .ForMember(dest => dest.IsEnforced, opt => opt.MapFrom(src => src.IsEnforced))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<SchedulingPreference, SchedulingPreferenceDto>().ReverseMap();
                #endregion
                #region WorkflowStatus Mapping
                config.CreateMap<WorkflowStatusDto, WorkflowStatus>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.CurrentStage, opt => opt.MapFrom(src => src.CurrentStage))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.ExpectedCompletion, opt => opt.MapFrom(src => src.ExpectedCompletion))
                    .ForMember(dest => dest.ActualCompletion, opt => opt.MapFrom(src => src.ActualCompletion))
                    .ForMember(dest => dest.DelayStatus, opt => opt.MapFrom(src => src.DelayStatus))
                    .ForMember(dest => dest.DelayReason, opt => opt.MapFrom(src => src.DelayReason))
                    .ForMember(dest => dest.CustomerNotified, opt => opt.MapFrom(src => src.CustomerNotified))
                    .ForMember(dest => dest.QualityInspectionStatus, opt => opt.MapFrom(src => src.QualityInspectionStatus))
                    .ForMember(dest => dest.ReadyForDelivery, opt => opt.MapFrom(src => src.ReadyForDelivery))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<WorkflowStatus, WorkflowStatusDto>().ReverseMap();
                #endregion
                #region Appointment
                config.CreateMap<AppointmentDto, Appointment>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.AppointmentDate))
                    .ForMember(dest => dest.AppointmentTime, opt => opt.MapFrom(src => src.AppointmentTime))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.EstimatedDuration, opt => opt.MapFrom(src => src.EstimatedDuration))
                    .ForMember(dest => dest.Source, opt => opt.MapFrom(src => src.Source))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.PreferredBayType, opt => opt.MapFrom(src => src.PreferredBayType))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Appointment, AppointmentDto>().ReverseMap();
                #endregion
                #region ServiceBay
                config.CreateMap<ServiceBay, ServiceBayDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))


                    .ForMember(dest => dest.Allocations, opt => opt.MapFrom(src => src.Allocations ?? new List<string>()))
                    .ForMember(dest => dest.BayNumber, opt => opt.MapFrom(src => src.BayNumber))
                    .ForMember(dest => dest.BayType, opt => opt.MapFrom(src => src.BayType))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))

                    .ForMember(dest => dest.HasCompressedAir, opt => opt.MapFrom(src => src.HasCompressedAir))
                    .ForMember(dest => dest.HasPowerSupply, opt => opt.MapFrom(src => src.HasPowerSupply))
                    .ForMember(dest => dest.HasWaterSupply, opt => opt.MapFrom(src => src.HasWaterSupply))
                    .ForMember(dest => dest.Height, opt => opt.MapFrom(src => src.Height))
                    .ForMember(dest => dest.Length, opt => opt.MapFrom(src => src.Length))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.MaintenanceSchedules, opt => opt.MapFrom(src => src.MaintenanceSchedules ?? new List<string>()))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Reservations, opt => opt.MapFrom(src => src.Reservations ?? new List<string>()))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.Width, opt => opt.MapFrom(src => src.Width))
                    .ForMember(dest => dest.AcquisitionCost, opt => opt.MapFrom(src => src.AcquisitionCost))
                    .ForMember(dest => dest.AcquisitionDate, opt => opt.MapFrom(src => src.AcquisitionDate))
                    .ForMember(dest => dest.Capacity, opt => opt.MapFrom(src => src.Capacity))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.ExpectedLifetimeMonths, opt => opt.MapFrom(src => src.ExpectedLifetimeMonths))
                    .ForMember(dest => dest.LastMaintenanceDate, opt => opt.MapFrom(src => src.LastMaintenanceDate))
                    .ForMember(dest => dest.LiftCapacity, opt => opt.MapFrom(src => src.LiftCapacity))
                    .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                    .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                    .ForMember(dest => dest.NextMaintenanceDate, opt => opt.MapFrom(src => src.NextMaintenanceDate))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))

                    .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                    .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => src.SupplierId))
                    .ForMember(dest => dest.WarrantyExpiry, opt => opt.MapFrom(src => src.WarrantyExpiry))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ServiceBayDto, ServiceBay>().ReverseMap();
                #endregion
                #region ServicePackage
                config.CreateMap<ServicePackageDto, ServicePackage>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.PackageType, opt => opt.MapFrom(src => src.PackageType))
                    .ForMember(dest => dest.ValidityDays, opt => opt.MapFrom(src => src.ValidityDays))
                    .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                    .ForMember(dest => dest.TermsAndConditions, opt => opt.MapFrom(src => src.TermsAndConditions))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ServicePackage, ServicePackageDto>().ReverseMap();
                #endregion
                #region ServicePackageItem 
                config.CreateMap<ServicePackageItemDto, ServicePackageItem>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.PackageId, opt => opt.MapFrom(src => src.PackageId))
                    .ForMember(dest => dest.ServiceItemId, opt => opt.MapFrom(src => src.ServiceItemId))
                    .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                    .ForMember(dest => dest.DiscountPercentage, opt => opt.MapFrom(src => src.DiscountPercentage))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted)); // Assuming these fields exist

                config.CreateMap<ServicePackageItem, ServicePackageItemDto>().ReverseMap();
                #endregion
                #region QCInspection
                config.CreateMap<QCInspectionDto, QCInspection>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.InspectionDate, opt => opt.MapFrom(src => src.InspectionDate))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.SupervisorComments, opt => opt.MapFrom(src => src.SupervisorComments))
                    .ForMember(dest => dest.TechnicalComments, opt => opt.MapFrom(src => src.TechnicalComments))
                    .ForMember(dest => dest.InspectorId, opt => opt.MapFrom(src => src.InspectorId))
                    .ForMember(dest => dest.ModuleId, opt => opt.MapFrom(src => src.ModuleId))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<QCInspection, QCInspectionDto>().ReverseMap();
                #endregion
                #region QCCheckItem
                config.CreateMap<QCCheckItemDto, QCCheckItem>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ModuleId, opt => opt.MapFrom(src => src.ModuleId))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.IsMandatory, opt => opt.MapFrom(src => src.IsMandatory))
                    .ForMember(dest => dest.ExpectedValue, opt => opt.MapFrom(src => src.ExpectedValue))
                    .ForMember(dest => dest.ValidationRule, opt => opt.MapFrom(src => src.ValidationRule))
                    .ForMember(dest => dest.SequenceNumber, opt => opt.MapFrom(src => src.SequenceNumber))
                    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                    .ForMember(dest => dest.FailureSeverity, opt => opt.MapFrom(src => src.FailureSeverity))
                    .ForMember(dest => dest.RequiresPhoto, opt => opt.MapFrom(src => src.RequiresPhoto))
                    .ForMember(dest => dest.RequiresMeasurement, opt => opt.MapFrom(src => src.RequiresMeasurement))
                    .ForMember(dest => dest.MeasurementUnit, opt => opt.MapFrom(src => src.MeasurementUnit))
                    .ForMember(dest => dest.AcceptableRangeMin, opt => opt.MapFrom(src => src.AcceptableRangeMin))
                    .ForMember(dest => dest.AcceptableRangeMax, opt => opt.MapFrom(src => src.AcceptableRangeMax))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<QCCheckItem, QCCheckItemDto>().ReverseMap();
                #endregion
                #region QCModule
                config.CreateMap<QCModuleDto, QCModule>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.IsGeneralQc, opt => opt.MapFrom(src => src.IsGeneralQc))
                    .ForMember(dest => dest.SequenceNumber, opt => opt.MapFrom(src => src.SequenceNumber))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<QCModule, QCModuleDto>().ReverseMap();
                #endregion
                #region QCRework
                config.CreateMap<QCReworkDto, QCRework>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.InspectionId, opt => opt.MapFrom(src => src.InspectionId))
                    .ForMember(dest => dest.OriginalJobAllocationId, opt => opt.MapFrom(src => src.OriginalJobAllocationId))
                    .ForMember(dest => dest.ReworkJobAllocationId, opt => opt.MapFrom(src => src.ReworkJobAllocationId))
                    .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.AssignedToId, opt => opt.MapFrom(src => src.AssignedToId))
                    .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.Deadline))
                    .ForMember(dest => dest.CompletionDate, opt => opt.MapFrom(src => src.CompletionDate))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.VerificationDate, opt => opt.MapFrom(src => src.VerificationDate))
                    .ForMember(dest => dest.VerifiedById, opt => opt.MapFrom(src => src.VerifiedById))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<QCRework, QCReworkDto>().ReverseMap();

                #endregion
                #region QCResult
                config.CreateMap<QCResultDto, QCResult>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.InspectionId, opt => opt.MapFrom(src => src.InspectionId))
                    .ForMember(dest => dest.InspectorId, opt => opt.MapFrom(src => src.InspectorId))
                    .ForMember(dest => dest.CheckItemId, opt => opt.MapFrom(src => src.CheckItemId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                    .ForMember(dest => dest.Measurement, opt => opt.MapFrom(src => src.Measurement))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.PhotoUrls))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<QCResult, QCResultDto>().ReverseMap();
                #endregion
                #region QCDefectHistory
                config.CreateMap<QCDefectHistoryDto, QCDefectHistory>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.DefectId, opt => opt.MapFrom(src => src.DefectId))
                    .ForMember(dest => dest.FromStatus, opt => opt.MapFrom(src => src.FromStatus))
                    .ForMember(dest => dest.ToStatus, opt => opt.MapFrom(src => src.ToStatus))
                    .ForMember(dest => dest.ChangedById, opt => opt.MapFrom(src => src.ChangedById))
                    .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<QCDefectHistory, QCDefectHistoryDto>().ReverseMap();
                #endregion
                #region QCDefect
                config.CreateMap<QCDefectDto, QCDefect>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.InspectionId, opt => opt.MapFrom(src => src.InspectionId))
                    .ForMember(dest => dest.CheckItemId, opt => opt.MapFrom(src => src.CheckItemId))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Resolution, opt => opt.MapFrom(src => src.Resolution))
                    .ForMember(dest => dest.Severity, opt => opt.MapFrom(src => src.Severity))
                    .ForMember(dest => dest.ReportedById, opt => opt.MapFrom(src => src.ReportedById))
                    .ForMember(dest => dest.AssignedToId, opt => opt.MapFrom(src => src.AssignedToId))
                    .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.PhotoUrls))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    // .ForMember(dest => dest.StatusHistory, opt => opt.MapFrom(src => src.StatusHistory))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<QCDefect, QCDefectDto>().ReverseMap();
                #endregion
                #region CustomerContactPersonAddress
                config.CreateMap<CustomerContactPersonAddressDto, CustomerContactPersonAddress>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
                    .ForMember(dest => dest.AddressType, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.BuildingName, opt => opt.MapFrom(src => src.BuildingName))
                    .ForMember(dest => dest.StreetAddress, opt => opt.MapFrom(src => src.StreetAddress))
                    .ForMember(dest => dest.Landmark, opt => opt.MapFrom(src => src.Landmark))
                    .ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.CityId))
                    .ForMember(dest => dest.StateId, opt => opt.MapFrom(src => src.StateId))
                    .ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.CountryId))
                    .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomerContactPersonAddress, CustomerContactPersonAddressDto>().ReverseMap();
                #endregion
                #region CustomerContactPersonContact
                config.CreateMap<CustomerContactPersonContactDto, CustomerContactPersonContact>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId))
                    .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                    .ForMember(dest => dest.IsPrimary, opt => opt.MapFrom(src => src.IsPrimary))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomerContactPersonContact, CustomerContactPersonContactDto>().ReverseMap();
                #endregion
                #region QCTemplate
                config.CreateMap<QCTemplateDto, QCTemplate>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.JobTypeId, opt => opt.MapFrom(src => src.JobTypeId))
                    .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.Version, opt => opt.MapFrom(src => src.Version))
                    .ForMember(dest => dest.EffectiveFrom, opt => opt.MapFrom(src => src.EffectiveFrom))
                    .ForMember(dest => dest.EffectiveTo, opt => opt.MapFrom(src => src.EffectiveTo))
                    //.ForMember(dest => dest.Modules, opt => opt.MapFrom(src => src.Modules))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<QCTemplate, QCTemplateDto>().ReverseMap();
                #endregion
                #region ServiceReminder

                config.CreateMap<ServiceReminderDto, ServiceReminder>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomerVehicleId, opt => opt.MapFrom(src => src.CustomerVehicleId))
                    .ForMember(dest => dest.DueDate, opt => opt.MapFrom(src => src.DueDate))
                    .ForMember(dest => dest.IsSent, opt => opt.MapFrom(src => src.IsSent))
                    .ForMember(dest => dest.ReminderType, opt => opt.MapFrom(src => src.ReminderType))
                    .ForMember(dest => dest.ServiceIntervalKilometers, opt => opt.MapFrom(src => src.ServiceIntervalKilometers))
                    .ForMember(dest => dest.ServiceIntervalMonths, opt => opt.MapFrom(src => src.ServiceIntervalMonths))
                    .ForMember(dest => dest.LastServiceDate, opt => opt.MapFrom(src => src.LastServiceDate))
                    .ForMember(dest => dest.NextReminderDate, opt => opt.MapFrom(src => src.NextReminderDate))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.SentDate, opt => opt.MapFrom(src => src.SentDate))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ServiceReminder, ServiceReminderDto>().ReverseMap();

                #endregion
                #region ServiceFeedback
                config.CreateMap<ServiceFeedbackDto, ServiceFeedback>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.FeedbackType, opt => opt.MapFrom(src => src.FeedbackType))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments))
                    .ForMember(dest => dest.PriceSatisfactionRating, opt => opt.MapFrom(src => src.PriceSatisfactionRating))
                    .ForMember(dest => dest.QualityRating, opt => opt.MapFrom(src => src.QualityRating))
                    .ForMember(dest => dest.ResponseTimeRating, opt => opt.MapFrom(src => src.ResponseTimeRating))
                    .ForMember(dest => dest.StaffBehaviorRating, opt => opt.MapFrom(src => src.StaffBehaviorRating))
                    .ForMember(dest => dest.WouldRecommend, opt => opt.MapFrom(src => src.WouldRecommend))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ServiceFeedback, ServiceFeedbackDto>().ReverseMap();
                #endregion
                #region MilestoneStatusHistory
                config.CreateMap<MilestoneStatusHistoryDto, MilestoneStatusHistory>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ChangedById, opt => opt.MapFrom(src => src.ChangedById))
                    .ForMember(dest => dest.FromStatus, opt => opt.MapFrom(src => src.FromStatus))
                    .ForMember(dest => dest.MilestoneId, opt => opt.MapFrom(src => src.MilestoneId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.ToStatus, opt => opt.MapFrom(src => src.ToStatus))
                    .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));

                config.CreateMap<MilestoneStatusHistory, MilestoneStatusHistoryDto>().ReverseMap();
                #endregion
                #region MilestoneTracker
                config.CreateMap<MilestoneTrackerDto, MilestoneTracker>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.IsCustomerVisible, opt => opt.MapFrom(src => src.IsCustomerVisible))
                    .ForMember(dest => dest.MilestoneType, opt => opt.MapFrom(src => src.MilestoneType))
                    .ForMember(dest => dest.NotificationSent, opt => opt.MapFrom(src => src.NotificationSent))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.StatusHistory, opt => opt.MapFrom(src => src.StatusHistory))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.ActualTime, opt => opt.MapFrom(src => src.ActualTime))
                    .ForMember(dest => dest.ExpectedTime, opt => opt.MapFrom(src => src.ExpectedTime))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.ResponsibleUserId, opt => opt.MapFrom(src => src.ResponsibleUserId));

                config.CreateMap<MilestoneTracker, MilestoneTrackerDto>().ReverseMap();
                #endregion
                #region NotificationDelivery
                config.CreateMap<NotificationDeliveryDto, NotificationDelivery>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AttemptedTime, opt => opt.MapFrom(src => src.AttemptedTime))
                    .ForMember(dest => dest.Channel, opt => opt.MapFrom(src => src.Channel))
                    .ForMember(dest => dest.NotificationId, opt => opt.MapFrom(src => src.NotificationId))
                    .ForMember(dest => dest.RecipientId, opt => opt.MapFrom(src => src.RecipientId))
                    .ForMember(dest => dest.RetryCount, opt => opt.MapFrom(src => src.RetryCount))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.DeliveredTime, opt => opt.MapFrom(src => src.DeliveredTime))
                    .ForMember(dest => dest.ErrorMessage, opt => opt.MapFrom(src => src.ErrorMessage))
                    .ForMember(dest => dest.ExternalReference, opt => opt.MapFrom(src => src.ExternalReference));

                config.CreateMap<NotificationDelivery, NotificationDeliveryDto>().ReverseMap();
                #endregion
                #region NotificationPreference
                config.CreateMap<NotificationPreferenceDto, NotificationPreference>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.IsEnabled))
                    .ForMember(dest => dest.PriorityThreshold, opt => opt.MapFrom(src => src.PriorityThreshold))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                    .ForMember(dest => dest.Channel, opt => opt.MapFrom(src => src.Channel))
                    .ForMember(dest => dest.MilestoneType, opt => opt.MapFrom(src => src.MilestoneType))
                    .ForMember(dest => dest.NotificationType, opt => opt.MapFrom(src => src.NotificationType))
                    .ForMember(dest => dest.QuietHoursStart, opt => opt.MapFrom(src => src.QuietHoursStart))
                    .ForMember(dest => dest.QuietHoursEnd, opt => opt.MapFrom(src => src.QuietHoursEnd));

                config.CreateMap<NotificationPreference, NotificationPreferenceDto>().ReverseMap();
                #endregion
                #region NotificationRecipient
                config.CreateMap<NotificationRecipientDto, NotificationRecipient>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Channels, opt => opt.MapFrom(src => src.Channels))
                    .ForMember(dest => dest.IsRead, opt => opt.MapFrom(src => src.IsRead))
                    .ForMember(dest => dest.NotificationId, opt => opt.MapFrom(src => src.NotificationId))
                    .ForMember(dest => dest.RecipientId, opt => opt.MapFrom(src => src.RecipientId))
                    .ForMember(dest => dest.RecipientType, opt => opt.MapFrom(src => src.RecipientType))
                    .ForMember(dest => dest.ReadTime, opt => opt.MapFrom(src => src.ReadTime))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));

                config.CreateMap<NotificationRecipient, NotificationRecipientDto>().ReverseMap();
                #endregion
                #region Notification

                config.CreateMap<NotificationDto, Notification>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.NotificationType, opt => opt.MapFrom(src => src.NotificationType))
                    .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                    .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                    .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.TemplateId))
                    .ForMember(dest => dest.ExpiryTime, opt => opt.MapFrom(src => src.ExpiryTime))
                    .ForMember(dest => dest.JobAllocationId, opt => opt.MapFrom(src => src.JobAllocationId))
                    .ForMember(dest => dest.MilestoneType, opt => opt.MapFrom(src => src.MilestoneType))
                    .ForMember(dest => dest.RuleId, opt => opt.MapFrom(src => src.RuleId))
                    .ForMember(dest => dest.ScheduleSlotId, opt => opt.MapFrom(src => src.ScheduleSlotId))
                    .ForMember(dest => dest.ScheduledTime, opt => opt.MapFrom(src => src.ScheduledTime))
                    .ForMember(dest => dest.SentTime, opt => opt.MapFrom(src => src.SentTime))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById));

                config.CreateMap<Notification, NotificationDto>().ReverseMap();

                #endregion
                #region NotificationRule

                config.CreateMap<NotificationRuleDto, NotificationRule>()
                    .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.TemplateId))
                    .ForMember(dest => dest.MilestoneType, opt => opt.MapFrom(src => src.MilestoneType))
                    .ForMember(dest => dest.TriggerType, opt => opt.MapFrom(src => src.TriggerType))
                    .ForMember(dest => dest.TriggerCondition, opt => opt.MapFrom(src => src.TriggerCondition))
                    .ForMember(dest => dest.RecipientRoles, opt => opt.MapFrom(src => src.RecipientRoles))
                    .ForMember(dest => dest.Channels, opt => opt.MapFrom(src => src.Channels))
                    .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.DelayMinutes, opt => opt.MapFrom(src => src.DelayMinutes))
                    .ForMember(dest => dest.RepeatInterval, opt => opt.MapFrom(src => src.RepeatInterval))
                    .ForMember(dest => dest.MaxRepeats, opt => opt.MapFrom(src => src.MaxRepeats))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<NotificationRule, NotificationRuleDto>().ReverseMap();

                #endregion
                #region NotificationTemplate
                config.CreateMap<NotificationTemplateDto, NotificationTemplate>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                    .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body))
                    .ForMember(dest => dest.MilestoneType, opt => opt.MapFrom(src => src.MilestoneType))
                    .ForMember(dest => dest.NotificationType, opt => opt.MapFrom(src => src.NotificationType))
                    .ForMember(dest => dest.Channels, opt => opt.MapFrom(src => src.Channels))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                    .ForMember(dest => dest.Variables, opt => opt.MapFrom(src => src.Variables))
                    .ForMember(dest => dest.DefaultPriority, opt => opt.MapFrom(src => src.DefaultPriority))
                    .ForMember(dest => dest.LocalizedTemplates, opt => opt.MapFrom(src => src.LocalizedTemplates))
                    .ForMember(dest => dest.Rules, opt => opt.MapFrom(src => src.Rules))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<NotificationTemplate, NotificationTemplateDto>().ReverseMap();
                #endregion
                #region LocalizedTemplate
                config.CreateMap<LocalizedTemplateDto, LocalizedTemplate>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body))
                    .ForMember(dest => dest.LanguageCode, opt => opt.MapFrom(src => src.LanguageCode))
                    .ForMember(dest => dest.Subject, opt => opt.MapFrom(src => src.Subject))
                    .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.TemplateId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<LocalizedTemplate, LocalizedTemplateDto>().ReverseMap();
                #endregion
                #region ReworkAuthorization
                config.CreateMap<ReworkAuthorizationDto, ReworkAuthorization>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ApprovalDate, opt => opt.MapFrom(src => src.ApprovalDate))
                    .ForMember(dest => dest.AuthorizedById, opt => opt.MapFrom(src => src.AuthorizedById))
                    .ForMember(dest => dest.CorrectiveActions, opt => opt.MapFrom(src => src.CorrectiveActions))
                    .ForMember(dest => dest.CostResponsibility, opt => opt.MapFrom(src => src.CostResponsibility))
                    .ForMember(dest => dest.InvestigationFindings, opt => opt.MapFrom(src => src.InvestigationFindings))
                    .ForMember(dest => dest.OriginalTicketId, opt => opt.MapFrom(src => src.OriginalTicketId))
                    .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                    .ForMember(dest => dest.ReworkTicketId, opt => opt.MapFrom(src => src.ReworkTicketId))
                    .ForMember(dest => dest.ValidityPeriod, opt => opt.MapFrom(src => src.ValidityPeriod))
                    .ForMember(dest => dest.WarrantyApplicable, opt => opt.MapFrom(src => src.WarrantyApplicable))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ReworkAuthorization, ReworkAuthorizationDto>().ReverseMap();
                #endregion
                #region TenantIdentity
                config.CreateMap<TenantIdentityDto, TenantIdentity>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => src.DocumentId))
                    .ForMember(dest => dest.IdentityTypeId, opt => opt.MapFrom(src => src.IdentityTypeId))
                    .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<TenantIdentity, TenantIdentityDto>().ReverseMap();

                #endregion
                #region Manufacturer
                config.CreateMap<ManufacturerDto, Manufacturer>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.ContactInfo, opt => opt.MapFrom(src => src.ContactInfo))
                    .ForMember(dest => dest.Website, opt => opt.MapFrom(src => src.Website))
                    .ForMember(dest => dest.LogoUrl, opt => opt.MapFrom(src => src.LogoUrl))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Manufacturer, ManufacturerDto>().ReverseMap();
                #endregion
                #region PartPrice
                config.CreateMap<PartPriceDto, PartPrice>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CostPrice, opt => opt.MapFrom(src => src.CostPrice))
                    .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                    .ForMember(dest => dest.EffectiveFrom, opt => opt.MapFrom(src => src.EffectiveFrom))
                    .ForMember(dest => dest.IsCurrent, opt => opt.MapFrom(src => src.IsCurrent))
                    .ForMember(dest => dest.MarkupPercentage, opt => opt.MapFrom(src => src.MarkupPercentage))
                    .ForMember(dest => dest.PartId, opt => opt.MapFrom(src => src.PartId))
                    .ForMember(dest => dest.SellingPrice, opt => opt.MapFrom(src => src.SellingPrice))
                    .ForMember(dest => dest.EffectiveTo, opt => opt.MapFrom(src => src.EffectiveTo))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<PartPrice, PartPriceDto>().ReverseMap();
                #endregion
                #region Unit
                config.CreateMap<UnitDto, Unit>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Abbreviation, opt => opt.MapFrom(src => src.Abbreviation))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.BaseUnitId, opt => opt.MapFrom(src => src.BaseUnitId))
                    .ForMember(dest => dest.ConversionFactor, opt => opt.MapFrom(src => src.ConversionFactor))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Unit, UnitDto>().ReverseMap();
                #endregion
                #region CustomerProfile 
                config.CreateMap<CustomerProfileDto, CustomerProfile>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                    .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                    .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                    .ForMember(dest => dest.Salutation, opt => opt.MapFrom(src => src.Salutation))
                    .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.MiddleName))
                    .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                    .ForMember(dest => dest.ImageId, opt => opt.MapFrom(src => src.ImageId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomerProfile, CustomerProfileDto>().ReverseMap();
                #endregion
                #region Supplier
                config.CreateMap<SupplierDto, Supplier>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                    .ForMember(dest => dest.BankDetails, opt => opt.MapFrom(src => src.BankDetails))
                    .ForMember(dest => dest.ContactPerson, opt => opt.MapFrom(src => src.ContactPerson))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.PaymentTerms, opt => opt.MapFrom(src => src.PaymentTerms))
                    .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.TaxId, opt => opt.MapFrom(src => src.TaxId))
                    .ForMember(dest => dest.Website, opt => opt.MapFrom(src => src.Website))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreditLimit, opt => opt.MapFrom(src => src.CreditLimit))
                    .ForMember(dest => dest.Supply, opt => opt.MapFrom(src => src.SuppliedParts))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Supplier, SupplierDto>().ReverseMap();
                #endregion
                #region AppPreference
                config.CreateMap<AppPreferenceDto, AppPreference>()
                   .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                   .ForMember(dest => dest.Theme, opt => opt.MapFrom(src => src.Theme))
                   .ForMember(dest => dest.LanguageId, opt => opt.MapFrom(src => src.LanguageId))
                   .ForMember(dest => dest.PrimaryColor, opt => opt.MapFrom(src => src.PrimaryColor))
                   .ForMember(dest => dest.SecondaryColor, opt => opt.MapFrom(src => src.SecondaryColor))
                   .ForMember(dest => dest.FontSize, opt => opt.MapFrom(src => src.FontSize))
                   .ForMember(dest => dest.NotificationsEnabled, opt => opt.MapFrom(src => src.NotificationsEnabled))
                   .ForMember(dest => dest.AnimationsEnabled, opt => opt.MapFrom(src => src.AnimationsEnabled))
                   .ForMember(dest => dest.DefaultCurrencyId, opt => opt.MapFrom(src => src.DefaultCurrencyId))
                   .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                   .ForMember(dest => dest.Logo, opt => opt.MapFrom(src => src.Logo))
                   .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                   .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                   .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                   .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                   .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                   .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                   .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                   .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                   .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                   .ForMember(dest => dest.TimeZone, opt => opt.MapFrom(src => src.TimeZone))
                   .ForMember(dest => dest.DateFormat, opt => opt.MapFrom(src => src.DateFormat))
                   .ForMember(dest => dest.TimeFormat, opt => opt.MapFrom(src => src.TimeFormat))
                   .ForMember(dest => dest.StartOfWeek, opt => opt.MapFrom(src => src.StartOfWeek));
                config.CreateMap<AppPreference, AppPreferenceDto>();
                #endregion
                #region Invoice
                config.CreateMap<InvoiceDto, Invoice>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                    .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                    .ForMember(dest => dest.JobAllocationId, opt => opt.MapFrom(src => src.JobAllocationId))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.AdvanceInvoiceId, opt => opt.MapFrom(src => src.AdvanceInvoiceId))
                    .ForMember(dest => dest.ExcessInvoiceId, opt => opt.MapFrom(src => src.ExcessInvoiceId))
                    .ForMember(dest => dest.ParentInvoiceId, opt => opt.MapFrom(src => src.ParentInvoiceId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.InvoiceDate, opt => opt.MapFrom(src => src.InvoiceDate))
                    .ForMember(dest => dest.InvoiceNumber, opt => opt.MapFrom(src => src.InvoiceNumber))
                    .ForMember(dest => dest.InvoiceType, opt => opt.MapFrom(src => src.InvoiceType))
                    .ForMember(dest => dest.SubTotal, opt => opt.MapFrom(src => src.SubTotal))
                    .ForMember(dest => dest.TaxAmount, opt => opt.MapFrom(src => src.TaxAmount))
                    .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalAmount))
                    .ForMember(dest => dest.BalanceAmount, opt => opt.MapFrom(src => src.BalanceAmount))
                    .ForMember(dest => dest.ClaimNumber, opt => opt.MapFrom(src => src.ClaimNumber))
                    .ForMember(dest => dest.CreditDebitNotes, opt => opt.MapFrom(src => src.CreditDebitNotes))
                    .ForMember(dest => dest.CreditNoteNumber, opt => opt.MapFrom(src => src.CreditNoteNumber))
                    .ForMember(dest => dest.DiscountAmount, opt => opt.MapFrom(src => src.DiscountAmount))
                    .ForMember(dest => dest.DueDate, opt => opt.MapFrom(src => src.DueDate))
                    .ForMember(dest => dest.IsTaxInclusive, opt => opt.MapFrom(src => src.IsTaxInclusive))
                    .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items))
                    .ForMember(dest => dest.LpoDate, opt => opt.MapFrom(src => src.LpoDate))
                    .ForMember(dest => dest.LpoNumber, opt => opt.MapFrom(src => src.LpoNumber))
                    .ForMember(dest => dest.PaidAmount, opt => opt.MapFrom(src => src.PaidAmount))
                    .ForMember(dest => dest.PaymentTerms, opt => opt.MapFrom(src => src.PaymentTerms))
                    .ForMember(dest => dest.PoliceReportNumber, opt => opt.MapFrom(src => src.PoliceReportNumber))
                    .ForMember(dest => dest.Remarks, opt => opt.MapFrom(src => src.Remarks))
                    .ForMember(dest => dest.RoundOffAmount, opt => opt.MapFrom(src => src.RoundOffAmount))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.StatusHistory, opt => opt.MapFrom(src => src.StatusHistory))
                    .ForMember(dest => dest.TermsAndConditions, opt => opt.MapFrom(src => src.TermsAndConditions))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Invoice, InvoiceDto>().ReverseMap();
                #endregion
                #region Activity
                config.CreateMap<ActivityDto, Activity>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Activity, ActivityDto>().ReverseMap();
                #endregion
                #region StockAllocation
                config.CreateMap<StockAllocationDto, StockAllocation>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.AllocatedById, opt => opt.MapFrom(src => src.AllocatedById))
                    .ForMember(dest => dest.JobAllocationId, opt => opt.MapFrom(src => src.JobAllocationId))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                    .ForMember(dest => dest.QuantityAllocated, opt => opt.MapFrom(src => src.QuantityAllocated))
                    .ForMember(dest => dest.QuantityRequested, opt => opt.MapFrom(src => src.QuantityRequested))
                    .ForMember(dest => dest.RequestedById, opt => opt.MapFrom(src => src.RequestedById))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.StockItemId, opt => opt.MapFrom(src => src.StockItemId))
                    .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<StockAllocation, StockAllocationDto>().ReverseMap();
                #endregion
                #region StockItem
                config.CreateMap<StockItemDto, StockItem>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.BatchNumber, opt => opt.MapFrom(src => src.BatchNumber))
                    .ForMember(dest => dest.Condition, opt => opt.MapFrom(src => src.Condition))
                    .ForMember(dest => dest.Cost, opt => opt.MapFrom(src => src.Cost))
                    .ForMember(dest => dest.ExpiryDate, opt => opt.MapFrom(src => src.ExpiryDate))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.PartId, opt => opt.MapFrom(src => src.PartId))
                    .ForMember(dest => dest.PurchaseOrderId, opt => opt.MapFrom(src => src.PurchaseOrderId))
                    .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                    .ForMember(dest => dest.ReservedForTicketId, opt => opt.MapFrom(src => src.ReservedForTicketId))
                    .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(src => src.SerialNumber))
                    .ForMember(dest => dest.Source, opt => opt.MapFrom(src => src.Source))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<StockItem, StockItemDto>().ReverseMap();
                #endregion
                #region PurchaseOrder
                config.CreateMap<PurchaseOrderDto, PurchaseOrder>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ApprovalDate, opt => opt.MapFrom(src => src.ApprovalDate))
                    .ForMember(dest => dest.ApprovedById, opt => opt.MapFrom(src => src.ApprovedById))
                    .ForMember(dest => dest.CurrencyId, opt => opt.MapFrom(src => src.CurrencyId))
                    .ForMember(dest => dest.ExpectedDeliveryDate, opt => opt.MapFrom(src => src.ExpectedDeliveryDate))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate))
                    .ForMember(dest => dest.PaymentTerms, opt => opt.MapFrom(src => src.PaymentTerms))
                    .ForMember(dest => dest.PoNumber, opt => opt.MapFrom(src => src.PoNumber))
                    .ForMember(dest => dest.ShippingTerms, opt => opt.MapFrom(src => src.ShippingTerms))
                    .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => src.SupplierId))
                    .ForMember(dest => dest.TotalAmount, opt => opt.MapFrom(src => src.TotalAmount))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<PurchaseOrder, PurchaseOrderDto>().ReverseMap();
                #endregion

                //  #region PurchaseOrderReciept
                //             config.CreateMap<PurchaseOrderReceipt, PurchaseOrderReceiptDto>()
                //         .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items.Select(i => i.Id)));

                //     config.CreateMap<PurchaseOrderReceiptDto, PurchaseOrderReceipt>()
                //     .ForMember(dest => dest.Items, opt => opt.Ignore()); 
                //     #endregion
                #region PurchaseOrderReceipt

                config.CreateMap<PurchaseOrderReceiptDto, PurchaseOrderReceipt>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.DeliveryNoteNumber, opt => opt.MapFrom(src => src.DeliveryNoteNumber))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.ReceiptDate, opt => opt.MapFrom(src => src.ReceiptDate))
                    .ForMember(dest => dest.ReceiptNumber, opt => opt.MapFrom(src => src.ReceiptNumber))
                    .ForMember(dest => dest.PurchaseOrderId, opt => opt.MapFrom(src => src.PurchaseOrderId))
                    .ForMember(dest => dest.ReceivedById, opt => opt.MapFrom(src => src.ReceivedById))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                      .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items
                        .Select(id => new PurchaseOrderReceiptItem { Id = id }).ToList()));

                config.CreateMap<PurchaseOrderReceipt, PurchaseOrderReceiptDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.DeliveryNoteNumber, opt => opt.MapFrom(src => src.DeliveryNoteNumber))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.ReceiptDate, opt => opt.MapFrom(src => src.ReceiptDate))
                    .ForMember(dest => dest.ReceiptNumber, opt => opt.MapFrom(src => src.ReceiptNumber))
                    .ForMember(dest => dest.PurchaseOrderId, opt => opt.MapFrom(src => src.PurchaseOrderId))
                    .ForMember(dest => dest.ReceivedById, opt => opt.MapFrom(src => src.ReceivedById))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                    .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                     .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items
                        .Select(i => i.Id).ToList()));

                #endregion
                #region CustomField
                config.CreateMap<CustomFieldDto, CustomField>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.EntityType, opt => opt.MapFrom(src => src.EntityType))
                    .ForMember(dest => dest.FieldName, opt => opt.MapFrom(src => src.FieldName))
                    .ForMember(dest => dest.FieldType, opt => opt.MapFrom(src => src.FieldType))
                    .ForMember(dest => dest.IsRequired, opt => opt.MapFrom(src => src.IsRequired))
                    .ForMember(dest => dest.DefaultValue, opt => opt.MapFrom(src => src.DefaultValue))
                    .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Options))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomField, CustomFieldDto>().ReverseMap();
                #endregion
                #region CustomFieldValue
                config.CreateMap<CustomFieldValueDto, CustomFieldValue>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CustomFieldId, opt => opt.MapFrom(src => src.CustomFieldId))
                    .ForMember(dest => dest.EntityType, opt => opt.MapFrom(src => src.EntityType))
                    .ForMember(dest => dest.EntityId, opt => opt.MapFrom(src => src.EntityId))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<CustomFieldValue, CustomFieldValueDto>().ReverseMap();
                #endregion
                #region StockTransaction
                config.CreateMap<StockTransactionDto, StockTransaction>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.FromLocationId, opt => opt.MapFrom(src => src.FromLocationId))
                    .ForMember(dest => dest.ToLocationId, opt => opt.MapFrom(src => src.ToLocationId))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.PerformedById, opt => opt.MapFrom(src => src.PerformedById))
                    .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                    .ForMember(dest => dest.ReferenceNumber, opt => opt.MapFrom(src => src.ReferenceNumber))
                    .ForMember(dest => dest.ReferenceType, opt => opt.MapFrom(src => src.ReferenceType))
                    .ForMember(dest => dest.StockItemId, opt => opt.MapFrom(src => src.StockItemId))
                    .ForMember(dest => dest.TransactionType, opt => opt.MapFrom(src => src.TransactionType))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<StockTransaction, StockTransactionDto>().ReverseMap();
                #endregion
                #region ResourceReservation
                config.CreateMap<ResourceReservationDto, ResourceReservation>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.ResourceId, opt => opt.MapFrom(src => src.ResourceId))
                    .ForMember(dest => dest.Priority, opt => opt.MapFrom(src => src.Priority))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.ReservedById, opt => opt.MapFrom(src => src.ReservedById))
                    .ForMember(dest => dest.ReservationType, opt => opt.MapFrom(src => src.ReservationType))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.JobAllocationId, opt => opt.MapFrom(src => src.JobAllocationId))
                    .ForMember(dest => dest.MaintenanceScheduleId, opt => opt.MapFrom(src => src.MaintenanceScheduleId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ResourceReservation, ResourceReservationDto>().ReverseMap();
                #endregion
                #region PartSupplier
                config.CreateMap<PartSupplierDto, PartSupplier>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.PartId, opt => opt.MapFrom(src => src.PartId))
                    .ForMember(dest => dest.SupplierId, opt => opt.MapFrom(src => src.SupplierId))
                    .ForMember(dest => dest.IsPreferred, opt => opt.MapFrom(src => src.IsPreferred))
                    .ForMember(dest => dest.LeadTimeDays, opt => opt.MapFrom(src => src.LeadTimeDays))
                    .ForMember(dest => dest.MinimumOrderQuantity, opt => opt.MapFrom(src => src.MinimumOrderQuantity))
                    .ForMember(dest => dest.UnitCost, opt => opt.MapFrom(src => src.UnitCost))
                    .ForMember(dest => dest.LastPurchaseDate, opt => opt.MapFrom(src => src.LastPurchaseDate))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Rating))
                    .ForMember(dest => dest.SupplierPartNumber, opt => opt.MapFrom(src => src.SupplierPartNumber))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<PartSupplier, PartSupplierDto>().ReverseMap();
                #endregion
                #region Part
                config.CreateMap<PartDto, Part>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.PartNumber, opt => opt.MapFrom(src => src.PartNumber))
                    .ForMember(dest => dest.ManufacturerId, opt => opt.MapFrom(src => src.ManufacturerId))
                    .ForMember(dest => dest.UnitId, opt => opt.MapFrom(src => src.UnitId))
                    .ForMember(dest => dest.Barcode, opt => opt.MapFrom(src => src.Barcode))
                    .ForMember(dest => dest.DefaultLocationId, opt => opt.MapFrom(src => src.DefaultLocationId))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.Dimensions, opt => opt.MapFrom(src => src.Dimensions))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.OemNumber, opt => opt.MapFrom(src => src.OemNumber))
                    .ForMember(dest => dest.PhotoUrls, opt => opt.MapFrom(src => src.PhotoUrls))
                    .ForMember(dest => dest.IsLotControlled, opt => opt.MapFrom(src => src.IsLotControlled))
                    .ForMember(dest => dest.IsSerialized, opt => opt.MapFrom(src => src.IsSerialized))
                    .ForMember(dest => dest.MaxStockLevel, opt => opt.MapFrom(src => src.MaxStockLevel))
                    .ForMember(dest => dest.MinStockLevel, opt => opt.MapFrom(src => src.MinStockLevel))
                    .ForMember(dest => dest.ReorderLevel, opt => opt.MapFrom(src => src.ReorderLevel))
                    .ForMember(dest => dest.ShelfLifeMonths, opt => opt.MapFrom(src => src.ShelfLifeMonths))
                    .ForMember(dest => dest.WarrantyPeriod, opt => opt.MapFrom(src => src.WarrantyPeriod))
                    .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Weight))
                    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                    .ForMember(dest => dest.Prices, opt => opt.MapFrom(src => src.Prices))
                    .ForMember(dest => dest.Suppliers, opt => opt.MapFrom(src => src.Suppliers))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Part, PartDto>().ReverseMap();
                #endregion
                #region ResourceAllocation
                config.CreateMap<ResourceAllocationDto, ResourceAllocation>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.ResourceId, opt => opt.MapFrom(src => src.ResourceId))
                    .ForMember(dest => dest.JobAllocationId, opt => opt.MapFrom(src => src.JobAllocationId))
                    .ForMember(dest => dest.AllocatedById, opt => opt.MapFrom(src => src.AllocatedById))
                    .ForMember(dest => dest.AllocatedToId, opt => opt.MapFrom(src => src.AllocatedToId))
                    .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                    .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                    .ForMember(dest => dest.Purpose, opt => opt.MapFrom(src => src.Purpose))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ResourceAllocation, ResourceAllocationDto>().ReverseMap();
                #endregion
                #region ResourceLocation
                config.CreateMap<ResourceLocationDto, ResourceLocation>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.ParentLocationId, opt => opt.MapFrom(src => src.ParentLocationId))
                    .ForMember(dest => dest.LocationType, opt => opt.MapFrom(src => src.LocationType))
                    .ForMember(dest => dest.Floor, opt => opt.MapFrom(src => src.Floor))
                    .ForMember(dest => dest.Building, opt => opt.MapFrom(src => src.Building))
                    .ForMember(dest => dest.Area, opt => opt.MapFrom(src => src.Area))
                    .ForMember(dest => dest.Resources, opt => opt.MapFrom(src => src.Resources))
                    .ForMember(dest => dest.ChildLocations, opt => opt.MapFrom(src => src.ChildLocations))

                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ResourceLocation, ResourceLocationDto>().ReverseMap();
                #endregion
                #region ResourceCertification
                config.CreateMap<ResourceCertificationDto, ResourceCertification>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.CertificateNumber, opt => opt.MapFrom(src => src.CertificateNumber))
                    .ForMember(dest => dest.CertificationType, opt => opt.MapFrom(src => src.CertificationType))
                    .ForMember(dest => dest.ExpiryDate, opt => opt.MapFrom(src => src.ExpiryDate))
                    .ForMember(dest => dest.IssueDate, opt => opt.MapFrom(src => src.IssueDate))
                    .ForMember(dest => dest.IssuingAuthority, opt => opt.MapFrom(src => src.IssuingAuthority))
                    .ForMember(dest => dest.RenewalReminderDays, opt => opt.MapFrom(src => src.RenewalReminderDays))
                    .ForMember(dest => dest.ResourceId, opt => opt.MapFrom(src => src.ResourceId))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.DocumentUrl, opt => opt.MapFrom(src => src.DocumentUrl))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ResourceCertification, ResourceCertificationDto>().ReverseMap();
                #endregion
                #region ResourceMetric
                config.CreateMap<ResourceMetricDto, ResourceMetric>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.MeasurementDate, opt => opt.MapFrom(src => src.MeasurementDate))
                    .ForMember(dest => dest.MetricType, opt => opt.MapFrom(src => src.MetricType))
                    .ForMember(dest => dest.RecordedById, opt => opt.MapFrom(src => src.RecordedById))
                    .ForMember(dest => dest.ResourceId, opt => opt.MapFrom(src => src.ResourceId))
                    .ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.Unit))
                    .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Value))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<ResourceMetric, ResourceMetricDto>().ReverseMap();
                #endregion
                #region Role
                config.CreateMap<RoleDto, Role>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<Role, RoleDto>().ReverseMap();
                #endregion
                #region RolePermission
                config.CreateMap<RolePermissionDto, RolePermission>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.PermissionId, opt => opt.MapFrom(src => src.PermissionId))
                    .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<RolePermission, RolePermissionDto>().ReverseMap();
                #endregion
                #region PurchaseOrderItem
                config.CreateMap<PurchaseOrderItemDto, PurchaseOrderItem>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.ExpectedDeliveryDate, opt => opt.MapFrom(src => src.ExpectedDeliveryDate))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.PartId, opt => opt.MapFrom(src => src.PartId))
                    .ForMember(dest => dest.PurchaseOrderId, opt => opt.MapFrom(src => src.PurchaseOrderId))
                    .ForMember(dest => dest.QuantityOrdered, opt => opt.MapFrom(src => src.QuantityOrdered))
                    .ForMember(dest => dest.QuantityReceived, opt => opt.MapFrom(src => src.QuantityReceived))
                    .ForMember(dest => dest.ReceivedDate, opt => opt.MapFrom(src => src.ReceivedDate))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                    .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.TotalPrice))
                    .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<PurchaseOrderItem, PurchaseOrderItemDto>().ReverseMap();
                #endregion
                #region PurchaseOrderReceiptItem
                config.CreateMap<PurchaseOrderReceiptItemDto, PurchaseOrderReceiptItem>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.BatchNumber, opt => opt.MapFrom(src => src.BatchNumber))
                    .ForMember(dest => dest.Condition, opt => opt.MapFrom(src => src.Condition))
                    .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                    .ForMember(dest => dest.QuantityReceived, opt => opt.MapFrom(src => src.QuantityReceived))
                    .ForMember(dest => dest.SerialNumbers, opt => opt.MapFrom(src => src.SerialNumbers))
                    .ForMember(dest => dest.LocationId, opt => opt.MapFrom(src => src.LocationId))
                    .ForMember(dest => dest.PurchaseOrderItemId, opt => opt.MapFrom(src => src.PurchaseOrderItemId))
                    .ForMember(dest => dest.ReceiptId, opt => opt.MapFrom(src => src.ReceiptId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<PurchaseOrderReceiptItem, PurchaseOrderReceiptItemDto>().ReverseMap();
                #endregion
                #region FuelType
                config.CreateMap<FuelTypeDto, FuelType>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<FuelType, FuelTypeDto>().ReverseMap();
                #endregion
                #region RepairType
                config.CreateMap<RepairTypeDto, RepairType>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.CustomerCategoryId, opt => opt.MapFrom(src => src.CustomerCategoryId))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));

                config.CreateMap<RepairType, RepairTypeDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                    .ForMember(dest => dest.CustomerCategoryId, opt => opt.MapFrom(src => src.CustomerCategoryId))
                    .ForMember(dest => dest.CustomerCategoryName, opt => opt.MapFrom(src => src.CustomerCategory.Name))
                    .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId))
                    .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                    .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                    .ForMember(dest => dest.CreatedById, opt => opt.MapFrom(src => src.CreatedById))
                    .ForMember(dest => dest.DeletedById, opt => opt.MapFrom(src => src.DeletedById))
                    .ForMember(dest => dest.UpdatedById, opt => opt.MapFrom(src => src.UpdatedById))
                    .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted));
                #endregion
            });
            return mappingConfig;
        }
    }
}
