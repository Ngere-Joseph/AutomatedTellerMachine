using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleATM
{
    class NoDebitCardInsertedState :IMachineState
    {
        public void ejectDebitCard()
        {
            Console.WriteLine("No debit card inside atm");
            Console.WriteLine("**************************************");
        }

        public void enterPinAndWithdrawMoney()
        {
            Console.WriteLine("No debit card in ATM Machine, so you can not withdraw money");
        }

        public void HasCardInsertedState()
        {
            Console.WriteLine("Debit Card Inserted");
        }
    }
}
