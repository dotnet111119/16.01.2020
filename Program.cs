using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16._01_
{
    class Program
    {
        public static void Foo1(object o)
        {
            Console.WriteLine(o);
        }
        public static void Foo2()
        {
            Console.WriteLine("no args");
        }
        public static void MyCallback(object o)
        {
            Console.WriteLine(o);
        }
        static void Main(string[] args)
        {
            /*
            Thread t = new Thread(Foo1);
            t.Start("Hello");

            Thread t2 = new Thread(Foo2);
            t2.Start();

            new Thread(o => Console.WriteLine(o)).Start("hello");

            */
            /*
            Thread t4 = new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Woke up");
            });
            t4.IsBackground = true;
            t4.Start();
            */

            //ThreadPool.QueueUserWorkItem(o => { Console.WriteLine(); }, "hello");
            ThreadPool.QueueUserWorkItem(MyCallback, "hello");

            Console.WriteLine("Main has ended.....");
            
        }
    }
}
