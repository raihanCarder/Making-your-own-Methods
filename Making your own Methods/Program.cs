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
            Double perimeter = 3 + 4 + MyMethods.GetHypotenuse(3, 4);

            Console.WriteLine($"The perimeter is { perimeter } cm");
            Console.WriteLine(MyMethods.GetHypotenuse(3, 4));
            Console.WriteLine(MyMethods.Reverse("Mono"));
            MyMethods.GetRandomArray(1,10,10);

            Console.ReadLine();
        }
    }
}
