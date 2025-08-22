namespace EunigosApi.Models.Entity.Common
{
    public class Country :AuditInfo
    {
        public string Code { get; set; }  
        public string Name { get; set; }  
        public string CurrencyId { get; set; }  
        public string PhoneCode { get; set; }

        //Navigation Property
        public Currency Currency { get; set; }
        public Tenant Tenant { get; set; }  
        
        public ICollection<State> States { get; set; }  // Navigation Property to States
    }
}
