using EunigosApi.Models.Dto;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.TicketManagement;
using AutoMapper;
namespace EunigosApi.Models.AutoMappers
{
    public class EstimateMapping : Profile
    {
        public EstimateMapping()
        {

            CreateMap<Ticket, EstimateDto>()
                .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName))
                .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.Owner.FirstName))
                .ForMember(dest => dest.CorporateName, opt => opt.MapFrom(src => src.Corporate.FirstName))
                .ForMember(dest => dest.ContactPersonId, opt => opt.MapFrom(src => src.CustomerContactPersonId))
                .ForMember(dest => dest.ContactNumber, opt => opt.MapFrom(src => src.ContactPerson.ContactNumber))
                .ForMember(dest => dest.VehicleName, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleManufacturers.Name + "-" + src.CustomerVehicle.VehicleModels.Name + "-" + src.CustomerVehicle.Year))
                .ForMember(dest => dest.VehicleNumber, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleNumber))
                .ForMember(dest => dest.VINNumber, opt => opt.MapFrom(src => src.CustomerVehicle.VINNumber))
                .ForMember(dest => dest.ManufactureId, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleManufacturerId))
                .ForMember(dest => dest.ModelId, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleModelId))
                .ForMember(dest => dest.Kilometers, opt => opt.MapFrom(src => src.VehicleInspection.OdometerReading))
                .ForMember(dest => dest.AdvisorName, opt => opt.MapFrom(src => src.Advisor.UserName));

            CreateMap<Estimate, EstimateDto>()
                .ForMember(dest => dest.TicketNumber, opt => opt.MapFrom(src => src.Ticket.TicketNumber))
                .ForMember(dest => dest.RepairtypeId, opt => opt.MapFrom(src => src.Ticket.RepairTypeId))
                .ForMember(dest => dest.JobtypeId, opt => opt.MapFrom(src => src.Ticket.JobTypeId))
                .ForMember(dest => dest.JobtypeName, opt => opt.MapFrom(src => src.Ticket.JobType.Name))
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.Ticket.CustomerId))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Ticket.Customer.FirstName))
                .ForMember(dest => dest.OwnerId, opt => opt.MapFrom(src => src.Ticket.OwnerId))
                .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.Ticket.Owner.FirstName))
                .ForMember(dest => dest.CorporateName, opt => opt.MapFrom(src => src.Ticket.Corporate.FirstName))
                .ForMember(dest => dest.CorporateId, opt => opt.MapFrom(src => src.Ticket.CorporateId))
                .ForMember(dest => dest.ContactPersonId, opt => opt.MapFrom(src => src.Ticket.CustomerContactPersonId))
                .ForMember(dest => dest.ContactPersonName, opt => opt.MapFrom(src => src.Ticket.ContactPerson.Name))
                .ForMember(dest => dest.ContactNumber, opt => opt.MapFrom(src => src.Ticket.ContactPerson.ContactNumber))
                .ForMember(dest => dest.CustomerVehicleId, opt => opt.MapFrom(src => src.Ticket.CustomerVehicleId))
                .ForMember(dest => dest.VehicleName, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VehicleManufacturers.Name + "-" + src.Ticket.CustomerVehicle.VehicleModels.Name + "-" + src.Ticket.CustomerVehicle.Year))
                .ForMember(dest => dest.VehicleNumber, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VehicleNumber))
                .ForMember(dest => dest.VINNumber, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VINNumber))
                .ForMember(dest => dest.Kilometers, opt => opt.MapFrom(src => src.Ticket.VehicleInspection.OdometerReading))
                .ForMember(dest => dest.ManufactureId, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VehicleManufacturerId))
                .ForMember(dest => dest.ModelId, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VehicleModelId))
                .ForMember(dest => dest.AdvisorId, opt => opt.MapFrom(src => src.Ticket.AdvisorId))
                .ForMember(dest => dest.AdvisorName, opt => opt.MapFrom(src => src.Ticket.Advisor.UserName))
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.EstimateItems))
                .ForMember(dest => dest.Insurance, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.InsuranceDetail))
                .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.EstimateDocuments));


            CreateMap<EstimateDto, Estimate>();
            #region Related DTO Mappings

            CreateMap<EstimateItem, EstimateItemDto>().ReverseMap();
            CreateMap<EstimateDocument, EstimateDocumentDto>().ReverseMap();
            CreateMap<EstimateApproval, EstimateApprovalDto>().ReverseMap();
            CreateMap<CustomerVehicle, CustomerVehicleDto>().ReverseMap();
            CreateMap<CustomerContactPerson, CustomerContactPersonDto>().ReverseMap();

            #endregion


        }
    }
}
