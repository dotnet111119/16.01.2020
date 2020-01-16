using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_01
{
    public class HR
    {
        public void SendEmployee(object sender, MissingEmplEventArgs miss)
        {
            if (sender.GetType().Name != "DannyShovevany")
            {
                Console.WriteLine($"Sending employee of type {miss.PositionName} to {sender}");
            }
        }
    }
}
