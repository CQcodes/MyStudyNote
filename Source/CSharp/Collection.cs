using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Collection
    {
        // non-generic collections
        public Stack NGStack { get; set; }
        public Queue NGQueue { get; set; }
        public ArrayList NGList { get; set; }
        public Hashtable NGDictionary { get; set; }

        // generic collections
        public Stack<int> GStack { get; set; }
        public Queue<int> GQueue { get; set; }
        public List<int> GList { get; set; }
        public Dictionary<int,int> GDictionary { get; set; }
        public SortedDictionary<int, int> sortedDictionary { get; set; }
        public SortedList<int,int> sortedList { get; set; }
        public SortedSet<int> sortedSet { get; set; }

        public void TryNGCollections()
        {
            IEnumerable v = new int[2];
            IEnumerable<Student> s = new List<Student>();
            IEnumerator v1 = v.GetEnumerator();
            IEnumerator<Student> s1 = s.GetEnumerator();
            //IEquatable<Student> ??
            //IEqualityComparer<Student> ??
        }
    }
}
