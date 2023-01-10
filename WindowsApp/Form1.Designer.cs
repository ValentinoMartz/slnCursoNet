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
            this.btnCrearProveedor = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btnCrearClienteEmpresa = new System.Windows.Forms.Button();
            this.btnCrearVendedor = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnCrearRemito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProducto.Location = new System.Drawing.Point(54, 49);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(260, 38);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Crear un producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnCrearProveedor
            // 
            this.btnCrearProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProveedor.Location = new System.Drawing.Point(54, 138);
            this.btnCrearProveedor.Name = "btnCrearProveedor";
            this.btnCrearProveedor.Size = new System.Drawing.Size(260, 38);
            this.btnCrearProveedor.TabIndex = 1;
            this.btnCrearProveedor.Text = "Crear un proveedor";
            this.btnCrearProveedor.UseVisualStyleBackColor = true;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCliente.Location = new System.Drawing.Point(54, 228);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(260, 38);
            this.btnCrearCliente.TabIndex = 2;
            this.btnCrearCliente.Text = "Crear un Cliente (Individual)";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click);
            // 
            // btnCrearClienteEmpresa
            // 
            this.btnCrearClienteEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearClienteEmpresa.Location = new System.Drawing.Point(361, 49);
            this.btnCrearClienteEmpresa.Name = "btnCrearClienteEmpresa";
            this.btnCrearClienteEmpresa.Size = new System.Drawing.Size(260, 38);
            this.btnCrearClienteEmpresa.TabIndex = 3;
            this.btnCrearClienteEmpresa.Text = "Crear un Cliente Empresa";
            this.btnCrearClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVendedor.Location = new System.Drawing.Point(361, 138);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(260, 38);
            this.btnCrearVendedor.TabIndex = 4;
            this.btnCrearVendedor.Text = "Crear un vendedor";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFactura.Location = new System.Drawing.Point(361, 228);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(260, 38);
            this.btnCrearFactura.TabIndex = 5;
            this.btnCrearFactura.Text = "Crear un factura";
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            // 
            // btnCrearRemito
            // 
            this.btnCrearRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearRemito.Location = new System.Drawing.Point(206, 315);
            this.btnCrearRemito.Name = "btnCrearRemito";
            this.btnCrearRemito.Size = new System.Drawing.Size(260, 38);
            this.btnCrearRemito.TabIndex = 6;
            this.btnCrearRemito.Text = "Crear un remito";
            this.btnCrearRemito.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 401);
            this.Controls.Add(this.btnCrearRemito);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.btnCrearClienteEmpresa);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.btnCrearProveedor);
            this.Controls.Add(this.btnCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCrearProveedor;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Button btnCrearClienteEmpresa;
        private System.Windows.Forms.Button btnCrearVendedor;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnCrearRemito;
    }
}

