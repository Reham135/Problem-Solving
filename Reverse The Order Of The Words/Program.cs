namespace Reverse_The_Order_Of_The_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence ");
            string userSentence = Console.ReadLine();
            userSentence = String.Join(" ", userSentence.Split(' ').Reverse());
            Console.WriteLine("The senrence after reversing is : " + userSentence);
        }
    }
}








/*
 •	Given a list of space separated words, reverse the order of the words.

Input: this is a test		Output: test a is this
Input: all your base		Output: base your all
Input: Word			Output: Word

 */