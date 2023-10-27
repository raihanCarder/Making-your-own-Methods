using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_your_own_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Raihan Carder

            Console.Title = "My Methods";

            Double perimeter = 3 + 4 + MyMethods.GetHypotenuse(3, 4);

            Console.WriteLine($"The perimeter is { perimeter } cm");
            Console.WriteLine(MyMethods.GetHypotenuse(3, 4));
            Console.WriteLine(MyMethods.Reverse("Mono"));
            Console.WriteLine(MyMethods.RootChecker(1, 3, 4));
            Console.WriteLine(MyMethods.GetCircumference(3));
            Console.WriteLine(MyMethods.GetAverage(1,3,6));
            Console.WriteLine(string.Join(", ", MyMethods.GetRandomArray(1,10,4)));
            Console.WriteLine(string.Join(", ", MyMethods.GetRandomList(1, 10, 10)));
            Console.WriteLine(MyMethods.GetAverage(1,4,5));

            Console.ReadLine();
        }
    }
}
