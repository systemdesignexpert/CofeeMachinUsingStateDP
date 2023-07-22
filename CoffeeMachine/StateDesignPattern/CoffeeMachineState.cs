public abstract class CoffeeMachineState
{

    
    public abstract void InsertCoin(CoffeeMachine coffeeMachine, int amount);
    public abstract void SelectBeverage(CoffeeMachine coffeeMachine,CoffeeMenu selection);
    public abstract void BrewBeverage(CoffeeMachine coffeeMachine);
    public abstract void DispenseBeverage(CoffeeMachine coffeeMachine);
    public abstract void abort(CoffeeMachine coffeeMachine);
    public abstract int DispenseCash(CoffeeMachine coffeeMachine);
}
