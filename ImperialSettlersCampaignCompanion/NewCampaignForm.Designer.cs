namespace ImperialSettlersCampaignCompanion
{
    partial class NewCampaignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCampaignForm));
            this.textBox_CampaignName = new System.Windows.Forms.TextBox();
            this.label_CampaignName = new System.Windows.Forms.Label();
            this.listBox_Factions = new System.Windows.Forms.ListBox();
            this.label_Factions = new System.Windows.Forms.Label();
            this.button_SelectPlayerFaction = new System.Windows.Forms.Button();
            this.button_SelectForeignFaction = new System.Windows.Forms.Button();
            this.textBox_PlayerFaction = new System.Windows.Forms.TextBox();
            this.button_RemovePlayerFaction = new System.Windows.Forms.Button();
            this.label_PlayerFaction = new System.Windows.Forms.Label();
            this.label_ForeignFaction = new System.Windows.Forms.Label();
            this.button_RemoveForeignFaction = new System.Windows.Forms.Button();
            this.textBox_ForeignFaction = new System.Windows.Forms.TextBox();
            this.label_NameError = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_CampaignName
            // 
            resources.ApplyResources(this.textBox_CampaignName, "textBox_CampaignName");
            this.textBox_CampaignName.Name = "textBox_CampaignName";
            this.textBox_CampaignName.TextChanged += new System.EventHandler(this.textBox_CampaignName_TextChanged);
            // 
            // label_CampaignName
            // 
            resources.ApplyResources(this.label_CampaignName, "label_CampaignName");
            this.label_CampaignName.Name = "label_CampaignName";
            // 
            // listBox_Factions
            // 
            this.listBox_Factions.FormattingEnabled = true;
            resources.ApplyResources(this.listBox_Factions, "listBox_Factions");
            this.listBox_Factions.Name = "listBox_Factions";
            // 
            // label_Factions
            // 
            resources.ApplyResources(this.label_Factions, "label_Factions");
            this.label_Factions.Name = "label_Factions";
            // 
            // button_SelectPlayerFaction
            // 
            resources.ApplyResources(this.button_SelectPlayerFaction, "button_SelectPlayerFaction");
            this.button_SelectPlayerFaction.Name = "button_SelectPlayerFaction";
            this.button_SelectPlayerFaction.UseVisualStyleBackColor = true;
            this.button_SelectPlayerFaction.Click += new System.EventHandler(this.button_SelectPlayerFaction_Click);
            // 
            // button_SelectForeignFaction
            // 
            resources.ApplyResources(this.button_SelectForeignFaction, "button_SelectForeignFaction");
            this.button_SelectForeignFaction.Name = "button_SelectForeignFaction";
            this.button_SelectForeignFaction.UseVisualStyleBackColor = true;
            this.button_SelectForeignFaction.Click += new System.EventHandler(this.button_SelectForeignFaction_Click);
            // 
            // textBox_PlayerFaction
            // 
            resources.ApplyResources(this.textBox_PlayerFaction, "textBox_PlayerFaction");
            this.textBox_PlayerFaction.Name = "textBox_PlayerFaction";
            // 
            // button_RemovePlayerFaction
            // 
            resources.ApplyResources(this.button_RemovePlayerFaction, "button_RemovePlayerFaction");
            this.button_RemovePlayerFaction.Name = "button_RemovePlayerFaction";
            this.button_RemovePlayerFaction.UseVisualStyleBackColor = true;
            this.button_RemovePlayerFaction.Click += new System.EventHandler(this.button_RemovePlayerFaction_Click);
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
            // button_RemoveForeignFaction
            // 
            resources.ApplyResources(this.button_RemoveForeignFaction, "button_RemoveForeignFaction");
            this.button_RemoveForeignFaction.Name = "button_RemoveForeignFaction";
            this.button_RemoveForeignFaction.UseVisualStyleBackColor = true;
            this.button_RemoveForeignFaction.Click += new System.EventHandler(this.button_RemoveForeignFaction_Click);
            // 
            // textBox_ForeignFaction
            // 
            resources.ApplyResources(this.textBox_ForeignFaction, "textBox_ForeignFaction");
            this.textBox_ForeignFaction.Name = "textBox_ForeignFaction";
            // 
            // label_NameError
            // 
            this.label_NameError.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.label_NameError, "label_NameError");
            this.label_NameError.Name = "label_NameError";
            // 
            // button_OK
            // 
            resources.ApplyResources(this.button_OK, "button_OK");
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Name = "button_OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // NewCampaignForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_NameError);
            this.Controls.Add(this.label_ForeignFaction);
            this.Controls.Add(this.button_RemoveForeignFaction);
            this.Controls.Add(this.textBox_ForeignFaction);
            this.Controls.Add(this.label_PlayerFaction);
            this.Controls.Add(this.button_RemovePlayerFaction);
            this.Controls.Add(this.textBox_PlayerFaction);
            this.Controls.Add(this.button_SelectForeignFaction);
            this.Controls.Add(this.button_SelectPlayerFaction);
            this.Controls.Add(this.label_Factions);
            this.Controls.Add(this.listBox_Factions);
            this.Controls.Add(this.label_CampaignName);
            this.Controls.Add(this.textBox_CampaignName);
            this.Name = "NewCampaignForm";
            this.Load += new System.EventHandler(this.NewCampaignForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CampaignName;
        private System.Windows.Forms.Label label_CampaignName;
        private System.Windows.Forms.ListBox listBox_Factions;
        private System.Windows.Forms.Label label_Factions;
        private System.Windows.Forms.Button button_SelectPlayerFaction;
        private System.Windows.Forms.Button button_SelectForeignFaction;
        private System.Windows.Forms.TextBox textBox_PlayerFaction;
        private System.Windows.Forms.Button button_RemovePlayerFaction;
        private System.Windows.Forms.Label label_PlayerFaction;
        private System.Windows.Forms.Label label_ForeignFaction;
        private System.Windows.Forms.Button button_RemoveForeignFaction;
        private System.Windows.Forms.TextBox textBox_ForeignFaction;
        private System.Windows.Forms.Label label_NameError;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}