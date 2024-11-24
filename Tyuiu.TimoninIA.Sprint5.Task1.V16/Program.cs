using Tyuiu.TimoninIA.Sprint5.Task1.V16.Lib;
namespace Tyuiu.TimoninIA.Sprint5.Task1.V16;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт №5 | Выполнил: Тимонин  И. А. | ИИПБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #  16                                                         *");
        Console.WriteLine("* Выполнил: Тимонин Иван Александрович | ИИПБ-24-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция(произвести табулирование) на заданном диапазоне [5;5] с шагом *");
        Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
        Console.WriteLine("* Значение округлить до двух знаков после запятой                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int start = -5, end = 5;
        Console.WriteLine("Начало диапазона:" + start);
        Console.WriteLine("Конец диапазона: " + end);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(start, end);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}