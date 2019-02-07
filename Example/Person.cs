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

        // method returns details about the person object
        // if given name match to object's name
        public Person GetPersonInfo(string name)
        {
            if (this._lastName.Equals(name))
            {
                return this;
            }

            // return null, because names don't match
            return null;
        }

        public override string ToString()
        {
            return $"{this._lastName}, {this._age}";
        }
    }
}
