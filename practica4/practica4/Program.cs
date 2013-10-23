using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    class Program
    {
        static void Main(string[] args)
        {
            parser parser = new parser();
            parser.leerArchivo();
            parser.verifyFileType();
            List<string[]> myFile = parser.getFileContent();

            foreach(string[] array in myFile)
            {

                Console.WriteLine("Código: " + array[0] + "\nNombre: " + array[1] + "\nDirección: " + array[2] + "\nTelefono: " + array[3]);
            
            }

            Console.ReadKey();
        }
    }
}
