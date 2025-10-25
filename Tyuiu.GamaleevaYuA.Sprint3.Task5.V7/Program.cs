using Tyuiu.GamaleevaYuA.Sprint3.Task5.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* y = sum i=1, 3 sum k = 1, 10 1/cos(k) + x при x = 5                     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 10;
        int x = 5;
        Console.WriteLine("Переменная X = " + x);
        Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
        Console.WriteLine("Старт шага первой суммы ряда = " + startValue2);
        Console.WriteLine("Конец шага первой суммы ряда = " + stopValue2);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        Console.ReadKey();
    }
}