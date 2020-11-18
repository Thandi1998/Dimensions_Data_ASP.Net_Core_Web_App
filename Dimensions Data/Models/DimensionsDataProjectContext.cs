using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Dimensions_Data.Models;

#nullable disable

namespace Dimensions_Data.Models
{
    public partial class DimensionsDataProjectContext : DbContext
    {
        public DimensionsDataProjectContext()
        {
        }

        public DimensionsDataProjectContext(DbContextOptions<DimensionsDataProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DepartmentsAndEducation> DepartmentsAndEducations { get; set; }
        public virtual DbSet<EmployeeBasicInfo> EmployeeBasicInfos { get; set; }
        public virtual DbSet<EmployeePersonal> EmployeePersonals { get; set; }
        public virtual DbSet<EmployeeWorkInfomation> EmployeeWorkInfomations { get; set; }
        public virtual DbSet<LoginInformation> LoginInformations { get; set; }
        public virtual DbSet<PerfomanceAndRate> PerfomanceAndRates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DimensionsDataProject;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentsAndEducation>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("DepartmentsAndEducation");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Education)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EducationField)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeCount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobInvolvement)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobLevel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobRole)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobSatisfaction)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeBasicInfo>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("employeeBasicInfo");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.Attrition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessTravel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DistanceFromHome)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EnvironmentSatisfaction)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeePersonal>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("employeePersonal");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Over18)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeWorkInfomation>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("employeeWorkInfomation");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.StockOptionLevel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TotalWorkingYears)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrainingTimesLastYear)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WorkLifeBalance)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearsAtCompany)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearsInCurrentRole)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.YearsSinceLastPromotion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LoginInformation>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.ToTable("loginInformation");

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("confirmPassword");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.EmployeeSurname).HasMaxLength(50);

                entity.Property(e => e.JobLevel).HasColumnName("jobLevel");

                entity.Property(e => e.JobRole)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("jobRole");

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<PerfomanceAndRate>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.Property(e => e.EmployeeNumber).ValueGeneratedNever();

                entity.Property(e => e.NumCompaniesWorked)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OverTime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RelationshipSatisfaction)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
