using System;
using System.Collections.Generic;
using CapaDatos.ClasesCRUD;
using CapaDatos.Modelos;

namespace CapaNegocios
{
    public class GestionProductos
    {
        public GestionProductos()
        {
            PersistenciaProductos.ListaProductos = new List<Producto>();
            PersistenciaProductos.CrearProductos();
        }

        public void GuardarProducto(int identificador, string descripcion, decimal precio, int existencia, string categoria)
        {
            PersistenciaProductos.GuardarProducto(new Producto(identificador, descripcion, precio, existencia, categoria));
        }

        public string ListarProductos()
        {
            return "IDENTIFICADOR\t\t\tDESCRIPCION\t\t\tCATEGORIA\n" + PersistenciaProductos.RetornarProductosEnString();
        }

        public void CrearProductos()
        {
            throw new NotImplementedException();
        }

        public void ListaProductos()
        {
            throw new NotImplementedException();
        }
        //
        public string Productos_agg()
        {

            return PersistenciaProductos.Mayor_Menor();

        }
        public string Total()
        {

            return PersistenciaProductos.sumatotal();
        }
        public string SubTotal()
        {

            return PersistenciaProductos.subtota();
        }
        public string IVA()
        {

            return PersistenciaProductos.iva();
        }
    }
}