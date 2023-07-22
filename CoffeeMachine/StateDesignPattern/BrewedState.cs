using System;

public class BrewedState : CoffeeMachineState
{
    public override void InsertCoin(CoffeeMachine coffeeMachine, int amount)
    {
        Console.WriteLine("Cannot insert a coin after brewing the beverage.");
    }

    public override void SelectBeverage(CoffeeMachine coffeeMachine, CoffeeMenu selection)
    {
        Console.WriteLine("Cannot select a beverage after brewing the current one.");
    }

    public override void BrewBeverage(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot brew a new beverage until the current one is dispensed.");
    }

    public override void DispenseBeverage(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Dispensing the brewed beverage.");
        coffeeMachine.inventory[coffeeMachine.current_selection]--;
    }

    public override void abort(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Coffee already brewed, can not abort now.");
    }

    public override int DispenseCash(CoffeeMachine coffeeMachine)
    {
        coffeeMachine.totalCash += CoffeePrices.Prices[(int)coffeeMachine.current_selection];
        coffeeMachine.SetState(new IdleState());
        int return_amount = coffeeMachine.current_amount - CoffeePrices.Prices[(int)coffeeMachine.current_selection];
        Console.WriteLine("Dispensing the remaining cash " + return_amount);
        return return_amount;
    }
}
