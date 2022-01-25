using System;
using System.Linq;
using CapaDatos.Modelos;
using CapaNegocios;



namespace CarritoDeCompras
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            GestionProductos producto = new GestionProductos();
            Console.WriteLine(producto.ListarProductos());

            GestionFacturas gestionFacturas = new GestionFacturas();
            //1) Los datos de los clientes del listado de facturas ordenados alfabeticamente de A a Z. (2 Puntos)
            Console.WriteLine("1.Los datos de los clientes del listado de facturas ordenados alfabeticamente de A a Z." + gestionFacturas.Retornar_Ordenado());
            Console.ReadKey();
           
            GestionProductos gestionProductos = new GestionProductos();
            // 2) Los datos de los productos agregados a una factura en particular localizada a través del número de factura. (2 Puntos)
            Console.WriteLine("2.Los datos de los productos agregados a una factura en particular localizada a través del número de factura.:" + gestionProductos.Productos_agg());
            Console.ReadKey();

            GestionProductos PersistenciaProductos = new GestionProductos();
            //3) El total de los productos agregados al detalle de cada una de las facturas. (2 Puntos)
            Console.WriteLine("3.El total de los productos agregados al detalle de cada una de las facturas:" + PersistenciaProductos.Total());
            Console.ReadKey();

            GestionProductos GestionProductos = new GestionProductos();
            //4) El subtotal (precio por cantidad) de la primera factura ingresada en la lista de facturas. (2 Puntos)
            Console.WriteLine("4.El subtotal (precio por cantidad) de la primera factura ingresada en la lista de facturas:" + GestionProductos.SubTotal());
            Console.ReadKey();

            //5) Una vez encontrado el subtotal, aumentarle el valor del IVA.. (2 Puntos)
            Console.WriteLine("5.Una vez encontrado el subtotal, aumentarle el valor del IVA.:" + PersistenciaProductos.IVA());
            Console.ReadKey();
        }





        }


        /* GRUPO 1
            Utilizando expresiones lambda o linq cree los métodos en las capas respectivas que permitan mostrar por pantalla:
            1) Los datos de los clientes del listado de facturas ordenados alfabeticamente de A a Z. (2 Puntos)
            2) Los datos de los productos agregados a una factura en particular localizada a través del número de factura. (2 Puntos)
            3) El total de los productos agregados al detalle de cada una de las facturas. (2 Puntos)
            4) El subtotal (precio por cantidad) de la primera factura ingresada en la lista de facturas. (2 Puntos)
            5) Una vez encontrado el subtotal, aumentarle el valor del IVA. (2 puntos)
         */

    }


