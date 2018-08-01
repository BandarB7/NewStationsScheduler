using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StationsScheduler.Data.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductSchedule_ScheduleProductScheduleID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ScheduleProductScheduleID",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ScheduleProductScheduleID",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductSchedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSchedule_ProductID",
                table: "ProductSchedule",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSchedule_Product_ProductID",
                table: "ProductSchedule",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSchedule_Product_ProductID",
                table: "ProductSchedule");

            migrationBuilder.DropIndex(
                name: "IX_ProductSchedule_ProductID",
                table: "ProductSchedule");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductSchedule");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleProductScheduleID",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ScheduleProductScheduleID",
                table: "Product",
                column: "ScheduleProductScheduleID",
                unique: true,
                filter: "[ScheduleProductScheduleID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductSchedule_ScheduleProductScheduleID",
                table: "Product",
                column: "ScheduleProductScheduleID",
                principalTable: "ProductSchedule",
                principalColumn: "ProductScheduleID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
