using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class VarvsDynamicvsObject
    {
        private dynamic GetPerson()
        {
            dynamic d = new Person();
            return d;
            //return new Person { fname = "New", lname = "Person"};
            //return new object();
        }

        public void Execute()
        {
            Person d1 = GetPerson();
            d1.fname = "dynamic-person-fname";
            d1.lname = "dynamic-person-lname";
            Console.WriteLine($"Dyanmic Person : {d1.fname} {d1.lname}");
        }
    }
}
