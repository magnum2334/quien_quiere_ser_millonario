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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbcorrecto1.Visible = false;
            lbincorrecto1.Visible = false;
            btnsiguiente1.Visible = false;
        }

        private void lbincorrecto1_Click(object sender, EventArgs e)
        {

        }

        private void btnultima_Click(object sender, EventArgs e)
        {
            if (rb3.Checked == true)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("su recaudo en el juego es: 50.000 \n hasta a luego gracias por jugar :)");
            Application.Exit();
        }

        private void btnsiguiente1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm = new Form4();
            frm.Show();
        }
    }
}
