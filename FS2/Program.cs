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
            ShowWindowsDirectoryInfo();
        }

        static void NewFile()
        {

        }

        static void ShowWindowsDirectoryInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(@"c:\windows");
            Console.WriteLine("****Инфо о файле****");
            Console.WriteLine("Полный путь: {0}\nНазвание папки: {1}\nРодительский каталог: {2}\nВремя создания: {3}\nАтрибуты: {4}\nКорневой каталог: {5}", dir.FullName, dir.Name, dir.Parent, dir.CreationTime, dir.Attributes, dir.Root);
            Console.ReadLine();
        }


    }
}
