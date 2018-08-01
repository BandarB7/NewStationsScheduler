using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StationsScheduler.Data.Migrations
{
    public partial class relations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductSchedule",
                columns: table => new
                {
                    ProductScheduleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OwnerId = table.Column<string>(nullable: true),
                    ProductID = table.Column<int>(nullable: true),
                    StationID = table.Column<int>(nullable: true),
                    Time = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSchedule", x => x.ProductScheduleID);
                    table.ForeignKey(
                        name: "FK_ProductSchedule_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSchedule_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSchedule_Station_StationID",
                        column: x => x.StationID,
                        principalTable: "Station",
                        principalColumn: "StationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSchedule_OwnerId",
                table: "ProductSchedule",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSchedule_ProductID",
                table: "ProductSchedule",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSchedule_StationID",
                table: "ProductSchedule",
                column: "StationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSchedule");
        }
    }
}
