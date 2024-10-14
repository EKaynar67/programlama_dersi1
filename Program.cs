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
       
        static void ageCalc()
        {
            DateTime moment = new System.DateTime(2024, 10, 14);
            int year = moment.Year;

            int birthYear = 0;
            int age = year - birthYear;
            int restYear = 50 - birthYear;
            birthYear = Convert.ToInt32(Console.ReadLine());
            //int calculation = 50 - (year - birthYear);



            Console.WriteLine("When were you born?");
            Console.Write(restYear + " years later you'll be 50 years old");
        }

        static int gpaCalculator(int visa, int final)
        {
            visa = visa * 40 / 100;
            final = final * 60 / 100;

            int average = visa + final;

                        //avg = (visa * 0.4) + (final * 0.6)


            if (visa + final < 65)
            {
                Console.Clear();
                Console.WriteLine("You are failed");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You are passed");
            }

            return average;
        }

        static void Main(string[] args)
        {

            
            
            
            Random rnd = new Random();

            Console.WriteLine(rnd.Next(5, 100%60));

            Console.WriteLine(rnd.Next(5, 10));

            Console.WriteLine(rnd.Next());






            /*
            int visaScore = 0, finalScore = 0;
            
            
            Console.WriteLine("Enter your visa and final scores...");

            visaScore = Convert.ToInt32(Console.ReadLine());
            finalScore = Convert.ToInt32(Console.ReadLine());


            gpaCalculator(visaScore, finalScore);
            

            Console.WriteLine($"Your GPA is {gpaCalculator(visaScore, finalScore)}");
            
            

            Console.WriteLine();




            //Console.Clear();
            //avg = (visa * 0.4) + (final * 0.6)
            */


            Console.ReadKey();
            
        }
    }
}


// bir kişi şehirler arası seyehat planı yapmakta
// kişi nevşehirden önce kayseriye ardından kayseriden adanaya son olarak da adanadan mersine gitmek istedi. buna göre kullanıcıya gideceği şehirler arası mesafeyi sorup toplamda gideceği mesafeyi hesaplayan ve ekrana yazan programı yazın.
