//Facade Design Pattern

using FDP;

RestaurantFacade restaurantFacade = new(new CakeMaker(), new CoffeeMaker());

restaurantFacade.OrderCake();
Console.WriteLine("\n---------------------------------\n");
restaurantFacade.OrderCoffee();