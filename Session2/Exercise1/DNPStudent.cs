﻿using System;

namespace Exercise201
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
