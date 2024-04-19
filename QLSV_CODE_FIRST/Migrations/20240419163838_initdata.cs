using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLSV_CODE_FIRST.Migrations
{
    /// <inheritdoc />
    public partial class initdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    khoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lops_Khoas_khoaId",
                        column: x => x.khoaId,
                        principalTable: "Khoas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenSinhVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    lopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.id);
                    table.ForeignKey(
                        name: "FK_SinhViens_Lops_lopId",
                        column: x => x.lopId,
                        principalTable: "Lops",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Khoas",
                columns: new[] { "id", "tenKhoa" },
                values: new object[,]
                {
                    { 1, "Khoa công nghệ số" },
                    { 2, "Khoa điện - điện tử" },
                    { 3, "Khoa cơ khí" },
                    { 4, "Khoa xây dựng" }
                });

            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "id", "khoaId", "tenLop" },
                values: new object[,]
                {
                    { 1, 1, "21T1" },
                    { 2, 1, "21T2" },
                    { 3, 1, "21T3" },
                    { 4, 2, "21D1" },
                    { 5, 2, "21D2" },
                    { 6, 2, "21D3" },
                    { 7, 3, "21C1" },
                    { 8, 3, "21C2" },
                    { 9, 3, "21C3" },
                    { 10, 4, "21XD1" },
                    { 11, 4, "21XD1" },
                    { 12, 4, "21XD1" }
                });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "id", "age", "lopId", "tenSinhVien" },
                values: new object[,]
                {
                    { 1, 20, 3, "Trần Công Quang Phú" },
                    { 2, 21, 1, "Phạm Thanh Trúc" },
                    { 3, 19, 5, "Lê Phước Đức" },
                    { 4, 22, 6, "Trần Văn Lượng" },
                    { 5, 19, 2, "Hồ Đăng Quốc Anh" },
                    { 6, 18, 3, "Trương Văn Lâm" },
                    { 7, 18, 7, "Phan Lê Văn Minh" },
                    { 8, 19, 12, "Phạm Văn Bảo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lops_khoaId",
                table: "Lops",
                column: "khoaId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_lopId",
                table: "SinhViens",
                column: "lopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "Khoas");
        }
    }
}
