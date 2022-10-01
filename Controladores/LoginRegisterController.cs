using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    internal class LoginRegisterController
    {

        public static Login login1
        {
            get
            {
                if (_login1 == null)
                {
                    _login1 = new Login();
                }
                return _login1;
            }
        }

        public static Register register1
        {
            get
            {
                if (_register1 == null)
                {
                    _register1 = new Register();
                }
                return _register1;
            }
        }

        private static Login _login1;
        private static Register _register1;

    }
}
