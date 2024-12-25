using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35Threading
{
    public partial class Form1 : Form
    {

        Thread t1 = null;
        Thread t2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void increase()
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i.ToString());
                Thread.Sleep(1000);
            }
        }

        private void decrease()
        {
            for (int i = 10; i >= 0; i--)
            {
                listBox2.Items.Add(i.ToString());
                Thread.Sleep(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t2 = new Thread(new ThreadStart(decrease));
            t2.Start();
        }

        private void btnStartT1_Click(object sender, EventArgs e)
        {
            t1 = new Thread(new ThreadStart(increase));
            t1.Start();
        }
    }
}
