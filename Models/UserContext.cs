using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using Project.Models.DAO;

namespace ProjectCore.Models
{
    public class UserContext:DbContext
    {
        public DbSet<khachhang> khachhangs { get; set; }
        public DbSet<roletable> roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=project_dotnet;user=root;password=StrongPass123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<sanpham>(entity =>
            {
                entity.HasKey(e => e.idsanpham);
                entity.Property(e => e.idthongso).IsRequired();
                entity.HasOne(p => p.khuyenmai).WithOne(d => d.sanpham);
            });
            modelBuilder.Entity<khuyenmai>(entity =>
            {
                entity.HasKey(e => e.idKhuyenMai);
            });
        }
    }
}
