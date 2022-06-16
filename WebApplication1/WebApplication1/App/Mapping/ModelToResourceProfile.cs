using AutoMapper;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Resources;

namespace WebApplication1.App.Mapping;

public class ModelToResourceProfile:Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<BrandVehicle, BrandVehicleResource>();
        CreateMap<Courier, CourierResource>();
        CreateMap<PaymentService, PaymentServiceResource>();
        CreateMap<Service, ServiceResource>();
        CreateMap<UserRequest, UserRequestResource>();
        CreateMap<Vehicle, VehicleResource>();
    }
}