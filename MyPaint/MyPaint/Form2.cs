﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void submitDimensions_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        public int getHeight()
        {
            return int.Parse(heightTB.Text);
        }

        public int getWidth()
        {

            return int.Parse(widthTB.Text);
        }
    }
}
