namespace FDP
{
    internal class RestaurantFacade
    {
        private readonly CakeMaker _cakeMaker;
        private readonly CoffeeMaker _coffeeMaker;

        public RestaurantFacade(CakeMaker cakeMaker, CoffeeMaker coffeeMaker)
        {
            _cakeMaker = cakeMaker;
            _coffeeMaker = coffeeMaker;
        }

        public void OrderCake()
        {
            _cakeMaker.AddMilk();
            _cakeMaker.AddEgg();
            _cakeMaker.AddFlour();
            _cakeMaker.AddSugar();
            _cakeMaker.AddBakingSoda();
            _cakeMaker.AddCocao();
            _cakeMaker.Mix();
        }

        public void OrderCoffee()
        {
            _coffeeMaker.PrepareCup();
            _coffeeMaker.AddCoffee();
            _coffeeMaker.AddMilk();
            _coffeeMaker.AddSugar();
            _coffeeMaker.Mix();
        }
    }
}