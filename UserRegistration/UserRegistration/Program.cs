using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.isValidLastName("Abcdef"));
            Console.WriteLine(pattern.isValidLastName("abc"));
            Console.WriteLine(pattern.isValidLastName("ABC"));
            Console.WriteLine(pattern.isValidLastName("AB"));



        }
    }
}
