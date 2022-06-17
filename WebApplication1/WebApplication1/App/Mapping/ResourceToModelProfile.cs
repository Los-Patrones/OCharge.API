using AutoMapper;
using WebApplication1.App.Domain;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Resources;

namespace WebApplication1.App.Mapping;

public class ResourceToModelProfile:Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveBrandVehicleResource, BrandVehicle>();
        CreateMap<SaveCourierResource, Courier>();
        CreateMap<SavePaymentMethodResource, PaymentMethod>();
        CreateMap<SavePaymentServiceResource, PaymentService>();
        CreateMap<SavePersonResource, Person>();
        CreateMap<SaveServiceResource, Service>();
        CreateMap<SaveUserResource, User>();
        CreateMap<SaveUserRequestResource, UserRequest>();
        CreateMap<SaveVehicleResource, Vehicle>();
    }
}