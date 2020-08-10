using Microsoft.EntityFrameworkCore;
using Persistence_Layer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence_Layer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            //modelBuilder.Entity<UserRole>()

            //    .HasKey(t => new { t.UserId, t.RoleId });



            //modelBuilder.Entity<UserRole>()

            //    .HasOne(pt => pt.User)

            //    .WithMany(p => p.UserRole)

            //    .HasForeignKey(pt => pt.UserId);



            //modelBuilder.Entity<UserRole>()

            //    .HasOne(pt => pt.Role)

            //    .WithMany(t => t.UserRole)

            //    .HasForeignKey(pt => pt.RoleId);



            //modelBuilder.Entity<Role>().HasData(

            //    new Role { Id = 1, Description = "Admin" },

            //    new Role { Id = 2, Description = "User" },

            //    new Role { Id = 3, Description = "Viewer" }

            //);



            //modelBuilder.Entity<Business>().HasData(

            //    new Business { Id = 1, Address1 = "Address 1", Address2 = "Address 2", Name = "Business Name", State = "zz", ZipCode = "zzzzz" }

            //);



            modelBuilder.Entity<Group>().HasData(

                new Group { Id = 1, Description = "Group A" }

            );

        }

    }
}
