using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.isValidPassword("Abcdefgh"));
            Console.WriteLine(pattern.isValidPassword("abcdefgh"));
            Console.WriteLine(pattern.isValidPassword("ABCDEFGH"));
            Console.WriteLine(pattern.isValidPassword("Abgfdswerrtty54657"));
            Console.WriteLine(pattern.isValidPassword("asdsd@dff"));
            Console.WriteLine(pattern.isValidPassword("asdk"));



        }
    }
}
