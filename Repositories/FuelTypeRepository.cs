using EunigosApi.Data;
using EunigosApi.FilteringPagination;
using EunigosApi.Models;
using EunigosApi.Models.CommonModels;
using EunigosApi.Models.Entity.VehicleManagement;
using EunigosApi.Repositories.Currencies;
using Microsoft.EntityFrameworkCore;

namespace EunigosApi.Repositories.FuelTypes;

public class FuelTypeRepository : Repository<FuelType>, IFuelTypeRepository
{

    private ApplicationDbContext _db;
    public FuelTypeRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
}
