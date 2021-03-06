﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorPagar
{
    public partial class FrmLogin : Form
    {
        Cuentas_por_pagarEntities1 entities = new Cuentas_por_pagarEntities1();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = (from u in entities.Usuario
                                where u.NOMBRE_USUARIO.Equals(txtUsuario.Text) &&
                                      u.CLAVE_USUARIO.Equals(txtClave.Text)
                                select u).FirstOrDefault();

            if (usuario == null)
            {
                MessageBox.Show("Datos incorrectos");
            }
            else if (!usuario.ESTADO_USUARIO.Equals("Activo"))
            {
                MessageBox.Show("Datos incorrectos");
            }
            else
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
                FrmMenu frm = new FrmMenu();
                frm.modo = usuario.ROL.First().NOMBRE_ROL;
                this.Hide();
                frm.ShowDialog();            
            }
        }
    }
}
