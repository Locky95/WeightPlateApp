﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightPlateApp
{
    public partial class Form1 : Form
    {
        WeightCalculator a = new WeightCalculator();
        double weight;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtDisplay.Text = a.weightToDisplay(Convert.ToDouble(txtWeight.Text));


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
