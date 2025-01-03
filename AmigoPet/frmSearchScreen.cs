using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AmigoPet
{
    // Exemplo de como o construtor de frmSearchScreen deve ser
    public partial class frmSearchScreen : Form
    {
        private frmFavoritesScreen favouritesScreen;

        // Construtor que aceita o parâmetro frmFavoritesScreen
        // Certifique-se de que o construtor de frmSearchScreen é como este
        public frmSearchScreen(frmFavoritesScreen favouritesScreen)
        {
            InitializeComponent();
            this.favouritesScreen = favouritesScreen;
        }

        private void frmSearchScreen_Load(object sender, EventArgs e)
        {
            // Criação do cliente HTTP
            HttpClient client = new HttpClient();

            // Define a URL base para as requisições
            client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");

            // Adiciona o cabeçalho com a chave da API (substitua com sua chave)
            client.DefaultRequestHeaders.Add("x-api-key", "live_fKX1CYdcnuqMtNWIRfFWyRtR9VjHDs8v8LRIWLuhtmZzOUjhF8fSveF0MtUVFLDd"); // Substitua por sua chave de API

            // Faz a requisição para buscar as raças
            HttpResponseMessage response = client.GetAsync("breeds").Result;

            // Verifica se a requisição foi bem-sucedida
            if (response.IsSuccessStatusCode)
            {
                // Lê a resposta JSON
                var json = response.Content.ReadAsStringAsync().Result;

                // Desserializa o JSON para uma lista de objetos Gato
                var cats = JsonConvert.DeserializeObject<List<Gato>>(json);

                // Preenche o ComboBox com os dados das raças
                foreach (var cat in cats)
                {
                    cbRaca.Items.Add(new { Name = cat.name, Id = cat.id });
                }

                cbRaca.DisplayMember = "Name";
                cbRaca.ValueMember = "Id";
            }
            else
            {
                // Caso a requisição falhe, exibe uma mensagem de erro
                MessageBox.Show("Erro ao carregar raças.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFavoritarGato_Click(object sender, EventArgs e)
        {
            if (cbRaca.SelectedItem != null)
            {
                var selectedCat = (dynamic)cbRaca.SelectedItem;
                string catName = selectedCat.Name;

                // Adiciona o gato aos favoritos usando o método da instância de favoritos
                favouritesScreen.AddFavorito(catName);

                MessageBox.Show($"{catName} foi adicionado aos favoritos!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Selecione uma raça para favoritar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limparCampos()
        {
            cbRaca.Text = "Selecione uma raça";
            lbResultadoTemperamento.Text = "Resultado";
            lbResultadoOrigem.Text = "Resultado";
            lbResultadoDescricao.Text = "Resultado";
        }

        private void btnBuscarGato_Click(object sender, EventArgs e)
        {
            if (cbRaca.SelectedItem != null)
            {
                var selectedCat = (dynamic)cbRaca.SelectedItem;
                string selectedId = selectedCat.Id;

                // Criando o cliente HTTP e configurando a requisição
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://api.thecatapi.com/v1/");
                client.DefaultRequestHeaders.Add("x-api-key", "sua_chave_aqui"); // Substitua pela sua chave de API

                // Requisição para buscar os detalhes da raça
                HttpResponseMessage response = client.GetAsync($"breeds/{selectedId}").Result;

                if (response.IsSuccessStatusCode)
                {
                    // Lê a resposta e desserializa o objeto Gato
                    var json = response.Content.ReadAsStringAsync().Result;
                    var cat = JsonConvert.DeserializeObject<Gato>(json);

                    // Atualiza os Labels com as informações da raça do gato
                    lbResultadoTemperamento.Text = cat.temperament;
                    lbResultadoOrigem.Text = cat.origin;
                    lbResultadoDescricao.Text = cat.description;
                }
                else
                {
                    // Exibe uma mensagem de erro se a requisição falhar
                    MessageBox.Show("Erro ao buscar informações da raça.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Caso o usuário não tenha selecionado uma raça
                MessageBox.Show("Selecione uma raça no combo box.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}