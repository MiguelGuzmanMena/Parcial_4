using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Empleadocs
/// </summary>
public class Empleadocs
{
    public Empleadocs()
    {
       
    }
    public int id_empleado { get; set; }
    public string nombre_empleado { get; set; }
    public string apellido_empleado { get; set; }
    public string direccion { get; set; }
    public string ciudad { get; set; }
    public string region { get; set; }
    public string pais { get; set; }
    public string telefono { get; set; }
    public string codigo { get; set; }
}