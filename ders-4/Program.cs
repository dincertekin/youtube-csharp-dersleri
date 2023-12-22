using System;

namespace ilkprojemiz
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // 0'dan 99'a kadar saydıralım.
      for (int i = 0; i 100; i++)
      {
        Console.WriteLine(i);
      }

      // Tüm sayıları sırasıyla ekrana yazdıralım.
      int[] sayilar = { 1, 4, 9, 12, 5, 7 };
      for (int i = 0; i < sayilar.Length; i++)
      {
        Console.WriteLine(sayilar[i]);
      }
      
      Console.ReadKey();
    }
  }
}
