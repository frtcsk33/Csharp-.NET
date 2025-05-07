using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2.Models
{
    public class Ork : Character
    {
        Random random = new Random();
        public override int GetSpeed()
        {
            return random.Next(6,12);
        }
    }
}
