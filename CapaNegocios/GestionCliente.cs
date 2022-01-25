using System;
using System.Collections.Generic;
using CapaDatos;
using CapaDatos.ClasesCRUD;
using CapaDatos.Modelos;
using System.Linq;



namespace CapaNegocios
{
    public class GestionCliente
    {
        public GestionCliente()
        {
            PersistenciaClientes.ListaClientes = new List<Cliente>();
        }

        public void GuardarClien(string cedula, string nombres, string apellidos, string usuario, string contrasenia, int edad)
        {
           PersistenciaClientes.GuardarCliente(new Cliente(cedula, nombres, apellidos, usuario, contrasenia, edad));
        }

        public void GuardarCliente(string v1, string v2, string v3, string v4, string v5)
        {
            throw new NotImplementedException();
        }

        public string ListarUsuarios()
        {
            return "CEDULA\t\t\tNOMBRES\t\t\tAPELLIDOS\n" + PersistenciaClientes.RetornarClientesEnString();
        }
    }
}
