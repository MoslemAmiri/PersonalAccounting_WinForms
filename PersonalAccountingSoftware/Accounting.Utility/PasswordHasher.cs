using System;
using System.Security.Cryptography;
using System.Text;

namespace Accounting.Utility
{
    public class PasswordHasher : IPasswordHasher
    {
        SHA256CryptoServiceProvider _sHA256 = new SHA256CryptoServiceProvider();

        public bool Check(string hash, string password)
        {
            byte[] byte1 = Encoding.UTF8.GetBytes(password);
            byte[] byte2 = _sHA256.ComputeHash(byte1);
            string hashPassword = BitConverter.ToString(byte2);

            return hashPassword == hash;
        }

        public string Hash(string password)
        {
            byte[] byte1 = Encoding.UTF8.GetBytes(password.Trim());
            byte[] byte2 = _sHA256.ComputeHash(byte1);
            return BitConverter.ToString(byte2);
        }
    }
}