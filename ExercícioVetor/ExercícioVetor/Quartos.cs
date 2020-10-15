using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioVetor
{
    class Quartos
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Quartos(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
