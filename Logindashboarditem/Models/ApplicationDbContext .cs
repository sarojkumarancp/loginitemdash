using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Logindashboarditem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ItemMaster> ItemMasters { get; set; }
    }
}