using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;
using Microsoft.Office;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        float porcentaje, seguroDesgravamenMinimo;
        List<Amortizacion> filas = new List<Amortizacion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboTipoCredito();
            CargarComboSistema();
        }

        private void CargarComboTipoCredito()
        {
            string[] enumElements = Enum.GetNames(typeof(Fun.TipoCredito));
            foreach (var item in enumElements)
            {
                comboBox_TipoCredito.Items.Add(item.Replace("_", " "));
            }
            comboBox_TipoCredito.SelectedIndex = (int)Fun.TipoCredito.PRODUCTIVO_PYMES;
            //comboBox_TipoCredito.SelectedIndex = 0;
        }

        private void CargarComboSistema()
        {
            string[] enumElements = Enum.GetNames(typeof(Fun.SistemaAmortizacion));
            foreach (var item in enumElements)
            {
                comboBox_SistemaAmortizacion.Items.Add(item.Replace("_", " "));
            }
            //comboBox_SistemaAmortizacion.SelectedIndex = (int)Fun.SistemaAmortizacion.FRANCÉS_CUOTA_FIJA;
            comboBox_SistemaAmortizacion.SelectedIndex = 0;
        }

        private void button_Generar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void CargarDataGrid()
        {
            if (comboBox_SistemaAmortizacion.Text == "ALEMAN CUOTA VARIABLE")
                AmortizacionaAlemana();
            else
                AmortizacionFrancesa();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filas;

        }

        private void AmortizacionFrancesa()
        {
            float monto = Convert.ToSingle(numericUpDown_Monto.Value);
            int tiempo = Convert.ToInt32(numericUpDown_Tiempo.Value);
            float porcentajeMensual = porcentaje / 12;
            double seguroDesgravamen = (monto * seguroDesgravamenMinimo) / Convert.ToSingle(numericUpDown_Monto.Minimum);//ya esta
            double cuota = (monto * ((porcentajeMensual) / (1 - Math.Pow((1 + porcentajeMensual), -tiempo)))) + seguroDesgravamen;
            double saldo = monto;
            double abonoCapital;
            double interes;
            for (int i = 1; i <= tiempo; i++)
            {
                interes = saldo * porcentajeMensual;
                abonoCapital = cuota - interes - seguroDesgravamen;
                saldo -= abonoCapital;
                filas.Add(new Amortizacion(i, Convert.ToSingle(abonoCapital.ToString("F")), Convert.ToSingle(interes.ToString("F")), Convert.ToSingle(seguroDesgravamen.ToString("F")), Convert.ToSingle(cuota.ToString("F")), Convert.ToSingle(saldo.ToString("F"))));
            }
        }

        private void AmortizacionaAlemana()
        {
            float monto = Convert.ToSingle(numericUpDown_Monto.Value);
            int tiempo = Convert.ToInt32(numericUpDown_Tiempo.Value);
            float saldo = monto;
            float abonoCapital = monto / tiempo;//ya esta
            float interes;
            float seguroDesgravamen = (monto * seguroDesgravamenMinimo) / Convert.ToSingle(numericUpDown_Monto.Minimum);//ya esta
            float cuota;
            for (int i = 1; i <= tiempo; i++)
            {
                interes = (saldo * porcentaje) / 12;
                cuota = abonoCapital + interes + seguroDesgravamen;//ya esta;
                saldo -= abonoCapital;
                filas.Add(new Amortizacion(i, Convert.ToSingle(abonoCapital.ToString("F")), Convert.ToSingle(interes.ToString("F")), Convert.ToSingle(seguroDesgravamen.ToString("F")), Convert.ToSingle(cuota.ToString("F")), Convert.ToSingle(saldo.ToString("F"))));
            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            filas.Clear();
        }

        private void button_GenerarExcel_Click(object sender, EventArgs e)
        {
            GenerarExcel();
        }

        private void GenerarExcel()
        {
            Microsoft.Office.Interop.Excel.Application generarExcel = new Microsoft.Office.Interop.Excel.Application();
            generarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                indiceColumna++;
                generarExcel.Cells[1, indiceColumna] = columna.Name;
                generarExcel.Cells[1, indiceColumna].Font.Bold = true;
                generarExcel.Cells[1, indiceColumna].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);
            }
            int indiceFila = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    indiceColumna++;
                    generarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            generarExcel.Columns.AutoFit();
            generarExcel.Columns.NumberFormat = ".00";
            generarExcel.Visible = true;
        }

        private void comboBox_TipoCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown_Monto.Maximum = 0;
            numericUpDown_Tiempo.Maximum = 0;
            string item = comboBox_TipoCredito.Text;
            numericUpDown_Tiempo.Minimum = 1;
            switch (item)
            {
                case "PRODUCTIVO PYMES":
                    numericUpDown_Monto.Minimum = 5000.00M;
                    numericUpDown_Monto.Maximum = 200000.00M;
                    numericUpDown_Tiempo.Maximum = 60;
                    porcentaje = 10.40F / 100;
                    seguroDesgravamenMinimo = 7.45F;
                    break;
                case "PRODUCTIVO EMPRESARIAL":
                    numericUpDown_Monto.Minimum = 5000.00M;
                    numericUpDown_Monto.Maximum = 200000.00M;
                    numericUpDown_Tiempo.Maximum = 60;
                    porcentaje = 9.30F / 100;
                    seguroDesgravamenMinimo = 7.45F;
                    break;
                case "PRODUCTIVO CORPORATIVO":
                    numericUpDown_Monto.Minimum = 5000.00M;
                    numericUpDown_Monto.Maximum = 200000.00M;
                    numericUpDown_Tiempo.Maximum = 60;
                    porcentaje = 8.30F / 100;
                    seguroDesgravamenMinimo = 7.45F;
                    break;
                case "CONSUMO":
                    numericUpDown_Monto.Minimum = 400.00M;
                    numericUpDown_Monto.Maximum = 200000.00M;
                    numericUpDown_Tiempo.Maximum = 120;
                    porcentaje = 14.00F / 100;
                    seguroDesgravamenMinimo = 0.60F;
                    break;
                case "MICROCREDITO":
                    numericUpDown_Monto.Minimum = 400.00M;
                    numericUpDown_Monto.Maximum = 10000.00M;
                    numericUpDown_Tiempo.Maximum = 72;
                    porcentaje = 14.75F / 100;
                    seguroDesgravamenMinimo = 0.60F;
                    break;
                case "VIVIENDA":
                    numericUpDown_Monto.Minimum = 5000.00M;
                    numericUpDown_Monto.Maximum = 200000.00M;
                    numericUpDown_Tiempo.Maximum = 120;
                    porcentaje = 9.50F / 100;
                    seguroDesgravamenMinimo = 7.45F;
                    break;
                case "ESTUDIANTIL":
                    numericUpDown_Monto.Minimum = 400.00M;
                    numericUpDown_Monto.Maximum = 200000.00M;
                    numericUpDown_Tiempo.Maximum = 48;
                    porcentaje = 12.20F / 100;
                    seguroDesgravamenMinimo = 0.60F;
                    break;
                case "MAESTRIAS":
                    numericUpDown_Monto.Minimum = 400.00M;
                    numericUpDown_Monto.Maximum = 35000.00M;
                    numericUpDown_Tiempo.Maximum = 60;
                    porcentaje = 12.20F / 100;
                    seguroDesgravamenMinimo = 0.60F;
                    break;
                case "PHD":
                    numericUpDown_Monto.Minimum = 400.00M;
                    numericUpDown_Monto.Maximum = 30000.00M;
                    numericUpDown_Tiempo.Maximum = 84;
                    porcentaje = 12.20F / 100;
                    seguroDesgravamenMinimo = 0.60F;
                    break;
            }
        }
    }
}
