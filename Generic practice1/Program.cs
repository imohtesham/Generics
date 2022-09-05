using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] intarray = { 1, 2, 3 };
            double[] doublearray = { 1.1, 2.2, 3.3 };
            char[] chararray = { 'a', 'b', 'c', 'd', 'e', };
            new PrintArray<int>(intarray).toprint();
            new PrintArray<double>(doublearray).toprint();
            new PrintArray<char>(chararray).toprint();



            Console.WriteLine("Find  maximum number");
            int output = Findmaximum.FindMaxValue(11, 55, 77);
            Console.WriteLine("Find  maximum number");
            Console.WriteLine(output);
            
            double Output = Findmaximum.FinddoubleValue(33.22, 22.55 ,43.33);
            Console.WriteLine("Find  maximum number");
            Console.WriteLine(Output);

            float OutPut = Findmaximum.FindfloatValue(1.1f, 5.5f, 7.6f);
            Console.WriteLine("Find  maximum number");
            Console.WriteLine(OutPut);
            */
            Console.WriteLine("Find  maximum number");

            int[] intarray = { 1, 2, 3 };
            GenericsMax<int> generic = new GenericsMax<int>(intarray);
            generic.printmaxvalue();

            double[] doublearray = { 23.2, 34.4, 24.8 };
            GenericsMax<double> genericd  = new GenericsMax<double>(doublearray);
            genericd.printmaxvalue();

            string[] stringarrayy = { "232", "344", "667" };
            GenericsMax<string> stringA = new GenericsMax<string>(stringarrayy);
            stringA.printmaxvalue();




        }
    }
}
