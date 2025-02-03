using System;

namespace ilkprojemiz
{
  internal class Program
  {
    static void Main(string[] args)
    {
      try
      {
        int a = 5;
        int b = 10;
        if (a > b)
        {
          throw new Exception ("a, b'den buyuk olamaz!");
        } else
        {
          int toplam = a + b;
          Console.WriteLine(toplam);
        }
      } catch (Exception ex)
      {
          Console.WriteLine(ex.ToString());
      }
      finally
      {
        Console.WriteLine("Tum kodlar yurutuldu, her sey tamam. Finally calisti.");
      }
    }
  }
}
