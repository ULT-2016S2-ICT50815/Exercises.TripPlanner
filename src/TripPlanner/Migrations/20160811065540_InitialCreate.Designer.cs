using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TripPlanner.DataAccess.Model;

namespace TripPlanner.Migrations
{
    [DbContext(typeof(TripPlannerDbContext))]
    [Migration("20160811065540_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TripPlanner.DataAccess.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Postcode");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Suburb");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Model.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Model.PackageTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PackageId");

                    b.Property<decimal>("TripCost");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("TripId");

                    b.ToTable("PackagesTrip");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Model.TransportType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TransportTypes");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Model.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Destination");

                    b.Property<string>("Origin");

                    b.Property<int>("TransportTypeId");

                    b.Property<DateTime>("TripDate");

                    b.HasKey("Id");

                    b.HasIndex("TransportTypeId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Model.Package", b =>
                {
                    b.HasOne("TripPlanner.DataAccess.Model.Customer", "Customer")
                        .WithMany("Packages")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Model.PackageTrip", b =>
                {
                    b.HasOne("TripPlanner.DataAccess.Model.Package", "Package")
                        .WithMany("PackageTrips")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TripPlanner.DataAccess.Model.Trip", "Trip")
                        .WithMany("PackageTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TripPlanner.DataAccess.Model.Trip", b =>
                {
                    b.HasOne("TripPlanner.DataAccess.Model.TransportType", "TransportType")
                        .WithMany("Trips")
                        .HasForeignKey("TransportTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
