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
using Tienda.Controladores;
using Tienda.Modelos;

namespace Tienda
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bttnAcceder_Click(object sender, EventArgs e)
        {
            bool valido =false;

            StreamReader sr = new StreamReader("usuarios.txt");
            while (!sr.EndOfStream)
            {
                string usuario = sr.ReadLine();
                string[] datos = usuario.Split(',');
                
                if (datos[1].Equals(txtUsuarioLogin.Text) && datos[2].Equals(txtContrasenaLogin.Text))
                {
                    valido= true;
                }

            }
            sr.Close();

            if(valido)
            {
                this.Hide();
                MessageBox.Show("VENTAS");
                 
            }else
            {
                MessageBox.Show("Error");
            }
        }

        private void labelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registro = new Register();

            this.Hide();
            DialogResult dialogResult = registro.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                controladorUsuarios.AñadirUsuario(registro.usuario);
            }
        }


    }
}
