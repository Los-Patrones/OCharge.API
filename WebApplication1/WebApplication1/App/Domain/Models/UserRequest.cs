namespace WebApplication1.App.Domain.Models;
public class UserRequest
{
    //PK
    public User User { get; set; }
    public int UserId { get; set; }
    //Attributes
    public int AddressStart { get; set; }
    public int AddressEnd { get; set; }
    public string ReferenceAddress { get; set; }
    public string Photo { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Hour { get; set; }
    //RelationShip
    public List<Service> Services { get; set; } = new List<Service>();
    
}