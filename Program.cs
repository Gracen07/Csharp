using System;
namespace Hello
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Enter a day");
            int day=int.Parse(Console.ReadLine());
            switch (day)
            {
                case 0:
                    Console.WriteLine("SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                default:
                    Console.WriteLine("enter a valid number between 0 and 6");
                    break;
            }
            }
    }
}
