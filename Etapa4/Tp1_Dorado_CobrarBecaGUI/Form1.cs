using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1_Dorado_CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Edad;
            
            string Ingresos; 
            Edad = int.Parse(CampText.Text);
            int nada;
            Ingresos = comboBox1.Text;
            string ingresado = "100,001 - 200,000";
            string ingresado2 = "Más de 200,000";
            if (Edad == )
            {

            }
            if (Edad >= 19 && (Ingresos == ingresado ||  Ingresos == ingresado2 ))
            {
                MessageBox.Show("¡Felicidades! Puedes cobrar la beca");
            }
            else
            {
                MessageBox.Show("No cumples con los requisitos para cobrar la beca lo sentimos");
            }
            
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
