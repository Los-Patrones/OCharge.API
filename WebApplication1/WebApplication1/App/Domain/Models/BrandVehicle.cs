namespace WebApplication1.App.Domain;

public class BrandVehicle
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public Vehicle Vehicle { get; set; }
    public int VehicleId { get; set; }
}