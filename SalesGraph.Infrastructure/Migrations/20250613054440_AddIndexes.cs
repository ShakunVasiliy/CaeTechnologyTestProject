using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesGraph.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_WeekSales_StartDate_EndDate",
                table: "WeekSales",
                columns: new[] { "StartDate", "EndDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Date",
                table: "Sales",
                column: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_DaySales_StartDate_EndDate",
                table: "DaySales",
                columns: new[] { "StartDate", "EndDate" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WeekSales_StartDate_EndDate",
                table: "WeekSales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_Date",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_DaySales_StartDate_EndDate",
                table: "DaySales");
        }
    }
}
