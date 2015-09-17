using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDellaportas.EfSoftDelete.Console.Models
{
    public class Parent: Entity
    {
        public string Sex { get; protected set; }

        public ICollection<Child> Children { get; protected set; }
    }
}
