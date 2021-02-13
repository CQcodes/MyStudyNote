using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public delegate void PrintNameHelper(string fname, string lname);
    public class Anonymous
    {
        public PrintNameHelper anonymousMethod;
    }
}
