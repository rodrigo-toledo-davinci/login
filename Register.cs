using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Controladores;
using Tienda.Modelos;

namespace Tienda
{
    
    public partial class Register : Form
    {
        public Usuario usuario;
        public static int Iddefault = 0;
        public Register()
        {
            InitializeComponent();
            Iddefault = (controladorUsuarios.lastId+1);
        }

        private void labelIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = LoginRegisterController.login1;
            login.Show();
            this.Hide();
        }

        /*private void guardarRegistro()
        {
            Usuario user = new Usuario()
            {
                Id = Iddefault,
                Nombre = txtUsuarioRegister.Text,
                Contrasena = txtContrasenaRegister.Text,
                EsAdmin = false
            };

            ListaUsuarios lista = controladorUsuarios.ListaUsuario;
            lista.GuardarEnInstancia(user);
            lista.GuardarEnMemoria(user);
        }*/

        private bool ValidarUsuario(out string errorMsg)
        {
            errorMsg = String.Empty;
            if (string.IsNullOrEmpty(txtUsuarioRegister.Text))
            {
                errorMsg += "Debe indicar nombre del usuario" + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(txtContrasenaRegister.Text))
            {
                errorMsg += "Debe indicar la contraseña del usuario" + Environment.NewLine;
            }
            return errorMsg == String.Empty;
        }


        private void bttnRegistrarse_Click(object sender, EventArgs e)
        {
            bool usuarioValidado = ValidarUsuario(out string errormsg);

            if (usuarioValidado)
            {
                usuario = new Usuario()
                {
                    Id = Iddefault,
                    Nombre = txtUsuarioRegister.Text,
                    Contrasena = txtContrasenaRegister.Text,
                    EsAdmin = false
                };

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errormsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
