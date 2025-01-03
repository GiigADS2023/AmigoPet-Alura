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

                var selectedBreed = breeds.FirstOrDefault(b => b.Name.Equals(selectedBreedName, StringComparison.OrdinalIgnoreCase));

                if (selectedBreed != null)
                {
                    lbResultadoTemperamento.Text = selectedBreed.Temperament;
                    lbResultadoOrigem.Text = selectedBreed.Origin;
                    lbResultadoDescricao.Text = selectedBreed.Description;
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

        private async void frmSearchScreen_Load(object sender, EventArgs e)
        {
            try
            {
                var breeds = await _catApiService.GetBreedsAsync();

                if (breeds == null || !breeds.Any())
                {
                    MessageBox.Show("Nenhuma raça foi encontrada. Verifique sua conexão com a API.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cbRaca.DataSource = null;
                cbRaca.DataSource = breeds.Select(b => b.Name).ToList();
                cbRaca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar raças: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnFavoritarGato_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o nome da raça selecionada
                var selectedBreedName = cbRaca.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedBreedName))
                {
                    MessageBox.Show("Por favor, selecione uma raça.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Faz a busca das raças
                var breeds = await _catApiService.GetBreedsAsync();
                var selectedBreed = breeds.FirstOrDefault(b => b.Name.Equals(selectedBreedName, StringComparison.OrdinalIgnoreCase));

                if (selectedBreed == null || selectedBreed.Image == null || string.IsNullOrEmpty(selectedBreed.Image.Id))
                {
                    MessageBox.Show("Não foi possível localizar a imagem da raça selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Envia a raça favorita para a API
                var success = await _catApiService.FavoriteBreedAsync(selectedBreed.Image.Id);

                if (success)
                {
                    MessageBox.Show("Raça favoritada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao favoritar a raça. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Hide(); // Esconde a tela atual
        }
    }
}