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
        CreateMap<PaymentMethod, PaymentMethodResource>();
        CreateMap<PaymentService, PaymentServiceResource>();
        CreateMap<Person, PersonResource>();
        CreateMap<Service, ServiceResource>();
        CreateMap<User, UserResource>();
        CreateMap<UserRequest, UserRequestResource>();
        CreateMap<Vehicle, VehicleResource>();
        CreateMap<License, LicenseResource>();
    }
}