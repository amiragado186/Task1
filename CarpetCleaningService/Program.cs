using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarpetCleaningService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of small carpets:");
            int NumSmallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number of large carpets:");
            int NumLargeCarpet = Convert.ToInt32(Console.ReadLine());
            int SmallCarpetPrice = NumSmallCarpet * 25;
            int LargeCarpetPrice = NumLargeCarpet * 35;
            int Cost = SmallCarpetPrice + LargeCarpetPrice;
            double Tax = Cost * 0.06;
            double Total = Tax + Cost;
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine($"Number of small carpets: {NumSmallCarpet} <--");
            Console.WriteLine($"Number of large carpets: {NumLargeCarpet} <--");
            Console.WriteLine("Price per small carpet: $25");
            Console.WriteLine("Price per large carpet: $35");
            Console.WriteLine($"Cost : ${Cost}");
            Console.WriteLine($"Tax: ${Tax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${Total}");
            Console.WriteLine("This estimate is valid for 30 days");

        }
    }
}
