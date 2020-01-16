using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Yarkan yatzataTzadik = new Yarkan();
            Restaurant smadar = new Restaurant();

            smadar.RunOutOfVegtablesEventHandler += yatzataTzadik.SupplyFast;

            HR hr = new HR();
            smadar.MissingEmployeeEventHandler += hr.SendEmployee;

            smadar.EmployeeCallingSick("Cook");

            DannyShovevany danny = new DannyShovevany();
            danny.MissingEmployeeEventHandler += hr.SendEmployee;
            danny.PlayTrick();


            smadar.MakeSalad();
            smadar.MakeSalad();
        }
    }
}
