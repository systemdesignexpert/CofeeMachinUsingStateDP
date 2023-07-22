using System;

public class IdleState : CoffeeMachineState
{
    public IdleState()
    {

    }
    public override void InsertCoin(CoffeeMachine coffeeMachine, int amount)
    {
        Console.WriteLine("Coin inserted for amount: " + amount);
        coffeeMachine.current_amount = amount;
        coffeeMachine.SetState(new CoinInsertedState());
    }

    public override void SelectBeverage(CoffeeMachine coffeeMachine, CoffeeMenu selection)
    {
        Console.WriteLine("Cannot select a beverage without inserting a coin.");
    }

    public override void BrewBeverage(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot brew a beverage without inserting a coin and selecting a beverage.");
    }

    public override void DispenseBeverage(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot dispense a beverage without brewing it first.");
    }

    public override int DispenseCash(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot dispense cash.");
        return 0;
    }

    public override void abort(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot abort without inserting cash or making selection");
    }
}
