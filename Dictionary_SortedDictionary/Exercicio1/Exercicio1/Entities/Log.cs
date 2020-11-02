using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    class Log
    {
        public string Candidate { get; set; }
        public int Vote { get; set; }

        public void Sum(int votes)
        {
            Vote += votes;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
