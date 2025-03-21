using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {

                CanvasImage tux = new CanvasImage("tux.jpg");

                tux.MaxWidth(24);

                AnsiConsole.Write(tux);
            }
        }
    }
}