using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class Person
    {
        private int _age;
        private string _lastName;

        // property
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Ikä pitää olla välillä 0 ja 100.");
                }
                else
                {
                    _age = value;
                }
            }
        }

        // property
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        // constructor
        public Person()
        {
            _age = -1;
            _lastName = String.Empty;
        }
    }
}
