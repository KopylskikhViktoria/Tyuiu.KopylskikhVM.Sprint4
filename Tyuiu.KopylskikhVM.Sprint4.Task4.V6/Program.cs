using Tyuiu.KopylskikhVM.Sprint4.Task4.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Копыльских В. М. | НТм-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный массив 5x5, заполненный значениями с клавиатуры.          *");
        Console.WriteLine("* Заменить нечетные элементы на 0.                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                do
                {
                    Console.Write($"Введите элемент [{i},{j}] (от 4 до 9): ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                while (array[i, j] < 4 || array[i, j] > 9);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int[,] res = ds.Calculate(array);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Измененный массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(res[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}