using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //sealed impede a herança
    public sealed class SecurityManager
    {
        private static SecurityManager instance;
        private SecurityManager()
        {

        }

        public static SecurityManager getInstance()
        {
            if (instance==null)
            {
                instance = new SecurityManager();
            }
            return instance;
        }
        public void login()
        {

        }
    }
}
