using System;

namespace CSharp
{
    internal class Person
    {
        public string fname { get; set; }
        public string lname { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return this == null ? true : false;
            if (obj is Person)
                return this.fname == ((Person)obj).fname && this.lname == ((Person)obj).lname;
            else
                return false;
        }
    }

    public class EqualsMethodDemo
    {
        public void Execute()
        {
            int i = 2;int j = 2;
            Console.WriteLine("Comparing two ValueTypes(int) with same values => i & j");
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"j = {j}");
            Console.WriteLine($"i == j => {i == j}");
            Console.WriteLine($"i.Equals(j) => {i.Equals(j)}");

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            int m = 1; int n = 2;
            Console.WriteLine("Comparing two ValueTypes(int) with diff. values => m & n");
            Console.WriteLine($"m = {m}");
            Console.WriteLine($"n = {n}");
            Console.WriteLine($"m == n => {m == n}");
            Console.WriteLine($"m.Equals(n) => {m.Equals(n)}");

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            var person1 = new Person{ fname = "Virat", lname = "Kohli" };
            var person2 = new Person { fname = "Virat", lname = "Kohli" };
            Console.WriteLine("Comparing two Reference Variable pointing to two separate (Person) objects => person1 & person2");
            Console.WriteLine($"person1.fname = {person1.fname} , person1.lname = {person1.lname}");
            Console.WriteLine($"person2.fname = {person2.fname} , person2.lname = {person2.lname}");
            Console.WriteLine($"person1 == person2 => {person1 == person2}");
            Console.WriteLine($"person1.Equals(person2) => {person1.Equals(person2)}");

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            var person3 = person1;
            Console.WriteLine("Comparing two Reference Variable pointing to same (Person) objects => person1 & person3");
            Console.WriteLine($"person1 == person3 => {person1 == person3}");
            Console.WriteLine($"person1.Equals(person3) => {person1.Equals(person3)}");

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            var obj1 = (object)person1;
            var obj2 = (object)person2;
            Console.WriteLine($"obj1 == obj2 => {obj1 == obj2}");
            Console.WriteLine($"obj1.Equals(obj2) => {obj1.Equals(obj2)}");
        }
    }
}
