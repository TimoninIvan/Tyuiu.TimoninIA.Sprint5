using Tyuiu.TimoninIA.Sprint5.Task3.V29.Lib;
namespace Tyuiu.TimoninIA.Sprint5.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Stud0\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);


        }
    }
}