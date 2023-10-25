using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_your_own_Methods // Have to Change to Whatever Project we're using this class for
{
    static class MyMethods
    {
        ///<summary>
        ///This method returns the length of the hypotenuse of a right triangle when two legs are provided.
        ///</summary>
        ///<param name="a"> A double value representing the length of one leg of a right triangle.</param>
        ///<param name="b"> A double value representing the length of the second leg of a right triangle.</param>
        ///<returns>A double value representing the length of the hypotenuse of a right triangle.</returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        ///<summary>
        ///This method returns the length of the remaining leg of a right triangle when the hypotenuse and a leg are provided.
        ///</summary>
        ///<param name="a"> A double value representing the length of one leg of a right triangle.</param>
        ///<param name="hyp"> A double value representing the length of the hypotenuse of a right triangle.</param>
        ///<returns>A double value representing the length of the remaining leg of a right triangle.</returns>
        public static double GetLeg(double a, double hyp)
        {
            return Math.Sqrt(hyp - a);
        }

        ///<summary>
        ///This method returns the rise (y2-y1) a of two y values provided.
        ///</summary>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the rise (y2-y1) of two y-values provided.</returns>
        public static double GetRise(double y1, double y2)
        {
            return (y2 - y1);
        }

        ///<summary>
        ///This method returns the rise (y2-y1) of two coordinates provided.
        ///</summary>
        ///<param name="p1"> A Point value representing the first coordinate.</param>
        ///<param name="p2"> A Point value representing the second coordinate.</param>
        ///<returns>A double value representing the rise (y2-y1) of two coordinates provided.</returns>
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y);
        }

        ///<summary>
        ///This method returns the run (x2-x1) of two coordinates provided.
        ///</summary>
        ///<param name="x1"> A Point value representing the first coordinate.</param>
        ///<param name="x2"> A Point value representing the second coordinate.</param>
        ///<returns>A double value representing the run (x2-x1) of two coordinates provided.</returns>
        public static double GetRun(double x1, double x2)
        {
            return (x2 - x1);
        }

        ///<summary>
        ///This method returns the run (x2-x1) of two x values provided.
        ///</summary>
        ///<param name="p1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="p2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the rise (x2-x1) of two x-values provided.</returns>
        public static double GetRun(Point p1, Point p2)
        {
            return GetRun(p1.X, p2.X);
        }

        ///<summary>
        ///This method returns the distance between 2 coordinates.
        ///</summary>
        ///<param name="x1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="x2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the distance between two coordinates provided.</returns>
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) * Math.Pow((y2 - y1), 2));
        }

        ///<summary>
        ///This method returns the distance between 2 coordinates.
        ///</summary>
        ///<param name="p1"> A Point representing the first coordinate.</param>
        ///<param name="p2"> A Point representing the second coordinate.</param>
        ///<returns>A double value representing the distance between two coordinates provided.</returns>
        public static double GetDistance(Point p1, Point p2)
        {
            return GetHypotenuse(p2.Y - p1.Y, p2.X - p1.X);
        }
        ///<summary>
        ///This method returns the slope of a line passing through two coordinates.
        ///</summary>
        ///<param name="x1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="x2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the slope of a line containing the two coordinates provided.</returns>
        public static double GetSlope(double x1, double y1, double x2, double y2)
        {
            return (y2 - y1) / (x2 - x1);
        }  

        ///<summary>
        ///This method returns the slope of a line passing through two coordinates.
        ///</summary>
        ///<param name="p1"> A Point representing the first coordinate.</param>
        ///<param name="p2"> A Point representing the second coordinate.</param>
        ///<returns>A double value representing the slope of a line containing the two coordinates provided.</returns>
        public static double GetSlope(Point p1, Point p2)
        {
            return (p2.Y - p1.Y) / (p2.X - p1.X);
        }
        /// <summary>
        /// This method returns the y intercept of a slope given one cordinate.
        /// </summary>
        /// <param name="slope"> double representing Slope of Function.</param>
        /// <param name="p1"> Point Cordinates on said function.</param>
        /// <returns> A double value giving the Y intercept</returns>
        public static double GetYIntercept(double slope, Point p1)
        {
            double b = 0;
            b = (p1.Y - (slope * p1.X));
            return ((b * -1) / slope);
        }
        /// <summary>
        /// This method reverses a word.
        /// </summary>
        /// <param name="word"> Word that you want to be reversed</param>
        /// <returns> Reversed word </returns>
        public static string Reverse(string word)
        {
            char[] reverseWord = word.ToCharArray();
            Array.Reverse(reverseWord);
            string reversedWord = new string (reverseWord);
            return reversedWord;
        }
        /// <summary>
        /// This method returns the circumference when given the radius.
        /// </summary>
        /// <param name="radius"> Double value representing radius of circle</param>
        /// <returns> Returns Circumference of Circle</returns>
        public static double GetCircumference(double radius)
        {         
            return 2*Math.PI*radius;
        }
        /// <summary>
        /// This method finds the amount of roots when given the a,b, and c values.
        /// </summary>
        /// <param name="a"> double value representing a value in a quadratic equation.</param>
        /// <param name="b"> double value representing b value in a quadratic equation.</param>
        /// <param name="c"> double value representing c value in a quadratic equation.</param>
        /// <returns> Returns the amount of Roots in the equation.</returns>
        public static double RootChecker(double a, double b, double c)
        {
            double discriminant = 0;
            int numberRoots = 0;

            discriminant = ((b * b) - (4 * a * c));

            if (discriminant > 0)
            {
                numberRoots = 2;
            }
            else if (discriminant < 0)
            {
                numberRoots = 0;
            }
            else if (discriminant == 0)
            {
                numberRoots = 1;
            }
            else
            {
                Console.WriteLine("Error");
            }

            return numberRoots;
        }
        /// <summary>
        /// This method finds the Perimeter of a triangle when given 3 sides.
        /// </summary>
        /// <param name="side1"> Length of First Side of a Triangle.</param>
        /// <param name="side2"> Length of Second Side of a Triangle.</param>
        /// <param name="side3"> Length of third side of a Triangle.</param>
        /// <returns> Returns Perimeter of a Triangle.</returns>
        public static double PerimeterOfTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 + side3);
        }
        /// <summary>
        /// This method creates a random array and fills it within the given parameters.
        /// </summary>
        /// <param name="min">  Double value representing minimum value the array can generate.</param>
        /// <param name="max">  Double value representing maximum value the array can generate.</param>
        /// <param name="size"> Double value representing Size of the array.</param>
        /// <returns> Returns array made within those values.</returns>
        public static Array GetRandomArray(int min, int max, int size)
        {
            Random generator = new Random();
            double[] randomArray = new double[size];
            int number;
            for (int i = 0; i <= randomArray.Count(); i++)
            {
                number = generator.Next(min, max+1);
                randomArray[i] = number;
            }

            return randomArray;
               
        }
    }
    
}
