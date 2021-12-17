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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lb2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbcorrecto.Visible = false;
            lbincorrecto.Visible = false;
            btnsiguiente.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("su recaudo en el juego es: 0 \n hasta a luego gracias por jugar :)");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb1.Checked==true)
            {
                MessageBox.Show("respuesta correcta");
                lbcorrecto.Visible = true;
                lbincorrecto.Visible =false ;
                btnsiguiente.Visible = true;
            }
            else
            {
                MessageBox.Show("incorrecto");
                lbincorrecto.Visible = true;
            }
             
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
