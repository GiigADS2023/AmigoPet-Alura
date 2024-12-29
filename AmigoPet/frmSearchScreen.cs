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
        private frmFavoritesScreen favouritesScreen;

        public frmSearchScreen(frmFavoritesScreen favouritesScreen)
        {
            InitializeComponent();
            this.favouritesScreen = favouritesScreen;
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

        private void btnFavoritarGato_Click(object sender, EventArgs e)
        {
            if (cbRaca.SelectedItem != null)
            {
                // Acessando o item selecionado
                var selectedCat = (dynamic)cbRaca.SelectedItem; // 'dynamic' para não precisar de classe extra
                
                string catName = selectedCat.Name;

                // Adicionar o nome do gato na ListBox de favoritos no outro formulário
                if (!favouritesScreen.ListBoxFavoritos.Items.Contains(catName))
                {
                    favouritesScreen.ListBoxFavoritos.Items.Add(catName);
                    MessageBox.Show($"{catName} foi adicionado aos favoritos!");
                }
                else
                {
                    MessageBox.Show($"{catName} já está nos favoritos!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma raça para favoritar.");
            }
        }
    }
}
