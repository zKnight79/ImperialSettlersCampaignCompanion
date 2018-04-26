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
            this.label_Separator = new System.Windows.Forms.Label();
            this.label_CampaignName = new System.Windows.Forms.Label();
            this.label_PlayerFaction = new System.Windows.Forms.Label();
            this.label_ForeignFaction = new System.Windows.Forms.Label();
            this.textBox_PlayerFaction = new System.Windows.Forms.TextBox();
            this.textBox_ForeignFaction = new System.Windows.Forms.TextBox();
            this.textBox_CampaignName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Chapter = new System.Windows.Forms.TextBox();
            this.label_Chapter = new System.Windows.Forms.Label();
            this.button_GameReport = new System.Windows.Forms.Button();
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
            // label_Separator
            // 
            resources.ApplyResources(this.label_Separator, "label_Separator");
            this.label_Separator.BackColor = System.Drawing.Color.Gray;
            this.label_Separator.Name = "label_Separator";
            // 
            // label_CampaignName
            // 
            resources.ApplyResources(this.label_CampaignName, "label_CampaignName");
            this.label_CampaignName.Name = "label_CampaignName";
            // 
            // label_PlayerFaction
            // 
            resources.ApplyResources(this.label_PlayerFaction, "label_PlayerFaction");
            this.label_PlayerFaction.Name = "label_PlayerFaction";
            // 
            // label_ForeignFaction
            // 
            resources.ApplyResources(this.label_ForeignFaction, "label_ForeignFaction");
            this.label_ForeignFaction.Name = "label_ForeignFaction";
            // 
            // textBox_PlayerFaction
            // 
            this.textBox_PlayerFaction.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_PlayerFaction, "textBox_PlayerFaction");
            this.textBox_PlayerFaction.Name = "textBox_PlayerFaction";
            this.textBox_PlayerFaction.ReadOnly = true;
            // 
            // textBox_ForeignFaction
            // 
            this.textBox_ForeignFaction.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ForeignFaction, "textBox_ForeignFaction");
            this.textBox_ForeignFaction.Name = "textBox_ForeignFaction";
            this.textBox_ForeignFaction.ReadOnly = true;
            // 
            // textBox_CampaignName
            // 
            this.textBox_CampaignName.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_CampaignName, "textBox_CampaignName");
            this.textBox_CampaignName.Name = "textBox_CampaignName";
            this.textBox_CampaignName.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox_Chapter
            // 
            this.textBox_Chapter.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_Chapter, "textBox_Chapter");
            this.textBox_Chapter.Name = "textBox_Chapter";
            this.textBox_Chapter.ReadOnly = true;
            // 
            // label_Chapter
            // 
            resources.ApplyResources(this.label_Chapter, "label_Chapter");
            this.label_Chapter.Name = "label_Chapter";
            // 
            // button_GameReport
            // 
            resources.ApplyResources(this.button_GameReport, "button_GameReport");
            this.button_GameReport.Name = "button_GameReport";
            this.button_GameReport.UseVisualStyleBackColor = true;
            this.button_GameReport.Click += new System.EventHandler(this.button_GameReport_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_GameReport);
            this.Controls.Add(this.textBox_Chapter);
            this.Controls.Add(this.label_Chapter);
            this.Controls.Add(this.textBox_CampaignName);
            this.Controls.Add(this.textBox_ForeignFaction);
            this.Controls.Add(this.textBox_PlayerFaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ForeignFaction);
            this.Controls.Add(this.label_PlayerFaction);
            this.Controls.Add(this.label_CampaignName);
            this.Controls.Add(this.label_Separator);
            this.Controls.Add(this.button_LoadCampaign);
            this.Controls.Add(this.button_NewCampaign);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_NewCampaign;
        private System.Windows.Forms.Button button_LoadCampaign;
        private System.Windows.Forms.Label label_Separator;
        private System.Windows.Forms.Label label_CampaignName;
        private System.Windows.Forms.Label label_PlayerFaction;
        private System.Windows.Forms.Label label_ForeignFaction;
        private System.Windows.Forms.TextBox textBox_PlayerFaction;
        private System.Windows.Forms.TextBox textBox_ForeignFaction;
        private System.Windows.Forms.TextBox textBox_CampaignName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Chapter;
        private System.Windows.Forms.Label label_Chapter;
        private System.Windows.Forms.Button button_GameReport;
    }
}

