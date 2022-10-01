namespace Tienda
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIniciarSesion = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrasenaRegister = new System.Windows.Forms.TextBox();
            this.txtUsuarioRegister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIniciarSesion
            // 
            this.labelIniciarSesion.AutoSize = true;
            this.labelIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciarSesion.Location = new System.Drawing.Point(545, 411);
            this.labelIniciarSesion.Name = "labelIniciarSesion";
            this.labelIniciarSesion.Size = new System.Drawing.Size(87, 16);
            this.labelIniciarSesion.TabIndex = 12;
            this.labelIniciarSesion.TabStop = true;
            this.labelIniciarSesion.Text = "Iniciar Sesion";
            this.labelIniciarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelIniciarSesion_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Registrarse";
            // 
            // txtContrasenaRegister
            // 
            this.txtContrasenaRegister.Location = new System.Drawing.Point(568, 264);
            this.txtContrasenaRegister.Name = "txtContrasenaRegister";
            this.txtContrasenaRegister.Size = new System.Drawing.Size(181, 20);
            this.txtContrasenaRegister.TabIndex = 10;
            // 
            // txtUsuarioRegister
            // 
            this.txtUsuarioRegister.Location = new System.Drawing.Point(568, 149);
            this.txtUsuarioRegister.Name = "txtUsuarioRegister";
            this.txtUsuarioRegister.Size = new System.Drawing.Size(181, 20);
            this.txtUsuarioRegister.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña:";
            // 
            // bttnRegistrarse
            // 
            this.bttnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRegistrarse.Location = new System.Drawing.Point(421, 326);
            this.bttnRegistrarse.Name = "bttnRegistrarse";
            this.bttnRegistrarse.Size = new System.Drawing.Size(328, 71);
            this.bttnRegistrarse.TabIndex = 7;
            this.bttnRegistrarse.Text = "Registrarse";
            this.bttnRegistrarse.UseVisualStyleBackColor = true;
            this.bttnRegistrarse.Click += new System.EventHandler(this.bttnRegistrarse_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIniciarSesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContrasenaRegister);
            this.Controls.Add(this.txtUsuarioRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnRegistrarse);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel labelIniciarSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrasenaRegister;
        private System.Windows.Forms.TextBox txtUsuarioRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnRegistrarse;
    }
}