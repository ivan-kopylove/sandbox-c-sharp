﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox_c_sharp
{
    public class SomeSut
    {
        public int calculate(int one, int two)
        {
            return one + two;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
        }
    }
}
