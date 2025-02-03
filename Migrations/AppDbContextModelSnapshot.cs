﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asurance.Models;

#nullable disable

namespace asurance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("asurance.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Addr1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Addr2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Addr3")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Addr4")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MemberId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("asurance.Models.ContactDetail", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Celphone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HomeTel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MemberId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Other")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkTel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("ContactDetails");
                });

            modelBuilder.Entity("asurance.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IDNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MemberType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SubId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
