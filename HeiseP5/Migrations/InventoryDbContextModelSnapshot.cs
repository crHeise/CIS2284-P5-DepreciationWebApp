﻿// <auto-generated />
using System;
using HeiseP5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HeiseP5.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    partial class InventoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("HeiseP5.Data.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CurrentValue")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateRemoved")
                        .HasColumnType("TEXT");

                    b.Property<int>("LifeTime")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SalvageValue")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("StartValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("InventoryItems");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            CurrentValue = 35.310273972602739726027397175m,
                            DateAdded = new DateTime(2015, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRemoved = new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            LifeTime = 20,
                            SalvageValue = 5.0m,
                            StartValue = 50.0m,
                            Title = "Desk Lamp",
                            isActive = true
                        },
                        new
                        {
                            Id = 1002,
                            CurrentValue = 244.95890410958904109589041096m,
                            DateAdded = new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRemoved = new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            LifeTime = 10,
                            SalvageValue = 20.0m,
                            StartValue = 250.0m,
                            Title = "Computer Monitor",
                            isActive = true
                        },
                        new
                        {
                            Id = 1003,
                            CurrentValue = 8.196255707762557077625570901m,
                            DateAdded = new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRemoved = new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LifeTime = 30,
                            SalvageValue = 0.5m,
                            StartValue = 15.0m,
                            Title = "Coffee Cup",
                            isActive = false
                        },
                        new
                        {
                            Id = 1004,
                            CurrentValue = 69.178082191780821917808219125m,
                            DateAdded = new DateTime(2018, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRemoved = new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            LifeTime = 10,
                            SalvageValue = 10.0m,
                            StartValue = 100.0m,
                            Title = "Keyboard",
                            isActive = true
                        },
                        new
                        {
                            Id = 1005,
                            CurrentValue = 49.816438356164383561643835599m,
                            DateAdded = new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateRemoved = new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            LifeTime = 5,
                            SalvageValue = 15.0m,
                            StartValue = 75.0m,
                            Title = "Wireless Speaker",
                            isActive = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
