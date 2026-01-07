using System;
using System.Collections.Generic;
using System.Text;

namespace LearningEnums
{
    /// <summary> 
    /// Luokka, joka demonstroi enum-tyyppien määrittelyä ja käyttöä. 
    /// </summary>
    class EnumShowcase
    {
        /// <summary> 
        /// Viikonpäiviä kuvaava enum. Arvot alkavat oletuksena nollasta.
        /// </summary>
        enum Days { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday };

        /// <summary> 
        /// Veden kiehumispisteet eri lämpötilayksiköissä. 
        /// Enum-arvoille annetaan eksplisiittiset kokonaislukuarvot.
        /// </summary>
        enum BoilingPoints { Celsius = 100, Fahrenheit = 212 };

        /// <summary> 
        /// Värit, joille on annettu arvot. 
        /// </summary>
        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

        private Days startDay;
        private Days endDay;
        private Colors color;

        // Konstruktori, joka alustaa enum-tyyppiset muuttujat oletusarvoilla.
        public EnumShowcase()
        {
            startDay = Days.Tuesday;
            endDay = Days.Friday;
            color = Colors.Yellow;
        }

        // Tulostaa enum-muuttujien nimet ja numeeriset arvot konsoliin.
        public void PrintDetails()
        {
            Console.WriteLine("startDay - name: " + startDay + " - value: " + (int)startDay);
            Console.WriteLine("endDay - name: " + endDay + " - value: " + (int)endDay);
            Console.WriteLine("color - name: " + color + " - value: " + (int)color);
        }

    }
}
