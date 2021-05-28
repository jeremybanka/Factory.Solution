using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class LicenseIdIsString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Engineers_EngineerId1",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Machines_MachineId1",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Licenses_EngineerId1",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Licenses_MachineId1",
                table: "Licenses");

            migrationBuilder.DropColumn(
                name: "EngineerId1",
                table: "Licenses");

            migrationBuilder.DropColumn(
                name: "MachineId1",
                table: "Licenses");

            migrationBuilder.AlterColumn<string>(
                name: "MachineId",
                table: "Licenses",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "EngineerId",
                table: "Licenses",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LicenseId",
                table: "Licenses",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_EngineerId",
                table: "Licenses",
                column: "EngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_MachineId",
                table: "Licenses",
                column: "MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Engineers_EngineerId",
                table: "Licenses",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Machines_MachineId",
                table: "Licenses",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Engineers_EngineerId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Machines_MachineId",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Licenses_EngineerId",
                table: "Licenses");

            migrationBuilder.DropIndex(
                name: "IX_Licenses_MachineId",
                table: "Licenses");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Licenses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EngineerId",
                table: "Licenses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LicenseId",
                table: "Licenses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "EngineerId1",
                table: "Licenses",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MachineId1",
                table: "Licenses",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_EngineerId1",
                table: "Licenses",
                column: "EngineerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_MachineId1",
                table: "Licenses",
                column: "MachineId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Engineers_EngineerId1",
                table: "Licenses",
                column: "EngineerId1",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Machines_MachineId1",
                table: "Licenses",
                column: "MachineId1",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
