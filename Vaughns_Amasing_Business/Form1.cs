﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaughns_Amasing_Business
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //This goes under the read in file section
            dataGridView1.DataSource = People;
        }
    }
}
