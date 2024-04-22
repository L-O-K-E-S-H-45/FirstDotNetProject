using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._28_3_24.OOP
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
