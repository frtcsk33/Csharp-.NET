using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tools
{
    public class Uçak : SavaşAracı
    {
        public override void Saldir()
        {
            System.Windows.Forms.MessageBox.Show("Füze atıldı.");
        }
    }
}
