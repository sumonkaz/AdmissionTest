using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Bulb
    {
        public event EventHandler? On;
        public event EventHandler? Off;

        public void TurnOn()
        {
            On?.Invoke(this, EventArgs.Empty);
        }

        public void TurnOff()
        {
            Off?.Invoke(this, EventArgs.Empty);
        }
    }
}
