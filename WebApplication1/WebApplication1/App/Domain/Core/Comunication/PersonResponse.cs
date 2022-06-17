using WebApplication1.App.Domain.Models;
using WebApplication1.Shared.Domain.Core.Comunication;

namespace WebApplication1.App.Domain.Core.Comunication;

public class PersonResponse:BaseResponse<Person>
{
    public PersonResponse(Person resource) : base(resource)
    {
    }

    public PersonResponse(string message) : base(message)
    {
    }
}