using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvionComercial_Click(object sender, EventArgs e)
        {
            AvionComercial avionComercial = new AvionComercial();

            MessageBox.Show(avionComercial.ToString());
        }
    }
}
