using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.OsintsevKP.Sprint5.Review.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TChecedExistFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
