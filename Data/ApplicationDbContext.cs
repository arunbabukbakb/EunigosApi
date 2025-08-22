using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity;
using EunigosApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Data;
using System.Security.Cryptography;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Models.Entity.EstimateManagement;

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
