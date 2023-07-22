using System;
using static System.Collections.Specialized.BitVector32;

public class CoinInsertedState : CoffeeMachineState
{
    public override void InsertCoin(CoffeeMachine coffeeMachine, int amount)
    {
        
        Console.WriteLine("Coin already inserted.");
    }

    public override void SelectBeverage(CoffeeMachine coffeeMachine, CoffeeMenu selection)
    {
        
        if (coffeeMachine.current_amount >= CoffeePrices.Prices[(int)selection])
        {
            coffeeMachine.current_selection = selection;
            coffeeMachine.SetState(new BeverageSelectedState());
            Console.WriteLine("Beverage selected. Price: " + CoffeePrices.Prices[(int)selection]);
        } else
        {
            Console.WriteLine("Can't select Beverage. Need " + CoffeePrices.Prices[(int)selection] + " atleast for this.");
            this.abort(coffeeMachine);
        }
        
    }

    public override void BrewBeverage(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot brew a beverage without selecting one.");
    }

    public override void DispenseBeverage(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot dispense a beverage without brewing it first.");
    }

    public override int DispenseCash(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Cannot dispense a cash without brewing it first.");
        return 0;
    }

    public override void abort(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Aborting..");
        coffeeMachine.SetState(new AbortState());
    }
}
