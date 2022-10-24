using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //sealed impede a herança
    public sealed class SecurityManager2
    {
        private static SecurityManager2 instance = new SecurityManager2();//Crianda antes mesmo de realmente precisar.

        private SecurityManager2()
        {

        }

        public static SecurityManager2 getInstance()
        {
          return instance;
        }
        public void login()
        {

        }
    }
}
