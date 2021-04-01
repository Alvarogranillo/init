using System;
using System.IO;

namespace init
{
    class iniciar
    {
        static void Main(string[] args)
        {
            //Despues del comando INIT

            string[] allfiles = new string[10];
            string ruta;
            Console.WriteLine("Trabajar sobre Archivo existente 1.-");
            Console.WriteLine("Crear nuevo Archivo 2.-");
            int opc;
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    //Ingresar ruta
                    Console.WriteLine("Ingresar la ruta donde se encuentra el archivo con el que desea trabajar");
                    ruta = @""+Console.ReadLine();
                    if (Directory.Exists(ruta))
                    {
                        Console.WriteLine("Archivo a dar seguimiento: " + allfiles[0]);
                    }
                    else { Console.WriteLine("Ruta no encontrada"); }
                    break;
                case 2:
                    Console.WriteLine("Ingresar la ruta donde desea crear el archivo:");
                    ruta = @""+Console.ReadLine();
                    
                    if (Directory.Exists(ruta))
                    {
                        
                        TextWriter archivo;
                        archivo = new StreamWriter(ruta+@"\.txt" );

                        /*listaDeArchivos.recorrer(archivo);*/
                        archivo.Close();
                        Console.Clear();
                        Console.WriteLine("se ha guardado el archivo");

                    }
                    break;
            }
        }
    }
}
