using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FS1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"C:\Users\плотниковс\Documents\visual studio 2015\Projects\FS2\FS2\text.txt";
     

            FileInfo file = new FileInfo(url);
            FileStream fs = file.Create();
            fs.Close();
           
        }

        static void NewFile()
        {

        }


    }
}
