using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_forms2
{
    public partial class Form1 : Form
    {
        private const string V = "...";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Привет!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "До свидания!";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            label1.Text = "Начало работы";
        }

    }
}
