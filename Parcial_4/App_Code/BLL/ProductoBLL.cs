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


    //Select del Where
    public static Producto MostrarProducto(int Id_producto)
    {
        ProductoDSTableAdapters.ProductosTableAdapter adaptador = new ProductoDSTableAdapters.ProductosTableAdapter();
        ProductoDS.ProductosDataTable tabla = adaptador.MostrarProductoID(Id_producto);
        if (tabla.Rows.Count==0)
        {
            return null;
        }
        return filaDTOProductos(tabla[0]);
    }
    public void InsertarProducto(string nombre_producto, int id_categoria, decimal precio_unitario, string detalle)
    {
        ProductoDSTableAdapters.ProductosTableAdapter adaptador = new ProductoDSTableAdapters.ProductosTableAdapter();
        adaptador.Insert(nombre_producto, id_categoria, precio_unitario, detalle);
    }

    public void BorrarProducto(int Id_Producto)
    {
        ProductoDSTableAdapters.ProductosTableAdapter adaptador = new ProductoDSTableAdapters.ProductosTableAdapter();
        adaptador.Delete(Id_Producto);
    }
    //public void UpdateProducto(int Id_Producto, string nombre_producto)
    //{
    //    ProductoDSTableAdapters.ProductosTableAdapter adaptador = new ProductoDSTableAdapters.ProductosTableAdapter();
    //    adaptador.Update(Id_Producto, nombre_producto);
    //}
}