using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoDePrueba
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
            double Num;
            Num = double.Parse(textBox1.Text);

            pas_kelvin(Num);
            pas_farenheit(Num);
        }
        void pas_kelvin(double Num)
        {
            Kelvin.Text = Num + 273 + " °K";
        }

        void pas_farenheit(double Num)
        {
            Farenheit.Text = Num * 18 / 10 + 32 + " °F";
        }

      
    }
}
