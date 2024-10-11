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
       
        static void Main(string[] args)
        {
            string name = "Ahmet";
            string surName = "Golbasi";
            int no = 38;
            string address = "Merkez / Nevşehir";
            int a = 0;
            /*
            Console.WriteLine($"Adı: {name}");
            Console.WriteLine($"Soyadı: {surName}");
            Console.WriteLine($"No: {no}");
            Console.WriteLine($"Adres: {address}");

            Console.WriteLine($"Adı:    {name}");
            Console.WriteLine($"Soyadı: {surName}");
            Console.WriteLine($"No:     {no}");
            Console.WriteLine($"Adres:  {address}");
            */

            Console.Write($"Adı: \t {name} \nSoyadı:\t {surName} \nNo: \t {no} \nAdres: \t {address}");
            //Console.WriteLine();
            Console.WriteLine();
            //Console.Write($"\nAdı: \t {name} \nSoyad:\t {surName} \nNo: \t {no} \nAdres: \t {address}");

            Console.WriteLine("Sırasıyla adınızı soyadınızı numaranızı ve adresinizi girin.");

            name = Console.ReadLine();
            surName = Console.ReadLine();
            no = Convert.ToInt32(Console.ReadLine()); 
            address = Console.ReadLine();

            Console.Clear();


            Console.Write($"\nAdı: \t {name} \nSoyad:\t {surName} \nNo: \t {no} \nAdres: \t {address}");

            

            Console.ReadKey();
            
        }
    }
}
