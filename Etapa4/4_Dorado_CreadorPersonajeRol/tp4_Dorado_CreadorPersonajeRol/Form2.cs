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
    public partial class Form2 : Form
    {
        public Form2 (string RecepcionTexto1, string RecepcionTexto2, string RecepcionTexto3, bool RecepcionTexto4, bool RecepcionTexto5, bool RecepcionTexto6)
        {
            InitializeComponent();
            label1.Text = RecepcionTexto1;
            label2.Text = RecepcionTexto2;
            label3.Text = RecepcionTexto3;
            label4.Visible = RecepcionTexto4;
            label5.Visible = RecepcionTexto5;
            label6.Visible = RecepcionTexto6;

            if (RecepcionTexto4)
            {
                label4.Text = "Fuerza Sobrehumana";
            }
            if (RecepcionTexto5)
            {
                label5.Text =  "Invisibilidad";
            }
            if (RecepcionTexto6)
            {
                label6.Text = "Regeneracion rapida";
            }


        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Ventana1 = new Form1();
            Ventana1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
