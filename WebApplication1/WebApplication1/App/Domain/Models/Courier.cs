namespace WebApplication1.App.Domain;

public class Courier
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public int LicenseCategoryId { get; set; }
    public int UserId { get; set; }
    public int DNI { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string BirthDay { get; set; }
    public string Email { get; set; }
    public string LicenseNumber { get; set; }
    //RelationsShip one many
    public List<Vehicle> Vehicles  { get; set; } = new List<Vehicle>();
    public List<LicenseCategory> LicenseCategories  { get; set; } = new List<LicenseCategory>();
    public List<Service> Services { get; set; } = new List<Service>();
}