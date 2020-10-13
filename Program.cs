using System;

namespace PoP_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_04();

        }
        private static void Task_01()
        {
            Console.Write("Side A: ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Side B: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.Write("Side C: ");
            int sideC = int.Parse(Console.ReadLine());

            if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                Console.WriteLine("There are 2 equal sides.");

                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("There are 3 equal sides.");
                    Console.WriteLine("A, B, C are equal.");
                }
                else
                {
                    if (sideA == sideB)
                    {
                        Console.WriteLine("A is equal to B");
                    }
                    else if (sideB == sideC)
                    {
                        Console.WriteLine("B is equal to C");
                    }
                    else
                    {
                        Console.WriteLine("A is equal to C");
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no equal sides");
            }
            












        }
        private static void Task03()
        {
            Console.Write($"Please enter your height in cm.: ");
            int height = int.Parse(Console.ReadLine());

            if (height > 190)
            {
                Console.WriteLine("Basketball");
            }
            else if (height > 175)
            {
                Console.WriteLine("Athletics");
            }
            else
            {
                Console.WriteLine("Horse riding");
            }
        }
        private static void Task_04()
        {
            int weekDay = 1;
            int hour = 22;

            string partOfTheDay = GetPartOfTheDay(hour);
            string weekDayName = GetDayOfTheWeek(weekDay);
            string periodToTheWeekend = GetPeriodToTheWeekend(weekDay);

            Console.WriteLine($"Good {partOfTheDay}, it is a lovely {weekDayName} today. {periodToTheWeekend}");
        }

        private static string GetPartOfTheDay(int hour)
        {
            if (hour < 6 || hour > 20)
            {
                return "night";
            }
            else if (hour < 10)
            {
                return "morning";
            }
            else if (hour < 16)
            {
                return "day";
            }
            else
            {
                return "evening";
            }
        }

        private static string GetPeriodToTheWeekend(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return $"Weekend is coming in {6 - dayNumber}";

                case 6:
                case 7:
                    return "Weekend is here";

                default:
                    return "It is knknown time of the week";
            }
        }

        private static string GetDayOfTheWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "Error!";
            }
        }


    }











}

       

        
            
        
            


        
    