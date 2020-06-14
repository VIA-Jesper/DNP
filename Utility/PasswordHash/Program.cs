using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace PasswordHash
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] salt;
            byte[] hashBytes;
            string pw = "123";
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                salt = hmac.Key;
                hashBytes = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pw));
            }
            string hashed = hashBytes.Aggregate("", (s, e) => s + String.Format("{0:x2}", e), s => s);
            string salted = salt.Aggregate("", (s, e) => s + String.Format("{0:x2}", e), s => s);

            Console.WriteLine("Salt: " + salted);
            Console.WriteLine("Hash: " + hashed);


            Console.ReadLine();
        }
    }
}
