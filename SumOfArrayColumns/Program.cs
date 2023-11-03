namespace SumOfArrayColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array of 3 rows,4 cols   
            int[,] arr = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Enter Number at Index {i},{j}");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Value at Index {i},{j} is {arr[i, j]}");
                }
            }
            #endregion

            #region calculating the sum of columns
            int sum;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                sum = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[j, i];
                }
                Console.WriteLine($"coulumn{i + 1}: {sum}");
                #endregion
            }
        }
    }
}