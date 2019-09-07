using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fondo_de_colores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnazul.ForeColor = Color.Blue;
            btnamarillo.ForeColor = Color.Yellow;
            btnnaranja.ForeColor = Color.Orange;
            btnverde.ForeColor = Color.Green;
            btnmorado.ForeColor = Color.Purple;
        }

       

        private void Btnazul_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Blue;
            

        }

        private void Btnamarillo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;

        }

        private void Btnnaranja_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void Btnverde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void Btnmorado_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }
    }
}
