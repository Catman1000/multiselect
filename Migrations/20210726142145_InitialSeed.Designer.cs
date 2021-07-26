﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using multiselect.Data;

namespace multiselect.Migrations
{
    [DbContext(typeof(MultiselectContext))]
    [Migration("20210726142145_InitialSeed")]
    partial class InitialSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.HasSequence<int>("OrderNumbers", "shared");

            modelBuilder.Entity("multiselect.Models.UserModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Selected")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SelectedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FullName = "Carson Li",
                            Selected = false,
                            SelectedDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            FullName = "Meredith Ivanova",
                            Selected = false,
                            SelectedDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 3,
                            FullName = "Arturo Jopalov",
                            Selected = false,
                            SelectedDate = new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 4,
                            FullName = "Gytis Peskha",
                            Selected = false,
                            SelectedDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 5,
                            FullName = "Yan Li",
                            Selected = false,
                            SelectedDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 6,
                            FullName = "Peggy Poo",
                            Selected = false,
                            SelectedDate = new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 7,
                            FullName = "Laura Dee",
                            Selected = false,
                            SelectedDate = new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 8,
                            FullName = "Nina Nani",
                            Selected = false,
                            SelectedDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
