using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lock
{
    public class Singleton
    {

        private static Singleton Instance;
        private static object key = new object();

        protected Singleton()
        {

        }
        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                lock (key)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
            }

            return Instance;
        }
    }
}
