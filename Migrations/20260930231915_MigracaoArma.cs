using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoArma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 23, "AK47" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 30, "Ak78" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 50, "MP40" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 32, "M1014" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 35, "M1911" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 67, "Desert" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 90, "M4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 100, "a" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 100, "Frodo" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 100, "Frodo" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 100, "Frodo" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 100, "Frodo" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 100, "Frodo" });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Dano", "Nome" },
                values: new object[] { 100, "Frodo" });
        }
    }
}
