using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol2_Datum_a_čas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
        }
        DateTime start = new DateTime();

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "X";
            label3.Text = "X";
            start = DateTime.Now;
            int startSekundy = start.Second;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime stop = new DateTime();
            stop = DateTime.Now;
            int stopSekundy = stop.Second;
            TimeSpan vysledek = stop - start;
            button1.Enabled = true;
            button2.Enabled = false;
            label1.Text = Math.Floor(vysledek.TotalMinutes).ToString();
            label3.Text = Math.Floor(vysledek.TotalSeconds).ToString();
        }
    }
}
