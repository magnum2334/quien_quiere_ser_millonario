using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quien_quiere_sermillonario
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string usuario = "1";
        string contraseña = "123";

        private void btn1_Click(object sender, EventArgs e)
        {
            string user = txt1.Text;
            string password = txt2.Text;
            //cree una carpeta en su unidad de disco C  
            string temurl = "E:\\userRegister\\" + user + ".txt";
            if (!File.Exists(temurl))
            {
               MessageBox.Show("error el usuario no existe debe registrarse");
                txt1.Text = "";
                txt2.Text = "";
            }
            else
            {
                contraseña = File.ReadAllText(temurl);
                if (password.Equals(contraseña))
                {
                    MessageBox.Show(" bienvenido " + user);
                    this.Hide();
                    Form2 frm = new Form2();
                    frm.Show();
                }

                else
                {
                    MessageBox.Show("error ingrese todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txt1.Text;
            string password = txt2.Text;
            string temurl = "E:\\userRegister\\" +user +".txt";
            if (File.Exists(temurl))
            {
                MessageBox.Show("no es posible registrar este usuario");
            }
            else
            {
                File.WriteAllText(temurl,password);
                MessageBox.Show("registro exitoso, ingrese con el boton login");
                txt1.Text = "";
                txt2.Text = "";
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
