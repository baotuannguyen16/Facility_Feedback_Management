using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObject.Models
{
    public partial class FeedbackDBContext : DbContext
    {
        public FeedbackDBContext()
        {
        }

        public FeedbackDBContext(DbContextOptions<FeedbackDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server =(local); Database = FeedbackDB; Uid=sa; Pwd=123456789;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("Device");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoomNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.RoomNoNavigation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.RoomNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Device__RoomNo__2B3F6F97");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.CreateDate)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reply).HasMaxLength(500);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Feedback__Device__300424B4");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.FeedbackStaffs)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__Feedback__StaffI__30F848ED");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FeedbackUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Feedback__UserId__2F10007B");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RoomNo)
                    .HasName("PK__Room__328651AA37CC9644");

                entity.ToTable("Room");

                entity.Property(e => e.RoomNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
