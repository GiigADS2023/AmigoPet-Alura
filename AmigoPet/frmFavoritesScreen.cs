using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoPet
{
    public partial class frmFavoritesScreen : Form
    {
        public frmFavoritesScreen()
        {
            InitializeComponent();
        }

        public ListBox ListBoxFavoritos
        {
            get { return listBoxGatosFavoritos; }
        }
    }
}
