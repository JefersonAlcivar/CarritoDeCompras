using System;
using System.Collections.Generic;
using CapaDatos.Modelos;
using System.Linq;

namespace CapaDatos.ClasesCRUD
{
    public class Gestion_Productos
    {
        public Gestion_Productos()
        {
            this.ListaStockProductos = new List<Producto>();
        }

       public List<Producto> ListaStockProductos { get; set; }

        public void CrearProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {
               
                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" +letra + numero + i;                
                producto.Precio = numero;

                Random existencia = new Random();
                producto.Existencia = existencia.Next(100);
                this.ListaStockProductos.Add(producto);
           }
       }

        //PROCESOS DE EXAMEN
        //Modificar este método
       public void ImprimirStokProductos()
       {
            var mostrar_Stok = from productos in ListaStockProductos
                               select productos.Identificador + " -" + productos.Descripcion + "- " + productos.Precio + "- " + productos.Existencia;
            Console.WriteLine("\n" + mostrar_Stok);
        }

        //Añadir método que permita la búsqueda de un producto del stock de productos y devuelva ese producto.
        public string Buscar_Producto()
        {
            var buscar_stock = ListaStockProductos.Find(busqueda => busqueda.Identificador == 1);
            var devolver = $"El producto seleccionado es con el identificador #1, siendo {buscar_stock.Descripcion}";
            return (string.Join("\n", devolver));
        }
        //Añadir método que devuelva la cantidad de productos (stock total) que hay en el local por medio de ListaStockProductos.
        public string total_Stock()
        {
            var TOTAL = ListaStockProductos.Count();
            return (string.Join("\n", TOTAL));
        }
        //Añadir método que devuelva el producto cuyo precio sea el mas alto.
        public string Costo_Mayor()
        {
            var MAYOR = ListaStockProductos.OrderByDescending(ALTO => ALTO.Precio).Select(ALTO => $"El Producto {ALTO.Descripcion} cuenta con el precio más alto de la tienda, siendo: ${ALTO.Precio}").First();
            return (string.Join("\n", MAYOR));
        }
    }
}
