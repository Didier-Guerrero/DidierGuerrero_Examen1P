using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DidierGuerrero_Examen1P.Migrations
{
    public partial class DidierGuerreroDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DidierGuerrero__Tabla",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dgEntradasDisponibles = table.Column<int>(type: "int", nullable: false),
                    dgPrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dgNombrePelicula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dgFechaPelicula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MdgMayorEdad = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DidierGuerrero__Tabla", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DidierGuerrero__Tabla");
        }
    }
}
