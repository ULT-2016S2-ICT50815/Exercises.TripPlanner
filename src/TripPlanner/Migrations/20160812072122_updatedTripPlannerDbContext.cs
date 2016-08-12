using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripPlanner.Migrations
{
    public partial class updatedTripPlannerDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Package_Customers_CustomerId",
                table: "Package");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageTrip_Package_PackageId",
                table: "PackageTrip");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageTrip_Trip_TripId",
                table: "PackageTrip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_TransportType_TransportTypeId",
                table: "Trip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trip",
                table: "Trip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransportType",
                table: "TransportType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackageTrip",
                table: "PackageTrip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Package",
                table: "Package");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trips",
                table: "Trip",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransportTypes",
                table: "TransportType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackageTrips",
                table: "PackageTrip",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Packages",
                table: "Package",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Customers_CustomerId",
                table: "Package",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTrips_Packages_PackageId",
                table: "PackageTrip",
                column: "PackageId",
                principalTable: "Package",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTrips_Trips_TripId",
                table: "PackageTrip",
                column: "TripId",
                principalTable: "Trip",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_TransportTypes_TransportTypeId",
                table: "Trip",
                column: "TransportTypeId",
                principalTable: "TransportType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_Trip_TransportTypeId",
                table: "Trip",
                newName: "IX_Trips_TransportTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageTrip_TripId",
                table: "PackageTrip",
                newName: "IX_PackageTrips_TripId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageTrip_PackageId",
                table: "PackageTrip",
                newName: "IX_PackageTrips_PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_Package_CustomerId",
                table: "Package",
                newName: "IX_Packages_CustomerId");

            migrationBuilder.RenameTable(
                name: "Trip",
                newName: "Trips");

            migrationBuilder.RenameTable(
                name: "TransportType",
                newName: "TransportTypes");

            migrationBuilder.RenameTable(
                name: "PackageTrip",
                newName: "PackageTrips");

            migrationBuilder.RenameTable(
                name: "Package",
                newName: "Packages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Customers_CustomerId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageTrips_Packages_PackageId",
                table: "PackageTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageTrips_Trips_TripId",
                table: "PackageTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_TransportTypes_TransportTypeId",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trips",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransportTypes",
                table: "TransportTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PackageTrips",
                table: "PackageTrips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Packages",
                table: "Packages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trip",
                table: "Trips",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransportType",
                table: "TransportTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PackageTrip",
                table: "PackageTrips",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Package",
                table: "Packages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Customers_CustomerId",
                table: "Packages",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTrip_Package_PackageId",
                table: "PackageTrips",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageTrip_Trip_TripId",
                table: "PackageTrips",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_TransportType_TransportTypeId",
                table: "Trips",
                column: "TransportTypeId",
                principalTable: "TransportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameIndex(
                name: "IX_Trips_TransportTypeId",
                table: "Trips",
                newName: "IX_Trip_TransportTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageTrips_TripId",
                table: "PackageTrips",
                newName: "IX_PackageTrip_TripId");

            migrationBuilder.RenameIndex(
                name: "IX_PackageTrips_PackageId",
                table: "PackageTrips",
                newName: "IX_PackageTrip_PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_Packages_CustomerId",
                table: "Packages",
                newName: "IX_Package_CustomerId");

            migrationBuilder.RenameTable(
                name: "Trips",
                newName: "Trip");

            migrationBuilder.RenameTable(
                name: "TransportTypes",
                newName: "TransportType");

            migrationBuilder.RenameTable(
                name: "PackageTrips",
                newName: "PackageTrip");

            migrationBuilder.RenameTable(
                name: "Packages",
                newName: "Package");
        }
    }
}
