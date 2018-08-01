using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StationsScheduler.Data.Migrations
{
    public partial class StationListIsNowString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Station_Product_ProductID",
                table: "Station");

            migrationBuilder.DropIndex(
                name: "IX_Station_ProductID",
                table: "Station");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Station");

            migrationBuilder.AddColumn<string>(
                name: "Stations",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stations",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Station",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Station_ProductID",
                table: "Station",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Station_Product_ProductID",
                table: "Station",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
