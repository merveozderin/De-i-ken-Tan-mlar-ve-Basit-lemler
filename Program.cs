using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool b1= true;
            bool b2= false;

            DateTime dt = DateTime.Now ;
            Console.WriteLine(dt);

            string str1 =string.Empty ;
            str1 = "Merve Özderin";
            string ad = "Doğa" ;
            string soyad = "Hayat" ;
            string tamisim = ad + " " + soyad ;

            bool bool1 = 5<3 ;
            bool bool2 = 8>6 ;

            //Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20 ;
            string yenideger = str20 + int20.ToString() ;
            Console.WriteLine(yenideger); // Elde edilen çıktı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Elde edilen çıktı 40

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22); // Elde edilen çıktı yine 40 olacaktır

            // Datetime

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy") ;
            Console.WriteLine(datetime1) ;

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy") ;
            Console.WriteLine(datetime2) ;

            //Saat

            string datetime3 = DateTime.Now.ToString("HH:mm") ;
            Console.WriteLine(datetime3) ;

        






        }
    }
}
