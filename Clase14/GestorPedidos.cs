using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14
{
    public class GestorPedidos
    {
        public void EnviarPedidoSegunTipoProducto(Pedido pedido, IProveedor proveedor)
        {
            proveedor.EnviarPedido(pedido);
        }
    }
}
