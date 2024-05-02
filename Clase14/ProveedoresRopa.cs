using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    internal class ProveedoresRopa : IProveedor
    {
        public string DireccionFisica { get; set; }
        public void EnviarPedido(Pedido pedido)
        {
            Console.WriteLine("Enviar Pedido Proveedor Ropa");
            Console.WriteLine($"Nombre: {pedido.Nombre}");
            Console.WriteLine($"Costo: {pedido.Costo}");
            Console.WriteLine($"Direccion Fisica: {DireccionFisica}");
        }
    }
}
