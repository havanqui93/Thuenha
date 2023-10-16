using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Thuenha.DATATHUENHA
{
    public partial class Dulieu : DbContext
    {
        public Dulieu()
            : base("name=Dulieu")
        {
        }

        public virtual DbSet<administrative_regions> administrative_regions { get; set; }
        public virtual DbSet<administrative_units> administrative_units { get; set; }
        public virtual DbSet<Dangnhap> Dangnhaps { get; set; }
        public virtual DbSet<district> districts { get; set; }
        public virtual DbSet<Gia> Gias { get; set; }
        public virtual DbSet<Locdientich> Locdientiches { get; set; }
        public virtual DbSet<phanloainha> phanloainhas { get; set; }
        public virtual DbSet<province> provinces { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Thongtinnha> Thongtinnhas { get; set; }
        public virtual DbSet<ward> wards { get; set; }
        public virtual DbSet<Dangky> Dangkies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<administrative_regions>()
                .HasMany(e => e.provinces)
                .WithOptional(e => e.administrative_regions)
                .HasForeignKey(e => e.administrative_region_id);

            modelBuilder.Entity<administrative_units>()
                .HasMany(e => e.districts)
                .WithOptional(e => e.administrative_units)
                .HasForeignKey(e => e.administrative_unit_id);

            modelBuilder.Entity<administrative_units>()
                .HasMany(e => e.provinces)
                .WithOptional(e => e.administrative_units)
                .HasForeignKey(e => e.administrative_unit_id);

            modelBuilder.Entity<administrative_units>()
                .HasMany(e => e.wards)
                .WithOptional(e => e.administrative_units)
                .HasForeignKey(e => e.administrative_unit_id);

            modelBuilder.Entity<Dangnhap>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Dangnhap>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Dangnhap>()
                .HasMany(e => e.Dangkies)
                .WithRequired(e => e.Dangnhap)
                .HasForeignKey(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<district>()
                .HasMany(e => e.wards)
                .WithOptional(e => e.district)
                .HasForeignKey(e => e.district_code);

            modelBuilder.Entity<Gia>()
                .Property(e => e.code)
                .IsFixedLength();

            modelBuilder.Entity<Locdientich>()
                .Property(e => e.code)
                .IsFixedLength();

            modelBuilder.Entity<phanloainha>()
                .Property(e => e.maloainha)
                .IsFixedLength();

            modelBuilder.Entity<phanloainha>()
                .HasMany(e => e.Thongtinnhas)
                .WithRequired(e => e.phanloainha)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<province>()
                .HasMany(e => e.districts)
                .WithOptional(e => e.province)
                .HasForeignKey(e => e.province_code);

            modelBuilder.Entity<Thongtinnha>()
                .Property(e => e.manha)
                .IsFixedLength();

            modelBuilder.Entity<Thongtinnha>()
                .Property(e => e.maloainha)
                .IsFixedLength();

            modelBuilder.Entity<Dangky>()
                .Property(e => e.User)
                .IsFixedLength();

            modelBuilder.Entity<Dangky>()
                .Property(e => e.Pass)
                .IsFixedLength();
        }
    }
}
