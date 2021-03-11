using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.isValidMobileNumber("91 9876543210"));
            Console.WriteLine(pattern.isValidMobileNumber("7870237660"));
            Console.WriteLine(pattern.isValidMobileNumber("8976543210"));
            Console.WriteLine(pattern.isValidMobileNumber("9876543210"));
            Console.WriteLine(pattern.isValidMobileNumber("09876543215"));
            Console.WriteLine(pattern.isValidMobileNumber("0987654321"));
            Console.WriteLine(pattern.isValidMobileNumber("98765432102"));
            Console.WriteLine(pattern.isValidMobileNumber("765432198"));


        }
    }
}
