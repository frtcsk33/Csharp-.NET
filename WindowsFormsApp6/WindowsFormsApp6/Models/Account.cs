using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6.Models
{
    class Account
    {
        



        string _userName;
        public string userName 
        {
            get { return  _userName; }
            set 
            {
                if(value.Length > 3)
                {
                    _userName = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Kullanıcı adını en az 4 karakter girmelisiniz");
                    Application.Restart();
                }
            }
        }

        public string password { get; set; }

    }
}
