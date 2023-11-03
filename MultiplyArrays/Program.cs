namespace MultiplyArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region first question
            // First Array
            int[,] arr1 =   { {3 , 2 },
                              {1 , 3 },
                              {4 , 5 } };

            // Second Array

            int[,] arr2 = { { 1 }
                           ,{ 2 } };


            //Array for multiplication
            int[,] mult = new int[arr1.GetLength(0), arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    mult[i, j] = 0;
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        mult[i, j] += arr1[i, k] * arr2[k, j];

                    }
                }
            }

            //print array
            for (int i = 0; i < mult.GetLength(0); i++)
            {
                for (int j = 0; j < mult.GetLength(1); j++)
                {
                    Console.WriteLine(mult[i, j]);
                }
            }
            #endregion


            #region second question
            // matrix1
            int[,] matrix1 = {  {1,2,3 },
                                {4,5,6 },
                                {7,8,9 } };

            //matrix2
            int[,] matrix2 = {  {1,3 },
                                {4,5 },
                                {3,5 } };

            //matrix3
            int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix3[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }//print
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    Console.WriteLine(matrix3[i, j]);

                }

            }
            #endregion
        }
    }
}