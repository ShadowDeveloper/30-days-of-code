class Program
{
  static void Main(string[] args)
  {
      int n = Convert.ToInt32(Console.ReadLine());

      for (var j = 0; j <= n - 1; j++)
      {
          string txt1 = Console.ReadLine();

          for (var i = 0; i <= txt1.Length - 1; i++)
          {
              if (i % 2 == 0)
              {
                  Console.Write(txt1[i]);
              }
          }

          Console.Write(" ");

          for (var i = 0; i <= txt1.Length - 1; i++)
          {
              if (i % 2 != 0)
              {
                  Console.Write(txt1[i]);
              }
          }

          Console.Write(Environment.NewLine);
      }

      Console.ReadKey();
  }
}