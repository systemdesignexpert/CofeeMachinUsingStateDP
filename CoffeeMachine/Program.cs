class Program
{
    static void Main()
    {
        CoffeeMachine coffeeMachine = new CoffeeMachine();

        coffeeMachine.InsertCoin(10);  // Coin inserted.
        coffeeMachine.SelectBeverage(CoffeeMenu.AMERICANO);  // Beverage selected.
        coffeeMachine.BrewBeverage();  // Brewing beverage...
        coffeeMachine.DispenseBeverage();  // Dispensing the brewed beverage.
        coffeeMachine.DispenseCash(); // return cash

        coffeeMachine.InsertCoin(40);  // Coin inserted.
        coffeeMachine.SelectBeverage(CoffeeMenu.AMERICANO);  // Beverage already selected.
        coffeeMachine.BrewBeverage();  // Brewing beverage...
        coffeeMachine.DispenseBeverage();  // Dispensing the brewed beverage.
        coffeeMachine.DispenseCash();

        coffeeMachine.InsertCoin(40);  // Coin inserted.
        coffeeMachine.DispenseCash();
        coffeeMachine.SelectBeverage(CoffeeMenu.AMERICANO);  // Beverage already selected.
        coffeeMachine.BrewBeverage();  // Brewing beverage...
        coffeeMachine.Abort();
        coffeeMachine.DispenseBeverage();  // Dispensing the brewed beverage.
        coffeeMachine.DispenseCash();

        coffeeMachine.InsertCoin(40);  // Coin inserted.
        coffeeMachine.SelectBeverage(CoffeeMenu.AMERICANO);  // Beverage already selected.
        coffeeMachine.Abort();
        coffeeMachine.BrewBeverage();  // Brewing beverage...
        coffeeMachine.DispenseBeverage();  // Dispensing the brewed beverage.
        coffeeMachine.DispenseCash();

        Console.WriteLine("TEST CASE");
        coffeeMachine.DispenseBeverage();
        coffeeMachine.Abort();
        coffeeMachine.InsertCoin(40);
        coffeeMachine.SelectBeverage(CoffeeMenu.CAPPUCCINO);
        coffeeMachine.DispenseCash();
        coffeeMachine.BrewBeverage();
        coffeeMachine.DispenseBeverage();
        coffeeMachine.Abort();
        coffeeMachine.DispenseCash();



        Console.WriteLine("Total cash = " + coffeeMachine.totalCash);

    }
}
