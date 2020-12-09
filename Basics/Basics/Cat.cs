using System;
namespace Basics
{
    public class Cat : Pet
    {
        public Cat(string name, int age) : base(name, age)
        {
            
        }

        public override string Speak()
        {
            return "Miau";
        }
    }
}
