using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using framework.db;
namespace framework.auth
{
    class AuthService<T> : IAuth
    {
        private readonly IRepository<T> _authRepository;
        public AuthService(IRepository<T> authRepository)
        {
            _authRepository = authRepository;
        }
        public string Login()
        {
            return "";
        }
        public bool Register()
        {
            return false;
        }
        public bool ChangePassword()
        {
            return false;
        }
    }
}
