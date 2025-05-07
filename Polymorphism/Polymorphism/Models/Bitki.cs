using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Bitki : Can_lı
    {
        public override void NefesAl()
        {
            System.Windows.Forms.MessageBox.Show("Fotosentez yap.");
        }
    }
}
