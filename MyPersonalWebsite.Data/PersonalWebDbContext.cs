using Microsoft.EntityFrameworkCore;
using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Data.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyPersonalWebsite.Data
{
    public class PersonalWebDbContext : DbContext
    {
        public PersonalWebDbContext()
        {

        }
        public PersonalWebDbContext(DbContextOptions<PersonalWebDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost;Database=MyEcommerseApi; user=sa; password=test123;Trusted_Connection=True;TrustServerCertificate=true;");
            }
            optionsBuilder.AddInterceptors(new LoggingSavingChangesInterceptor());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<MaterialInformation> MaterialInformations { get; set; }
        public DbSet<GenericList> GenericLists { get; set; }
        public DbSet<ChangeLog> ChangeLogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UserSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new OrderStatusSeed(new int[] { 1, 2 ,3,4,5,6}));
            modelBuilder.ApplyConfiguration(new MaterialInformationSeed(new int[] { 1, 2, 3, 4, 5, 6 }));
            modelBuilder.ApplyConfiguration(new GenericListSeed(new int[] { 1, 2, 3, 4, 5, 6 }));

            modelBuilder.Entity<Order>()
        .HasIndex(e => e.CustomerOrderNo)
        .IsUnique();
        }
    }


}
