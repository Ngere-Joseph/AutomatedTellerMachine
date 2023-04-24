using System;

namespace ConsoleATM
{
    public class PmeAtmMachine : IMachineState
    {
            private IMachineState _state;
            public int _balance = 5000;
            public int _pin = 1234;
            public PmeAtmMachine()
            {
                _state = new NoDebitCardInsertedState();
            }
            public IMachineState GetMachineState()
            {
                return _state;
            }
            public void setIMachineState(IMachineState state)
            {
                this._state = state;
            }
            public void ejectDebitCard()
            {
                _state.ejectDebitCard();

                if (_state is DebitCardInsertedState)
                {
                    _state = new NoDebitCardInsertedState();
                    Console.WriteLine("State Changed");
                    Console.WriteLine(_state.GetType().Name);
                }
            }
            public void enterPinAndWithdrawMoney()
            {
                if (_state is DebitCardInsertedState)
                {
                    _state.enterPinAndWithdrawMoney();
                }
            }

            public void HasCardInsertedState()
            {

                if (_state is NoDebitCardInsertedState)
                {
                    _state = new DebitCardInsertedState();
                    Console.WriteLine("State Changed");
                    Console.WriteLine(_state.GetType().Name);
                    Console.WriteLine("************************************");
                }

            }

        }
    }

