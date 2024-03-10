using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Helpers.Exceptions;
using Task.Services;

namespace Task.Controllers
{
    public class CustomMathController
    {
        public CustomMathService _customMath;

        public CustomMathController()
        {
            _customMath = new CustomMathService();
        }
        public void Factorial()
        {
            try
            {
                Console.WriteLine("Please add number:");
                string text = Console.ReadLine();

                if (!int.TryParse(text, out int number))
                {
                    throw new CustomMathException("Format is wrong.");
                }

                if (number < 0)
                {
                    throw new CustomMathException("Number must be positive.");
                }

                var response = _customMath.Factorial(number);

                Console.WriteLine("Result: " + response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
