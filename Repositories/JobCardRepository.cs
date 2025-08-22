using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.JobCardManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.JobCardManagement.JobCards
{
    public class JobCardRepository : Repository<JobCard>, IJobCardRepository
    {

        private ApplicationDbContext _db;
        public JobCardRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
