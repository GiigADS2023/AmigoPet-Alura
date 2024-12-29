using System;
using System.Windows.Forms;

namespace AmigoPet
{
    public partial class frmWelcomeScreen : Form
    {
        private frmFavoritesScreen favouritesScreen; // Instância compartilhada de favoritos

        public frmWelcomeScreen()
        {
            InitializeComponent();
            favouritesScreen = new frmFavoritesScreen(); // Cria a instância de favoritos apenas uma vez
        }

        private void IconBreedSearch_Click(object sender, EventArgs e)
        {
            // Esconde a tela de boas-vindas
            this.Hide();

            // Cria o formulário de busca e o exibe
            var searchScreen = new frmSearchScreen(favouritesScreen); // Passa a instância existente de favoritos

            searchScreen.FormClosed += (s, args) => this.Show(); // Reexibe o formulário de boas-vindas ao fechar
            searchScreen.Show(); // Mostra o formulário de busca
        }

        private void IconFavoriteBreed_Click(object sender, EventArgs e)
        {
            // Esconde a tela de boas-vindas
            this.Hide();

            // Já existe uma instância do frmFavoritesScreen, então apenas exibe
            favouritesScreen.FormClosed += (s, args) => this.Show(); // Reexibe o formulário de boas-vindas ao fechar
            favouritesScreen.Show(); // Mostra o formulário de favoritos
        }
    }
}