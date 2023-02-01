namespace WindowsApp
{
    partial class Form1
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
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnCrearVendedor = new System.Windows.Forms.Button();
            this.btnCrearEmpresa = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnCrearRemito = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(287, 51);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(181, 49);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Crear producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(287, 159);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(181, 44);
            this.btnCrearVendedor.TabIndex = 2;
            this.btnCrearVendedor.Text = "Crear vendedor";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            this.btnCrearVendedor.Click += new System.EventHandler(this.btnCrearVendedor_Click);
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.Location = new System.Drawing.Point(287, 209);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(181, 39);
            this.btnCrearEmpresa.TabIndex = 3;
            this.btnCrearEmpresa.Text = "Crear empresa";
            this.btnCrearEmpresa.UseVisualStyleBackColor = true;
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Location = new System.Drawing.Point(287, 263);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(181, 39);
            this.btnCrearFactura.TabIndex = 4;
            this.btnCrearFactura.Text = "Crear factura";
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // btnCrearRemito
            // 
            this.btnCrearRemito.Location = new System.Drawing.Point(287, 320);
            this.btnCrearRemito.Name = "btnCrearRemito";
            this.btnCrearRemito.Size = new System.Drawing.Size(181, 40);
            this.btnCrearRemito.TabIndex = 5;
            this.btnCrearRemito.Text = "Crear remito";
            this.btnCrearRemito.UseVisualStyleBackColor = true;
            this.btnCrearRemito.Click += new System.EventHandler(this.btnCrearRemito_Click);
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Location = new System.Drawing.Point(287, 106);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(181, 47);
            this.btnCrearCliente.TabIndex = 6;
            this.btnCrearCliente.Text = "Crear cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.btnCrearRemito);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnCrearEmpresa);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.btnCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCrearVendedor;
        private System.Windows.Forms.Button btnCrearEmpresa;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnCrearRemito;
        private System.Windows.Forms.Button btnCrearCliente;
    }
}

