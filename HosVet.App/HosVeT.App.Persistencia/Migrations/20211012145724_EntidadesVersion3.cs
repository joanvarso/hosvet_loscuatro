using Microsoft.EntityFrameworkCore.Migrations;

namespace HosVeT.App.Persistencia.Migrations
{
    public partial class EntidadesVersion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MascotaId",
                table: "SignosVitales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuxiliarVeterinarioId",
                table: "Mascotas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HistoriaId",
                table: "Mascotas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicoVeterinarioId",
                table: "Mascotas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PropietarioDesignadoId",
                table: "Mascotas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_MascotaId",
                table: "SignosVitales",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_AuxiliarVeterinarioId",
                table: "Mascotas",
                column: "AuxiliarVeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_HistoriaId",
                table: "Mascotas",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_MedicoVeterinarioId",
                table: "Mascotas",
                column: "MedicoVeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_PropietarioDesignadoId",
                table: "Mascotas",
                column: "PropietarioDesignadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Historias_HistoriaId",
                table: "Mascotas",
                column: "HistoriaId",
                principalTable: "Historias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Personas_AuxiliarVeterinarioId",
                table: "Mascotas",
                column: "AuxiliarVeterinarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Personas_MedicoVeterinarioId",
                table: "Mascotas",
                column: "MedicoVeterinarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascotas_Personas_PropietarioDesignadoId",
                table: "Mascotas",
                column: "PropietarioDesignadoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SignosVitales_Mascotas_MascotaId",
                table: "SignosVitales",
                column: "MascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Historias_HistoriaId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Personas_AuxiliarVeterinarioId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Personas_MedicoVeterinarioId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascotas_Personas_PropietarioDesignadoId",
                table: "Mascotas");

            migrationBuilder.DropForeignKey(
                name: "FK_SignosVitales_Mascotas_MascotaId",
                table: "SignosVitales");

            migrationBuilder.DropIndex(
                name: "IX_SignosVitales_MascotaId",
                table: "SignosVitales");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_AuxiliarVeterinarioId",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_HistoriaId",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_MedicoVeterinarioId",
                table: "Mascotas");

            migrationBuilder.DropIndex(
                name: "IX_Mascotas_PropietarioDesignadoId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "MascotaId",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "AuxiliarVeterinarioId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "HistoriaId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "MedicoVeterinarioId",
                table: "Mascotas");

            migrationBuilder.DropColumn(
                name: "PropietarioDesignadoId",
                table: "Mascotas");
        }
    }
}
