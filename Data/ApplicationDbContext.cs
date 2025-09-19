using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Contact> Contacts { get; set; }  // maps to Contacts table
}