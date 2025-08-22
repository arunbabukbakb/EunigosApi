using EunigosApi.Extensions;
using EunigosApi.Models.Dto;
using EunigosApi.Models.Entity.EstimateManagement;
using EunigosApi.Models.Entity.TicketManagement;
using EunigosApi.Models.Entity.VehicleManagement;
using AutoMapper;

namespace EunigosApi.Models.AutoMappers
{
    public class TicketMapping : Profile
    {
        public TicketMapping()
        {
            CreateMap<Ticket, TicketDto>()
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.FirstName))
                .ForMember(dest => dest.OwnerName, opt => opt.MapFrom(src => src.Owner.FirstName))
                .ForMember(dest => dest.CorporateName, opt => opt.MapFrom(src => src.Corporate.FirstName))
                .ForMember(dest => dest.AdvisorName, opt => opt.MapFrom(src => src.Advisor.UserName))
                .ForMember(dest => dest.ContactPersonName, opt => opt.MapFrom(src => src.ContactPerson.Name))
                .ForMember(dest => dest.ContactNumber, opt => opt.MapFrom(src => src.ContactPerson.ContactNumber))
                .ForMember(dest => dest.EmailId, opt => opt.MapFrom(src => src.ContactPerson.Email))
                .ForMember(dest => dest.JobTypeName, opt => opt.MapFrom(src => src.JobType.Name))
                .ForMember(dest => dest.CustomerVehicleId, opt => opt.MapFrom(src => src.CustomerVehicle.Id))
                .ForMember(dest => dest.VehicleNumber, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleNumber))
                .ForMember(dest => dest.VehicleManufacturerId, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleManufacturerId))
                .ForMember(dest => dest.VehicleManufaturerName, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleManufacturers.Name))
                .ForMember(dest => dest.VehicleModelId, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleModelId))
                .ForMember(dest => dest.VehicleModelName, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleModels.Name))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.CustomerVehicle.Year))
                .ForMember(dest => dest.VINNumber, opt => opt.MapFrom(src => src.CustomerVehicle.VINNumber))
                .ForMember(dest => dest.EngineCode, opt => opt.MapFrom(src => src.CustomerVehicle.EngineCode))
                .ForMember(dest => dest.VehicleTypeId, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleTypeId))
                .ForMember(dest => dest.VehicleTypeName, opt => opt.MapFrom(src => src.CustomerVehicle.VehicleTypes.Name))
                .ForMember(dest => dest.FuelType, opt => opt.MapFrom(src => src.CustomerVehicle.FuelType))
                .ForMember(dest => dest.StatusName, opt => opt.MapFrom(src => src.Status.HasValue ? src.Status.Value.GetDescription() : null))
                .ForMember(dest => dest.Inspections, opt => opt.MapFrom(src => src.VehicleInspection));


            CreateMap<TicketDto, Ticket>();

            // VehicleInspection mapping
            CreateMap<VehicleInspection, VehicleInspectionDto>().ReverseMap();

            // ✅ Missing mapping: InspectionMedia → InspectionMediaDto
            CreateMap<InspectionMedia, InspectionMediaDto>().ReverseMap();
        }
	}
}
