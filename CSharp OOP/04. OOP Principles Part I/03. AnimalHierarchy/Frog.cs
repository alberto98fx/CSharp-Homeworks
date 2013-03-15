﻿namespace _03.AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(byte age, string name, Gender sex)
            : base(age, name, sex)
        { 
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Quack!!!");
        }
    }
}
