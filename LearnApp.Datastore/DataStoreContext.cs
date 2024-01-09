using LearnApp.Datastore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Datastore
{
    public class DataStoreContext : DbContext
    {
        public DataStoreContext(DbContextOptions<DataStoreContext> options) : base(options)
        {
        }
        public DbSet<UserInformation> UserInformations { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UserInformation>().ToTable(nameof(UserInformation)).HasMany(c => c.Users);

        //}
    }
}
