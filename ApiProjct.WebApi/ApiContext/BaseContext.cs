using ApiProject.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjct.WebApi.ApiContext;

public class BaseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source =DESKTOP-IGIJEMI\\SQLEXPRESS; Initial Catalog = YemekDb; Integrated Security = True; ");
    }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Chef>? Chefs { get; set; }
    public DbSet<Contact>? Contacts { get; set; }
    public DbSet<Feature>? Features { get; set; }
    public DbSet<İmage>? İmages { get; set; }
    public DbSet<Message>? Massages { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Service>? Services { get; set; }
    public DbSet<Testimonial>? Testimonials { get; set; }
    public DbSet<Reservation>? Reservations { get; set; }
}
