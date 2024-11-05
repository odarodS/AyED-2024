using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp4_Dorado_CreadorPersonajeRol
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 Ventana2 = new Form2(textBox1.Text, textBox2.Text, comboBox1.Text, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
            Ventana2.Show();
            this.Hide();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
