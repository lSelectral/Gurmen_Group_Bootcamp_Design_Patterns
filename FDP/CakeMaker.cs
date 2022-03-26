using System;
using System.Collections.Generic;
using System.Linq;
namespace FDP
{
    internal class CakeMaker
    {
        public void AddMilk() 
        {
            Console.WriteLine("Adding 1/2 Litre of milk");
        }
        public void AddEgg() 
        {
            Console.WriteLine("Adding 3 egg to the mix");
        }
        public void AddFlour() 
        {
            Console.WriteLine("Adding 400g of flour to the mix");
        }
        public void AddSugar() 
        {
            Console.WriteLine("Adding 3 glass of sugar to the mix.");
        }
        public void AddBakingSoda() 
        {
            Console.WriteLine("Adding 1 spoon of baking soda to the mix.");
        }
        public void AddCocao() 
        {
            Console.WriteLine("Adding half glass of cocao to the mix");
        }
        public void Mix() 
        {
            Console.WriteLine("Mixing the ingredients of the cake");
            Console.WriteLine("Cake is ready");
        }
    }
}
