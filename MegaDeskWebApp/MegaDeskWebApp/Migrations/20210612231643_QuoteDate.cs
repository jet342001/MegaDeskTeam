﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDeskWebApp.Migrations
{
    public partial class QuoteDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "DeskQuote",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "DeskQuote");
        }
    }
}
