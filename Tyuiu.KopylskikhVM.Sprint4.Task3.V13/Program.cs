using Tyuiu.KopylskikhVM.Sprint4.Task3.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Копыльских В. М. | НТм-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный массив 5x5. Найти сумму элементов                         *");
        Console.WriteLine("* третьего столбца.                                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[,]
        {
            {4, 7, 4, 2, 1},
            {6, 7, 3, 6, 5},
            {6, 5, 3, 3, 5},
            {4, 4, 6, 4, 7},
            {2, 1, 2, 3, 4}
        };

        Console.WriteLine("Массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма элементов третьего столбца = " + ds.Calculate(array));

        Console.ReadLine();
    }
}