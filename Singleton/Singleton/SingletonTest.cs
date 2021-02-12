using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonTest
    {
   
            static List<string> list;
            static SingletonTest singleInstance = null;
            private static readonly object lockingObject = new object();
            private SingletonTest()
            {
                list = new List<string>();
            }
            public static SingletonTest Instance
            {
                get
                {
                    lock (lockingObject)
                    {
                        if (singleInstance == null)
                        {
                            singleInstance = new SingletonTest();
                        }
                    }
                    return singleInstance;
                }
            }
            public void AddToList(string a, string b, string c, string d)
            {
                list.Add(a);
                list.Add(b);
                list.Add(c);
                list.Add(d);
            }
        }
}
