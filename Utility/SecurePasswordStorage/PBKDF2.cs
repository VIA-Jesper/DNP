using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SecurePasswordStorage
{
    public class PBKDF2Class : IPasswordSecurity
    {

        // These constants may be changed without breaking existing hashes.
        public const int SALT_BYTES = 24;
        public const int HASH_BYTES = 18;
        public const int PBKDF2_ITERATIONS = 180000;
        private HashAlgorithmName hashAlgorithmName = HashAlgorithmName.SHA512;
        private const string DELIMITER = "/";

        // These constants define the encoding and may not be changed.
        public const int HASH_SECTIONS = 4;
        public const int ITERATION_INDEX = 0;
        public const int HASH_SIZE_INDEX = 1;
        public const int SALT_INDEX = 2;
        public const int PBKDF2_INDEX = 3;


        public string CreateHash(string password)
        {
            // Generate a random salt
            byte[] salt = new byte[1];

            using var csprng = new RNGCryptoServiceProvider();
            csprng.GetBytes(salt);


            byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTES);

            // format: iterations/hashSize/salt/hash
            String parts = PBKDF2_ITERATIONS + DELIMITER + hash.Length + DELIMITER + Convert.ToBase64String(salt) + DELIMITER + Convert.ToBase64String(hash);
            return parts;
        }

        public bool VerifyPassword(string password, string goodHash)
        {
            char[] delimiter = DELIMITER.ToCharArray();
            string[] split = goodHash.Split(delimiter);

            if (split.Length != HASH_SECTIONS)
            {
                throw new Exception("Fields are missing from the password hash."
                );
            }


            int iterations = 0;
            iterations = Int32.Parse(split[ITERATION_INDEX]);


            if (iterations < 1)
            {
                throw new Exception("Invalid number of iterations. Must be >= 1.");
            }

            byte[] salt = null;
            salt = Convert.FromBase64String(split[SALT_INDEX]);


            byte[] hash = null;
            hash = Convert.FromBase64String(split[PBKDF2_INDEX]);


            int storedHashSize = 0;
            storedHashSize = Int32.Parse(split[HASH_SIZE_INDEX]);


            if (storedHashSize != hash.Length)
            {
                throw new Exception("Hash length doesn't match stored hash length.");
            }

            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }
            return diff == 0;
        }

        private byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, hashAlgorithmName))
            {
                pbkdf2.IterationCount = iterations;
                return pbkdf2.GetBytes(outputBytes);
            }
        }



    }
}
