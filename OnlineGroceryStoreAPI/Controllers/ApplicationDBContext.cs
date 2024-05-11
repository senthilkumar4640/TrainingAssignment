
using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryStoreAPI.Data;

namespace OnlineGroceryStoreAPI.Controllers
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior",true);

        }

        public DbSet<UserDetails> userList {get; set;}
        
        public DbSet<ProductDetails> productList {get; set;}

        public DbSet<OrderDetails> orderList {get; set;}
        public DbSet<BookingDetails> bookingList {get; set;}
    }
}