using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtema5._1
{
    internal class Program
    {
        static string nombreArchivo = "Listaproductos.txt"; // variable de clase

        static void Main(string[] args) 
        {
            agregarNuevoProducto();
        }
        static void agregarNuevoProducto()
        {
            //crear y abrir el documento de texto
            StreamWriter nuevoDocumento = new StreamWriter(nombreArchivo, true);

            //agregar un nuevo dato al documento de texto creado
            Console.Write("Ingrese el nombre del producto a registrar: ");
            string producto = Console.ReadLine();
            nuevoDocumento.WriteLine(producto);
            //IMPORTANTE !!! CERRAR para guardar los cambios en el documento
            nuevoDocumento.Close();
       
        }
    }   

}
