using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planificador_de_Compras
{
    public partial class Form_Planner : Form
    {
        BindingList<Item> items = new BindingList<Item>();
        public Form_Planner()
        {
            InitializeComponent();
        }

        private void AgregarProducto()
        {
            items.Add(new Item(textBox_Producto.Text, Convert.ToInt32(textBox_Cantidad.Text), Convert.ToSingle(textBox_PrecioU.Text), (Convert.ToInt32(textBox_Cantidad.Text) * Convert.ToSingle(textBox_PrecioU.Text))));
        }

        private void QuitarProducto()
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Esta Ud. seguro de eliminar permanentemente este registro?",
                "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
            else
            {
                MessageBox.Show("No se puede Quitar mientras no seleccione un item..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = items;
        }

        private void LimpiarControles()
        {
            textBox_Producto.Text = String.Empty;
            textBox_Cantidad.Text = String.Empty;
            textBox_PrecioU.Text = String.Empty;
        }

        private float Sumatoria()
        {
            float resultado = 0;
            foreach (var item in items)
            {
                resultado += item.SubTotal;
            }
            return resultado;
        }

        private void MostrarSumatoria()
        {
            textBox_Sumatoria.Text = String.Empty;
            textBox_Sumatoria.Text = Convert.ToString(Sumatoria());
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            CargarDataGrid();
            MostrarSumatoria();
            LimpiarControles();
        }

        private void button_Quitar_Click(object sender, EventArgs e)
        {
            QuitarProducto();
            CargarDataGrid();
            MostrarSumatoria();
        }

        private void textBox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite valores numericos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_PrecioU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite valores numericos y con decimales", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
