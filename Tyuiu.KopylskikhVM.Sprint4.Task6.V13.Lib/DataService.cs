using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KopylskikhVM.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            Array.ForEach(array, item =>
            {
                if (item.Length > 4)
                {
                    count++;
                }
            });

            return count;
        }
    }
}