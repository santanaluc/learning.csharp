using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício2.Entities
{
    class Course
    {
        public int Code { get; set; }

        public Course(int code)
        {
            Code = code;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Course))
            {
                return false;
            }

            Course other = obj as Course;
            return Code.Equals(other.Code);
        }

        public override string ToString()
        {
            return "Code" + Code;
        }
    }
}
