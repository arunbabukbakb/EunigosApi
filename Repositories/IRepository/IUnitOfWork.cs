using EunigosApi.Repositories.Auth;
using EunigosApi.Repositories.ConsumableItems;
using EunigosApi.Repositories.Countries;
using EunigosApi.Repositories.Currencies;
using EunigosApi.Repositories.CustomerCategories;
using EunigosApi.Repositories.CustomerContactPersons;
using EunigosApi.Repositories.Customers;
using EunigosApi.Repositories.EstimateDocuments;
using EunigosApi.Repositories.EstimateItems;
using EunigosApi.Repositories.Estimates;
using EunigosApi.Repositories.FuelTypes;
using EunigosApi.Repositories.InventoryItems;
using EunigosApi.Repositories.JobCardManagement.JobCards;
using EunigosApi.Repositories.JobTypeManagement.JobTypes;
using EunigosApi.Repositories.Manufactures;
using EunigosApi.Repositories.OutsideWorkItems;
using EunigosApi.Repositories.PartManagement.ItemService;
using EunigosApi.Repositories.PartManagement.SourceOfPart;
using EunigosApi.Repositories.PartManagement.TypesOfPart;
using EunigosApi.Repositories.RepairTypes;
using EunigosApi.Repositories.Roles;
using EunigosApi.Repositories.Serviceitems;
using EunigosApi.Repositories.States;
using EunigosApi.Repositories.Taxes;
using EunigosApi.Repositories.Tickets;
using EunigosApi.Repositories.Users;
using EunigosApi.Repositories.VehicleInventories;
using EunigosApi.Repositories.VehicleModels;
using EunigosApi.Repositories.VehicleTypes;

namespace EunigosApi.Repositories.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthRepository Auth { get; }
        IConsumableItemRepository ConsumableItem { get; }
        ICountryRepository Country { get; }
        ICurrencyRepository Currency { get; }
        ICustomerCategoryRepository CustomerCategory { get; }
        ICustomerContactPersonRepository CustomerContactPerson { get; }
        ICustomerRepository Customer { get; }
        IEstimateDocumentRepository EstimateDocument { get; }
        IEstimateItemRepository EstimateItem { get; }
        IEstimateRepository Estimate { get; }
        IFuelTypeRepository FuelType { get; }
        IInventoryItemRepository InventoryItem { get; }
        IItemServicesRepository ItemServices { get; }
        IJobCardRepository JobCard { get; }
        IJobTypeRepository JobType { get; }
        IManufacturerRepository Manufacturer { get; }
        IOutsideWorkItemRepository OutsideWorkItem { get; }
        IRepairTypeRepository RepairType { get; }
        IRoleRepository Role { get; }
        IServiceItemRepository ServiceItem { get; }
        ISourceOfPartsRepository SourceOfParts { get; }
        IStateRepository State { get; }
        ITaxRepository Tax { get; }
        ITicketRepository Ticket { get; }
        ITypesOfPartsRepository TypesOfParts { get; }

        void Save();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }

}
