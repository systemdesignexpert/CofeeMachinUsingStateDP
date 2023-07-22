using System;

public class BeverageSelectedState : CoffeeMachineState
{
    public override void InsertCoin(CoffeeMachine coffeeMachine, int amount)
    {
        Console.WriteLine("Coin already inserted.");
    }

    public override void SelectBeverage(CoffeeMachine coffeeMachine, CoffeeMenu selection)
    {
        Console.WriteLine("Beverage already selected.");
    }

    public override void BrewBeverage(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Brewing beverage...");
        coffeeMachine.SetState(new BrewedState());
    }

    public override void DispenseBeverage(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot dispense a beverage without brewing it first.");
    }

    public override int DispenseCash(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("cant dispense cash.");
        return 0;
    }

    public override void abort(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Aborting...");
        coffeeMachine.SetState(new AbortState());
    }
}
    