using API_StoresWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace API_StoresWeb.Data
{
    public class StoresWebAPIDbContact : DbContext
    {
        public StoresWebAPIDbContact(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UsersModel> Users { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
    }
}
