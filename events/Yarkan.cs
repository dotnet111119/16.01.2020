using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_01
{
    public class Yarkan
    {
        public void SupplyFast(object sender, VegEventArgs veg)
        {
            veg.Vegtables.ForEach(v => { Console.WriteLine($"supply fast 100 KG of {v} to {sender}"); });
        }
    }
}
