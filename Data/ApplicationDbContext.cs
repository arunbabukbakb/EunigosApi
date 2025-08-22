using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity;
using EunigosApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Models.Entity.VehicleServiceManagement;
using EunigosApi.Models.Entity.RepairKitManagement;
using EunigosApi.Models.Entity.PartManagement;
using EunigosApi.Models.Entity.UserManagement;

namespace EunigosApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        //Registrations
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Estimate> Estimate { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<CustomerCategory> CustomerCategories { get; set; }
        public DbSet<VehicleInventory> VehicleInventories { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<RepairType> RepairTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<VehicleInventoryItem> VehicleInventoryItems { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<ConsumableItem> ConsumableItems { get; set; }
        public DbSet<OutsideWorkItem> OutsideWorkItems { get; set; }
        public DbSet<TypesOfParts> TypesOfParts { get; set; }
        public DbSet<SourceOfParts> SourceOfParts { get; set; }
        public DbSet<ItemServices> ItemServices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 10000;

        public string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt;
            //new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);
            RandomNumberGenerator.Create().GetBytes(salt = new byte[SaltSize]);

            // Create a hash using PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Combine the salt and hash
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert the byte array to a base64-encoded string
            string hashedPassword = Convert.ToBase64String(hashBytes);

            return hashedPassword;
        }

        //Update modified on default
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
