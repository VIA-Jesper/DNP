using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace SecurePasswordStorage
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = new PBKDF2Class().CreateHash("123");
            Console.WriteLine(result);


            var verify = new PBKDF2Class().VerifyPassword("123", "180000/18/AdvyLQ3YCMI+VsNbD8K5QrhIqqzmfPOv/7Q3xeeJzWVNRz3JjJWilIqsg");
            Console.WriteLine("Result verify: " + verify);
            //Console.WriteLine("Hello World!");


            //IPasswordSecurity pws = new PBKDF2Class();

            //var hash = pws.CreateHash("1234");
            //var base64encoded = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(hash));
            //Console.WriteLine(base64encoded);

            //var base64decoded = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(base64encoded));
            //Console.WriteLine(base64decoded);


            //var verify = pws.VerifyPassword("1234", "sha1:64000:18:6OHVMruoaGSuUO5Gqld27sRd1qGK61D+:aZmf5sDIBZAGqQx5a8QLd+PD");
            //Console.WriteLine(verify);
            //Console.ReadLine();


        }
    }
}
