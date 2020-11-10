namespace DSI_PPAI_Implementacion_CU_1.CapaPresentacion
{
    partial class PantMenuPrincipal
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
            this.btnRegistrarPedidoMesa = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarPedidoMesa
            // 
            this.btnRegistrarPedidoMesa.Location = new System.Drawing.Point(12, 12);
            this.btnRegistrarPedidoMesa.Name = "btnRegistrarPedidoMesa";
            this.btnRegistrarPedidoMesa.Size = new System.Drawing.Size(216, 34);
            this.btnRegistrarPedidoMesa.TabIndex = 0;
            this.btnRegistrarPedidoMesa.Text = "Registrar pedido de mesa";
            this.btnRegistrarPedidoMesa.UseVisualStyleBackColor = true;
            this.btnRegistrarPedidoMesa.Click += new System.EventHandler(this.btnRegistrarPedidoMesa_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(11, 52);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(216, 34);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PantMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 95);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarPedidoMesa);
            this.Name = "PantMenuPrincipal";
            this.ShowIcon = false;
            this.Text = "Menú principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarPedidoMesa;
        private System.Windows.Forms.Button btnSalir;
    }
}