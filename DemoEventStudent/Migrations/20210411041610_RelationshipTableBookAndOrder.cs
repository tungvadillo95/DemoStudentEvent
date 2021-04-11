using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEventStudent.Migrations
{
    public partial class RelationshipTableBookAndOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookOrderDetail",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "integer", nullable: false),
                    OrderDetalisBookId = table.Column<int>(type: "integer", nullable: false),
                    OrderDetalisOrderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOrderDetail", x => new { x.BooksBookId, x.OrderDetalisBookId, x.OrderDetalisOrderId });
                    table.ForeignKey(
                        name: "FK_BookOrderDetail_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookOrderDetail_OrderDetail_OrderDetalisBookId_OrderDetalis~",
                        columns: x => new { x.OrderDetalisBookId, x.OrderDetalisOrderId },
                        principalTable: "OrderDetail",
                        principalColumns: new[] { "BookId", "OrderId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrderDetail_OrderDetalisBookId_OrderDetalisOrderId",
                table: "BookOrderDetail",
                columns: new[] { "OrderDetalisBookId", "OrderDetalisOrderId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Orders_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Orders_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropTable(
                name: "BookOrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail");
        }
    }
}
