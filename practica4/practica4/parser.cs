using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    class parser
    {
        private string @rutaDeArchivo;


        public List<string[]> getFileContent() 
        {
            List<string[]> csvArray = new List<string[]>();
            string line;
            string[] row;

            StreamReader readFile = new StreamReader(this.rutaDeArchivo);
            while ((line = readFile.ReadLine()) != null)
            {
                row = line.Split(',');
                csvArray.Add(row);
            }

            return csvArray;
        }

        public void verifyFileType()
        {

            if(verifyPath())
                if (Path.GetExtension(this.rutaDeArchivo) == ".csv")
                    Console.WriteLine("El archivo seleccionado es .csv");
                else
                    Console.WriteLine("El archivo seleccionado no es de tipo .csv, es " + Path.GetExtension(this.rutaDeArchivo) );
        }


        private Boolean verifyPath()
        {
            Boolean fileExist;
            if(File.Exists(this.rutaDeArchivo))
                fileExist = true;
            else
                fileExist = false;

            return fileExist;
        }

        public void leerArchivo()
        {
            Console.WriteLine("Ingresa la ruta del archivo CSV que quieres abrir:");
            this.rutaDeArchivo = Console.ReadLine();
        }

    }
}
