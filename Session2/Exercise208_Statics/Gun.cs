using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise208_Statics
{
    class Gun
    {
        public static int gunCount, bulletCount;
        public int shotsFired;

        public Gun()
        {
            gunCount++;
        }

        public void Shoot()
        {
            Console.WriteLine("BANG!");
            bulletCount++;
            shotsFired++;
        }
    }
}
