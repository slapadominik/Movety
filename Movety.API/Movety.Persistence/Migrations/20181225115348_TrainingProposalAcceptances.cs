using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class TrainingProposalAcceptances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingProposalsAcceptances",
                columns: table => new
                {
                    TrainingProposalsId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProposalsAcceptances", x => new { x.TrainingProposalsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_TrainingProposalsAcceptances_TrainingProposals_TrainingProposalsId",
                        column: x => x.TrainingProposalsId,
                        principalTable: "TrainingProposals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingProposalsAcceptances_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProposalsAcceptances_UserId",
                table: "TrainingProposalsAcceptances",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingProposalsAcceptances");
        }
    }
}
