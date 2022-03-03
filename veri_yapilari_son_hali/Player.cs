using System;
using System.Collections.Generic;
using System.Text;

namespace veri_yapilari_son_hali
{
    class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Player() { }
        public Player(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name + "(" + Age + ")";
        }
    }
}
