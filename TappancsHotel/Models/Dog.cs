using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace TappancsHotel.Models
{
    public class Dog : Pet
    {
        public Dog(string name) : base(name, "Kutya", "🐶") { }
        public override string Speak ()
        {
            return "Vau-Vau! Jöhet az érettségi?";
        }
        public override string Play()
        {
            ChangeStats(-14, 30, - 24);
            return $"{Name} boldogan labdázott! + 30 jókedv";
        }
    }
}
