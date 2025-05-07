using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Tools
{
    public class Tank : SavaşAracı
    {
        public override void Saldir()
        {
            System.Windows.Forms.MessageBox.Show("Hedefe top ateşleyerek saldırıldı.");
        }
    }
}
