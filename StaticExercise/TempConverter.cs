using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            // C = (F - 32) * 5 / 9;
            var answer = (fahrenheit - 32) * 5 / 9;
            return answer;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            var answer = (celsius * 9) / 5 + 32;
            return answer;
        }
    }
}
