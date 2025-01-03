using System;
using System.Windows.Forms;

namespace AmigoPet
{
    public partial class frmWelcomeScreen : Form
    {
        private frmFavoritesScreen favouritesScreen; // Instância única de favoritos

        public frmWelcomeScreen()
        {
            InitializeComponent();

            // Cria a instância de favoritos uma vez
            favouritesScreen = new frmFavoritesScreen();

            // Adiciona o evento de fechamento apenas uma vez no construtor
            favouritesScreen.FormClosed += (s, args) => this.Show();
        }

        private void IconBreedSearch_Click(object sender, EventArgs e)
        {
            // Esconde a tela de boas-vindas
            this.Hide();

            // Cria o formulário de busca e passa a instância de favoritos
            var searchScreen = new frmSearchScreen(favouritesScreen);

            searchScreen.FormClosed += (s, args) => this.Show(); // Reexibe a tela de boas-vindas ao fechar
            searchScreen.Show(); // Mostra o formulário de busca
        }

        private void IconFavoriteBreed_Click(object sender, EventArgs e)
        {
            // Esconde a tela de boas-vindas
            this.Hide();

            // Apenas exibe a instância única de favoritos
            favouritesScreen.Show();
        }
    }
}