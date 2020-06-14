using System;
using System.Collections.Generic;
using System.Text;

namespace SecurePasswordStorage
{
    interface IPasswordSecurity
    {
        public string CreateHash(string password);
        public bool VerifyPassword(string password, string goodHash);

    }
}
