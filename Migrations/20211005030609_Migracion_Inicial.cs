﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P1_AP1_Danilo_20190266.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aportes",
                columns: table => new
                {
                    AporteID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Persona = table.Column<string>(type: "TEXT", nullable: true),
                    Concepto = table.Column<string>(type: "TEXT", nullable: true),
                    Monto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aportes", x => x.AporteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aportes");
        }
    }
}
