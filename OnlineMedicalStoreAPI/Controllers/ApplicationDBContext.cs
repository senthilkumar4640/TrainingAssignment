using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineMedicalStoreAPI.Data;

namespace OnlineMedicalStoreAPI.Controllers
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
    public DbSet<User> userList {get; set;}
    public DbSet<MedicalInfo> medicineList {get; set;}
    public DbSet<Order> orderList {get; set;}
    }
}