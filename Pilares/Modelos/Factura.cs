using System;

namespace ClaseObjeto
{
    class Factura
    {
        public int numeroFactura;
        public DateTime fechaEmision;
        public string cliente;
        public Producto[] productos;
        public decimal total;
    }
}