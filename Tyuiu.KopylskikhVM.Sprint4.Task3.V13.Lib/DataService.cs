using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KopylskikhVM.Sprint4.Task3.V13.Lib
{
    public class DataService : ISprint4Task3V13
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, 2]; // третий столбец (индекс 2)
            }

            return sum;
        }
    }
}