namespace AmigoPet
{
    partial class frmWelcomeScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcomeScreen));
            this.AmigoPet_Menu = new System.Windows.Forms.MenuStrip();
            this.lbWelcomeAmigoPet = new System.Windows.Forms.Label();
            this.imgCatWelcome = new System.Windows.Forms.PictureBox();
            this.IconBreedSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.IconFavoriteBreed = new System.Windows.Forms.ToolStripMenuItem();
            this.AmigoPet_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCatWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // AmigoPet_Menu
            // 
            this.AmigoPet_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(226)))), ((int)(((byte)(172)))));
            this.AmigoPet_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AmigoPet_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconBreedSearch,
            this.IconFavoriteBreed});
            this.AmigoPet_Menu.Location = new System.Drawing.Point(0, 0);
            this.AmigoPet_Menu.Name = "AmigoPet_Menu";
            this.AmigoPet_Menu.Size = new System.Drawing.Size(800, 31);
            this.AmigoPet_Menu.TabIndex = 0;
            this.AmigoPet_Menu.Text = "menuStrip1";
            // 
            // lbWelcomeAmigoPet
            // 
            this.lbWelcomeAmigoPet.AutoSize = true;
            this.lbWelcomeAmigoPet.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeAmigoPet.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbWelcomeAmigoPet.Location = new System.Drawing.Point(205, 294);
            this.lbWelcomeAmigoPet.Name = "lbWelcomeAmigoPet";
            this.lbWelcomeAmigoPet.Size = new System.Drawing.Size(395, 35);
            this.lbWelcomeAmigoPet.TabIndex = 1;
            this.lbWelcomeAmigoPet.Text = "Bem-Vindo(a) ao AmigoPet";
            // 
            // imgCatWelcome
            // 
            this.imgCatWelcome.Image = global::AmigoPet.Properties.Resources.cat_welcome_screen;
            this.imgCatWelcome.Location = new System.Drawing.Point(334, 99);
            this.imgCatWelcome.Name = "imgCatWelcome";
            this.imgCatWelcome.Size = new System.Drawing.Size(201, 192);
            this.imgCatWelcome.TabIndex = 2;
            this.imgCatWelcome.TabStop = false;
            // 
            // IconBreedSearch
            // 
            this.IconBreedSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBreedSearch.Image = global::AmigoPet.Properties.Resources.icon_menu_search;
            this.IconBreedSearch.Name = "IconBreedSearch";
            this.IconBreedSearch.Size = new System.Drawing.Size(142, 27);
            this.IconBreedSearch.Text = "Buscar Raças";
            this.IconBreedSearch.Click += new System.EventHandler(this.IconBreedSearch_Click);
            // 
            // IconFavoriteBreed
            // 
            this.IconFavoriteBreed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconFavoriteBreed.Image = global::AmigoPet.Properties.Resources.icon_menu_star;
            this.IconFavoriteBreed.Name = "IconFavoriteBreed";
            this.IconFavoriteBreed.Size = new System.Drawing.Size(157, 27);
            this.IconFavoriteBreed.Text = "Meus Favoritos";
            this.IconFavoriteBreed.Click += new System.EventHandler(this.IconFavoriteBreed_Click);
            // 
            // frmWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgCatWelcome);
            this.Controls.Add(this.lbWelcomeAmigoPet);
            this.Controls.Add(this.AmigoPet_Menu);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AmigoPet_Menu;
            this.Name = "frmWelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-Vindo(a) ao AmigoPet";
            this.AmigoPet_Menu.ResumeLayout(false);
            this.AmigoPet_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCatWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AmigoPet_Menu;
        private System.Windows.Forms.ToolStripMenuItem IconBreedSearch;
        private System.Windows.Forms.ToolStripMenuItem IconFavoriteBreed;
        private System.Windows.Forms.Label lbWelcomeAmigoPet;
        private System.Windows.Forms.PictureBox imgCatWelcome;
    }
}

