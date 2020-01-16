using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lock
{
    public class MyCodedList
    {

        //System.Collections.Concurrent.ConcurrentBag
        // not thread safEE1
        private List<string> items;

        public const string SECRET_CODE = "12345";
        public int i = 1;
        //public static object key = new object(); -- will lock all of the instances
        public object key = new object();

        public MyCodedList()
        {
            items = new List<string>();
        }

        public void Add(string s, string code)
        {
            if (code == SECRET_CODE)
            {
                lock (this){
                    try
                    {
                        Monitor.Enter(key);

                        // crticial section
                        items.Add(s);
                    }
                    finally
                    {
                        Monitor.Exit(key);
                    }
                }
            }
        }

        public string GetAt(int index, string code)
        {
            if (code == SECRET_CODE)
            {
                lock (key)
                {
                    return items[index];
                }
            }
            return "Unautherized! hacker!";
        }

        public void RemoveAt(int index, string code)
        {
            if (code == SECRET_CODE)
            {
                lock (key)
                {
                    items.RemoveAt(index);
                }
            }
        }
    }
}
