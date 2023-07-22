using System;
	public class AbortState: CoffeeMachineState
	{
		public AbortState()
		{
		}

    public override void abort(CoffeeMachine coffeeMachine)
    {
        Console.WriteLine("Already aborted!!");
    }

    public override void BrewBeverage(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Cant brew, aborting!!");
        }

        public override void DispenseBeverage(CoffeeMachine coffeeMachine)
        {
            Console.WriteLine("Cant dispense, aborting!!");
        }

        public override int DispenseCash(CoffeeMachine coffeeMachine)
        {
            coffeeMachine.SetState(new IdleState());
            Console.WriteLine("dispensing cash " + coffeeMachine.current_amount);
            return coffeeMachine.current_amount;
        }

        public override void InsertCoin(CoffeeMachine coffeeMachine, int amount)
        {
            Console.WriteLine("Cant insert coin, aborting!!");
        }

        public override void SelectBeverage(CoffeeMachine coffeeMachine, CoffeeMenu selection)
        {
            Console.WriteLine("Cant select, aborting!!");
        }
    }

