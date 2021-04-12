using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        private string name;
        public string Title
        {
            get { return name; }
            set { name = value; }
        }
        public void Display()
        {
            Console.WriteLine($"Hello! {Title}");
        }

    }
}
