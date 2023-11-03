namespace Max_Min_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this algorithm is linear that has time complexity is effectively O(n)
            int[] arr = new int[10];
            Console.WriteLine("Enter the 10 numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = arr[0];
            int max = arr[1];

            Console.WriteLine(" Enter array values ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("tha minimum number is " + min);
            Console.WriteLine("tha maximum number is " + max);




            //another solution{not recommended}..it is a bad algorithm you can solve with,,beacuse it has time complexity O(n^2)

            //int[] arr = new int[10];
            //int temp = 0;
            //Console.WriteLine("Enter the 10 numbers");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i <= arr.Length - 1; i++)

            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }

            //    }
            //}
            //Console.WriteLine("tha minimum number is "+ arr[0]);
            //Console.WriteLine("tha maximum number is " + arr[9]);

        }
    }
}