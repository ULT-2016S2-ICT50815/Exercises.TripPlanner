using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TripPlanner.DataAccess.Models;

namespace TripPlanner.Migrations
{
    [DbContext(typeof(TripPlannerDbContext))]
    [Migration("20160814091430_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TripPlanner.DataAccess.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("char(4)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("char(3)");

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<string>("Suburb")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Models.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Models.PackageTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PackageId");

                    b.Property<decimal>("TripCost");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("TripId");

                    b.ToTable("PackageTrips");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Models.TransportType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TransportTypes");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Destination")
                        .IsRequired();

                    b.Property<string>("Origin")
                        .IsRequired();

                    b.Property<int?>("TransportTypeId");

                    b.Property<DateTime>("TripDate");

                    b.HasKey("Id");

                    b.HasIndex("TransportTypeId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Models.Package", b =>
                {
                    b.HasOne("TripPlanner.DataAccess.Models.Customer", "Customer")
                        .WithMany("Packages")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Models.PackageTrip", b =>
                {
                    b.HasOne("TripPlanner.DataAccess.Models.Package", "Package")
                        .WithMany("PackageTrips")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TripPlanner.DataAccess.Models.Trip", "Trip")
                        .WithMany("PackageTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Models.Trip", b =>
                {
                    b.HasOne("TripPlanner.DataAccess.Models.TransportType", "TransportType")
                        .WithMany()
                        .HasForeignKey("TransportTypeId");
                });
        }
    }
}
