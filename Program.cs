using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)// Kontrol etmek istediğimiz koşulu yazarız.
            {
                case 1: // month değeri 1 e eşit ise bu kod bloğuna girer.
                    Console.WriteLine("Ocak Ayındasınız");
                    break; // kod bloğu çalıştıktan sonra break ile switch yapısından çıkarız.
                case 2:
                    Console.WriteLine("Şubat Ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız");
                    break;

                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındasınız");
                    break;
                default:
                    break;
            }
        }
    }
}
