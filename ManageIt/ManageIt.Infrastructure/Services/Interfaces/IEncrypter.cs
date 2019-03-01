using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ManageIt.Infrastructure.Services.Interfaces
{
    public interface IEncrypter
    {
        string GetSalt();
        string GetHash(string value, string salt);
    }
}
