using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StationsScheduler.Data.Migrations
{
    public partial class DataManipulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_ApplicationUserId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Station_AspNetUsers_ApplicationUserId",
                table: "Station");

            migrationBuilder.DropIndex(
                name: "IX_Product_ApplicationUserId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Station",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Station_ApplicationUserId",
                table: "Station",
                newName: "IX_Station_OwnerId");

            migrationBuilder.RenameColumn(
                name: "Stations",
                table: "Product",
                newName: "OwnerId");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_OwnerId",
                table: "Product",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_OwnerId",
                table: "Product",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Station_AspNetUsers_OwnerId",
                table: "Station",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_OwnerId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Station_AspNetUsers_OwnerId",
                table: "Station");

            migrationBuilder.DropIndex(
                name: "IX_Product_OwnerId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Station",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Station_OwnerId",
                table: "Station",
                newName: "IX_Station_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Product",
                newName: "Stations");

            migrationBuilder.AlterColumn<string>(
                name: "Stations",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ApplicationUserId",
                table: "Product",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_ApplicationUserId",
                table: "Product",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Station_AspNetUsers_ApplicationUserId",
                table: "Station",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
