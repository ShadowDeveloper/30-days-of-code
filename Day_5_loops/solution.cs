class Program
{
  class Program
  {
      static void NumRecebidoLoop(int num)
      {
          int result;
          for (var i = 1; i <= 10; i++)
          {
              result = num * i;
              Console.WriteLine(num + " x " + i + " = " + result);
          }
          Console.ReadKey();
      }

      static void Main(string[] args)
      {
          int n = Convert.ToInt32(Console.ReadLine());
          NumRecebidoLoop(n);
      }
  }
}