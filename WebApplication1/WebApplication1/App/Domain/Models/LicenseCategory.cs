namespace WebApplication1.App.Domain;

public class LicenseCategory
{
    public int Id { get; set; }
    public int Type { get; set; }
    public Vehicle Vehicle { get; set; }
    public int VehicleId { get; set; }
}