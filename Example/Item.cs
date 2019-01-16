using System;

namespace Example
{
    class Item
    {
        public string name;
        public int id;
        private static int counter = 0;

        public Item()
        {
            this.name = System.String.Empty;
            this.id = counter++;
        }

        public Item(string name)
        {
            this.name = name;
            this.id = counter++;
        }

        public override string ToString()
        {
            return this.id + " : "+ this.name;
        }
    }
}
