using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using AmigoPet.APIService;
using System.Linq;

namespace AmigoPet
{
    public partial class frmSearchScreen : Form
    {
        private readonly CatApiService _catApiService;

        private static frmSearchScreen _instance;

        public static frmSearchScreen Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new frmSearchScreen();
                }
                return _instance;
            }
        }

        public frmSearchScreen()
        {
            InitializeComponent();
            _catApiService = new CatApiService();
        }

        private async void btnBuscarGato_Click(object sender, EventArgs e)
        {
            try
            {
                var breeds = await _catApiService.GetBreedsAsync();
                var selectedBreedName = cbRaca.SelectedItem?.ToString();

                if (selectedBreedName == null)
                {
                    MessageBox.Show("Por favor, selecione uma raça.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedBreed = breeds.FirstOrDefault(b => b.name.Equals(selectedBreedName, StringComparison.OrdinalIgnoreCase));

                if (selectedBreed != null)
                {
                    lbResultadoTemperamento.Text = selectedBreed.temperament;
                    lbResultadoOrigem.Text = selectedBreed.origin;
                    lbResultadoDescricao.Text = selectedBreed.description;
                }
                else
                {
                    MessageBox.Show("Raça não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar informações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSearchScreen_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
            client.DefaultRequestHeaders.Add("x-api-key", "live_fKX1CYdcnuqMtNWIRfFWyRtR9VjHDs8v8LRIWLuhtmZzOUjhF8fSveF0MtUVFLDd");

            HttpResponseMessage response = client.GetAsync("breeds").Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                var cats = JsonConvert.DeserializeObject<List<Gato>>(json);

                if (cats != null && cats.Any())
                {
                    foreach (var cat in cats)
                    {
                        cbRaca.Items.Add(cat.name); 
                    }

                    cbRaca.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Nenhuma raça foi encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Erro ao carregar raças.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnFavoritarGato_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedBreedName = cbRaca.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedBreedName))
                {
                    MessageBox.Show("Por favor, selecione uma raça.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var breeds = await _catApiService.GetBreedsAsync();
                var selectedBreed = breeds.FirstOrDefault(b => b.name.Equals(selectedBreedName, StringComparison.OrdinalIgnoreCase));

                if (selectedBreed == null || selectedBreed.image == null || string.IsNullOrEmpty(selectedBreed.image.id))
                {
                    MessageBox.Show("Não foi possível localizar a imagem da raça selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var success = await _catApiService.FavoriteBreedAsync(selectedBreed.image.id);

                if (success)
                {
                    var favoritesScreen = frmFavoritesScreen.Instance;
                    favoritesScreen.AddToFavorites(selectedBreedName);

                    MessageBox.Show("Raça favoritada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Já foi adicionado aos favoritos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar a requisição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmWelcomeScreen welcomeScreen = new frmWelcomeScreen();
            welcomeScreen.Show();
            this.Hide(); 
        }
    }
}