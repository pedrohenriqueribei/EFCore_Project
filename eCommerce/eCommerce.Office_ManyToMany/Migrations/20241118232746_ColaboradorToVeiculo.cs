using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Office_ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class ColaboradorToVeiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradoresId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculosId",
                table: "ColaboradorVeiculo");

            migrationBuilder.RenameColumn(
                name: "VeiculosId",
                table: "ColaboradorVeiculo",
                newName: "VeiculoId");

            migrationBuilder.RenameColumn(
                name: "ColaboradoresId",
                table: "ColaboradorVeiculo",
                newName: "ColaboradorId");

            migrationBuilder.RenameIndex(
                name: "IX_ColaboradorVeiculo_VeiculosId",
                table: "ColaboradorVeiculo",
                newName: "IX_ColaboradorVeiculo_VeiculoId");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DataInicio",
                table: "ColaboradorVeiculo",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 1, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3930), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3963), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 1 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3966), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 3, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3972), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 5, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3969), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 2 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3974), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 3 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3977), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 8, 3 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 2, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 6, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3996), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 9, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3991), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 10, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3989), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 11, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3998), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 12, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3984), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 14, 4 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(3982), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 4, 5 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(4001), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ColaboradoresSetores",
                keyColumns: new[] { "ColaboradorId", "SetorId" },
                keyValues: new object[] { 7, 5 },
                column: "Criacao",
                value: new DateTimeOffset(new DateTime(2024, 11, 18, 20, 27, 45, 57, DateTimeKind.Unspecified).AddTicks(4003), new TimeSpan(0, -3, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "Id", "Nome", "Placa" },
                values: new object[,]
                {
                    { 1, "Voyage", "ABC-1234" },
                    { 2, "Jetta", "DEF-5678" },
                    { 3, "T-Cross", "GHI-9A00" },
                    { 4, "Fusca", "JKL-1011" },
                    { 5, "Virtus", "MNO-1T13" },
                    { 6, "Amarok", "PQR-1415" },
                    { 7, "Virtus", "STU-1617" },
                    { 8, "Taos", "VWX-1G19" },
                    { 9, "Tiguan", "ZZZ-2000" },
                    { 10, "Polo", "AAA-1J34" },
                    { 11, "Nivus", "BBB-0L90" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradorId",
                table: "ColaboradorVeiculo",
                column: "ColaboradorId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculoId",
                table: "ColaboradorVeiculo",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradorId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculoId",
                table: "ColaboradorVeiculo");

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "ColaboradorVeiculo");

            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "ColaboradorVeiculo",
                newName: "VeiculosId");

            migrationBuilder.RenameColumn(
                name: "ColaboradorId",
                table: "ColaboradorVeiculo",
                newName: "ColaboradoresId");

            migrationBuilder.RenameIndex(
                name: "IX_ColaboradorVeiculo_VeiculoId",
                table: "ColaboradorVeiculo",
                newName: "IX_ColaboradorVeiculo_VeiculosId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Colaboradores_ColaboradoresId",
                table: "ColaboradorVeiculo",
                column: "ColaboradoresId",
                principalTable: "Colaboradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColaboradorVeiculo_Veiculos_VeiculosId",
                table: "ColaboradorVeiculo",
                column: "VeiculosId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
