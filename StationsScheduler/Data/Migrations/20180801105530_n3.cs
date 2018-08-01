using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StationsScheduler.Data.Migrations
{
    public partial class n3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProblemId",
                table: "Station",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProblemId",
                table: "Product",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Problem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problem", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Station_ProblemId",
                table: "Station",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProblemId",
                table: "Product",
                column: "ProblemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Problem_ProblemId",
                table: "Product",
                column: "ProblemId",
                principalTable: "Problem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Station_Problem_ProblemId",
                table: "Station",
                column: "ProblemId",
                principalTable: "Problem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Problem_ProblemId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Station_Problem_ProblemId",
                table: "Station");

            migrationBuilder.DropTable(
                name: "Problem");

            migrationBuilder.DropIndex(
                name: "IX_Station_ProblemId",
                table: "Station");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProblemId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProblemId",
                table: "Station");

            migrationBuilder.DropColumn(
                name: "ProblemId",
                table: "Product");
        }
    }
}
