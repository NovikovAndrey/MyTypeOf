namespace MyTypeOf
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public void Display()
        {
            System.Console.WriteLine($"Name = {Name}, Age = {Age}");
        }
        public int Payment(int x, int y)
        {
            return x * y;
        }
    }
}