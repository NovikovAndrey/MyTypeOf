using System;
using System.Reflection;

namespace MyTypeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("MyTypeOf.User", false, true);
            Console.WriteLine("Methods");
            foreach(MethodInfo method in type.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                {
                    modificator += "static";
                }
                if (method.IsVirtual)
                {
                    modificator += "virtual";
                }
                Console.WriteLine($"{modificator} {method.ReturnType.Name} {method.Name} :");
                ParameterInfo[] parameterInfos = method.GetParameters();
                for (int i=0; i<parameterInfos.Length; i++)
                {
                    Console.WriteLine($"{parameterInfos[i].ParameterType.Name} {parameterInfos[i].Name}");
                    if (i+1<parameterInfos.Length)
                    {
                        Console.WriteLine(", ");
                    }
                }
            }
            //foreach(var mi in type.GetMembers())
            //{
            //    Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            //}
            //Console.ReadKey();
        }
    }
}
