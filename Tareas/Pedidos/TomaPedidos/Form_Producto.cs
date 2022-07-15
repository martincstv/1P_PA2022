using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomaPedidos
{
    public partial class Form_Producto : Form
    {
        //Crear Propiedad - Producto
        public Producto ProductoSeleccionado { get; set; }
        public Form_Producto()
        {
            InitializeComponent();
        }

        private void Form_Producto_Load(object sender, EventArgs e)
        {
            CargarEnGridListadoProductos();
        }

        private void CargarEnGridListadoProductos()
        {
            dataGridView_Productos.DataSource = DevolverListadoProductos();
        }

        private List<Producto> DevolverListadoProductos()
        {
            List<Producto> listadoProductos = new List<Producto>();
            listadoProductos.Add(new Producto(1,"Kilo Pan",2.55F));
            listadoProductos.Add(new Producto(2,"Kilo Harina",4.30F));
            listadoProductos.Add(new Producto(3,"Litro Leche",1.25F));
            listadoProductos.Add(new Producto(4,"Kilo Carne",5.45F));
            listadoProductos.Add(new Producto(5,"Kilo Fideo",1.95F));
            return listadoProductos;
        }

        private void dataGridView_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView_Productos.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            var nombre = dataGridView_Productos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            var precioUnitario = Convert.ToSingle(dataGridView_Productos.Rows[e.RowIndex].Cells["Precio"].Value.ToString());

            Producto _producto = new Producto(id, nombre, precioUnitario);
            ProductoSeleccionado=_producto;
            this.Close();
        }
    }
}
