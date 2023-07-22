using System;

public class CoffeeMachine
{
    public int totalCash;
    public Dictionary<CoffeeMenu, int> inventory;

    public int current_amount;
    public CoffeeMenu current_selection;

    public CoffeeMachineState State { get; private set; }

    public CoffeeMachine()
    {
        totalCash = 0;
        inventory = new Dictionary<CoffeeMenu, int>();
        inventory[CoffeeMenu.AMERICANO] = 100;
        inventory[CoffeeMenu.CAPPUCCINO] = 100;
        inventory[CoffeeMenu.FILTER] = 100;
        inventory[CoffeeMenu.ESPRESSO] = 100;
        inventory[CoffeeMenu.LATTE] = 100;

        current_amount = 0;
        current_selection = 0;

        State = new IdleState();
    }

    public void SetState(CoffeeMachineState state)
    {
        State = state;
    }

    public void InsertCoin(int amount)
    {
        State.InsertCoin(this, amount);
    }

    public void SelectBeverage(CoffeeMenu selection)
    {
        State.SelectBeverage(this, selection);

    }

    public void BrewBeverage()
    {
        State.BrewBeverage(this);
    }

    public void DispenseBeverage()
    {
        State.DispenseBeverage(this);
    }

    public void DispenseCash()
    {
        State.DispenseCash(this);
    }

    public void Abort()
    {
        State.abort(this);
    }
}
