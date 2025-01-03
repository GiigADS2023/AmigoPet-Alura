using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AmigoPet
{
    public partial class frmFavoritesScreen : Form
    {
        // Lista de gatos favoritos (pode ser substituída por outro método de persistência)
        private List<string> favoritos = new List<string>();

        public frmFavoritesScreen()
        {
            InitializeComponent();
            this.FormClosing += frmFavoritesScreen_FormClosing; // Adiciona o evento FormClosing
            LoadFavoritos(); // Carrega os favoritos
        }

        public ListBox ListBoxFavoritos
        {
            get { return listBoxGatosFavoritos; }
        }

        // Método para carregar os gatos favoritos na ListBox
        private void LoadFavoritos()
        {
            // A lista de gatos pode ser carregada de uma variável, banco de dados, ou outro método
            listBoxGatosFavoritos.Items.Clear();
            foreach (var gato in favoritos)
            {
                listBoxGatosFavoritos.Items.Add(gato);
            }
        }

        // Método para adicionar gato à lista
        public void AddFavorito(string gato)
        {
            favoritos.Add(gato);
            LoadFavoritos();
        }

        // Método para excluir gato da lista
        private void btExcluirGatoFavorito_Click(object sender, EventArgs e)
        {
            if (ListBoxFavoritos.SelectedItem != null)
            {
                string selectedCat = ListBoxFavoritos.SelectedItem.ToString();

                DialogResult confirmaExclusao = MessageBox.Show($"Deseja realmente excluir o {selectedCat}?", "Aviso",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == confirmaExclusao)
                {
                    ListBoxFavoritos.Items.Remove(selectedCat);
                    MessageBox.Show($"{selectedCat} foi removido dos favoritos!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Erro ao remover {selectedCat}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um gato para remover dos favoritos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmFavoritesScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancela o fechamento e apenas esconde o formulário
            e.Cancel = true;
            this.Hide();
        }
    }
}