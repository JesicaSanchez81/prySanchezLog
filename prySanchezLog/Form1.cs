using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySanchezLog
{
    public partial class frmPrincipal : Form
    {
        clsAccesoBD objAccesoBD = new clsAccesoBD();    
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            objAccesoBD.ConectarBaseDatos();

            lblEstadoConexion.Text = objAccesoBD.EstadoConexion;

            //MessageBox.Show(objAccesoBD.EstadoConexion);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            objAccesoBD.TraerDatosDataSet(dgvRegistro);

            if (txtNombre.Text != "")
            {
                objAccesoBD.RegistrarDatosDataSet(txtNombre.Text);
            }
        }

    }
}
}
