using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KopylskikhVM.Sprint4.Task7.V16.Lib
{
    public class DataService : ISprint4Task7V16
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int prod = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[i * m + j].ToString());

                    if (matrix[i, j] % 2 == 0)
                    {
                        prod *= matrix[i, j];
                    }
                }
            }

            return prod;
        }
    }
}