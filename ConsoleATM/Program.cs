using System;

namespace ConsoleATM
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PmeAtmMachine atmMachine = new PmeAtmMachine();

            atmMachine.enterPinAndWithdrawMoney();
            atmMachine.ejectDebitCard();
            atmMachine.HasCardInsertedState();

            atmMachine.enterPinAndWithdrawMoney();
            atmMachine.HasCardInsertedState();
            atmMachine.ejectDebitCard();

            Console.ReadLine();   
        }
    }
}

    

