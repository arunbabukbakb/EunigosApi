using EunigosApi.Data;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Models;
using EunigosApi.Repositories.IRepository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
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
using EunigosApi.Repositories.JobCardManagement.JobTypes;
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

namespace EunigosApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

            Auth = new AuthRepository(_db);
            ConsumableItem = new ConsumableItemRepository(_db);
            Country = new CountryRepository(_db);
            Currency = new CurrencyRepository(_db);
            CustomerCategory = new CustomerCategoryRepository(_db);
            CustomerContactPerson = new CustomerContactPersonRepository(_db);
            Customer = new CustomerRepository(_db);
            EstimateDocument = new EstimateDocumentRepository(_db);
            EstimateItem = new EstimateItemRepository(_db);
            Estimate = new EstimateRepository(_db);
            FuelType = new FuelTypeRepository(_db);
            InventoryItem = new InventoryItemRepository(_db);
            ItemServices = new ItemServicesRepository(_db);
            JobCard = new JobCardRepository(_db);
            JobType = new JobTypeRepository(_db);
            Manufacturer = new ManufacturerRepository(_db);
            OutsideWorkItem = new OutsideWorkItemRepository(_db);
            RepairType = new RepairTypeRepository(_db);
            Role = new RoleRepository(_db);
            ServiceItem = new ServiceItemRepository(_db);
            SourceOfParts = new SourceOfPartsRepository(_db);
            State = new StateRepository(_db);
            Tax = new TaxRepository(_db);
            Ticket = new TicketRepository(_db);
            TypesOfParts = new TypesOfPartsRepository(_db);
        }

        public IAuthRepository Auth { get; private set; }
        public IConsumableItemRepository ConsumableItem { get; private set; }
        public ICountryRepository Country { get; private set; }
        public ICurrencyRepository Currency { get; private set; }
        public ICustomerCategoryRepository CustomerCategory { get; private set; }
        public ICustomerContactPersonRepository CustomerContactPerson { get; private set; }
        public ICustomerRepository Customer { get; private set; }
        public IEstimateDocumentRepository EstimateDocument { get; private set; }
        public IEstimateItemRepository EstimateItem { get; private set; }
        public IEstimateRepository Estimate { get; private set; }
        public IFuelTypeRepository FuelType { get; private set; }
        public IInventoryItemRepository InventoryItem { get; private set; }
        public IItemServicesRepository ItemServices { get; private set; }
        public IJobCardRepository JobCard { get; private set; }
        public IJobTypeRepository JobType { get; private set; }
        public IManufacturerRepository Manufacturer { get; private set; }
        public IOutsideWorkItemRepository OutsideWorkItem { get; private set; }
        public IRepairTypeRepository RepairType { get; private set; }
        public IRoleRepository Role { get; private set; }
        public IServiceItemRepository ServiceItem { get; private set; }
        public ISourceOfPartsRepository SourceOfParts { get; private set; }
        public IStateRepository State { get; private set; }
        public ITaxRepository Tax { get; private set; }
        public ITicketRepository Ticket { get; private set; }
        public ITypesOfPartsRepository TypesOfParts { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
        public void BeginTransaction()
        {
            _transaction = _db.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction?.Commit();
        }

        public void Rollback()
        {
            _transaction?.Rollback();
        }

        // Implement IDisposable interface for proper cleanup if needed
        public void Dispose()
        {
            _transaction?.Dispose();
            _db.Dispose();
        }
    }
}
