using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos.Modelos;

namespace CapaDatos.ClasesCRUD
{
    public static class PersistenciaFacturas
    {
        public static string Clientes_Alfabeticamente()
        {
            //var clientes = ListaFacturas.OrderBy(orden => orden.Detalle).Aggregate("",(suma,cliente)=>suma +=$"{cliente.Cabecera}").Select(alfabetico=>alfabetico);
            var cliente = ListaFacturas.OrderBy(orden => orden.Cabecera.ClienteCabecera.Nombres).Select(x => x.Cabecera.ClienteCabecera.Nombres);
            return string.Join("\n", cliente);
        }

        public static List<Factura> ListaFacturas { get; set; }

        /// <summary>
        /// Método para crear productos aleatoreamente.
        /// </summary>
        public static void AgregarFacturas()
        {
            List<DetalleFactura> detalleFacturas = new List<DetalleFactura>();

            
            int numero;
            for (int i = 1; i <= 10; i++)
            {
                Random random = new Random();
                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO " + letra + numero + i;
                producto.Precio = numero;
                

                CabeceraFactura cabeceraFactura = new CabeceraFactura();
                cabeceraFactura.NumeroFactura = $"00{i}-001";
                cabeceraFactura.ClienteCabecera = new Cliente { Apellidos = "APELLIDO" + numero + 1 + letra, Nombres = "NOMBRE" + numero + i, Cedula = $"{i}{i}{i}{i}{i}{i}", Edad = i, Email = "", Contrasena = "" };
                cabeceraFactura.EmpresaCabecera = new Empresa { Direccion = "Manta", RazonSocial = $"{i}{i}{i}{i}{i}{i}0001" };


                for (int j = 1; j <= 10; j++)
                {
                    Random detalleRamdom = new Random();

                    DetalleFactura detalleFactura = new DetalleFactura();
                    detalleFactura.ProductoCarrito = producto;
                    detalleFactura.Cantidad = detalleRamdom.Next(10) + 1;

                    detalleFacturas.Add(detalleFactura);
                }

                ListaFacturas.Add(new Factura { Cabecera = cabeceraFactura, Detalle = detalleFacturas });

                //Modificar el método para agregar categorías aleatoreas
            }
        }

        //CRUD
        //CREATE
        public static void GuardarFactura()
        {
            
        }

        //UPDATE
        public static void ModificarFactura()
        {

        }

        //DELETE
        public static void EliminarFactura()
        {
           
        }

        //READ
        //UN OBJETO
        public static void BuscarUnaFactura()
        {
            
        }

        //LISTADO DE OBJETOS FORMATEADOS SEGÚN REQUERIMIENTO
        public static string RetornarFacturasEnString()
        {
            return ListaFacturas.Aggregate("", (acumulador, factura) => acumulador += $"{factura.Cabecera.ClienteCabecera.Apellidos} \t {factura.Cabecera.ClienteCabecera.Nombres} \t {factura.Cabecera.EmpresaCabecera.RazonSocial} \n");
        }



    }
}
