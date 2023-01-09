﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartQueue.DataAccess.Concrete.EntityFramework.Context;

#nullable disable

namespace SmartQueue.DataAccess.Migrations
{
    [DbContext(typeof(SmartQueueDbContext))]
    partial class SmartQueueDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SmartQueue.Entity.Entities.Queue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Queues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8941),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Gular",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Azimli"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8944),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Ruslan",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Galandarli"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8946),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Laman",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Galandarli"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8960),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Nijat",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Mammadzada"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8962),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Ruslan",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Salahow"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8964),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Mecid",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Abdullayev"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8966),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Ata",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Babayev"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8968),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Nijat",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Aliyev"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8970),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Ali",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Nehmatov"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8972),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Samad",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Samadov"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8973),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Ehtiram",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Salayev"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8976),
                            Email = "ruslan.galandarli@gmail.com",
                            IsDeleted = false,
                            Name = "Kerim",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Mammadzada"
                        });
                });

            modelBuilder.Entity("SmartQueue.Entity.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8898),
                            IsDeleted = false,
                            Name = "Admin",
                            State = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8901),
                            IsDeleted = false,
                            Name = "User",
                            State = true
                        });
                });

            modelBuilder.Entity("SmartQueue.Entity.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8654),
                            Email = "admin@gmail.com",
                            HashedPassword = "jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=",
                            IsDeleted = false,
                            Name = "Admin",
                            PhoneNumber = "0559122536",
                            State = true,
                            Surname = "Admin"
                        });
                });

            modelBuilder.Entity("SmartQueue.Entity.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 10, 29, 15, 20, 26, 52, DateTimeKind.Local).AddTicks(8921),
                            IsDeleted = false,
                            RoleId = 1,
                            State = true,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SmartQueue.Entity.Entities.UserRole", b =>
                {
                    b.HasOne("SmartQueue.Entity.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQueue.Entity.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartQueue.Entity.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("SmartQueue.Entity.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
