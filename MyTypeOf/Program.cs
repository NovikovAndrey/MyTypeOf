using System;

namespace MyTypeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("MyTypeOf.User", false, true);
            foreach(var mi in type.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }
            Console.ReadKey();
        }
    }
}
