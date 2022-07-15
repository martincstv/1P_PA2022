namespace Planificador_de_Compras
{
    partial class Form_Planner
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
            this.button_Agregar = new System.Windows.Forms.Button();
            this.textBox_PrecioU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Quitar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Sumatoria = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Agregar);
            this.groupBox1.Controls.Add(this.textBox_PrecioU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Cantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Producto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(544, 33);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(100, 28);
            this.button_Agregar.TabIndex = 6;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // textBox_PrecioU
            // 
            this.textBox_PrecioU.Location = new System.Drawing.Point(417, 39);
            this.textBox_PrecioU.Name = "textBox_PrecioU";
            this.textBox_PrecioU.ShortcutsEnabled = false;
            this.textBox_PrecioU.Size = new System.Drawing.Size(100, 22);
            this.textBox_PrecioU.TabIndex = 5;
            this.textBox_PrecioU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PrecioU_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio U";
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(246, 39);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.ShortcutsEnabled = false;
            this.textBox_Cantidad.Size = new System.Drawing.Size(100, 22);
            this.textBox_Cantidad.TabIndex = 3;
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // textBox_Producto
            // 
            this.textBox_Producto.Location = new System.Drawing.Point(73, 39);
            this.textBox_Producto.Name = "textBox_Producto";
            this.textBox_Producto.Size = new System.Drawing.Size(100, 22);
            this.textBox_Producto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // button_Quitar
            // 
            this.button_Quitar.Location = new System.Drawing.Point(12, 410);
            this.button_Quitar.Name = "button_Quitar";
            this.button_Quitar.Size = new System.Drawing.Size(100, 28);
            this.button_Quitar.TabIndex = 7;
            this.button_Quitar.Text = "Quitar";
            this.button_Quitar.UseVisualStyleBackColor = true;
            this.button_Quitar.Click += new System.EventHandler(this.button_Quitar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(660, 300);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sumatoria";
            // 
            // textBox_Sumatoria
            // 
            this.textBox_Sumatoria.Location = new System.Drawing.Point(556, 413);
            this.textBox_Sumatoria.Name = "textBox_Sumatoria";
            this.textBox_Sumatoria.ReadOnly = true;
            this.textBox_Sumatoria.Size = new System.Drawing.Size(100, 22);
            this.textBox_Sumatoria.TabIndex = 10;
            // 
            // Form_Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.textBox_Sumatoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Quitar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Planner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.TextBox textBox_PrecioU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Quitar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Sumatoria;
    }
}

