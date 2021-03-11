using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.isValidPassword("Abcd56efgh"));
            Console.WriteLine(pattern.isValidPassword("abcde89fgh"));
            Console.WriteLine(pattern.isValidPassword("ABCDEFGHdffgf"));
            Console.WriteLine(pattern.isValidPassword("Abcdsportal20"));
            Console.WriteLine(pattern.isValidPassword("asdsd@dff"));
            Console.WriteLine(pattern.isValidPassword("asdk"));



        }
    }
}
