using EunigosApi.Models.Dto;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.JobCardManagement;
using EunigosApi.Models.Entity.TicketManagement;
using AutoMapper;
using EunigosApi.Models.Entity;
namespace EunigosApi.Models.AutoMappers
{
    public class JobCardMapping : Profile
	{
		public JobCardMapping()
		{
			CreateMap<Estimate, JobCardDto>()
				.ForMember(dest => dest.Id, opt => opt.Ignore()) // Always empty when creating jobcard
				.ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
				.ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Ticket.Customer.FirstName))
				.ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.Ticket.Owner.FirstName))
				.ForMember(dest => dest.CorporateName, opt => opt.MapFrom(src => src.Ticket.Corporate.FirstName))
				.ForMember(dest => dest.ContactPersonId, opt => opt.MapFrom(src => src.Ticket.CustomerContactPersonId))
				.ForMember(dest => dest.ContactNumber, opt => opt.MapFrom(src => src.Ticket.ContactPerson.ContactNumber))
				.ForMember(dest => dest.VehicleName, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VehicleManufacturers.Name + "-" + src.Ticket.CustomerVehicle.VehicleModels.Name + "-" + src.Ticket.CustomerVehicle.Year))
				.ForMember(dest => dest.VINNumber, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VINNumber))
				.ForMember(dest => dest.ManufactureId, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VehicleManufacturerId))
				.ForMember(dest => dest.ModelId, opt => opt.MapFrom(src => src.Ticket.CustomerVehicle.VehicleModelId))
				.ForMember(dest => dest.Odometer, opt => opt.MapFrom(src => src.Kilometers))
				.ForMember(dest => dest.AdvisorName, opt => opt.MapFrom(src => src.Ticket.Advisor.UserName))
				.ForMember(dest => dest.JobtypeName, opt => opt.MapFrom(src => src.Ticket.JobType.Name));

			//.ForMember(dest => dest.CustomerComments, opt => opt.MapFrom(src => src.CustomerComments))
			//.ForMember(dest => dest.JobDescription, opt => opt.MapFrom(src => src.JobDescription))
			//.ForMember(dest => dest.VehicleDropDateTime, opt => opt.MapFrom(src => src.VehicleDropDateTime))
			//.ForMember(dest => dest.VehicleDropOdometerImage, opt => opt.MapFrom(src => src.VehicleDropOdometerImage))
			//.ForMember(dest => dest.VehicleDropOdometerReading, opt => opt.MapFrom(src => src.VehicleDropOdometerReading))
			// Child mappings
			CreateMap<EstimateItem, EstimateItemDto>();
			CreateMap<EstimateDocument, EstimateDocumentDto>();
			CreateMap<InsuranceDetail, InsuranceDetailDto>();




		}
	}
}
