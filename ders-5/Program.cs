using System;

namespace ilkprojemiz
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Insan ben = new Insan("Dinçer", 19);
      Console.WriteLine(ben.isim);
      Console.ReadKey();
    }
  }

  class Insan
  {
    public string isim;
    int yas;
    
    public Insan(string isim, int yas)
    {
      this.isim = isim;
      this.yas = yas;
    }
  }
}
