using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Generics.Helpers
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.Number == y.Number;
        }

        public int GetHashCode(Student obj)
        {
            return obj.Number.GetHashCode();
        }
    }
}
