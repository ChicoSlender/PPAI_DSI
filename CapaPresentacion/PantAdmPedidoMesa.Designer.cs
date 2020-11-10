namespace DSI_PPAI_Implementacion_CU_1.CapaPresentacion
{
    partial class PantAdmPedidoMesa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSeleccionMesa = new System.Windows.Forms.Label();
            this.dtgMesas = new System.Windows.Forms.DataGridView();
            this.nroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccionMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisoMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantComensales = new System.Windows.Forms.Label();
            this.numCantComensales = new System.Windows.Forms.NumericUpDown();
            this.grpAgregarItem = new System.Windows.Forms.GroupBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listaProductos = new System.Windows.Forms.ListBox();
            this.lblSubcategorias = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.listaSubcategorias = new System.Windows.Forms.ListBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.listaCategorias = new System.Windows.Forms.ListBox();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnProductosFav = new System.Windows.Forms.Button();
            this.btnCategYSubcateg = new System.Windows.Forms.Button();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.radMenuSugerido = new System.Windows.Forms.RadioButton();
            this.radProductoIndiv = new System.Windows.Forms.RadioButton();
            this.dtgDetallePedido = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarPedido = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.nombreDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantComensales)).BeginInit();
            this.grpAgregarItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionMesa
            // 
            this.lblSeleccionMesa.AutoSize = true;
            this.lblSeleccionMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionMesa.Location = new System.Drawing.Point(12, 18);
            this.lblSeleccionMesa.Name = "lblSeleccionMesa";
            this.lblSeleccionMesa.Size = new System.Drawing.Size(147, 17);
            this.lblSeleccionMesa.TabIndex = 0;
            this.lblSeleccionMesa.Text = "Seleccione una mesa:";
            // 
            // dtgMesas
            // 
            this.dtgMesas.AllowUserToAddRows = false;
            this.dtgMesas.AllowUserToDeleteRows = false;
            this.dtgMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroMesa,
            this.seccionMesa,
            this.sectorMesa,
            this.pisoMesa,
            this.uniones});
            this.dtgMesas.Location = new System.Drawing.Point(15, 41);
            this.dtgMesas.Name = "dtgMesas";
            this.dtgMesas.ReadOnly = true;
            this.dtgMesas.RowHeadersVisible = false;
            this.dtgMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMesas.Size = new System.Drawing.Size(475, 111);
            this.dtgMesas.TabIndex = 1;
            this.dtgMesas.SelectionChanged += new System.EventHandler(this.tomarSeleccionMesa);
            // 
            // nroMesa
            // 
            this.nroMesa.HeaderText = "Nro. Mesa";
            this.nroMesa.Name = "nroMesa";
            this.nroMesa.ReadOnly = true;
            this.nroMesa.Width = 50;
            // 
            // seccionMesa
            // 
            this.seccionMesa.HeaderText = "Seccion";
            this.seccionMesa.Name = "seccionMesa";
            this.seccionMesa.ReadOnly = true;
            this.seccionMesa.Width = 150;
            // 
            // sectorMesa
            // 
            this.sectorMesa.HeaderText = "Sector";
            this.sectorMesa.Name = "sectorMesa";
            this.sectorMesa.ReadOnly = true;
            this.sectorMesa.Width = 150;
            // 
            // pisoMesa
            // 
            this.pisoMesa.HeaderText = "Piso";
            this.pisoMesa.Name = "pisoMesa";
            this.pisoMesa.ReadOnly = true;
            this.pisoMesa.Width = 50;
            // 
            // uniones
            // 
            this.uniones.HeaderText = "Unida a";
            this.uniones.Name = "uniones";
            this.uniones.ReadOnly = true;
            this.uniones.Width = 70;
            // 
            // lblCantComensales
            // 
            this.lblCantComensales.AutoSize = true;
            this.lblCantComensales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantComensales.Location = new System.Drawing.Point(12, 169);
            this.lblCantComensales.Name = "lblCantComensales";
            this.lblCantComensales.Size = new System.Drawing.Size(231, 17);
            this.lblCantComensales.TabIndex = 2;
            this.lblCantComensales.Text = "Ingrese la cantidad de comensales:";
            this.lblCantComensales.Visible = false;
            // 
            // numCantComensales
            // 
            this.numCantComensales.Location = new System.Drawing.Point(257, 169);
            this.numCantComensales.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantComensales.Name = "numCantComensales";
            this.numCantComensales.Size = new System.Drawing.Size(65, 20);
            this.numCantComensales.TabIndex = 3;
            this.numCantComensales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantComensales.Visible = false;
            this.numCantComensales.ValueChanged += new System.EventHandler(this.tomarIngCantComens);
            // 
            // grpAgregarItem
            // 
            this.grpAgregarItem.Controls.Add(this.cmbProductos);
            this.grpAgregarItem.Controls.Add(this.lblNombreProducto);
            this.grpAgregarItem.Controls.Add(this.btnAgregar);
            this.grpAgregarItem.Controls.Add(this.listaProductos);
            this.grpAgregarItem.Controls.Add(this.lblSubcategorias);
            this.grpAgregarItem.Controls.Add(this.lblCategorias);
            this.grpAgregarItem.Controls.Add(this.lblProductos);
            this.grpAgregarItem.Controls.Add(this.listaSubcategorias);
            this.grpAgregarItem.Controls.Add(this.numCantidad);
            this.grpAgregarItem.Controls.Add(this.lblCantidad);
            this.grpAgregarItem.Controls.Add(this.listaCategorias);
            this.grpAgregarItem.Controls.Add(this.btnNombre);
            this.grpAgregarItem.Controls.Add(this.btnProductosFav);
            this.grpAgregarItem.Controls.Add(this.btnCategYSubcateg);
            this.grpAgregarItem.Controls.Add(this.lblBuscarProducto);
            this.grpAgregarItem.Controls.Add(this.radMenuSugerido);
            this.grpAgregarItem.Controls.Add(this.radProductoIndiv);
            this.grpAgregarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgregarItem.Location = new System.Drawing.Point(4, 200);
            this.grpAgregarItem.Name = "grpAgregarItem";
            this.grpAgregarItem.Size = new System.Drawing.Size(486, 307);
            this.grpAgregarItem.TabIndex = 4;
            this.grpAgregarItem.TabStop = false;
            this.grpAgregarItem.Text = "Agregar item";
            this.grpAgregarItem.Visible = false;
            // 
            // cmbProductos
            // 
            this.cmbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(210, 152);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(270, 24);
            this.cmbProductos.TabIndex = 24;
            this.cmbProductos.Visible = false;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccProductoPorNom);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(8, 155);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(196, 17);
            this.lblNombreProducto.TabIndex = 23;
            this.lblNombreProducto.Text = "Ingresar nombre de producto:";
            this.lblNombreProducto.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(384, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 28);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.tomarIngCantProd);
            // 
            // listaProductos
            // 
            this.listaProductos.FormattingEnabled = true;
            this.listaProductos.ItemHeight = 16;
            this.listaProductos.Location = new System.Drawing.Point(323, 155);
            this.listaProductos.Name = "listaProductos";
            this.listaProductos.Size = new System.Drawing.Size(146, 68);
            this.listaProductos.TabIndex = 19;
            this.listaProductos.Visible = false;
            this.listaProductos.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionProducto);
            // 
            // lblSubcategorias
            // 
            this.lblSubcategorias.AutoSize = true;
            this.lblSubcategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcategorias.Location = new System.Drawing.Point(197, 134);
            this.lblSubcategorias.Name = "lblSubcategorias";
            this.lblSubcategorias.Size = new System.Drawing.Size(86, 15);
            this.lblSubcategorias.TabIndex = 18;
            this.lblSubcategorias.Text = "Subcategorías";
            this.lblSubcategorias.Visible = false;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(37, 134);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(66, 15);
            this.lblCategorias.TabIndex = 16;
            this.lblCategorias.Text = "Categorías";
            this.lblCategorias.Visible = false;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(358, 134);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(62, 15);
            this.lblProductos.TabIndex = 20;
            this.lblProductos.Text = "Productos";
            this.lblProductos.Visible = false;
            // 
            // listaSubcategorias
            // 
            this.listaSubcategorias.FormattingEnabled = true;
            this.listaSubcategorias.ItemHeight = 16;
            this.listaSubcategorias.Location = new System.Drawing.Point(171, 155);
            this.listaSubcategorias.Name = "listaSubcategorias";
            this.listaSubcategorias.Size = new System.Drawing.Size(146, 68);
            this.listaSubcategorias.TabIndex = 17;
            this.listaSubcategorias.Visible = false;
            this.listaSubcategorias.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionSubcateg);
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(156, 259);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(65, 20);
            this.numCantidad.TabIndex = 14;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(11, 259);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(139, 17);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Seleccione cantidad:";
            this.lblCantidad.Visible = false;
            // 
            // listaCategorias
            // 
            this.listaCategorias.FormattingEnabled = true;
            this.listaCategorias.ItemHeight = 16;
            this.listaCategorias.Location = new System.Drawing.Point(19, 155);
            this.listaCategorias.Name = "listaCategorias";
            this.listaCategorias.Size = new System.Drawing.Size(146, 68);
            this.listaCategorias.TabIndex = 15;
            this.listaCategorias.Visible = false;
            this.listaCategorias.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionCategoriaCarta);
            // 
            // btnNombre
            // 
            this.btnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombre.Location = new System.Drawing.Point(374, 88);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(106, 28);
            this.btnNombre.TabIndex = 5;
            this.btnNombre.Tag = "Nombre";
            this.btnNombre.Text = "Nombre";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Visible = false;
            this.btnNombre.Click += new System.EventHandler(this.tomarOpcionBusqueda);
            // 
            // btnProductosFav
            // 
            this.btnProductosFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosFav.Location = new System.Drawing.Point(220, 88);
            this.btnProductosFav.Name = "btnProductosFav";
            this.btnProductosFav.Size = new System.Drawing.Size(148, 28);
            this.btnProductosFav.TabIndex = 4;
            this.btnProductosFav.Tag = "Favoritos";
            this.btnProductosFav.Text = "Productos favoritos";
            this.btnProductosFav.UseVisualStyleBackColor = true;
            this.btnProductosFav.Visible = false;
            this.btnProductosFav.Click += new System.EventHandler(this.tomarOpcionBusqueda);
            // 
            // btnCategYSubcateg
            // 
            this.btnCategYSubcateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategYSubcateg.Location = new System.Drawing.Point(8, 88);
            this.btnCategYSubcateg.Name = "btnCategYSubcateg";
            this.btnCategYSubcateg.Size = new System.Drawing.Size(206, 28);
            this.btnCategYSubcateg.TabIndex = 3;
            this.btnCategYSubcateg.Tag = "CategSubcateg";
            this.btnCategYSubcateg.Text = "Categorías y subcategorías";
            this.btnCategYSubcateg.UseVisualStyleBackColor = true;
            this.btnCategYSubcateg.Visible = false;
            this.btnCategYSubcateg.Click += new System.EventHandler(this.tomarOpcionBusqueda);
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Location = new System.Drawing.Point(8, 63);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(141, 17);
            this.lblBuscarProducto.TabIndex = 2;
            this.lblBuscarProducto.Text = "Buscar producto por:";
            this.lblBuscarProducto.Visible = false;
            // 
            // radMenuSugerido
            // 
            this.radMenuSugerido.AutoSize = true;
            this.radMenuSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuSugerido.Location = new System.Drawing.Point(172, 34);
            this.radMenuSugerido.Name = "radMenuSugerido";
            this.radMenuSugerido.Size = new System.Drawing.Size(108, 19);
            this.radMenuSugerido.TabIndex = 1;
            this.radMenuSugerido.Tag = "MenuSugerido";
            this.radMenuSugerido.Text = "Menú sugerido";
            this.radMenuSugerido.UseVisualStyleBackColor = true;
            this.radMenuSugerido.Visible = false;
            this.radMenuSugerido.CheckedChanged += new System.EventHandler(this.tomarOpcionParaItems);
            // 
            // radProductoIndiv
            // 
            this.radProductoIndiv.AutoSize = true;
            this.radProductoIndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProductoIndiv.Location = new System.Drawing.Point(11, 34);
            this.radProductoIndiv.Name = "radProductoIndiv";
            this.radProductoIndiv.Size = new System.Drawing.Size(129, 19);
            this.radProductoIndiv.TabIndex = 0;
            this.radProductoIndiv.Tag = "ProductoIndiv";
            this.radProductoIndiv.Text = "Producto individual";
            this.radProductoIndiv.UseVisualStyleBackColor = true;
            this.radProductoIndiv.Visible = false;
            this.radProductoIndiv.CheckedChanged += new System.EventHandler(this.tomarOpcionParaItems);
            // 
            // dtgDetallePedido
            // 
            this.dtgDetallePedido.AllowUserToAddRows = false;
            this.dtgDetallePedido.AllowUserToDeleteRows = false;
            this.dtgDetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDetalle,
            this.cantidadDetalle,
            this.precioDetalle});
            this.dtgDetallePedido.Location = new System.Drawing.Point(15, 540);
            this.dtgDetallePedido.Name = "dtgDetallePedido";
            this.dtgDetallePedido.ReadOnly = true;
            this.dtgDetallePedido.RowHeadersVisible = false;
            this.dtgDetallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetallePedido.Size = new System.Drawing.Size(480, 101);
            this.dtgDetallePedido.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Detalle de pedido:";
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRegistrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPedido.Location = new System.Drawing.Point(350, 647);
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(145, 32);
            this.btnRegistrarPedido.TabIndex = 7;
            this.btnRegistrarPedido.Text = "Registrar pedido";
            this.btnRegistrarPedido.UseVisualStyleBackColor = false;
            this.btnRegistrarPedido.Visible = false;
            this.btnRegistrarPedido.Click += new System.EventHandler(this.tomarConfirmPed);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(394, 511);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 28);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            // 
            // nombreDetalle
            // 
            this.nombreDetalle.HeaderText = "Nombre producto";
            this.nombreDetalle.Name = "nombreDetalle";
            this.nombreDetalle.ReadOnly = true;
            this.nombreDetalle.Width = 270;
            // 
            // cantidadDetalle
            // 
            this.cantidadDetalle.HeaderText = "Cantidad";
            this.cantidadDetalle.Name = "cantidadDetalle";
            this.cantidadDetalle.ReadOnly = true;
            // 
            // precioDetalle
            // 
            this.precioDetalle.HeaderText = "Precio";
            this.precioDetalle.Name = "precioDetalle";
            this.precioDetalle.ReadOnly = true;
            // 
            // PantAdmPedidoMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 683);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrarPedido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgDetallePedido);
            this.Controls.Add(this.grpAgregarItem);
            this.Controls.Add(this.numCantComensales);
            this.Controls.Add(this.lblCantComensales);
            this.Controls.Add(this.dtgMesas);
            this.Controls.Add(this.lblSeleccionMesa);
            this.Name = "PantAdmPedidoMesa";
            this.ShowIcon = false;
            this.Text = "Registrar pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantComensales)).EndInit();
            this.grpAgregarItem.ResumeLayout(false);
            this.grpAgregarItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionMesa;
        private System.Windows.Forms.DataGridView dtgMesas;
        private System.Windows.Forms.Label lblCantComensales;
        private System.Windows.Forms.NumericUpDown numCantComensales;
        private System.Windows.Forms.GroupBox grpAgregarItem;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnProductosFav;
        private System.Windows.Forms.Button btnCategYSubcateg;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.RadioButton radMenuSugerido;
        private System.Windows.Forms.RadioButton radProductoIndiv;
        private System.Windows.Forms.DataGridView dtgDetallePedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarPedido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccionMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisoMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listaProductos;
        private System.Windows.Forms.Label lblSubcategorias;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ListBox listaSubcategorias;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ListBox listaCategorias;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDetalle;
    }
}

