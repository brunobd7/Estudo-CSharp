﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4Media
{
    
        public class MathUtils
        {
            public static double Average(int a, int b)
            {
                return (a + b)/ 2;
            }
            public static void Main(string[] args)
            {
                Console.WriteLine(Average(2, 1));
                Console.ReadKey();

            }
        }
    
}
