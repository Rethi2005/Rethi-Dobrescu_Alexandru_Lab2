using Microsoft.EntityFrameworkCore;
using Rethi_Dobrescu_Alexandru_Lab2.Models;

public class Rethi_Dobrescu_Alexandru_Lab2Context(DbContextOptions<Rethi_Dobrescu_Alexandru_Lab2Context> options) : DbContext(options)
{
    public DbSet<Rethi_Dobrescu_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Publisher> Publisher { get; set; }
    public DbSet<Author> Author { get; set; }
}
