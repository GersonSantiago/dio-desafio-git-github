using JogoRpgDio.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpgDio
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 21, "Knight", 450, 90);
            Wizzard wizzard = new Wizzard("Angel", 23, "White Wizzard", 480, 100);
            BlackWizzard blackWizzard = new BlackWizzard("Magnos", 41, "Black Wizzard", 550, 110);
            Ninja ninja = new Ninja("Kaydo", 35, "Ninja", 520, 100);

            Console.Write("Enter hero type (Knigth/White Wizzard/Black Wizzard/Ninja: ");
            string heroType = Console.ReadLine();
            if (heroType == "Knight" || heroType == "knight")
            {
                Console.WriteLine(knight);
                Console.WriteLine(knight.Attack());
            }
            else if (heroType == "Wizzard" || heroType == "wizzard")
            {
                Console.WriteLine(wizzard);
            }
            else if (heroType == "BlackWizzard" || heroType == "blackWizzard")
            {
                Console.WriteLine(blackWizzard);
            }
            else if (heroType == "Ninja" || heroType == "ninja")
            {
                Console.WriteLine(ninja);
            }
            else
            {
                Console.WriteLine("Opção invalida, tente novamente!");
            }





            Console.ReadLine();
        }
    }
}
