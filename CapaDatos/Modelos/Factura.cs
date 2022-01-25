using System;
using System.Collections.Generic;

namespace CapaDatos.Modelos
{
    public class Factura
    {
        //Cabecera de Factura
        public CabeceraFactura Cabecera { get; set; }
        //Detalle de carrito
        //Lista de detalle de carrito (Producto y la cantidad)
        public List<DetalleFactura> Detalle { get; set; }

        public Factura()
        {
            this.Detalle = new List<DetalleFactura>();

        }
        public decimal SubTotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public void CalcularTotal()
        {
            this.Total = this.SubTotal;
        }

        public void CalcularSubtotal()
        {
            //Acumulador o sumador
            decimal subtotal = 0;
            foreach (DetalleFactura item in this.Detalle)
            {
                subtotal = subtotal + (item.Cantidad * item.ProductoCarrito.Precio);
            }

            this.SubTotal = subtotal;
        }
        public void CalcularIva()
        {
            if (this.SubTotal > 100)
            {
                this.IVA = this.SubTotal * 1.21m;
            }
            else
            {
                this.IVA = 0;
            }
        }

    }
}
