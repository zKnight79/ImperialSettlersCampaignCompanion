namespace ImperialSettlersCampaignCompanion
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_NewCampaign = new System.Windows.Forms.Button();
            this.button_LoadCampaign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NewCampaign
            // 
            resources.ApplyResources(this.button_NewCampaign, "button_NewCampaign");
            this.button_NewCampaign.Name = "button_NewCampaign";
            this.button_NewCampaign.UseVisualStyleBackColor = true;
            this.button_NewCampaign.Click += new System.EventHandler(this.button_NewCampaign_Click);
            // 
            // button_LoadCampaign
            // 
            resources.ApplyResources(this.button_LoadCampaign, "button_LoadCampaign");
            this.button_LoadCampaign.Name = "button_LoadCampaign";
            this.button_LoadCampaign.UseVisualStyleBackColor = true;
            this.button_LoadCampaign.Click += new System.EventHandler(this.button_LoadCampaign_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_LoadCampaign);
            this.Controls.Add(this.button_NewCampaign);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NewCampaign;
        private System.Windows.Forms.Button button_LoadCampaign;
    }
}

