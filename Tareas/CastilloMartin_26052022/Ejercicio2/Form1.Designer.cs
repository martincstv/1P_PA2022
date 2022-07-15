namespace Ejercicio2
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
            this.comboBox_TipoCredito = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_Monto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Generar = new System.Windows.Forms.Button();
            this.comboBox_SistemaAmortizacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Tiempo = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_GenerarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Monto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_TipoCredito
            // 
            this.comboBox_TipoCredito.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_TipoCredito.FormattingEnabled = true;
            this.comboBox_TipoCredito.Location = new System.Drawing.Point(9, 37);
            this.comboBox_TipoCredito.Name = "comboBox_TipoCredito";
            this.comboBox_TipoCredito.Size = new System.Drawing.Size(300, 24);
            this.comboBox_TipoCredito.TabIndex = 0;
            this.comboBox_TipoCredito.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipoCredito_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Que tipo de crédito esta buscando?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto de dinero que necesita";
            // 
            // numericUpDown_Monto
            // 
            this.numericUpDown_Monto.Location = new System.Drawing.Point(9, 83);
            this.numericUpDown_Monto.Name = "numericUpDown_Monto";
            this.numericUpDown_Monto.Size = new System.Drawing.Size(300, 22);
            this.numericUpDown_Monto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "En cuanto tiempo quiere pagarlo?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Limpiar);
            this.groupBox1.Controls.Add(this.button_Generar);
            this.groupBox1.Controls.Add(this.comboBox_SistemaAmortizacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_Tiempo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_TipoCredito);
            this.groupBox1.Controls.Add(this.numericUpDown_Monto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(398, 47);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 8;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Generar
            // 
            this.button_Generar.Location = new System.Drawing.Point(398, 18);
            this.button_Generar.Name = "button_Generar";
            this.button_Generar.Size = new System.Drawing.Size(75, 23);
            this.button_Generar.TabIndex = 7;
            this.button_Generar.Text = "Generar";
            this.button_Generar.UseVisualStyleBackColor = true;
            this.button_Generar.Click += new System.EventHandler(this.button_Generar_Click);
            // 
            // comboBox_SistemaAmortizacion
            // 
            this.comboBox_SistemaAmortizacion.FormattingEnabled = true;
            this.comboBox_SistemaAmortizacion.Location = new System.Drawing.Point(9, 171);
            this.comboBox_SistemaAmortizacion.Name = "comboBox_SistemaAmortizacion";
            this.comboBox_SistemaAmortizacion.Size = new System.Drawing.Size(300, 24);
            this.comboBox_SistemaAmortizacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sistema de amortización";
            // 
            // numericUpDown_Tiempo
            // 
            this.numericUpDown_Tiempo.Location = new System.Drawing.Point(9, 127);
            this.numericUpDown_Tiempo.Name = "numericUpDown_Tiempo";
            this.numericUpDown_Tiempo.Size = new System.Drawing.Size(300, 22);
            this.numericUpDown_Tiempo.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 203);
            this.dataGridView1.TabIndex = 6;
            // 
            // button_GenerarExcel
            // 
            this.button_GenerarExcel.Location = new System.Drawing.Point(575, 30);
            this.button_GenerarExcel.Name = "button_GenerarExcel";
            this.button_GenerarExcel.Size = new System.Drawing.Size(149, 23);
            this.button_GenerarExcel.TabIndex = 7;
            this.button_GenerarExcel.Text = "Generar Excel";
            this.button_GenerarExcel.UseVisualStyleBackColor = true;
            this.button_GenerarExcel.Click += new System.EventHandler(this.button_GenerarExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.button_GenerarExcel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Crédito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Monto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_TipoCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_Monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_SistemaAmortizacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_Tiempo;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Generar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_GenerarExcel;
    }
}

