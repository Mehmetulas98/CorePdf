using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CorePdf.Migrations
{
    public partial class finalmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "TicketDB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Departure",
                table: "TicketDB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureTime",
                table: "TicketDB",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DestinationTime",
                table: "TicketDB",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FQTV",
                table: "TicketDB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlightNumber",
                table: "TicketDB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gate",
                table: "TicketDB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroupCode",
                table: "TicketDB",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "TicketDB");

            migrationBuilder.DropColumn(
                name: "Departure",
                table: "TicketDB");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "TicketDB");

            migrationBuilder.DropColumn(
                name: "DestinationTime",
                table: "TicketDB");

            migrationBuilder.DropColumn(
                name: "FQTV",
                table: "TicketDB");

            migrationBuilder.DropColumn(
                name: "FlightNumber",
                table: "TicketDB");

            migrationBuilder.DropColumn(
                name: "Gate",
                table: "TicketDB");

            migrationBuilder.DropColumn(
                name: "GroupCode",
                table: "TicketDB");
        }
    }
}
