
using System;

namespace Wreek7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            food[3] = "Viinerid";
            string food = {"Võileib juusutga", "Peekon", "jogurt", "banaan", "muna"};


            Console.WriteLine("Menüüs on : ");
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

            {

                Console.Write("Vali toit (sisesta number 1-5 : ");
                int userChoice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Oled valinud : {food[userChoice]}");
                
            }
            
        }
    }
}

