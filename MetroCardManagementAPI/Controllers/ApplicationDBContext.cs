using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MetroCardManagementAPI.Data;

namespace MetroCardManagementAPI.Controllers
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
    public DbSet<UserDetails> userList {get; set;}
    public DbSet<TravelDetails> travelList {get; set;}
    public DbSet<TicketFairDetails> ticketFairList {get; set;}
    }
}