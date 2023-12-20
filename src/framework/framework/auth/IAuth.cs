using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace framework.auth
{
    interface IAuth
    {
         string Login();
         bool Register();
         bool ChangePassword();
    }
}
