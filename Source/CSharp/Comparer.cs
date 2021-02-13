using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharp
{
    public class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int rollNo { get; set; }

        public int CompareTo(Student other)
        {
            // ASC
            if (this.rollNo > other.rollNo) return 1;
            if (this.rollNo < other.rollNo) return -1;
            return 0;
        }
    }

    public class StudentComparer : IComparer<Student>
    {
        // reverse (DESC)
        public int Compare(Student x,Student y)
        {
            if (x.rollNo > y.rollNo) return -1;
            if (x.rollNo < y.rollNo) return 1;
            return 0;
        }
    }

    public static class Utility<T> where T : IComparable<T>
    {
        public static T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
