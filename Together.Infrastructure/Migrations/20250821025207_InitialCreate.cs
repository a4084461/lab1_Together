﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Together.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Coordinator = table.Column<string>(type: "TEXT", nullable: true),
                    Place = table.Column<string>(type: "TEXT", nullable: true),
                    Lat = table.Column<float>(type: "REAL", nullable: false),
                    Lng = table.Column<float>(type: "REAL", nullable: false),
                    Fee = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
