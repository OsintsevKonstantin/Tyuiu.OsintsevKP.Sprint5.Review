using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.OsintsevKP.Sprint5.Review.V11.Lib
{
    public class DataService
    {
        public string LoadDataSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V11.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using(StreamReader reader   = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine())!=null)
                {
                    for(int i = 0; i < line.Length; i++)
                    {
                        if (!Char.IsLower(line[i]))
                        {
                            strLine = strLine + line[i];
                        }
                       
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
