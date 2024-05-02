

using Clase14;
using System.Linq.Expressions;

GestorPedidos gestorPedidos = new GestorPedidos();

//  PRIMER FORMA DE PASAR PARAMETROS
Pedido pedido = new Pedido
{
    Id = 1,
    Nombre = "Julian",
    Costo = "S/. 26"
};

//  SEGUNDA FORMA  DE PASAR PARAMETROS
gestorPedidos.EnviarPedidoSegunTipoProducto(pedido, new ProveedorElectronica { PaginaWeb="ww.lima.com"});
gestorPedidos.EnviarPedidoSegunTipoProducto(new Pedido { Id=2,Nombre="Julia",Costo="S/. 18"}, new ProveedoresRopa { DireccionFisica="Lima - Peru"});