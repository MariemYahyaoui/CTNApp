using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CTNApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fonctions",
                columns: table => new
                {
                    Id_Fct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Design_Fct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fonctions", x => x.Id_Fct);
                });

            migrationBuilder.CreateTable(
                name: "Navires",
                columns: table => new
                {
                    Id_Navire = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Design_Navire = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navires", x => x.Id_Navire);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id_Role = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Design_Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id_Role);
                });

            migrationBuilder.CreateTable(
                name: "Situations",
                columns: table => new
                {
                    Id_Sit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Design_Sit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situations", x => x.Id_Sit);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    Matricule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId_Role = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnels", x => x.Matricule);
                    table.ForeignKey(
                        name: "FK_Personnels_Roles_RoleId_Role",
                        column: x => x.RoleId_Role,
                        principalTable: "Roles",
                        principalColumn: "Id_Role");
                });

            migrationBuilder.CreateTable(
                name: "Mouvements",
                columns: table => new
                {
                    Matricule = table.Column<int>(type: "int", nullable: false),
                    IdNavire = table.Column<int>(type: "int", nullable: false),
                    DateEmb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRemb = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remplaçant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Navire = table.Column<int>(type: "int", nullable: false),
                    NavireId_Navire = table.Column<int>(type: "int", nullable: true),
                    PersonnelMatricule = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mouvements", x => new { x.Matricule, x.IdNavire });
                    table.ForeignKey(
                        name: "FK_Mouvements_Navires_IdNavire",
                        column: x => x.IdNavire,
                        principalTable: "Navires",
                        principalColumn: "Id_Navire",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mouvements_Navires_NavireId_Navire",
                        column: x => x.NavireId_Navire,
                        principalTable: "Navires",
                        principalColumn: "Id_Navire");
                    table.ForeignKey(
                        name: "FK_Mouvements_Personnels_Matricule",
                        column: x => x.Matricule,
                        principalTable: "Personnels",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mouvements_Personnels_PersonnelMatricule",
                        column: x => x.PersonnelMatricule,
                        principalTable: "Personnels",
                        principalColumn: "Matricule");
                });

            migrationBuilder.CreateTable(
                name: "PersFcts",
                columns: table => new
                {
                    Matricule = table.Column<int>(type: "int", nullable: false),
                    IdFonctionnalite = table.Column<int>(type: "int", nullable: false),
                    DateFct = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FonctionId_Fct = table.Column<int>(type: "int", nullable: true),
                    IdFonction = table.Column<int>(type: "int", nullable: false),
                    PersonnelMatricule = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersFcts", x => new { x.Matricule, x.IdFonctionnalite });
                    table.ForeignKey(
                        name: "FK_PersFcts_Fonctions_FonctionId_Fct",
                        column: x => x.FonctionId_Fct,
                        principalTable: "Fonctions",
                        principalColumn: "Id_Fct");
                    table.ForeignKey(
                        name: "FK_PersFcts_Fonctions_IdFonctionnalite",
                        column: x => x.IdFonctionnalite,
                        principalTable: "Fonctions",
                        principalColumn: "Id_Fct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersFcts_Personnels_Matricule",
                        column: x => x.Matricule,
                        principalTable: "Personnels",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersFcts_Personnels_PersonnelMatricule",
                        column: x => x.PersonnelMatricule,
                        principalTable: "Personnels",
                        principalColumn: "Matricule");
                });

            migrationBuilder.CreateTable(
                name: "PersSits",
                columns: table => new
                {
                    Matricule = table.Column<int>(type: "int", nullable: false),
                    IdSit = table.Column<int>(type: "int", nullable: false),
                    DateSit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonnelMatricule = table.Column<int>(type: "int", nullable: true),
                    SituationId_Sit = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersSits", x => new { x.Matricule, x.IdSit });
                    table.ForeignKey(
                        name: "FK_PersSits_Personnels_Matricule",
                        column: x => x.Matricule,
                        principalTable: "Personnels",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersSits_Personnels_PersonnelMatricule",
                        column: x => x.PersonnelMatricule,
                        principalTable: "Personnels",
                        principalColumn: "Matricule");
                    table.ForeignKey(
                        name: "FK_PersSits_Situations_IdSit",
                        column: x => x.IdSit,
                        principalTable: "Situations",
                        principalColumn: "Id_Sit",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersSits_Situations_SituationId_Sit",
                        column: x => x.SituationId_Sit,
                        principalTable: "Situations",
                        principalColumn: "Id_Sit");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mouvements_IdNavire",
                table: "Mouvements",
                column: "IdNavire");

            migrationBuilder.CreateIndex(
                name: "IX_Mouvements_NavireId_Navire",
                table: "Mouvements",
                column: "NavireId_Navire");

            migrationBuilder.CreateIndex(
                name: "IX_Mouvements_PersonnelMatricule",
                table: "Mouvements",
                column: "PersonnelMatricule");

            migrationBuilder.CreateIndex(
                name: "IX_PersFcts_FonctionId_Fct",
                table: "PersFcts",
                column: "FonctionId_Fct");

            migrationBuilder.CreateIndex(
                name: "IX_PersFcts_IdFonctionnalite",
                table: "PersFcts",
                column: "IdFonctionnalite");

            migrationBuilder.CreateIndex(
                name: "IX_PersFcts_PersonnelMatricule",
                table: "PersFcts",
                column: "PersonnelMatricule");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_RoleId_Role",
                table: "Personnels",
                column: "RoleId_Role");

            migrationBuilder.CreateIndex(
                name: "IX_PersSits_IdSit",
                table: "PersSits",
                column: "IdSit");

            migrationBuilder.CreateIndex(
                name: "IX_PersSits_PersonnelMatricule",
                table: "PersSits",
                column: "PersonnelMatricule");

            migrationBuilder.CreateIndex(
                name: "IX_PersSits_SituationId_Sit",
                table: "PersSits",
                column: "SituationId_Sit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mouvements");

            migrationBuilder.DropTable(
                name: "PersFcts");

            migrationBuilder.DropTable(
                name: "PersSits");

            migrationBuilder.DropTable(
                name: "Navires");

            migrationBuilder.DropTable(
                name: "Fonctions");

            migrationBuilder.DropTable(
                name: "Personnels");

            migrationBuilder.DropTable(
                name: "Situations");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
