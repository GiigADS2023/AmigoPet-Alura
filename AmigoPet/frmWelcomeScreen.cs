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
            frmSearchScreen.Instance.Show(); 
            this.Hide(); 
        }

        private void IconFavoriteBreed_Click(object sender, EventArgs e)
        {
            frmFavoritesScreen.Instance.Show(); 
            this.Hide(); 
        }
    }
}