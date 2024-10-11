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
        static int distanceCalculator(int x, int y, int z)
        {
            Console.Write(x + y + z);
            return x + y + z;
        }
       
        static void Main(string[] args)
        {
            int n_k = 0;
            int k_a = 0;
            int a_m = 0;

            Console.WriteLine("Nevşehir ile Kayseri arasındaki mesafeyi giriniz");
            n_k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kayseri ile Adana arasındaki mesafeyi giriniz");
            k_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adana ile Mersin arasındaki mesafeyi giriniz");
            a_m = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Gideceğiniz toplam mesafe{distanceCalculator(n_k, k_a, a_m)}"); 

            //distanceCalculator(n_k, k_a, a_m);

            Console.ReadKey();
            
        }
    }
}


// bir kişi şehirler arası seyehat planı yapmakta
// kişi nevşehirden önce kayseriye ardından kayseriden adanaya son olarak da adanadan mersine gitmek istedi. buna göre kullanıcıya gideceği şehirler arası mesafeyi sorup toplamda gideceği mesafeyi hesaplayan ve ekrana yazan programı yazın.
