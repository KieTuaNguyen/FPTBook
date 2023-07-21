﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

<<<<<<< HEAD
namespace FPT.DataAccess.Migrations
=======
<<<<<<< HEAD
namespace FPT.DataAccess.Migrations
=======
namespace FPT.DataAcess.Migrations
>>>>>>> N-Tier-Architecture-02e
>>>>>>> dd438ed30c0d777fc96190ed8cbb0cd9517f75bd
{
    /// <inheritdoc />
    public partial class AddCategoryTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
