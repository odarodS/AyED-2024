using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Dorado_MiPrimerMenuGUI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Nacim = int.Parse(textBox1.Text);
            string edad = ("Va  a cumplir o ya cumplio " + (2024 -  Nacim) + " años " );
            label2.Text = edad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();
            this.Hide();
            ventana1.ShowDialog();
            this.Close();
        }
    }
}
