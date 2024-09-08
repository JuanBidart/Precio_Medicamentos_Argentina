using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using ScrapySharp.Extensions;


namespace scrapy2
{
    public partial class Form1 : Form
    {
        public string buscar = string.Empty;
        public Form1()
        {
            InitializeComponent();

            txtPorcentaje.Text = "0";
            checkRedondeo.Checked = true;
            

            
            
            progressBar1.Value = 0;
            
        }

        public List<string> ObtenerData()
        {
            {
                List<string> lista = new List<string>();

                var url = "https://www.preciosderemedios.com.ar/precios/?pattern="+buscar;
                HtmlWeb oWeb = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = oWeb.Load(url);
                int contador=0;
                for (int j = 1; j < 1000; j++)
                    try
                    {

                        var nodos = doc.DocumentNode.SelectNodes("//*[@id=\"resultadoConsulta\"]/tbody/tr[" + j + "]");
                        if (nodos != null)
                        {
                            foreach (var nodo in nodos)
                            {
                                contador++;
                                
                            }

                        }
                    }
                    catch (System.NullReferenceException) { }
                 progressBar1.Maximum = contador;
                    
                // Seleccionar las filas de la tabla
                for (int i = 1; i <= contador; i++)
                {
                   
                    try
                    {
                        foreach (var nodo in doc.DocumentNode.SelectNodes("//*[@id=\"resultadoConsulta\"]/tbody/tr[" + i + "]"))
                        {
                            // Extraer el nombre del producto
                            var nombreNodo = nodo.SelectSingleNode(".//td[1]/a");
                            var nombreProducto = nombreNodo != null ? nombreNodo.InnerText.Trim() : string.Empty;

                            // Extraer la presentación
                            var presentacionNodo = nodo.SelectSingleNode(".//td[2]");
                            var presentacion = presentacionNodo != null ? presentacionNodo.InnerText.Trim() : string.Empty;

                            // Extraer el precio
                            var precioNodo = nodo.SelectSingleNode(".//td[3]");
                            var precio = precioNodo != null ? precioNodo.InnerText.Trim() : string.Empty;

                            // Agregar los datos a la lista si todos los campos están presentes
                            if (!string.IsNullOrEmpty(nombreProducto) && !string.IsNullOrEmpty(presentacion) && !string.IsNullOrEmpty(precio))
                            {
                                lista.Add($"{nombreProducto}, {presentacion}, {precio}");
                                
                            }
                        }


                    }
                    catch (System.NullReferenceException) { return lista; }
                    catch (Exception)
                    {

                        return lista;
                    }

                }
                return lista;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            btnBuscar.Enabled = false;
            buscar = txtBuscar.Text;
            dgvMedicamentos.DataSource = null; //borrar datos del dgv
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Medicamentos");
            dt.Columns.Add("Presentacion");
            dt.Columns.Add("Precio");


            foreach (var item in ObtenerData())
            {
                string[] partes = item.Split(',');

                // Crear una nueva fila en el DataTable y asignar los valores
                DataRow fila = dt.NewRow();
                fila["Medicamentos"] = partes[0]; // Asignar "ibupirac" a la columna "Nombre"
                fila["Presentacion"] = partes[1];   // Asignar "pastilla" a la columna "Tipo"
                fila["Precio"] = partes[2]; // Asignar "$543" a la columna "Precio"

                // Agregar la fila al DataTable
                dt.Rows.Add(fila);

                // Actualizar el DataGridView
                dgvMedicamentos.DataSource = dt;
            }
        btnBuscar.Enabled = true;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tecla = e.KeyChar;
            if (tecla == '\r') { btnBuscar_Click(sender,e); }

        }

        private void dgvMedicamentos_SelectionChanged(object sender, EventArgs e)
        {
            txtSub.Enabled = true;
            if (dgvMedicamentos.Focused)
            {
                if (dgvMedicamentos.SelectedRows.Count > 0)
                {
                    // Obtén la fila seleccionada
                    DataGridViewRow filaSeleccionada = dgvMedicamentos.SelectedRows[0];

                    // Extrae los valores de las columnas
                    string nombre = filaSeleccionada.Cells["Medicamentos"].Value.ToString();
                    string tipo = filaSeleccionada.Cells["Presentacion"].Value.ToString();
                    string precio = filaSeleccionada.Cells["Precio"].Value.ToString().Replace(".",",");

                    lblPrecioCosto.Text = precio;

                    double costo = double.Parse(precio.Remove(0,2).Trim());
                    double porcentaje;
                    if (txtPorcentaje.Text == string.Empty)
                    {
                        porcentaje = 0;
                    }
                    else
                    {
                        porcentaje = double.Parse(txtPorcentaje.Text);
                    }
                    

                    if (checkRedondeo.Checked)
                    {
                        double resultado = ((costo * porcentaje) / 100) + costo;
                        txtSub.Text = resultado.ToString();

                        resultado = Math.Round(resultado / 100) * 100;

                        txtResultado.Text = resultado.ToString();
                    }
                    else 
                    {
                        double resultado = ((costo * porcentaje) / 100) + costo;
                        txtSub.Enabled = false;
                        txtResultado.Text = resultado.ToString();

                    }
                }
                else
                {
                    //MessageBox.Show("No hay ninguna fila seleccionada.");
                }
            }
            

        }

        private void btnCopiarSub_Click(object sender, EventArgs e)
        {
            string portapapeles = txtSub.Text;
            Clipboard.SetText(portapapeles);
        }
    }
}

