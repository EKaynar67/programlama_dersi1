// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

/*

 - do not use Turkish chars
 - use meaningful variable names 
 - var names mustnt start with numbers however var names could have numbers
 - do not use uniqe symbols except "_" and "@ for abstract classes"
 - don't use space in variable name
 - commands which are belong to programming language can not be used a variable name
 - upper and lower letter sensvity is exist
 - variables which have same name can not be used in the same code block

 */

namespace NetApp
{
    internal class Program
    {
        static void sum(int x, int y)
        { 
            int result = x + y;
            Console.WriteLine(result + " written by a method");
        }

        static void Main(string[] args)
        {
            int x = 5, y = 14, result = 0;

            result = x + y;

            Console.WriteLine($"result = {result}");
            sum(x, y);
            Console.WriteLine("{0} {1} {2}", x, y, result);
            Console.WriteLine($"dsa {result}");


            Console.ReadKey();
            
        }
    }
}
