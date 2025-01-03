using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AmigoPet.APIService;

namespace AmigoPet
{
    public partial class frmFavoritesScreen : Form
    {
        private readonly CatApiService _catApiService;

        public frmFavoritesScreen()
        {
            InitializeComponent();
            _catApiService = new CatApiService();
        }

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

        public void AddToFavorites(string breedName)
        {
            listBoxGatosFavoritos.Items.Add(breedName);
        }
        
        private async void btExcluirGatoFavorito_Click(object sender, EventArgs e)
        {
            if (listBoxGatosFavoritos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um favorito para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = listBoxGatosFavoritos.SelectedItem.ToString();
            var favouriteId = int.Parse(selectedItem.Split(':')[1].Trim());

            try
            {
                DialogResult confirmaExclusao = MessageBox.Show("Deseja realmente excluir este item?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == confirmaExclusao)
                {
                    bool isDeleted = await _catApiService.DeleteFavouriteAsync(favouriteId);

                    if (isDeleted)
                    {
                        MessageBox.Show("Favorito removido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listBoxGatosFavoritos.Items.Remove(selectedItem); 
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
            this.Hide(); 
        }
    }
}