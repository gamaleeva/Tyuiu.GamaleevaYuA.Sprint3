using Tyuiu.GamaleevaYuA.Sprint3.Task0.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
        Console.WriteLine("* по формуле, при a = 0,75                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double value = 0.75;
        int startValue = 1;
        int storValue = 20;
        Console.WriteLine("Переменная A = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + storValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, storValue));
        Console.ReadKey();
    }
}