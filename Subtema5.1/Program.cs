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
            GenerarReporte();
        }
        static void agregarNuevoProducto()
        {
            //StreamWriter
            //crear y abrir el documento de texto
            StreamWriter nuevoDocumento = new StreamWriter(nombreArchivo, true);
            //agregar un nuevo dato al documento de texto creado
            Console.Write("Ingrese el nombre del producto a registrar: ");
            string producto = Console.ReadLine();
            nuevoDocumento.WriteLine(producto);
            //IMPORTANTE !!! CERRAR para guardar los cambios en el documento
            nuevoDocumento.Close();

        }
        static void GenerarReporte()
        {   //StreamReader leer o editar un archivo de texto 
            StreamReader Leerdocumento = new StreamReader(nombreArchivo);

            //leer documento = coca cola 600, galleta, agua
            int contador = 0;
            string linea;
            string ultimoProducto = "";
            if (!File.Exists(nombreArchivo))
            {
                Console.WriteLine("El archivo de texto NO EXISTE!");
                return;
            }

            while ((linea = Leerdocumento.ReadLine()) != null)  //repetir y recorrer esta lista de productos mientras aun exista un producto que leer  
            {
                ultimoProducto = linea;
                contador++;
                Console.WriteLine("producto: " + linea);
            }

            Console.WriteLine("El total de productos en el almacen son: " + contador);
            Leerdocumento.Close(); //LIBERAR RECURSOS
            //COMPLETAR:  MOSTRAR EL ÚLTIMO PRODUCTO REGISTRADO!!

            Console.WriteLine("El último producto registrar es: " + ultimoProducto);
        }
    }   

}
