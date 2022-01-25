using System;
using System.Collections.Generic;
using CapaDatos.ClasesCRUD;
using CapaDatos.Modelos;

namespace CapaNegocios
{
    public class GestionFacturas
    {
        public string Retornar_Ordenado()
        {
            return PersistenciaFacturas.Clientes_Alfabeticamente();
        }

        public GestionFacturas()
        {
            PersistenciaFacturas.ListaFacturas = new List<Factura>();
            PersistenciaFacturas.AgregarFacturas();
        }

        public string RetornarFacturas()
        {
            string res = PersistenciaFacturas.RetornarFacturasEnString();
            return res;
        }

    }
}


