namespace AmigoPet
{
    partial class frmFavoritesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavoritesScreen));
            this.lbSeparator = new System.Windows.Forms.Label();
            this.lbSubtitleAmigoPet = new System.Windows.Forms.Label();
            this.lbTitleAmigoPet = new System.Windows.Forms.Label();
            this.btExcluirGatoFavorito = new System.Windows.Forms.Button();
            this.listBoxGatosFavoritos = new System.Windows.Forms.ListBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSeparator
            // 
            this.lbSeparator.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeparator.Location = new System.Drawing.Point(42, 77);
            this.lbSeparator.Name = "lbSeparator";
            this.lbSeparator.Size = new System.Drawing.Size(840, 3);
            this.lbSeparator.TabIndex = 19;
            // 
            // lbSubtitleAmigoPet
            // 
            this.lbSubtitleAmigoPet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitleAmigoPet.ForeColor = System.Drawing.Color.Peru;
            this.lbSubtitleAmigoPet.Location = new System.Drawing.Point(275, 22);
            this.lbSubtitleAmigoPet.Name = "lbSubtitleAmigoPet";
            this.lbSubtitleAmigoPet.Size = new System.Drawing.Size(389, 55);
            this.lbSubtitleAmigoPet.TabIndex = 18;
            this.lbSubtitleAmigoPet.Text = "Aqui você encontra a lista de gatinhos favoritos";
            this.lbSubtitleAmigoPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitleAmigoPet
            // 
            this.lbTitleAmigoPet.AutoSize = true;
            this.lbTitleAmigoPet.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleAmigoPet.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbTitleAmigoPet.Location = new System.Drawing.Point(373, 9);
            this.lbTitleAmigoPet.Name = "lbTitleAmigoPet";
            this.lbTitleAmigoPet.Size = new System.Drawing.Size(183, 27);
            this.lbTitleAmigoPet.TabIndex = 20;
            this.lbTitleAmigoPet.Text = "Meus Favoritos";
            this.lbTitleAmigoPet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btExcluirGatoFavorito
            // 
            this.btExcluirGatoFavorito.Location = new System.Drawing.Point(763, 491);
            this.btExcluirGatoFavorito.Name = "btExcluirGatoFavorito";
            this.btExcluirGatoFavorito.Size = new System.Drawing.Size(138, 23);
            this.btExcluirGatoFavorito.TabIndex = 21;
            this.btExcluirGatoFavorito.Text = "Excluir Favorito";
            this.btExcluirGatoFavorito.UseVisualStyleBackColor = true;
            this.btExcluirGatoFavorito.Click += new System.EventHandler(this.btExcluirGatoFavorito_Click);
            // 
            // listBoxGatosFavoritos
            // 
            this.listBoxGatosFavoritos.FormattingEnabled = true;
            this.listBoxGatosFavoritos.ItemHeight = 16;
            this.listBoxGatosFavoritos.Location = new System.Drawing.Point(167, 105);
            this.listBoxGatosFavoritos.Name = "listBoxGatosFavoritos";
            this.listBoxGatosFavoritos.Size = new System.Drawing.Size(583, 372);
            this.listBoxGatosFavoritos.TabIndex = 22;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(826, 9);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 23;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // frmFavoritesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(226)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(913, 526);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.listBoxGatosFavoritos);
            this.Controls.Add(this.btExcluirGatoFavorito);
            this.Controls.Add(this.lbTitleAmigoPet);
            this.Controls.Add(this.lbSeparator);
            this.Controls.Add(this.lbSubtitleAmigoPet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFavoritesScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Raças Favoritas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSeparator;
        private System.Windows.Forms.Label lbSubtitleAmigoPet;
        private System.Windows.Forms.Label lbTitleAmigoPet;
        private System.Windows.Forms.Button btExcluirGatoFavorito;
        private System.Windows.Forms.ListBox listBoxGatosFavoritos;
        private System.Windows.Forms.Button btVoltar;
    }
}