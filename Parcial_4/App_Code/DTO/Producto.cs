using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Producto
/// </summary>
public class Producto
{
    public Producto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public int id_producto { get; set; }
    public string nombre_producto { get; set; }
    public int id_categoria { get; set; }
    public decimal precio_unitario { get; set; }
    public string detalles { get; set; }
    public string codigo { get; set; }


}