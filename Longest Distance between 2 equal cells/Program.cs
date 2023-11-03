namespace Longest_Distance_between_2_equal_cells
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maxLength = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        int length = j - (i + 1);
                        maxLength = Math.Max(maxLength, length);
                    }
                }
            }
            Console.WriteLine("Longest length between duplicates: " + maxLength);





        //    //another solution

        //    Console.WriteLine("Enter the size of the array:");
        //    int size = int.Parse(Console.ReadLine());

        //    int[] arr = new int[size];

        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.WriteLine("Enter a number");
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }
        //    int maxLength = 0;

        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < arr.Length; j++)
        //        {
        //            if (arr[j] == arr[i])
        //            {
        //                int length = j - (i + 1);
        //                if (length > maxLength)
        //                {
        //                    maxLength = length;
        //                }
        //            }
        //        }
        //    }
        //    Console.WriteLine("Longest length between duplicates: " + maxLength);
        }
    }
}









/*
 •	Consider an Array of Integer values with size N, having values as in this
Example

7	0	0	0	5	6	7	5	0	7	5	3

Your task will be to write a program find the longest distance between
Two equal cells. In this example. The distance is measured by the number
Of cells- for example, the distance between the first and the fourth cell is
2 (cell 2 and cell 3).
In the example above, the longest distance is between the first 7 and the
10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
And the 10th 7s.
Note:
- Array values will be taken from the user
- If you have input like 1111111 then the distance is the number of
Cells between the first and the last cell.

 
 */