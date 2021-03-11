using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.isValidEmail("abc.xyz@bl.co.in"));
            Console.WriteLine(pattern.isValidEmail("abc@bl.co.in"));
            Console.WriteLine(pattern.isValidEmail("abc.xyz@bl.co"));
            Console.WriteLine(pattern.isValidEmail("abc.xyz@bl.co"));
            Console.WriteLine(pattern.isValidEmail("abc@bl.co.in.ap"));
            Console.WriteLine(pattern.isValidEmail("abc@gmail.co"));
            Console.WriteLine(pattern.isValidEmail("nandiniswaraj1995@gmail.com"));


        }
    }
}
