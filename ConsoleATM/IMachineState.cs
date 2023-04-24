using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleATM
{
    public interface IMachineState
    {
        void HasCardInsertedState();
        void ejectDebitCard();
        void enterPinAndWithdrawMoney();
    }
}
