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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lbcorrecto1.Visible = false;
            lbincorrecto1.Visible = false;
            btnsiguiente1.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("su recaudo en el juego es: 1.550.000 \n hasta a luego gracias por jugar :)");
            Application.Exit();
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

        private void btnsiguiente1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm = new Form6();
            frm.Show();
        }
    }
}
