using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DndApi.Migrations
{
    public partial class AddMonsters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    actions = table.Column<string>(type: "TEXT", nullable: true),
                    alignment = table.Column<string>(type: "TEXT", nullable: true),
                    armor_class = table.Column<int>(type: "INTEGER", nullable: false),
                    challenge_rating = table.Column<int>(type: "INTEGER", nullable: false),
                    charisma = table.Column<int>(type: "INTEGER", nullable: false),
                    charisma_save = table.Column<int>(type: "INTEGER", nullable: false),
                    condition_immu = table.Column<string>(type: "TEXT", nullable: true),
                    constitution = table.Column<int>(type: "INTEGER", nullable: false),
                    damage_immu = table.Column<string>(type: "TEXT", nullable: true),
                    damage_res = table.Column<string>(type: "TEXT", nullable: true),
                    damage_vuln = table.Column<string>(type: "TEXT", nullable: true),
                    dexterity = table.Column<int>(type: "INTEGER", nullable: false),
                    dexterity_save = table.Column<int>(type: "INTEGER", nullable: false),
                    hit_dice = table.Column<string>(type: "TEXT", nullable: true),
                    hit_points = table.Column<int>(type: "INTEGER", nullable: false),
                    intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    languages = table.Column<string>(type: "TEXT", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    perception = table.Column<int>(type: "INTEGER", nullable: false),
                    senses = table.Column<string>(type: "TEXT", nullable: true),
                    size = table.Column<string>(type: "TEXT", nullable: true),
                    special_abilities = table.Column<string>(type: "TEXT", nullable: true),
                    speed = table.Column<string>(type: "TEXT", nullable: true),
                    stealth = table.Column<int>(type: "INTEGER", nullable: false),
                    strength = table.Column<int>(type: "INTEGER", nullable: false),
                    subtype = table.Column<string>(type: "TEXT", nullable: true),
                    type = table.Column<string>(type: "TEXT", nullable: true),
                    wisdom = table.Column<int>(type: "INTEGER", nullable: false),
                    wisdom_save = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monsters");
        }
    }
}
