using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksExample
{
    internal class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{this.author}: {this.title}, {this.price} €";
        }
    }
}
