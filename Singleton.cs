using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class Singleton
    {
        private static Singleton singleton = null;
        private static readonly object singletonLock = new object();
        Singleton() { }
        public static Singleton SingleInstance
        {
            get 
            { 

            }
        }
    }
}
