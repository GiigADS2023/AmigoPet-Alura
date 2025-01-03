using System;
using System.Windows.Forms;
using AmigoPet.APIService;

namespace AmigoPet
{
    public partial class frmWelcomeScreen : Form
    {
        public frmWelcomeScreen()
        {
            InitializeComponent();
        }

        private void IconBreedSearch_Click(object sender, EventArgs e)
        {
            frmSearchScreen.Instance.Show(); // Abre a tela de busca
            this.Hide(); // Esconde a tela de boas-vindas
        }

        private void IconFavoriteBreed_Click(object sender, EventArgs e)
        {
            frmFavoritesScreen.Instance.Show(); // Abre a tela de favoritos
            this.Hide(); // Esconde a tela de boas-vindas
        }
    }
}