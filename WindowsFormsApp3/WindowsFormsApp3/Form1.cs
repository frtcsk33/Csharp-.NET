﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Models;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sample sample = new Sample();
            
        }

        //
        /*
         # public
        #internal => sadece oluşturlduğu projenin içerisinden erişilebilr
         #protected internal
        protected
        #private => sadece bulunduğu sayfadan erişilebilir

         */
    }
}
