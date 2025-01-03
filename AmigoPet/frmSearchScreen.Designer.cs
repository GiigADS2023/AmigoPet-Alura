namespace AmigoPet
{
    partial class frmSearchScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchScreen));
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.lbResultadoDescricao = new System.Windows.Forms.Label();
            this.lbResultadoOrigem = new System.Windows.Forms.Label();
            this.lbResultadoTemperamento = new System.Windows.Forms.Label();
            this.lbDescricaoGato = new System.Windows.Forms.Label();
            this.lbOrigemGato = new System.Windows.Forms.Label();
            this.lbTemperamentoGato = new System.Windows.Forms.Label();
            this.lbRacaGato = new System.Windows.Forms.Label();
            this.lbSeparator = new System.Windows.Forms.Label();
            this.lbSubtitleAmigoPet = new System.Windows.Forms.Label();
            this.lbTitleAmigoPet = new System.Windows.Forms.Label();
            this.imgCatSearch = new System.Windows.Forms.PictureBox();
            this.btnFavoritarGato = new System.Windows.Forms.Button();
            this.btnBuscarGato = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCatSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRaca
            // 
            this.cbRaca.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Location = new System.Drawing.Point(255, 107);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(211, 27);
            this.cbRaca.TabIndex = 24;
            this.cbRaca.Text = "Selecione uma raça";
            // 
            // lbResultadoDescricao
            // 
            this.lbResultadoDescricao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoDescricao.Location = new System.Drawing.Point(251, 246);
            this.lbResultadoDescricao.Name = "lbResultadoDescricao";
            this.lbResultadoDescricao.Size = new System.Drawing.Size(650, 228);
            this.lbResultadoDescricao.TabIndex = 23;
            this.lbResultadoDescricao.Text = "Resultado";
            // 
            // lbResultadoOrigem
            // 
            this.lbResultadoOrigem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoOrigem.Location = new System.Drawing.Point(251, 197);
            this.lbResultadoOrigem.Name = "lbResultadoOrigem";
            this.lbResultadoOrigem.Size = new System.Drawing.Size(650, 49);
            this.lbResultadoOrigem.TabIndex = 22;
            this.lbResultadoOrigem.Text = "Resultado";
            // 
            // lbResultadoTemperamento
            // 
            this.lbResultadoTemperamento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoTemperamento.Location = new System.Drawing.Point(251, 143);
            this.lbResultadoTemperamento.Name = "lbResultadoTemperamento";
            this.lbResultadoTemperamento.Size = new System.Drawing.Size(650, 54);
            this.lbResultadoTemperamento.TabIndex = 21;
            this.lbResultadoTemperamento.Text = "Resultado";
            // 
            // lbDescricaoGato
            // 
            this.lbDescricaoGato.AutoSize = true;
            this.lbDescricaoGato.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricaoGato.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbDescricaoGato.Location = new System.Drawing.Point(35, 239);
            this.lbDescricaoGato.Name = "lbDescricaoGato";
            this.lbDescricaoGato.Size = new System.Drawing.Size(79, 22);
            this.lbDescricaoGato.TabIndex = 20;
            this.lbDescricaoGato.Text = "Descrição";
            // 
            // lbOrigemGato
            // 
            this.lbOrigemGato.AutoSize = true;
            this.lbOrigemGato.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigemGato.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbOrigemGato.Location = new System.Drawing.Point(35, 190);
            this.lbOrigemGato.Name = "lbOrigemGato";
            this.lbOrigemGato.Size = new System.Drawing.Size(60, 22);
            this.lbOrigemGato.TabIndex = 19;
            this.lbOrigemGato.Text = "Origem";
            // 
            // lbTemperamentoGato
            // 
            this.lbTemperamentoGato.AutoSize = true;
            this.lbTemperamentoGato.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperamentoGato.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbTemperamentoGato.Location = new System.Drawing.Point(35, 136);
            this.lbTemperamentoGato.Name = "lbTemperamentoGato";
            this.lbTemperamentoGato.Size = new System.Drawing.Size(113, 22);
            this.lbTemperamentoGato.TabIndex = 18;
            this.lbTemperamentoGato.Text = "Temperamento";
            // 
            // lbRacaGato
            // 
            this.lbRacaGato.AutoSize = true;
            this.lbRacaGato.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRacaGato.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbRacaGato.Location = new System.Drawing.Point(36, 108);
            this.lbRacaGato.Name = "lbRacaGato";
            this.lbRacaGato.Size = new System.Drawing.Size(103, 22);
            this.lbRacaGato.TabIndex = 17;
            this.lbRacaGato.Text = "Raça do Gato";
            // 
            // lbSeparator
            // 
            this.lbSeparator.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeparator.Location = new System.Drawing.Point(40, 91);
            this.lbSeparator.Name = "lbSeparator";
            this.lbSeparator.Size = new System.Drawing.Size(840, 3);
            this.lbSeparator.TabIndex = 16;
            this.lbSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSubtitleAmigoPet
            // 
            this.lbSubtitleAmigoPet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitleAmigoPet.ForeColor = System.Drawing.Color.Peru;
            this.lbSubtitleAmigoPet.Location = new System.Drawing.Point(100, 39);
            this.lbSubtitleAmigoPet.Name = "lbSubtitleAmigoPet";
            this.lbSubtitleAmigoPet.Size = new System.Drawing.Size(719, 55);
            this.lbSubtitleAmigoPet.TabIndex = 15;
            this.lbSubtitleAmigoPet.Text = "Utilize a caixa de seleção de raças para buscar características sobre determinado" +
    " gatinho e descobrir qual é a sua raça favorita.";
            this.lbSubtitleAmigoPet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitleAmigoPet
            // 
            this.lbTitleAmigoPet.AutoSize = true;
            this.lbTitleAmigoPet.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleAmigoPet.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbTitleAmigoPet.Location = new System.Drawing.Point(289, 9);
            this.lbTitleAmigoPet.Name = "lbTitleAmigoPet";
            this.lbTitleAmigoPet.Size = new System.Drawing.Size(322, 27);
            this.lbTitleAmigoPet.TabIndex = 14;
            this.lbTitleAmigoPet.Text = "Encontre Sua Raça Favorita";
            this.lbTitleAmigoPet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgCatSearch
            // 
            this.imgCatSearch.Image = ((System.Drawing.Image)(resources.GetObject("imgCatSearch.Image")));
            this.imgCatSearch.Location = new System.Drawing.Point(509, 428);
            this.imgCatSearch.Name = "imgCatSearch";
            this.imgCatSearch.Size = new System.Drawing.Size(311, 161);
            this.imgCatSearch.TabIndex = 27;
            this.imgCatSearch.TabStop = false;
            // 
            // btnFavoritarGato
            // 
            this.btnFavoritarGato.Location = new System.Drawing.Point(826, 493);
            this.btnFavoritarGato.Name = "btnFavoritarGato";
            this.btnFavoritarGato.Size = new System.Drawing.Size(75, 23);
            this.btnFavoritarGato.TabIndex = 29;
            this.btnFavoritarGato.Text = "Favoritar";
            this.btnFavoritarGato.UseVisualStyleBackColor = true;
            this.btnFavoritarGato.Click += new System.EventHandler(this.btnFavoritarGato_Click);
            // 
            // btnBuscarGato
            // 
            this.btnBuscarGato.Location = new System.Drawing.Point(826, 464);
            this.btnBuscarGato.Name = "btnBuscarGato";
            this.btnBuscarGato.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarGato.TabIndex = 28;
            this.btnBuscarGato.Text = "Buscar";
            this.btnBuscarGato.UseVisualStyleBackColor = true;
            this.btnBuscarGato.Click += new System.EventHandler(this.btnBuscarGato_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(826, 9);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 30;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // frmSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(226)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(913, 526);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btnFavoritarGato);
            this.Controls.Add(this.btnBuscarGato);
            this.Controls.Add(this.imgCatSearch);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.lbResultadoDescricao);
            this.Controls.Add(this.lbResultadoOrigem);
            this.Controls.Add(this.lbResultadoTemperamento);
            this.Controls.Add(this.lbDescricaoGato);
            this.Controls.Add(this.lbOrigemGato);
            this.Controls.Add(this.lbTemperamentoGato);
            this.Controls.Add(this.lbRacaGato);
            this.Controls.Add(this.lbSeparator);
            this.Controls.Add(this.lbSubtitleAmigoPet);
            this.Controls.Add(this.lbTitleAmigoPet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Raças";
            this.Load += new System.EventHandler(this.frmSearchScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCatSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label lbResultadoDescricao;
        private System.Windows.Forms.Label lbResultadoOrigem;
        private System.Windows.Forms.Label lbResultadoTemperamento;
        private System.Windows.Forms.Label lbDescricaoGato;
        private System.Windows.Forms.Label lbOrigemGato;
        private System.Windows.Forms.Label lbTemperamentoGato;
        private System.Windows.Forms.Label lbRacaGato;
        private System.Windows.Forms.Label lbSeparator;
        private System.Windows.Forms.Label lbSubtitleAmigoPet;
        private System.Windows.Forms.Label lbTitleAmigoPet;
        private System.Windows.Forms.PictureBox imgCatSearch;
        private System.Windows.Forms.Button btnFavoritarGato;
        private System.Windows.Forms.Button btnBuscarGato;
        private System.Windows.Forms.Button btVoltar;
    }
}