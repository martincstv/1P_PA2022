using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomaPedidos.Properties;

namespace TomaPedidos
{
    public partial class Form_Pedido : Form
    {
        //Definir una lista
        List<Cliente> listaClientes = new List<Cliente>();
        List<DetalleVenta> listaDetallePedidos = new List<DetalleVenta>();
        public Form_Pedido()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarValoresInicio();
        }

        private void CargarValoresInicio()
        {
            CargarListadoClientes();
        }

        private void CargarListadoClientes()
        {
            listaClientes.Add(new Cliente(1, "1111111111", "Cuesta", "Martina", "032849510", "092151456", "Avenida Los Guaytambos"));
            listaClientes.Add(new Cliente(2, "2222222222", "Aguilar", "Geane", "032849510", "092151456", "Calle Malaga"));
            listaClientes.Add(new Cliente(3, "3333333333", "Paez", "Niurka", "032849510", "092151456", "Avenida Cevallos"));
            listaClientes.Add(new Cliente(4, "4444444444", "Sevilla", "Isabel", "032849510", "092151456", "Avenida Miraflores"));
            listaClientes.Add(new Cliente(5, "5555555555", "Cardenas", "Alejandra", "032849510", "092151456", "Avenida Los Chasquis"));
            listaClientes.Add(new Cliente(6, "6666666666", "Villacres", "Daniel", "032849510", "092151456", "Calle Frutillas"));
            listaClientes.Add(new Cliente(7, "7777777777", "Cepeda", "Juan", "032849510", "092151456", "Avenida Los Shiris"));
            listaClientes.Add(new Cliente(8, "8888888888", "Jaramillo", "Monserrath", "032849510", "092151456", "Humberto Albornoz"));


        }

        private void pictureBox_BuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            BuscarClientePorCedulaRuc(maskedTextBox_CedulaRuc.Text.Replace("-", ""));
        }

        private void BuscarClientePorCedulaRuc(string _cedulaRuc)
        {
            bool resultado = false;
            foreach (var cliente in listaClientes)
            {
                if (_cedulaRuc == cliente.CedulaRuc)
                {
                    CargarDatosClienteControles(cliente);
                    resultado = true;
                }
            }
            if (!resultado)
            {
                MessageBox.Show("No se encontraron clientes con la cédula/Ruc especificada",
                    "No hay registros",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                maskedTextBox_CedulaRuc.Focus();
                LimpiarControles();
            }
        }

        private void LimpiarControles()
        {
            maskedTextBox_CedulaRuc.Text = string.Empty;
            textBox_Apellido.Text = string.Empty;
            textBox_Nombre.Text = string.Empty;
            textBox_Telefono.Text = string.Empty;
            textBox_Celular.Text = string.Empty;
            textBox_Direccion.Text = string.Empty;
        }

        private void CargarDatosClienteControles(Cliente cliente)
        {
            textBox_Apellido.Text = cliente.Apellido;
            textBox_Nombre.Text = cliente.Nombre;
            textBox_Telefono.Text = cliente.Telefono;
            textBox_Celular.Text = cliente.Celular;
            textBox_Direccion.Text = cliente.Direccion;
        }

        private void button_Productos_Click(object sender, EventArgs e)
        {
            LlamarFormularioProductos();
        }

        private void LlamarFormularioProductos()
        {
            Form_Producto frm = new Form_Producto();
            frm.ShowDialog();
            if (frm.ProductoSeleccionado != null)
            {
                //TODO: Cargar Informacion en Controles
                textBox_NombreProducto.Text = frm.ProductoSeleccionado.Nombre;
                textBox_PrecioUnitario.Text = frm.ProductoSeleccionado.Precio.ToString();
                textBox_Cantidad.Focus();
            }
        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            AgregarProductosVentas();
            CalcularValores();
        }

        private void CalcularValores()
        {
            CalcularSubtotal();
            CalcularIva();
            CalcularTotal();
        }

        private void CalcularSubtotal()
        {
            float _subtotal = 0;
            foreach (var item in listaDetallePedidos)
            {
                _subtotal += item.Subtotal;
            }
            textBox_SubTotal.Text = _subtotal.ToString("F");
        }

        private void CalcularIva()
        {
            var _iva = Convert.ToSingle(textBox_SubTotal.Text) * Settings.Default.iva;
            textBox_Iva.Text = _iva.ToString("F");
        }

        private void CalcularTotal()
        {
            var _subtotal = Convert.ToSingle(textBox_SubTotal.Text);
            var _iva = Convert.ToSingle(textBox_Iva.Text);
            var _total = _subtotal + _iva;
            textBox_Total.Text = _total.ToString("F");
        }

        private void AgregarProductosVentas()
        {
            listaDetallePedidos.Add(new DetalleVenta(textBox_NombreProducto.Text,
                Convert.ToSingle(textBox_PrecioUnitario.Text),
                Convert.ToInt32(textBox_Cantidad.Text),
                Convert.ToSingle(textBox_PrecioUnitario.Text) * Convert.ToInt32(textBox_Cantidad.Text)
                ));
            dataGridView_DetallePedidos.DataSource = null;
            dataGridView_DetallePedidos.DataSource = listaDetallePedidos;
        }
    }
}
