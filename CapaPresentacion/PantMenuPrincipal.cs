using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI_PPAI_Implementacion_CU_1.CapaPresentacion
{
    public partial class PantMenuPrincipal : Form
    {
        public PantMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarPedidoMesa_Click(object sender, EventArgs e)
        {
            PantAdmPedidoMesa.opcionRegistrarPedidoMesa();
        }
    }
}
