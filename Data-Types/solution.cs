using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static void Main(string[] args)
    {

        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int r;
        double e;
        string text;

        Console.WriteLine("Digite um inteiro:");
        r = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite um double:");
        e = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite um texto:");
        text = Console.ReadLine();

        Console.WriteLine("Soma dos inteiros:");
        Console.WriteLine(r + i);

        Console.WriteLine("Soma dos Doubles:");
        Console.WriteLine(String.Format("{0:0.0}", d + e));

        Console.WriteLine("Textos concatenados:");
        Console.WriteLine(s + " " + text);

        Console.ReadKey();

    }
}
