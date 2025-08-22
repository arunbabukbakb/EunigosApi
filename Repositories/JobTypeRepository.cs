    using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.JobCardManagement;
using EunigosApi.Repositories.Currencies;
using EunigosApi.Repositories.JobTypeManagement.JobTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.JobCardManagement.JobTypes
{
    public class JobTypeRepository : Repository<JobType>, IJobTypeRepository
    {

        private ApplicationDbContext _db;
        public JobTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
