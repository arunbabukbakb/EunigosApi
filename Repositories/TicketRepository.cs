using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Repositories.RepairTypes;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.Tickets
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {

        private ApplicationDbContext _db;
        public TicketRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
