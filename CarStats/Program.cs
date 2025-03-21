using System;
using Bogus;
using Spectre.Console;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            BarChart bc = new BarChart();
            bc.AddItem("Dacia",12);

            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker();

        }
    }
}
