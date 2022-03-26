namespace FDP
{
    internal class CoffeeMaker
    {
        public void PrepareCup() 
        {
            Console.WriteLine("Coffee cup placed to the machine");
        }
        public void AddCoffee() 
        {
            Console.WriteLine("Adding 2g of coffee to the cup");
        }
        public void AddMilk() 
        {
            Console.WriteLine("Adding 100ml of milk to the cup");
        }
        public void AddSugar() 
        {
            Console.WriteLine("Adding 2 tea spoon of sugar to the cup");
        }
        public void Mix() 
        {
            Console.WriteLine("Coffee is mixed and ready. Enjoy!");
        }
    }
}
