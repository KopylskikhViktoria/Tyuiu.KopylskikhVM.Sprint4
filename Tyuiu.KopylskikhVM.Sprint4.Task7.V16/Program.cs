using Tyuiu.KopylskikhVM.Sprint4.Task7.V16.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Копыльских В. М. | НТм-24-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнила: Копыльских Виктория Максимовна | НТм-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"382976421897948\".                  *");
        Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте                          *");
        Console.WriteLine("* произведение четных чисел.                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int n = 5;
        int m = 3;
        string value = "382976421897948";
        int[,] matrix = new int[n, m];

        Console.WriteLine("Количество строк = " + n);
        Console.WriteLine("Количество столбцов = " + m);
        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine();
        Console.WriteLine("Матрица:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(value[i * m + j].ToString());
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Произведение четных чисел = " + ds.Calculate(n, m, value));

        Console.ReadLine();
    }
}