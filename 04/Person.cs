using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using oop_5;

namespace oop_5
{
    public partial class Person
    {
        public string? Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Person person) return Name == person.Name;
            return false;
        }
        public override int GetHashCode() => Name.GetHashCode();
    }

}

