using System;

namespace Example
{
    class Item
    {
        public string name;
        public int id;
        private static int counter = 0;

        /*
         * Default Constructor, no parameters
         */
        public Item()
        {
            this.name = String.Empty;
            // set id equal to counter
            this.id = counter++;
        }

        /*
         * Constructor, one parameter (name)
         */
        public Item(string name)
        {
            this.name = name;
            // set id equal to counter
            this.id = counter++;
        }

        /*
         * Override the ToString method.
         * Method returns a string representation of the object.
         */
        public override string ToString()
        {
            return this.id + " : " + this.name;
        }

        /*
         * Override the Equals method.
         * Method compares two objects and returns true or false.
         */
        public override bool Equals(Object obj)
        {
            // Convert type from Object to Item
            Item itemObj = obj as Item;

            if (itemObj == null)
            {
                return false;
            }
            else
            {
                // compare name
                bool isNameEqual = this.name.Equals(itemObj.name);
                // compare id
                bool isIdEqual = this.id.Equals(itemObj.id);
                return isNameEqual && isIdEqual;
            }
        }

        /*
         * Override the GetHashCode method.
         * GetHashCode() must be overrided, when Equals() is overridden.
         */
        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }
}
