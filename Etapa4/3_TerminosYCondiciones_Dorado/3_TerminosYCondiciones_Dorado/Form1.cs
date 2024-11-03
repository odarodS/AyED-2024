using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_TerminosYCondiciones_Dorado
{
    public partial class Form1 : Form
    {
        bool wasa;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        
    }
}
