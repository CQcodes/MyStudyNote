using System;

namespace CSharp
{
    public class File
    {
        public string Title { get; set; }
        public int Size { get; set; }
    }

    public static class ShallowCopy
    {
        public static void PerformShallowCopy()
        {
            var file1 = new File() { Title = "FileOne", Size = 5 };
            var file2 = file1;
            file1.Title = "FileOne-Edited";
            file2.Size = 10;

            Console.WriteLine("Copied file1 to file2. Changed File1 Title(str) and Size(int) properties.");
            Console.WriteLine($"File1 Title : {file1.Title}");
            Console.WriteLine($"File1 Size : {file1.Size}");
            Console.WriteLine($"File2 Title : {file2.Title}");
            Console.WriteLine($"File2 Size : {file2.Size}");
        }
    }
}
