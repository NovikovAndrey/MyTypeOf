using System;

namespace MyTypeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(User);
            Console.WriteLine(type.ToString());
        }
    }
}
