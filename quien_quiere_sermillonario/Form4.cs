using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quien_quiere_sermillonario
{
    public partial class Form4 : Form
    {
        public Form4()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lbcorrecto1.Visible = false;
            lbincorrecto1.Visible = false;
            btnsiguiente1.Visible = false;
        }

        private void btnultima_Click(object sender, EventArgs e)
        {
            if (rb4.Checked == true)
            {
                MessageBox.Show("respuesta correcta");
                lbcorrecto1.Visible = true;
                lbincorrecto1.Visible = false;
                btnsiguiente1.Visible = true;
            }
            else
            {
                MessageBox.Show("incorrecto");
                lbincorrecto1.Visible = true;
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsiguiente1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm = new Form5();
            frm.Show();
        }

        private void rbn3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
