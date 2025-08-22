using EunigosApi.Models.Entity.Common;

namespace EunigosApi.Models.Entity.AbstractEntities
{
    public abstract class AddressBase : AuditInfo
    {
        public string BuildingName { get; set; }

        public string StreetAddress { get; set; }

        public string Landmark { get; set; }

        public string CityId { get; set; }

        public string StateId { get; set; }

        public string CountryId { get; set; }

        public string PostalCode { get; set; }

        public string LocationId { get; set; }

         public bool IsPrimary { get; set; }


        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Location { get; set; }

    }
}
