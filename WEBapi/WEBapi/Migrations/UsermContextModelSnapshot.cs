﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBapi.Models;

#nullable disable

namespace WEBapi.Migrations
{
    [DbContext(typeof(UsermContext))]
    partial class UsermContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WEBapi.Models.Userm", b =>
                {
                    b.Property<int>("UsermId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsermId"));

                    b.Property<string>("UsermName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsermRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsermId");

                    b.ToTable("Userms");
                });
#pragma warning restore 612, 618
        }
    }
}