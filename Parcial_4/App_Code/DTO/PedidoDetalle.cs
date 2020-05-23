using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PedidoDetalle
/// </summary>
public class PedidoDetalle
{
    public PedidoDetalle()
    {
        
    }
    public int id_pedido { get; set; }
    public int id_producto { get; set; }
    public decimal precio_unitario { get; set; }
    public int cantidad { get; set; }
    public decimal descuento { get; set; }
}
