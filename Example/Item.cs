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
            this.name = String.Empty;
            this.id = counter++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Item(string name)
        {
            this.name = name;
            this.id = counter++;
        }

        public override string ToString()
        {
            return this.id + " : " + this.name;
        }

        public override bool Equals(Object obj)
        {
            Item itemObj = obj as Item;
            if (itemObj == null)
            {
                return false;
            }
            else
            {
                // compare only name
                return this.name.Equals(itemObj.name);
            }
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }
}
