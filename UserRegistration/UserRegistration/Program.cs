using System;

namespace UserRegistration
{
    class Program 
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("All Valid Mails");
            Console.WriteLine(pattern.isValidEmail("abc@yahoo.com"));
            Console.WriteLine(pattern.isValidEmail("abc-100@yahoo.com"));
            Console.WriteLine(pattern.isValidEmail("abc.100@yahoo.com"));
            Console.WriteLine(pattern.isValidEmail("abc.111@abc.com"));
            Console.WriteLine(pattern.isValidEmail("abc-100@abc.net"));
            Console.WriteLine(pattern.isValidEmail("abc.100@abc.com.au"));
            Console.WriteLine(pattern.isValidEmail("abc@1.com"));
            Console.WriteLine(pattern.isValidEmail("abc@gmail.com.com"));
            Console.WriteLine(pattern.isValidEmail("abc+100@gmail.com"));

            Console.WriteLine("All Invalid mails");
            Console.WriteLine(pattern.isValidEmail("abc"));
            Console.WriteLine(pattern.isValidEmail("abc@.com"));
            Console.WriteLine(pattern.isValidEmail("abc123@gmail.a"));
            Console.WriteLine(pattern.isValidEmail("abc123@.com"));
            Console.WriteLine(pattern.isValidEmail("abc123@.com.com"));
            Console.WriteLine(pattern.isValidEmail(".abc@abc.com"));
            Console.WriteLine(pattern.isValidEmail("abc()*@gmail.com"));
            Console.WriteLine(pattern.isValidEmail("abc@%*.com"));
            Console.WriteLine(pattern.isValidEmail("abc..2002@gmail.com"));
            Console.WriteLine(pattern.isValidEmail("abc.@gmail.com"));
            Console.WriteLine(pattern.isValidEmail("abc@abc@gmail.com"));
            Console.WriteLine(pattern.isValidEmail("abc@gmail.com.1a"));
            Console.WriteLine(pattern.isValidEmail("abc@gmail.com.aa.au"));





        }
    }
}
