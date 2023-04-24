using System;
using static ConsoleATM.PmeAtmMachine;

namespace ConsoleATM
{
    class DebitCardInsertedState : IMachineState
    {
        PmeAtmMachine pmeAtmMachine;
        public DebitCardInsertedState()
        {
            pmeAtmMachine = new PmeAtmMachine();
        }
        public void ejectDebitCard()
        {
            Console.WriteLine("Debit card ejected successfully");
        }

        public void enterPinAndWithdrawMoney()
        {
            Console.WriteLine("Welcome to PME microfinance bank!!!");
            Console.WriteLine("");
            Console.Write("Enter the Pin: ");
            int pin = int.Parse(Console.ReadLine());
            if (pmeAtmMachine._pin == pin)
            {
                Console.Write("Enter the amount: ");
                int amount = int.Parse(Console.ReadLine());
                if (amount > pmeAtmMachine._balance)
                {
                    Console.WriteLine("Isufficient Fund!!!");
                    Console.WriteLine("");
                    Console.WriteLine("******************************************");
                }
                else
                {
                    pmeAtmMachine._balance = pmeAtmMachine._balance - amount;
                    Console.WriteLine("");
                    Console.WriteLine("Please collect your cash");
                    Console.WriteLine("Remaining Balance is {0}", pmeAtmMachine._balance);
                    Console.WriteLine("***************************************");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Pin.");
                Console.WriteLine("");
                Console.WriteLine("******************************************");
            }
        }

        public void HasCardInsertedState()
        {
            Console.WriteLine("Debit card is already there, so can not insert debit card");
        }
    }
}

