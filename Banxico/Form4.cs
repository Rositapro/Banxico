using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace Banxico
{
    public partial class Form4 : Form
    {
        private readonly string token = "e3a8999bf1990e46c54e8bf72c3df04f494bde408dd6167afe970706a4bc28c9";
        public Form4()
        {
            InitializeComponent();
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            string fechaInicio = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string fechaFin = dtpEndDate.Value.ToString("yyyy-MM-dd");

            await ObtenerDolarPorFechas(fechaInicio, fechaFin);
        }
        private async Task ObtenerDolarPorFechas(string fechaInicio, string fechaFin)
        {
            string url = $"https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/{fechaInicio}/{fechaFin}?token={token}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject datos = JObject.Parse(jsonResponse);

                    var series = datos["bmx"]["series"][0]["datos"];

                    int totalDatos = series.Count();
                    double[] valores = new double[totalDatos];
                    string[] fechas = new string[totalDatos];

                    int index = 0;
                    foreach (var dato in series)
                    {
                        fechas[index] = dato["fecha"].ToString();
                        valores[index] = double.TryParse(dato["dato"].ToString(), out double valor) ? valor : 0;
                        index++;
                    }

                    //// Limpiar y actualizar la gráfica
                    //formsPlot1.Plot.Clear();
                    //var bar = formsPlot1.Plot.AddBar(valores);
                    //formsPlot1.Plot.XTicks(fechas);
                    //formsPlot1.Plot.Title("Valor del Dólar en el Rango de Fechas");
                    //formsPlot1.Plot.YLabel("Precio en MXN");
                    //formsPlot1.Plot.XLabel("Fecha");
                    //formsPlot1.Refresh();
                }
                else
                {
                    MessageBox.Show("Error al obtener los datos de Banxico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        //private async Task ObtenerDolarPorFechas(string fechaInicio, string fechaFin)
        //{
        //    string url = $"https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/{fechaInicio}/{fechaFin}?token={token}";
        //    using (HttpClient client = new HttpClient())
        //    {
        //        HttpResponseMessage response = await client.GetAsync(url);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string jsonResponse = await response.Content.ReadAsStringAsync();
        //            JObject datos = JObject.Parse(jsonResponse);
        //            // Extraer datos de la serie
        //            var series = datos["bmx"]["series"][0]["datos"];
        //            dataGridView1.Rows.Clear();
        //            foreach (var dato in series)
        //            {
        //                string fecha = dato["fecha"].ToString();
        //                string valor = dato["dato"].ToString();
        //                dataGridView1.Rows.Add(fecha, valor);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Error al obtener los datos de Banxico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

    }
}
