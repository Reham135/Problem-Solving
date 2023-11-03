namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simple Calculator for 2 numbers (using function)
            Console.WriteLine("plz enter first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter second number");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter The Operation =>  +  -  *  / ");
            char Operation = char.Parse(Console.ReadLine());
            
            switch (Operation)
            {
                case '+':
                    Console.WriteLine($"The result is :{firstnumber + secondnumber}");
                    break;
                case '-':
                    Console.WriteLine($"The result is :{firstnumber - secondnumber}");
                    break;
                case '*':
                    Console.WriteLine($"The result is :{firstnumber * secondnumber}");
                    break;
                case '/':
                    if (secondnumber == 0)
                    {
                        Console.WriteLine("You can not devide by zero!!");
                    }

                    Console.WriteLine($"The result is :{firstnumber / secondnumber}");

                    break;
                default:
                    Console.WriteLine("Please Enter a valid Operation");
                    break;
                    // Console.WriteLine("Continue for another operation?");
            }
        }


    }
}
