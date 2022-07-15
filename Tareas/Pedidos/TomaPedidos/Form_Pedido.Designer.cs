namespace TomaPedidos
{
    partial class Form_Pedido
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_BuscarCliente = new System.Windows.Forms.PictureBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Celular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox_CedulaRuc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.textBox_Iva = new System.Windows.Forms.TextBox();
            this.textBox_SubTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_Productos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_NombreProducto = new System.Windows.Forms.TextBox();
            this.dataGridView_DetallePedidos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BuscarCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetallePedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_BuscarCliente);
            this.groupBox1.Controls.Add(this.textBox_Direccion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Celular);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Telefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox_CedulaRuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS CLIENTE";
            // 
            // pictureBox_BuscarCliente
            // 
            this.pictureBox_BuscarCliente.Image = global::TomaPedidos.Properties.Resources.buscar;
            this.pictureBox_BuscarCliente.Location = new System.Drawing.Point(480, 32);
            this.pictureBox_BuscarCliente.Name = "pictureBox_BuscarCliente";
            this.pictureBox_BuscarCliente.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_BuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_BuscarCliente.TabIndex = 12;
            this.pictureBox_BuscarCliente.TabStop = false;
            this.pictureBox_BuscarCliente.Click += new System.EventHandler(this.pictureBox_BuscarCliente_Click);
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(153, 169);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(300, 22);
            this.textBox_Direccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "DIRECCIÓN";
            // 
            // textBox_Celular
            // 
            this.textBox_Celular.Location = new System.Drawing.Point(153, 141);
            this.textBox_Celular.Name = "textBox_Celular";
            this.textBox_Celular.Size = new System.Drawing.Size(300, 22);
            this.textBox_Celular.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "CELULAR";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(153, 113);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(300, 22);
            this.textBox_Telefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "TELEFONO";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(153, 85);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(300, 22);
            this.textBox_Nombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOMBRE";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(153, 57);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(300, 22);
            this.textBox_Apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDO";
            // 
            // maskedTextBox_CedulaRuc
            // 
            this.maskedTextBox_CedulaRuc.Location = new System.Drawing.Point(153, 29);
            this.maskedTextBox_CedulaRuc.Mask = "0000000000-000";
            this.maskedTextBox_CedulaRuc.Name = "maskedTextBox_CedulaRuc";
            this.maskedTextBox_CedulaRuc.Size = new System.Drawing.Size(104, 22);
            this.maskedTextBox_CedulaRuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEDULA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Total);
            this.groupBox2.Controls.Add(this.textBox_Iva);
            this.groupBox2.Controls.Add(this.textBox_SubTotal);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button_Agregar);
            this.groupBox2.Controls.Add(this.button_Productos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_Cantidad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_PrecioUnitario);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_NombreProducto);
            this.groupBox2.Controls.Add(this.dataGridView_DetallePedidos);
            this.groupBox2.Location = new System.Drawing.Point(13, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 437);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE PEDIDO";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(601, 380);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(100, 22);
            this.textBox_Total.TabIndex = 14;
            this.textBox_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Iva
            // 
            this.textBox_Iva.Location = new System.Drawing.Point(601, 352);
            this.textBox_Iva.Name = "textBox_Iva";
            this.textBox_Iva.ReadOnly = true;
            this.textBox_Iva.Size = new System.Drawing.Size(100, 22);
            this.textBox_Iva.TabIndex = 13;
            this.textBox_Iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_SubTotal
            // 
            this.textBox_SubTotal.Location = new System.Drawing.Point(601, 324);
            this.textBox_SubTotal.Name = "textBox_SubTotal";
            this.textBox_SubTotal.ReadOnly = true;
            this.textBox_SubTotal.Size = new System.Drawing.Size(100, 22);
            this.textBox_SubTotal.TabIndex = 12;
            this.textBox_SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(516, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "TOTAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "IVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "SUBTOTAL";
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(660, 78);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(41, 23);
            this.button_Agregar.TabIndex = 8;
            this.button_Agregar.Text = "+";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // button_Productos
            // 
            this.button_Productos.Location = new System.Drawing.Point(541, 77);
            this.button_Productos.Name = "button_Productos";
            this.button_Productos.Size = new System.Drawing.Size(113, 23);
            this.button_Productos.TabIndex = 7;
            this.button_Productos.Text = "Productos =>";
            this.button_Productos.UseVisualStyleBackColor = true;
            this.button_Productos.Click += new System.EventHandler(this.button_Productos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cantidad";
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(424, 78);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.textBox_Cantidad.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Precio Unitario";
            // 
            // textBox_PrecioUnitario
            // 
            this.textBox_PrecioUnitario.Location = new System.Drawing.Point(285, 78);
            this.textBox_PrecioUnitario.Name = "textBox_PrecioUnitario";
            this.textBox_PrecioUnitario.ReadOnly = true;
            this.textBox_PrecioUnitario.Size = new System.Drawing.Size(100, 22);
            this.textBox_PrecioUnitario.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Producto";
            // 
            // textBox_NombreProducto
            // 
            this.textBox_NombreProducto.Location = new System.Drawing.Point(46, 78);
            this.textBox_NombreProducto.Name = "textBox_NombreProducto";
            this.textBox_NombreProducto.ReadOnly = true;
            this.textBox_NombreProducto.Size = new System.Drawing.Size(200, 22);
            this.textBox_NombreProducto.TabIndex = 1;
            // 
            // dataGridView_DetallePedidos
            // 
            this.dataGridView_DetallePedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DetallePedidos.Location = new System.Drawing.Point(46, 116);
            this.dataGridView_DetallePedidos.Name = "dataGridView_DetallePedidos";
            this.dataGridView_DetallePedidos.RowHeadersWidth = 51;
            this.dataGridView_DetallePedidos.RowTemplate.Height = 24;
            this.dataGridView_DetallePedidos.Size = new System.Drawing.Size(655, 202);
            this.dataGridView_DetallePedidos.TabIndex = 0;
            // 
            // Form_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BuscarCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetallePedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_BuscarCliente;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Celular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_CedulaRuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_DetallePedidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_PrecioUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_NombreProducto;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.TextBox textBox_Iva;
        private System.Windows.Forms.TextBox textBox_SubTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_Productos;
    }
}

