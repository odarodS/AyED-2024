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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tabla = int.Parse(textBox1.Text);
            string resultado = (Tabla + " * 1 = " + Tabla * 1)+ "\n" 
                + (Tabla + " * 2 = " + Tabla * 2) + "\n" 
                + (Tabla + " * 3 = " + Tabla * 3) + "\n" 
                + (Tabla + " * 4 = " + Tabla * 4) + "\n" 
                + (Tabla + " * 5 = " + Tabla * 5) + "\n" 
                + (Tabla + " * 6 = " + Tabla * 6) + "\n"
                + (Tabla + " * 7 = " + Tabla * 7) + "\n" 
                + (Tabla + " * 8 = " + Tabla * 8) + "\n" 
                + (Tabla + " * 9 = " + Tabla * 9) + "\n" 
                + (Tabla + " * 10 = " + Tabla * 10);
            label2.Text = resultado;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
