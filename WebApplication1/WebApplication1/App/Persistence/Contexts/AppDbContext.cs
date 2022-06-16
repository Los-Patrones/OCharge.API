using Microsoft.EntityFrameworkCore;
using WebApplication1.App.Domain;

namespace WebApplication1.App.Persistence.Contexts;

public class AppDbContext:DbContext
{
     public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<BrandVehicle>Buyers { get; set; }
        public DbSet<Courier>Collaborators { get; set; }
        public DbSet<LicenseCategory>Comments { get; set; }
        public DbSet<PaymentMethod>Designs { get; set; }
        public DbSet<PaymentService>DesignCollaborators { get; set; }
        public DbSet<Service>Designers { get; set; }
        public DbSet<User>Plans { get; set; }
        public DbSet<UserRequest>Posts { get; set; }
        public DbSet<Vehicle>PostDesigns { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            /*-----------------------Properties and keys-----------------------*/
        
            //BrandVehicle
            builder.Entity<BrandVehicle>().ToTable("BrandVehicles");
            builder.Entity<BrandVehicle>().HasKey(p => p.Id);
            builder.Entity<BrandVehicle>().Property(p=>p.Id).IsRequired();
            builder.Entity<BrandVehicle>().Property(p => p.Brand).HasMaxLength(50);
            
            //Courier
            builder.Entity<Courier>().ToTable("Couriers");
            builder.Entity<Courier>().HasKey(p => p.Id);
            builder.Entity<Courier>().Property(p=>p.Id).IsRequired();
            builder.Entity<Courier>().Property(p=>p.DNI).HasMaxLength(50);
            builder.Entity<Courier>().Property(p=>p.Name).HasMaxLength(50);
            builder.Entity<Courier>().Property(p=>p.LastName).HasMaxLength(50);
            builder.Entity<Courier>().Property(p=>p.BirthDay).HasMaxLength(10);
            builder.Entity<Courier>().Property(p=>p.Email).HasMaxLength(50);
            builder.Entity<Courier>().Property(p=>p.LicenseNumber);
            
            //LicenseCategory
            builder.Entity<LicenseCategory>().ToTable("LicenseCategories");
            builder.Entity<LicenseCategory>().HasKey(p => p.Id);
            builder.Entity<LicenseCategory>().Property(p=>p.Id).IsRequired();
            builder.Entity<LicenseCategory>().Property(p=>p.Type);
            
            //PaymentMethod
            builder.Entity<PaymentMethod>().ToTable("PaymentMethods");
            builder.Entity<PaymentMethod>().HasKey(p => p.Id);
            builder.Entity<PaymentMethod>().Property(p=>p.Id).IsRequired();
            builder.Entity<PaymentMethod>().Property(p=>p.Type);
            
            //PaymentService
            builder.Entity<PaymentService>().ToTable("PaymentServices");
            builder.Entity<PaymentService>().HasKey(p => p.Id);
            builder.Entity<PaymentService>().Property(p=>p.Id).IsRequired();
            builder.Entity<PaymentService>().Property(p=>p.CardUser);
            builder.Entity<PaymentService>().Property(p=>p.CardCourier);
            
            //Service
            builder.Entity<Service>().ToTable("Services");
            builder.Entity<Service>().HasKey(p => p.Id);
            builder.Entity<Service>().Property(p=>p.Id).IsRequired();
            builder.Entity<Service>().Property(p=>p.Finalized);
            
            //User
            builder.Entity<User>().ToTable("Users");
            builder.Entity<User>().HasKey(p => p.Id);
            builder.Entity<User>().Property(p=>p.Id).IsRequired();
            builder.Entity<User>().Property(p=>p.Phone).HasMaxLength(50);
            
            //UserRequest
            builder.Entity<UserRequest>().ToTable("UserRequests");
            builder.Entity<UserRequest>().HasKey(p => p.UserId);
            builder.Entity<UserRequest>().Property(p=>p.UserId).IsRequired();
            builder.Entity<UserRequest>().Property(p=>p.AddressStart).HasMaxLength(500);
            builder.Entity<UserRequest>().Property(p=>p.AddressEnd).HasMaxLength(500);
            builder.Entity<UserRequest>().Property(p=>p.ReferenceAddress).HasMaxLength(500);
            builder.Entity<UserRequest>().Property(p=>p.Photo).HasMaxLength(500);
            builder.Entity<UserRequest>().Property(p=>p.Description).HasMaxLength(500);
            builder.Entity<UserRequest>().Property(p=>p.Date).HasMaxLength(30);
            builder.Entity<UserRequest>().Property(p=>p.Hour).HasMaxLength(15);

            //Vehicle
            builder.Entity<Vehicle>().ToTable("Vehicles");
            builder.Entity<Vehicle>().HasKey(p => p.Id);
            builder.Entity<Vehicle>().Property(p=>p.Id).IsRequired();
            builder.Entity<Vehicle>().Property(p=>p.Plate).HasMaxLength(10);
            builder.Entity<Vehicle>().Property(p=>p.Photo).HasMaxLength(500);
            builder.Entity<Vehicle>().Property(p=>p.CirculationCard).HasMaxLength(50);
            
            /*----------------------- Relationships and Foreignkeys -----------------------*/
        
            // --------------------------- Courier -------------------------------- //
        
            //User with Plan
            builder.Entity<Courier>()
                .HasMany(p => p.LicenseCategories)
                .WithMany(p => p.Buyer)
                .HasForeignKey(p => p.PlanId);
        
            //Buyer with User
            builder.Entity<Buyer>()
                .HasOne(p => p.User)
                .WithOne(p => p.Buyer)
                .HasForeignKey<Buyer>(p => p.UserId)
                .IsRequired(false);
        
            //User with Comment
            builder.Entity<User>()
                .HasMany(p => p.Comments)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        
            // --------------------------- DESIGNER -------------------------------- //
        
            //Designer with User
            builder.Entity<Designer>()
                .HasOne(p => p.User)
                .WithOne(p => p.Designer)
                .HasForeignKey<Designer>(p => p.UserId)
                .IsRequired(false);
      
            //Design with Purchase
            builder.Entity<Design>()
                .HasMany(p => p.Purchases)
                .WithOne(p => p.Design)
                .HasForeignKey(p => p.DesignId);
        
            //Design with PostDesign
            builder.Entity<Design>()
                .HasMany(p => p.PostDesigns)
                .WithOne(p => p.Design)
                .HasForeignKey(p => p.DesignId)
                .IsRequired(false);
        
            //Design with Designer
            builder.Entity<Design>()
                .HasOne(p => p.Designer)
                .WithMany(p => p.Designs)
                .HasForeignKey(p => p.DesignerId);
        
            //Design with DesignCollaborator
            builder.Entity<Design>()
                .HasMany(p => p.DesignCollaborators)
                .WithOne(p => p.Design)
                .HasForeignKey(p => p.DesignId)
                .IsRequired(false);
            
        }
}
