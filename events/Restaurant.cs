using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_01
{
    public class Restaurant
    {
        public event EventHandler<VegEventArgs> RunOutOfVegtablesEventHandler;

        public event EventHandler<MissingEmplEventArgs> MissingEmployeeEventHandler;

        private int tomatoCount = 2;

        private void OnRunOutOfVegtables(List<string> veg)
        {
            if (RunOutOfVegtablesEventHandler != null)
            {
                RunOutOfVegtablesEventHandler.Invoke(this, new VegEventArgs { Vegtables = veg });
            }
        }

        public void MakeSalad()
        {
            tomatoCount--;
            if (tomatoCount <= 0)
            {
                // for example ran out of tomato
                OnRunOutOfVegtables(new List<string> { "Tomato" });
            }
        }

        public void EmployeeCallingSick(string myPosition)
        {
            OnMissingEmployee(myPosition);
        }

        private void OnMissingEmployee(string myPosition)
        {
            if (MissingEmployeeEventHandler != null)
            {
                MissingEmployeeEventHandler.Invoke(this, new MissingEmplEventArgs { PositionName = myPosition });
            }
        }

        public override string ToString()
        {
            return "Cafe smadar Hertzel 80 Tel aviv";
        }
    }
}
