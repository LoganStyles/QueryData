﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QueryData;

#nullable disable

namespace QueryData.Migrations
{
    [DbContext(typeof(ArtistsContext))]
    [Migration("20220810124443_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("AlbumTag", b =>
                {
                    b.Property<long>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlbumId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("AlbumTags", (string)null);
                });

            modelBuilder.Entity("QueryData.Album", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("QueryData.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("QueryData.Studio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("QueryData.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("AlbumTag", b =>
                {
                    b.HasOne("QueryData.Album", null)
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QueryData.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QueryData.Album", b =>
                {
                    b.HasOne("QueryData.Employee", "Employee")
                        .WithMany("Albums")
                        .HasForeignKey("EmployeeId")
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("QueryData.Studio", b =>
                {
                    b.HasOne("QueryData.Employee", "Employee")
                        .WithOne("Studio")
                        .HasForeignKey("QueryData.Studio", "EmployeeId")
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("QueryData.Employee", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Studio");
                });
#pragma warning restore 612, 618
        }
    }
}
