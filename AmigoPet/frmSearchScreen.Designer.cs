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
            this.imgCatsSearch = new System.Windows.Forms.PictureBox();
            this.cbRaça = new System.Windows.Forms.ComboBox();
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
            this.btnBuscarGato = new System.Windows.Forms.Button();
            this.btnFavoritarGato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCatsSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCatsSearch
            // 
            this.imgCatsSearch.Image = global::AmigoPet.Properties.Resources.cats_search_screen;
            this.imgCatsSearch.Location = new System.Drawing.Point(43, 165);
            this.imgCatsSearch.Name = "imgCatsSearch";
            this.imgCatsSearch.Size = new System.Drawing.Size(634, 304);
            this.imgCatsSearch.TabIndex = 13;
            this.imgCatsSearch.TabStop = false;
            // 
            // cbRaça
            // 
            this.cbRaça.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRaça.FormattingEnabled = true;
            this.cbRaça.Location = new System.Drawing.Point(440, 104);
            this.cbRaça.Name = "cbRaça";
            this.cbRaça.Size = new System.Drawing.Size(211, 27);
            this.cbRaça.TabIndex = 24;
            this.cbRaça.Text = "Selecione uma raça";
            // 
            // lbResultadoDescricao
            // 
            this.lbResultadoDescricao.AutoSize = true;
            this.lbResultadoDescricao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoDescricao.Location = new System.Drawing.Point(436, 226);
            this.lbResultadoDescricao.Name = "lbResultadoDescricao";
            this.lbResultadoDescricao.Size = new System.Drawing.Size(80, 19);
            this.lbResultadoDescricao.TabIndex = 23;
            this.lbResultadoDescricao.Text = "Resultado";
            // 
            // lbResultadoOrigem
            // 
            this.lbResultadoOrigem.AutoSize = true;
            this.lbResultadoOrigem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoOrigem.Location = new System.Drawing.Point(436, 189);
            this.lbResultadoOrigem.Name = "lbResultadoOrigem";
            this.lbResultadoOrigem.Size = new System.Drawing.Size(80, 19);
            this.lbResultadoOrigem.TabIndex = 22;
            this.lbResultadoOrigem.Text = "Resultado";
            // 
            // lbResultadoTemperamento
            // 
            this.lbResultadoTemperamento.AutoSize = true;
            this.lbResultadoTemperamento.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoTemperamento.Location = new System.Drawing.Point(436, 150);
            this.lbResultadoTemperamento.Name = "lbResultadoTemperamento";
            this.lbResultadoTemperamento.Size = new System.Drawing.Size(80, 19);
            this.lbResultadoTemperamento.TabIndex = 21;
            this.lbResultadoTemperamento.Text = "Resultado";
            // 
            // lbDescricaoGato
            // 
            this.lbDescricaoGato.AutoSize = true;
            this.lbDescricaoGato.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricaoGato.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbDescricaoGato.Location = new System.Drawing.Point(237, 222);
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
            this.lbOrigemGato.Location = new System.Drawing.Point(237, 185);
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
            this.lbTemperamentoGato.Location = new System.Drawing.Point(237, 145);
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
            this.lbRacaGato.Location = new System.Drawing.Point(237, 103);
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
            this.lbSeparator.Size = new System.Drawing.Size(718, 3);
            this.lbSeparator.TabIndex = 16;
            this.lbSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSubtitleAmigoPet
            // 
            this.lbSubtitleAmigoPet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitleAmigoPet.ForeColor = System.Drawing.Color.Peru;
            this.lbSubtitleAmigoPet.Location = new System.Drawing.Point(39, 36);
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
            this.lbTitleAmigoPet.Location = new System.Drawing.Point(233, 9);
            this.lbTitleAmigoPet.Name = "lbTitleAmigoPet";
            this.lbTitleAmigoPet.Size = new System.Drawing.Size(322, 27);
            this.lbTitleAmigoPet.TabIndex = 14;
            this.lbTitleAmigoPet.Text = "Encontre Sua Raça Favorita";
            this.lbTitleAmigoPet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscarGato
            // 
            this.btnBuscarGato.Location = new System.Drawing.Point(683, 394);
            this.btnBuscarGato.Name = "btnBuscarGato";
            this.btnBuscarGato.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarGato.TabIndex = 25;
            this.btnBuscarGato.Text = "Buscar";
            this.btnBuscarGato.UseVisualStyleBackColor = true;
            // 
            // btnFavoritarGato
            // 
            this.btnFavoritarGato.Location = new System.Drawing.Point(683, 423);
            this.btnFavoritarGato.Name = "btnFavoritarGato";
            this.btnFavoritarGato.Size = new System.Drawing.Size(75, 23);
            this.btnFavoritarGato.TabIndex = 26;
            this.btnFavoritarGato.Text = "Favoritar";
            this.btnFavoritarGato.UseVisualStyleBackColor = true;
            // 
            // frmSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(226)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.btnFavoritarGato);
            this.Controls.Add(this.btnBuscarGato);
            this.Controls.Add(this.cbRaça);
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
            this.Controls.Add(this.imgCatsSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Raças";
            ((System.ComponentModel.ISupportInitialize)(this.imgCatsSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgCatsSearch;
        private System.Windows.Forms.ComboBox cbRaça;
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
        private System.Windows.Forms.Button btnBuscarGato;
        private System.Windows.Forms.Button btnFavoritarGato;
    }
}