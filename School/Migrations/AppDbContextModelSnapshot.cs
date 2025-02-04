﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace School.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeFirst.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Abdulmajeed@gmail.com",
                            FirstName = "Abdulmajeed",
                            LastName = "Almaymuni"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Ahmed@gmail.com",
                            FirstName = "Ahmed",
                            LastName = "Almaymuni"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Abdullah@gmail.com",
                            FirstName = "Abdullah",
                            LastName = "Almaymuni"
                        });
                });

            modelBuilder.Entity("CodeFirst.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TeacherId = 1,
                            Title = "Math"
                        },
                        new
                        {
                            Id = 2,
                            TeacherId = 1,
                            Title = "Physics"
                        },
                        new
                        {
                            Id = 3,
                            TeacherId = 2,
                            Title = "Computer"
                        });
                });

            modelBuilder.Entity("CodeFirst.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "AAltuwaim@gmail.com",
                            FullName = "Abdullah Altuwaim"
                        },
                        new
                        {
                            Id = 2,
                            Email = "HAlsalman@gmail.com",
                            FullName = "Hatem Alsalman"
                        });
                });

            modelBuilder.Entity("CodeFirst.Models.Subject", b =>
                {
                    b.HasOne("CodeFirst.Models.Teacher", "Teacher")
                        .WithMany("Subject")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("CodeFirst.Models.Teacher", b =>
                {
                    b.Navigation("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}
