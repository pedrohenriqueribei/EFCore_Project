using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Office_ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class Carga01Turma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(3924), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(3974), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(3978), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(3986), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(3982), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(3989), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 3 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 8, 3 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(3997), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4034), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4038), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 9, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4031), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 10, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4026), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 11, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 12, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4005), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 14, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 5 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4045), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 5 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 22, 58, 34, 986, DateTimeKind.Unspecified).AddTicks(4048), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Turmas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Turma A101" },
                    { 2, "Turma A102" },
                    { 3, "Turma A103" },
                    { 4, "Turma A104" },
                    { 5, "Turma A105" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Turmas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7841), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7893), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7899), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7909), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7904), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7914), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 3 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7919), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 8, 3 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7923), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7946), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7951), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 9, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7942), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 10, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7937), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 11, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7955), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 12, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7933), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 14, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7928), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 5 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7960), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 5 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 17, 20, 42, 59, 32, DateTimeKind.Unspecified).AddTicks(7964), new TimeSpan(0, -3, 0, 0, 0)));
        }
    }
}
