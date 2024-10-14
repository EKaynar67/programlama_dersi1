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
        static int distanceCalculator()
        {

            Console.WriteLine("Nevşehir ile Kayseri arasındaki mesafeyi giriniz");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Kayseri ile Adana arasındaki mesafeyi giriniz");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Adana ile Mersin arasındaki mesafeyi giriniz");
            int z = Convert.ToInt32(Console.ReadLine());
            int result = x + y + z;            

            Console.Write($"Gideceğiniz toplam mesafe: {result}");

            return result;
        }
       
        static void Main(string[] args)
        {

            distanceCalculator();


            Console.ReadKey();
            
        }
    }
}


// bir kişi şehirler arası seyehat planı yapmakta
// kişi nevşehirden önce kayseriye ardından kayseriden adanaya son olarak da adanadan mersine gitmek istedi. buna göre kullanıcıya gideceği şehirler arası mesafeyi sorup toplamda gideceği mesafeyi hesaplayan ve ekrana yazan programı yazın.
