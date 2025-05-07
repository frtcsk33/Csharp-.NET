using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErişimBelirteçleri.Models
{
    public abstract class Animal
    {
        protected int protectedProperty { get; set; }
        protected internal int protectedInternalProperty { get; set; }
    }
}
