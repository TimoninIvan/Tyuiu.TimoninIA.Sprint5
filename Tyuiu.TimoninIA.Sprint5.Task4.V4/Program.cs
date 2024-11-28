using Tyuiu.TimoninIA.Sprint5.Task4.V4.Lib;
using System.IO;
namespace Tyuiu.TimoninIA.Sprint5.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Тимонин И.А. | ИИПБ-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                      *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Тимонин Иван Александрович  | ИИПБ-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V4.txt";
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}