using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        var tip = 12 * (Decimal.Divide(tip_percent, 100));
        var tax = 12 * (Decimal.Divide(tax_percent, 100));
        var totalCost = Math.Round(tip + tax + Convert.ToInt32(meal_cost));
        Console.WriteLine("The total meal cost is " + totalCost + " dollars.");
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do alimento");
        double meal_cost = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o percentual da gorgeta");
        int tip_percent = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o percentual da taxa");
        int tax_percent = int.Parse(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);

    }
}
