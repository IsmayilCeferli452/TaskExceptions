﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Services.Interfaces;

namespace Task.Services
{
    public class CustomMathService : ICustomMathService
    {
        public int Factorial(int number)
        {
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
