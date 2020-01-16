using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_01
{
    public class DannyShovevany
    {
        public event EventHandler<MissingEmplEventArgs> MissingEmployeeEventHandler;

        private void OnMissingEmployee(string myPosition)
        {
            if (MissingEmployeeEventHandler != null)
            {
                MissingEmployeeEventHandler.Invoke(this, new MissingEmplEventArgs { PositionName = myPosition });
            }
        }

        public void PlayTrick()
        {
            OnMissingEmployee("Clown");
        }

        public override string ToString()
        {
            return "ha ha fool you!";
        }
    }
}
