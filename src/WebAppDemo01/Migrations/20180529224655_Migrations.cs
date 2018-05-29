using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppDemo01.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasUsuarios",
                columns: table => new
                {
                    CodigoCatUo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionCatUo = table.Column<string>(nullable: true),
                    NombreCatUo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasUsuarios", x => x.CodigoCatUo);
                });

            migrationBuilder.CreateTable(
                name: "ClientesDetalle",
                columns: table => new
                {
                    CodigoCliDetalle = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DetalleCliente = table.Column<string>(nullable: true),
                    NombreCliDetalle = table.Column<string>(nullable: true),
                    TipoCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesDetalle", x => x.CodigoCliDetalle);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    CodigoProveedores = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CargoContacto = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NombreContacto = table.Column<string>(nullable: true),
                    NombreProveedor = table.Column<string>(nullable: true),
                    Notas = table.Column<string>(nullable: true),
                    PaisProcedencia = table.Column<string>(nullable: true),
                    ProveedoresInactivos = table.Column<bool>(nullable: false),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.CodigoProveedores);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    CodigoUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApellidoUsuario = table.Column<string>(nullable: true),
                    CatUsuariosCodigoCatUo = table.Column<int>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    ListaNegra = table.Column<bool>(nullable: false),
                    NombreUsuario = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UsuariosInactivos = table.Column<bool>(nullable: false),
                    fechacreacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.CodigoUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_CategoriasUsuarios_CatUsuariosCodigoCatUo",
                        column: x => x.CatUsuariosCodigoCatUo,
                        principalTable: "CategoriasUsuarios",
                        principalColumn: "CodigoCatUo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    CodigoClientes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApellidoClientes = table.Column<string>(nullable: true),
                    ClientesDetalleCodigoCliDetalle = table.Column<int>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<string>(nullable: true),
                    NombreClientes = table.Column<string>(nullable: true),
                    NumDocumento = table.Column<int>(nullable: false),
                    Sexo = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    TipoDocumento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.CodigoClientes);
                    table.ForeignKey(
                        name: "FK_Clientes_ClientesDetalle_ClientesDetalleCodigoCliDetalle",
                        column: x => x.ClientesDetalleCodigoCliDetalle,
                        principalTable: "ClientesDetalle",
                        principalColumn: "CodigoCliDetalle",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ClientesDetalleCodigoCliDetalle",
                table: "Clientes",
                column: "ClientesDetalleCodigoCliDetalle");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CatUsuariosCodigoCatUo",
                table: "Usuarios",
                column: "CatUsuariosCodigoCatUo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "ClientesDetalle");

            migrationBuilder.DropTable(
                name: "CategoriasUsuarios");
        }
    }
}
