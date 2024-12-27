using System;
using System.Threading;
using System.Windows.Forms;

namespace AmigoPet
{
    public partial class frmWelcomeScreen : Form
    {
        Thread TOpenWindow;

        public frmWelcomeScreen()
        {
            InitializeComponent();
        }

        private void IconBreedSearch_Click(object sender, EventArgs e)
        {
            this.Close();
            TOpenWindow = new Thread(() => OpenWindow("Search"));
            TOpenWindow.SetApartmentState(ApartmentState.STA);
            TOpenWindow.Start();
        }

        private void IconFavoriteBreed_Click(object sender, EventArgs e)
        {
            this.Close();
            TOpenWindow = new Thread(() => OpenWindow("Favorites"));
            TOpenWindow.SetApartmentState(ApartmentState.STA);
            TOpenWindow.Start();
        }

        private void OpenWindow(string screenType)
        {
            if (screenType == "Search")
            {
                Application.Run(new frmSearchScreen());
                ReopenWelcomeScreen();
            }
            else if (screenType == "Favorites")
            {
                Application.Run(new frmFavoritesScreen());
                ReopenWelcomeScreen();
            }
        }

        private void ReopenWelcomeScreen()
        {
            Application.Run(new frmWelcomeScreen());
        }
    }
}