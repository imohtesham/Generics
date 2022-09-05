using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_practice1
{
    internal class Findmaximum
    {
       public static int FindMaxValue(int first, int second, int third)
            {
                if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                {
                    Console.WriteLine("first value is greater");
                    return first;
                }
                else if (second.CompareTo(first) >= 0 && second.CompareTo(third) > 0)
                {
                    Console.WriteLine("second value is greater");
                    return second;

                }
                else if (third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
                {
                    Console.WriteLine("third value is greater");
                    return third;
                }
                else
                {
                    Console.WriteLine("/n may 2 0r 3 numbers having same value ");
                    return first;

                }

            }
      
       public static float FindfloatValue(float first, float second, float third)
            {
                if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                {
                    Console.WriteLine("first value is greater");
                    return first;
                }
                else if (second.CompareTo(first) >= 0 && second.CompareTo(third) > 0)
                {
                    Console.WriteLine("second value is greater");
                    return second;

                }
                else if (third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
                {
                    Console.WriteLine("third value is greater");
                    return third;
                }
                else
                {
                    Console.WriteLine("/n may 2 0r 3 numbers having same value ");
                    return first;

                }

            }

       public static double FinddoubleValue(double first, double second, double third)
            {
                if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                {
                    Console.WriteLine("first value is greater");
                    return first;
                }
                else if (second.CompareTo(first) >= 0 && second.CompareTo(third) > 0)
                {
                    Console.WriteLine("second value is greater");
                    return second;

                }
                else if (third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
                {
                    Console.WriteLine("third value is greater");
                    return third;
                }
                else
                {
                    Console.WriteLine("/n may 2 0r 3 numbers having same value ");
                    return first;

                }

            }
        
    }

}

