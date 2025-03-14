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

namespace Banxico
{
    public partial class Form3 : Form
    {
        private readonly string token = "e3a8999bf1990e46c54e8bf72c3df04f494bde408dd6167afe970706a4bc28c9";
        public Form3()
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

                    // Extraer datos de la serie
                    var series = datos["bmx"]["series"][0]["datos"];
                    dataGridView1.Rows.Clear();

                    foreach (var dato in series)
                    {
                        string fecha = dato["fecha"].ToString();
                        string valor = dato["dato"].ToString();
                        dataGridView1.Rows.Add(fecha, valor);
                    }
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
    }
}
