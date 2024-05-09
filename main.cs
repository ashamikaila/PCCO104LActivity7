using System;

namespace HelloKitty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloKittyCharacter HelloKitty = new HelloKittyCharacter(25, "Hello Kitty", "Bow");
            HelloKitty.Sanrio();

            HelloKittyCharacter MyMelody = new HelloKittyCharacter(10, "My Melody", "Hood");
            MyMelody.Sanrio();

            HelloKittyCharacter Keroppi = new HelloKittyCharacter(15, "Keroppi", "Lily Pad");
            Keroppi.Sanrio();
        }
    }

    public class HelloKittyCharacter
    {
        private string Name { get; set; }

        private string Item { get; set; }

        private double Age { get; set; }

        public HelloKittyCharacter() { }

        public HelloKittyCharacter(double age)
        {
            Age = age;
        }

        public HelloKittyCharacter(double age, string name) : this(age)
        {
            Name = name;
        }

        public HelloKittyCharacter(double age, string name, string item) : this(age, name)
        {
            Item = item;
        }

        public void Sanrio()
        {
            Console.WriteLine($"{Name} - {Item} - {Age} years old.");
        }
    }
}
