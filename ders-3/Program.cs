using System;

namespace ilkprojemiz
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Operatörler: +, -, /, -, ^, %
      int x = 5;
      int y = 10;
      if (x + y > 12)
      {
        Console.WriteLine("Verilen iki sayı 12'den büyük!");
      } else {
        Console.WriteLine("Pek olmadı gibi.");
      }
      
      // if: Eğer
      // else: Değilse
      Console.WriteLine("İsminiz nedir?");
      string isim = Console.ReadLine();
      if (isim == "Dinçer")
      {
        Console.WriteLine("Tanıdım seni " + isim);
      } else {
        Console.WriteLine("Aaa merhaba " + isim);
      }
      Console.ReadKey();
    }
  }
}
