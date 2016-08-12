using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TripPlanner.Model;

namespace TripPlanner.Migrations
{
    [DbContext(typeof(TripPlannerDbContext))]
    [Migration("20160812071828_CreatedAllTables")]
    partial class CreatedAllTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TripPlanner.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PostCode")
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

            modelBuilder.Entity("TripPlanner.Model.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Package");
                });

            modelBuilder.Entity("TripPlanner.Model.PackageTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PackageId");

                    b.Property<decimal>("TripCost");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("TripId");

                    b.ToTable("PackageTrip");
                });

            modelBuilder.Entity("TripPlanner.Model.TransportType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TransportType");
                });

            modelBuilder.Entity("TripPlanner.Model.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Destination");

                    b.Property<string>("Origin");

                    b.Property<int>("TransportTypeId");

                    b.Property<DateTime>("TripDate");

                    b.HasKey("Id");

                    b.HasIndex("TransportTypeId");

                    b.ToTable("Trip");
                });

            modelBuilder.Entity("TripPlanner.Model.Package", b =>
                {
                    b.HasOne("TripPlanner.Model.Customer", "Customer")
                        .WithMany("Packages")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TripPlanner.Model.PackageTrip", b =>
                {
                    b.HasOne("TripPlanner.Model.Package", "Package")
                        .WithMany("PackageTrips")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TripPlanner.Model.Trip", "Trip")
                        .WithMany("PackageTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TripPlanner.Model.Trip", b =>
                {
                    b.HasOne("TripPlanner.Model.TransportType", "TransportType")
                        .WithMany("Trips")
                        .HasForeignKey("TransportTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
