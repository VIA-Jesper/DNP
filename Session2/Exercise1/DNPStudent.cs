using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class DNPStudent : Student
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi, Im a DNP Student");
            base.SayHi();
        }
    }
}
