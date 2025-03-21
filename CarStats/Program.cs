using System;
using System.Security.Cryptography.X509Certificates;
using Bogus;
using Bogus.DataSets;
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
            Faker faker = new Faker("V");
            
        }
         public string Manufacturer()
        {
            return GetRandomArrayItem("manufacturer");
        }

        private string GetRandomArrayItem(string v)
        {
            throw new NotImplementedException();
        }
    }
}
