using System;

namespace yemek_tarifiıu
{
    class Program
    {
        static void Main(string[] args)
        {
            string yemekad;
            string malzemeler;

            Console.WriteLine("Yapmak istediğiniz yemeğin adını giriniz");
            yemekad=Console.ReadLine();

            Console.WriteLine("Yemek için gerekli malzemeleri giriniz");
            malzemeler = Console.ReadLine();

            Console.WriteLine("YEMEĞİN ADI" + yemekad);
            Console.WriteLine("GEREKLİ MALZEMELER" + malzemeler);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
