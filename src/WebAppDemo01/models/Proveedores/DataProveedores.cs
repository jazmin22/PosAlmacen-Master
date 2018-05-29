using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebAppDemo01.models
{
    public static class DataProveedores
    {
        
        public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext contexto = ab.ApplicationServices.GetRequiredService<AppDbContext>();


            if (!contexto.Proveedores.Any())
            {

                contexto.AddRange
                (
                    new Proveedores { NombreProveedor = "carlos", NombreContacto = "Chumelo", CargoContacto = "Gerente", Direccion = "San Salvador El Salvador", Telefono = 25698745, Email = "carlos@gmal.com", Notas = "Buen cliente", ProveedoresInactivos = true, PaisProcedencia = "Mexico" },
                    new Proveedores { NombreProveedor = "Chumelo", NombreContacto = "Petronilo", CargoContacto = "Jefe de area de compras", Direccion = "San Salvador El Salvador", Telefono = 25146985, Email = "Chume@gmal.com", Notas = "Apopa tiene malas practicas", ProveedoresInactivos = false, PaisProcedencia = "Colombia" },
                    new Proveedores { NombreProveedor = "Petronilo", NombreContacto = "Carlos", CargoContacto = "Jefe de Bodega", Direccion = "San Salvador El Salvador", Telefono = 26986945, Email = "Petronck@gmal.com", Notas = "Es un buen cliente", ProveedoresInactivos = true, PaisProcedencia = "EEUU" }

                );
            }

            contexto.SaveChanges();
        }//fin de agregarData

    }
}



