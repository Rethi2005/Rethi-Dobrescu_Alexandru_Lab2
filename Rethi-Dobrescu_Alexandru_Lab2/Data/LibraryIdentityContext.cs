
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rethi_Dobrescu_Alexandru_Lab2.Models;

namespace Rethi_Dobrescu_Alexandru_Lab2.Data;

public class LibraryIdentityContext(DbContextOptions<LibraryIdentityContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
}
