using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed.models
{
    public abstract class Meyve:Bitki
    {
        public sealed override void Test()
        {
            System.Windows.Forms.MessageBox.Show("Test 2");
        }
    }
}
