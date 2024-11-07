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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("error introduzca 2 numeros");
            }
            if (textBox2.Text == "")
            {

                MessageBox.Show("error introduzca 2 numeros");
            }
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);
            string Suma = ("el resultado de la suma es: " + (Num1 + Num2));
            label2.Text = Suma;

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
