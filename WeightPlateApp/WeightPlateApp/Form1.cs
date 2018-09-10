using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WeightPlateApp
{
    public partial class Form1 : Form
    {
        SupplementAlarm b = new SupplementAlarm();
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

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;

            //Console.WriteLine("Press \'q\' to quit the sample.");
            //while (Console.Read() != 'q') ;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            label2.Text =
           b.checkAlarm(Convert.ToDateTime("10:41:00"));
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //txtDisplay.Text = a.weightToDisplay(Convert.ToDouble(txtWeight.Text));


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            label2.Text = 
            b.checkAlarm(Convert.ToDateTime("10:41:00"));
            
        }
        public void labelname()
        {
            label2.Text =
           b.checkAlarm(Convert.ToDateTime("10:41:00"));
        }
    }
}
