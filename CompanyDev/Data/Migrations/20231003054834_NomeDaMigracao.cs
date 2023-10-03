using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EquipeID",
                table: "Gerente",
                newName: "EquipeId");

            migrationBuilder.RenameColumn(
                name: "DonoID",
                table: "Gerente",
                newName: "DonoId");

            migrationBuilder.RenameColumn(
                name: "GerenteID",
                table: "Funcionario",
                newName: "GerenteId");

            migrationBuilder.RenameColumn(
                name: "EquipeID",
                table: "Funcionario",
                newName: "EquipeId");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Funcionario",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "GerenteID",
                table: "Equipe",
                newName: "GerenteId");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Diretor",
                newName: "Cpf");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EquipeId",
                table: "Gerente",
                newName: "EquipeID");

            migrationBuilder.RenameColumn(
                name: "DonoId",
                table: "Gerente",
                newName: "DonoID");

            migrationBuilder.RenameColumn(
                name: "GerenteId",
                table: "Funcionario",
                newName: "GerenteID");

            migrationBuilder.RenameColumn(
                name: "EquipeId",
                table: "Funcionario",
                newName: "EquipeID");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Funcionario",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "GerenteId",
                table: "Equipe",
                newName: "GerenteID");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Diretor",
                newName: "CPF");
        }
    }
}
