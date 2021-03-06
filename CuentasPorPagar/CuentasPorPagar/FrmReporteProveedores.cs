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
    public partial class FrmReporteProveedores : Form
    {
        Validaciones validar = new Validaciones();
        public FrmReporteProveedores()
        {
            InitializeComponent();
        }


        private void cmdReporte_Click(object sender, EventArgs e)
        {
            FrmVisorReporteProveedores frm = new FrmVisorReporteProveedores();
            frm.Nombre = txtNombre.Text;
            if (txtBalanceDesde.TextLength > 0)
            {
                frm.BalanceDesde = double.Parse(txtBalanceDesde.Text);
            }
            if (txtBalanceHasta.TextLength > 0)
            {
                frm.BalanceHasta = double.Parse(txtBalanceHasta.Text);
            }

            frm.TipoPersona = "";
            if (rbtFisica.Checked)
            {
                frm.TipoPersona = "Física";
            }
            if (rbtJuridica.Checked)
            {
                frm.TipoPersona = "Jurídica";
            }
              
            frm.Estado = "";
            if (rbtActivo.Checked)
            {
                frm.Estado = "Activo";
            }
            if (rbtInactivo.Checked)
            {
                frm.Estado = "Inactivo";
            }
                
            frm.ShowDialog();
        }

        private void FrmReporteProveedores_Load(object sender, EventArgs e)
        {

        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Campos_Reportes();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtBalanceDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void txtBalanceHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void Limpiar_Campos_Reportes()
        {
            foreach (var item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }

             foreach(var  item2 in groupBox1.Controls )
                {
                    if (item2 is RadioButton)
                    {
                        ((RadioButton)item2).Checked = false;
                    }
                }

                foreach (var item3 in groupBox2.Controls)
                {
                    if (item3 is RadioButton)
                    {
                        ((RadioButton)item3).Checked = false;
                    }
                }
            }
        }
    }
}
