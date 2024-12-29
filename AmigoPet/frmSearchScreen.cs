using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Formatting;
using System.Net.Http;
using Newtonsoft.Json;

namespace AmigoPet
{
    public partial class frmSearchScreen : Form
    {
        public frmSearchScreen()
        {
            InitializeComponent();
        }

        private void frmSearchScreen_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
            HttpResponseMessage response = client.GetAsync("breeds").Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                var cats = JsonConvert.DeserializeObject<List<Gato>>(json);
                foreach (var cat in cats)
                {
                    cbRaca.Items.Add(new { Name = cat.name, Id = cat.id });
                }

                cbRaca.DisplayMember = "Name";
                cbRaca.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Erro ao carregar raças.");
            }
        }

        private void btnBuscarGato_Click_1(object sender, EventArgs e)
        {
            if (cbRaca.SelectedItem != null)
            {
                var selectedCat = (dynamic)cbRaca.SelectedItem;
                string selectedId = selectedCat.Id;

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
                HttpResponseMessage response = client.GetAsync($"breeds/{selectedId}").Result;

                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var cat = JsonConvert.DeserializeObject<Gato>(json);

                    lbResultadoTemperamento.Text = cat.temperament;
                    lbResultadoOrigem.Text = cat.origin;
                    lbResultadoDescricao.Text = cat.description;
                }
                else
                {
                    MessageBox.Show("Erro ao buscar informações da raça.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma raça no combo box.");
            }
        }
    }
}
