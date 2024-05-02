using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    public class ProveedorElectronica : IProveedor
    {
        public string PaginaWeb { get; set; }
        public void EnviarPedido(Pedido pedido)
        {
            Console.WriteLine("Enviar Pedido Proveedor Electronica");
            Console.WriteLine($"Nombre: {pedido.Nombre}");
            Console.WriteLine($"Costo: {pedido.Costo}");
            Console.WriteLine($"Pagina Web: {PaginaWeb}");
        }
    }
}
