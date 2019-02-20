using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class EnumTest
    {
        enum Days { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };
        enum BoilingPoints { Celsius = 100, Fahrenheit = 212 };
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

        private Days startDay;
        private Days endDay;
        private Colors color;

        public EnumTest()
        {
            startDay = Days.Tuesday;
            endDay = Days.Friday;
            color = Colors.Yellow;
        }

        public void PrintDetails()
        {
            Console.WriteLine("startDay - name: " + startDay + " - value: " + (int)startDay);
            Console.WriteLine("endDay - name: " + endDay + " - value: " + (int)endDay);
            Console.WriteLine("color - name: " + color + " - value: " + (int)color);
        }

    }
}
