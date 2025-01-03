using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AmigoPet.APIService;

namespace AmigoPet
{
    public partial class frmFavoritesScreen : Form
    {
        private readonly CatApiService _catApiService;

        private static frmFavoritesScreen _instance;

        public static frmFavoritesScreen Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new frmFavoritesScreen();
                }
                return _instance;
            }
        }

        public frmFavoritesScreen()
        {
            InitializeComponent();
            _catApiService = new CatApiService();
        }

        // Marcado o método como 'async' para usar 'await'
        private async void frmFavoritesScreen_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtém a lista de favoritos de forma assíncrona
                var favourites = await _catApiService.GetFavouritesAsync();

                if (favourites.Count == 0)
                {
                    MessageBox.Show("Nenhuma raça favorita encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Exibe os nomes das raças no ListBox
                foreach (var favourite in favourites)
                {
                    // Exibe o ID da imagem (ou outro dado relevante)
                    listBoxGatosFavoritos.Items.Add($"Imagem ID: {favourite.Image_Id}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar favoritos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método assíncrono para excluir um favorito
        private async void btExcluirGatoFavorito_Click(object sender, EventArgs e)
        {
            // Verifica se há um item selecionado no ListBox
            if (listBoxGatosFavoritos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um favorito para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID do favorito do item selecionado
            var selectedItem = listBoxGatosFavoritos.SelectedItem.ToString();
            var favouriteId = int.Parse(selectedItem.Split(':')[1].Trim()); // Supondo que o ID está no formato "Imagem ID: {id}"

            try
            {
                DialogResult confirmaExclusao = MessageBox.Show("Deseja realmente excluir este item?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == confirmaExclusao)
                {
                    // Chama o método assíncrono para excluir o favorito
                    bool isDeleted = await _catApiService.DeleteFavouriteAsync(favouriteId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Favorito removido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listBoxGatosFavoritos.Items.Remove(selectedItem); // Remove o item da lista
                    }
                    else
                    {
                        MessageBox.Show("Erro ao remover favorito. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover favorito: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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