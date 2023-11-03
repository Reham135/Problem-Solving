namespace Find_The_Occurance_of_1_in_100_million_in_one_second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string value = "99999999";
            //int length = value.Length;
            //int numOFRepeat =(int) (length * Math.Pow(10, length - 1));
            //Console.WriteLine(numOFRepeat);



            ////another solution
            Console.WriteLine("Enter a Number");
            int value = int.Parse(Console.ReadLine());
            string valueStr = Convert.ToString(value);
            int length = valueStr.Length;
            double numOFRepeat = length * Math.Pow(10, length - 1);
            Console.WriteLine(numOFRepeat);

            ////another solution


            //int count = 0;
            //for (int i = 1; i < 99999999; i++)
            //{
            //    count += i.ToString().Split('1').Length - 1;
            //}
            //Console.WriteLine(count);
        }
    }
}









/*
 •	How can you count the occurrence of 1 from 1 to 99,999,999 (1 short of 100 million) and total up how many 1s were there.

(Convert Numbers to String in Case one and use String Functions to Count 1s, 
Use Only Mathematical Functions and Numeric values in case 2 and see the difference in performance) 
Is There Any Other Way to Do it in Approximately 1 Second or less

 
 */