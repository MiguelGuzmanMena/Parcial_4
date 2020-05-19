using ProductoDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Descripción breve de ProductoBLL
/// </summary>
/// 
public class ProductoBLL
{
    ProductoDS Producto = new ProductoDS();
    public ProductoBLL()
    {
        
    }

    public static List<Producto> MostrarTodosProductos()
    {
        List<Producto> ListarProducto = new List<Producto>();
        ProductoDSTableAdapters.ProductosTableAdapter adaptador = new ProductoDSTableAdapters.ProductosTableAdapter();
        ProductoDS.ProductosDataTable tabla = adaptador.MostrarProductos();
        //Llenar
        foreach (ProductoDS.ProductosRow filas in tabla)
        {
            ListarProducto.Add(filaDTOProductos(filas));
        }
        return ListarProducto;
        //REtornar
    }

    private static Producto filaDTOProductos(ProductoDS.ProductosRow filas)
    {
        Producto objproductos = new Producto();
        objproductos.id_categoria = filas.id_categoria;
        objproductos.id_producto = filas.id_producto;
        objproductos.nombre_producto = filas.nombre_producto;
        objproductos.precio_unitario = filas.precio_unitario;
        objproductos.detalles = filas.detalles;
        objproductos.codigo = filas.codigo;

        return objproductos;

    }
}