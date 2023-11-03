namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Calculate ur birth date
            int CurrentYear = DateTime.Now.Year;
            int CurrentMonth = DateTime.Now.Month;
            int CurrentDay = DateTime.Now.Day;
            Console.WriteLine("Enter Year");
            int Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month");
            int Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Day");
            int Day = int.Parse(Console.ReadLine());
            int YY = CurrentYear - Year;
            int MM = CurrentMonth - Month;
            int DD = CurrentDay - Day;
            if (Year > CurrentYear)
            {
                Console.WriteLine("Please Enter a Valid Year");
            }
            else if (Day < 0 || Day > 31)
            {
                Console.WriteLine("Please Enter a Valid Day");
            }
            else
            {

                if (MM < 0)
                {
                    YY -= 1;
                    MM += 12;
                }
                if (MM < 0) ;
                {
                    YY -= 1;
                    MM += 12;
                }
                if (DD < 0)
                {
                    MM -= 1;
                    switch (MM)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            DD += 31;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            DD += 30;
                            break;
                        case 2:
                            DD += 28;
                            break;
                    }

                }
                if (MM >= 12)
                {
                    YY += 1;
                    MM -= 12;
                }
                Console.WriteLine($"{YY} {MM} {DD}");
            }
        }
    }
}