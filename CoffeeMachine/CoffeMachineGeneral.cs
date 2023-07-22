using System;

public class CoffeeMachineGeneral
{

    
    private enum MachineState
    {
        Idle,
        CoinInserted,
        BeverageSelected,
        Brewed
    }

    private MachineState state;

    public CoffeeMachineGeneral()
    {
        state = MachineState.Idle;
    }

    public void InsertCoin()
    {
        switch (state)
        {
            case MachineState.Idle:
                Console.WriteLine("Coin inserted.");
                state = MachineState.CoinInserted;
                break;
            case MachineState.CoinInserted:
                Console.WriteLine("Coin already inserted.");
                break;
            case MachineState.BeverageSelected:
                Console.WriteLine("Cannot insert a coin after selecting a beverage.");
                break;
            case MachineState.Brewed:
                Console.WriteLine("Cannot insert a coin after brewing the beverage.");
                break;
        }
    }

    public void SelectBeverage()
    {
        switch (state)
        {
            case MachineState.Idle:
                Console.WriteLine("Cannot select a beverage without inserting a coin.");
                break;
            case MachineState.CoinInserted:
                Console.WriteLine("Beverage selected.");
                state = MachineState.BeverageSelected;
                break;
            case MachineState.BeverageSelected:
                Console.WriteLine("Beverage already selected.");
                break;
            case MachineState.Brewed:
                Console.WriteLine("Cannot select a beverage after brewing the current one.");
                break;
        }
    }

    public void BrewBeverage()
    {
        switch (state)
        {
            case MachineState.Idle:
                Console.WriteLine("Cannot brew a beverage without inserting a coin and selecting a beverage.");
                break;
            case MachineState.CoinInserted:
                Console.WriteLine("Cannot brew a beverage without selecting one.");
                break;
            case MachineState.BeverageSelected:
                Console.WriteLine("Brewing beverage...");
                state = MachineState.Brewed;
                break;
            case MachineState.Brewed:
                Console.WriteLine("Cannot brew a new beverage until the current one is dispensed.");
                break;
        }
    }

    public void DispenseBeverage()
    {
        switch (state)
        {
            case MachineState.Idle:
                Console.WriteLine("Cannot dispense a beverage without brewing it first.");
                break;
            case MachineState.CoinInserted:
                Console.WriteLine("Cannot dispense a beverage without brewing it first.");
                break;
            case MachineState.BeverageSelected:
                Console.WriteLine("Cannot dispense a beverage without brewing it first.");
                break;
            case MachineState.Brewed:
                Console.WriteLine("Dispensing the brewed beverage.");
                state = MachineState.Idle;
                break;
        }
    }
}
