﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrungChi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            if (c > 0)
            {
                Console.WriteLine(a + b);
            }
        }
    }
}
