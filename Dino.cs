using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppp
{
    public class Dino(string[] data)

    {
        public string Name { get; set; } = data[0];
        public string Color { get; set; } = data[1];
        public double weight { get; set; } = double.Parse(data[2]);
        public int age { get; set; } = int.Parse(data[3]);
        public string type { get; set; } = data[4];
        public bool adopt { get; set; } = bool.Parse(data[5]);

        public override string ToString()
        {
            return $"Name: {Name}, Color: {Color}, Weight: {weight}, Age: {age}, Type: {type}, Adopt: {adopt}";
        }

        public bool Adopted()
        {
            if(adopt != true)
            {
                return adopt == true;
            }
            else
            {
                return true;
            }
        }
        public double Eating(int food)
        {
            weight += food * 0.1;
            return weight;
        }
        public int AgeUP(int ageup)
        {
            age += ageup;
            return age;
        }
        public string rename(string newName)
        {
            if(adopt == true)
            {
                Name = newName;
            }
            return Name;
        }

    }
}
