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
    public partial class PantAdmPedidoMesa : Form
    {
        DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio.GestorAdmPedidoDeMesa gestor;
        bool mesasListasParaSeleccion;
        public PantAdmPedidoMesa()
        {
            InitializeComponent();
            this.gestor = new DSI_PPAI_Implementacion_CU_1.CapaLogicaNegocio.GestorAdmPedidoDeMesa(this);
            this.mesasListasParaSeleccion = false;
        }

        public static void opcionRegistrarPedidoMesa() {
            PantAdmPedidoMesa nuevaPantalla = new PantAdmPedidoMesa();
            nuevaPantalla.abrirVentana();
            nuevaPantalla.gestor.nuevoPedido();
        }

        public void mostrarMesasParaSeleccion(List<List<String>> mesas) {
            mesas.ForEach(mesa=> dtgMesas.Rows.Add(mesa.ToArray()));
            dtgMesas.ClearSelection();
            this.mesasListasParaSeleccion = true;
        }

        public void tomarSeleccionMesa(object sender, EventArgs e)
        {
            if (mesasListasParaSeleccion)
                gestor.tomarSeleccionMesa(dtgMesas.CurrentRow.Index);
        }

        public void solicitarIngCantComens()
        {
            lblCantComensales.Visible = true;
            numCantComensales.Visible = true;
        }

        public void tomarIngCantComens(object sender, EventArgs e)
        {
            gestor.tomarCantComens((int)numCantComensales.Value);
        }

        public void tomarConfirmPed(object sender, EventArgs e)
        {
            gestor.confirmarPedido();
        }

        public void mostrarOpcParaItems()
        {
            grpAgregarItem.Visible = true;
            radProductoIndiv.Visible = true;
            radMenuSugerido.Visible = true;
        }

        public void tomarOpcionParaItems(object sender, EventArgs e) {
            RadioButton radioOpcion = (RadioButton)sender;
            if(radioOpcion.Checked)
                gestor.tomarOpcionParaItems(radioOpcion.Tag.ToString());
        }

        public void mostrarOpcBusqueda()
        {
            btnCategYSubcateg.Visible = true;
            btnProductosFav.Visible = true;
            btnNombre.Visible = true;
        }

        public void abrirVentana() {
            this.Show();
        }

        public void mostrarCategoriasDeCartaPSeleccion(List<string> categorias)
        {
            lblNombreProducto.Visible = false;
            cmbProductos.Visible = false;

            lblCategorias.Visible = true;
            lblSubcategorias.Visible = true;
            lblProductos.Visible = true;
            listaCategorias.Visible = true;
            listaSubcategorias.Visible = true;
            listaProductos.Visible = true;
            listaCategorias.DataSource = categorias;
        }

        public void mostrarProductosFavPSeleccion(List<string> productos)
        {
            lblCategorias.Visible = false;
            lblSubcategorias.Visible = false;
            lblProductos.Visible = false;
            listaCategorias.Visible = false;
            listaSubcategorias.Visible = false;
            listaProductos.Visible = false;

            lblNombreProducto.Visible = true;
            cmbProductos.Visible = true;
            cmbProductos.DataSource = productos;
            cmbProductos.SelectedIndex = -1;
        }

        public void mostrarTodosProductosPSeleccion(List<string> productos)
        {
            lblCategorias.Visible = false;
            lblSubcategorias.Visible = false;
            lblProductos.Visible = false;
            listaCategorias.Visible = false;
            listaSubcategorias.Visible = false;
            listaProductos.Visible = false;

            lblNombreProducto.Visible = true;
            cmbProductos.Visible = true;
            cmbProductos.DataSource = productos;
            cmbProductos.SelectedIndex = -1;
        }

        public void tomarSeleccProductoPorNom(object sender, EventArgs e)
        {
            if(cmbProductos.SelectedIndex!=-1)
                gestor.tomarSeleccProd(cmbProductos.SelectedItem.ToString());
        }

        private void tomarOpcionBusqueda(object sender, EventArgs e)
        {
            Button botonOpcion = (Button)sender;
            gestor.tomarOpcBusq(botonOpcion.Tag.ToString());
        }

        private void tomarSeleccionCategoriaCarta(object sender, EventArgs e)
        {
            string seleccionada = listaCategorias.SelectedItem.ToString();
            gestor.tomarCategoriaCarta(seleccionada);
        }

        private void tomarSeleccionSubcateg(object sender, EventArgs e)
        {
            string seleccionada = listaSubcategorias.SelectedItem.ToString();
            gestor.tomarSeleccionSubcateg(seleccionada);
        }

        private void tomarSeleccionProducto(object sender, EventArgs e)
        {
            string seleccionado = listaProductos.SelectedItem.ToString();
            gestor.tomarSeleccProd(seleccionado);
        }

        public void mostrarSubcategoriasPSeleccion(List<string> subcategorias)
        {
            listaSubcategorias.DataSource = subcategorias;
        }

        public void solicitarIngCantProd()
        {
            lblCantidad.Visible = true;
            numCantidad.Visible = true;
        }

        private void tomarIngCantProd(object sender, EventArgs e)
        {
            gestor.tomarCantidadProd((int)numCantidad.Value);
        }

        public void mostrarDatosProdSelecc(object[] datos)
        {
            dtgDetallePedido.Rows.Add(datos);
        }

        public void mostrarOpcParaModific() {
            btnModificar.Visible = true;
        }

        public void solicitarConfirmacionPRegPed() {
            btnRegistrarPedido.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void mostrarProdPSeleccion(List<string> nomProductosCarta)
        {
            listaProductos.DataSource = nomProductosCarta;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
