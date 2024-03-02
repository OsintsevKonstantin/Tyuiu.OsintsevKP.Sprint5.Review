using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.OsintsevKP.Sprint5.Review.V11.Lib;

namespace Tyuiu.OsintsevKP.Sprint5.Review.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V11.txt";
            string pathSaveFile =  $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V11.txt";

            Console.WriteLine("Данные находятся  в  файле: " + path);
           

           


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РEЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            pathSaveFile = ds.LoadDataSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
