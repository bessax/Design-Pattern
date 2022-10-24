using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SecurityManager3
    {
        private static readonly object instancelock = new object();// Para ser usado no lock;
        private static SecurityManager3 instance;
        private SecurityManager3()
        {

        }

        public static SecurityManager3 getInstance()
        {            
            if (instance == null)
            {
                lock (instancelock)// para implementar sincronismo com Threads
                {
                    if (instance == null)
                    {
                        instance = new SecurityManager3();
                    }
                }
            }
            return instance;
        }
        public void login()
        {

        }
    }
}
