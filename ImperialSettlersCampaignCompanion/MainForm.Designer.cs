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
            this.components = new System.ComponentModel.Container();
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
            this.textBox_Chapter = new System.Windows.Forms.TextBox();
            this.label_Chapter = new System.Windows.Forms.Label();
            this.button_GameReport = new System.Windows.Forms.Button();
            this.label_Production = new System.Windows.Forms.Label();
            this.pictureBox_Worker = new System.Windows.Forms.PictureBox();
            this.pictureBox_Wood = new System.Windows.Forms.PictureBox();
            this.pictureBox_Stone = new System.Windows.Forms.PictureBox();
            this.pictureBox_Food = new System.Windows.Forms.PictureBox();
            this.pictureBox_Gold = new System.Windows.Forms.PictureBox();
            this.pictureBox_Weapon = new System.Windows.Forms.PictureBox();
            this.pictureBox_CardAny = new System.Windows.Forms.PictureBox();
            this.pictureBox_CardCommon = new System.Windows.Forms.PictureBox();
            this.pictureBox_CardFaction = new System.Windows.Forms.PictureBox();
            this.textBox_ProdWorker = new System.Windows.Forms.TextBox();
            this.textBox_ProdWood = new System.Windows.Forms.TextBox();
            this.textBox_ProdStone = new System.Windows.Forms.TextBox();
            this.textBox_ProdFood = new System.Windows.Forms.TextBox();
            this.textBox_ProdGold = new System.Windows.Forms.TextBox();
            this.textBox_ProdWeapon = new System.Windows.Forms.TextBox();
            this.textBox_ProdCardAny = new System.Windows.Forms.TextBox();
            this.textBox_ProdCardCommon = new System.Windows.Forms.TextBox();
            this.textBox_ProdCardFaction = new System.Windows.Forms.TextBox();
            this.toolTip_Production = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CardAny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CardCommon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CardFaction)).BeginInit();
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
            resources.ApplyResources(this.textBox_PlayerFaction, "textBox_PlayerFaction");
            this.textBox_PlayerFaction.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox_PlayerFaction.Name = "textBox_PlayerFaction";
            this.textBox_PlayerFaction.ReadOnly = true;
            // 
            // textBox_ForeignFaction
            // 
            resources.ApplyResources(this.textBox_ForeignFaction, "textBox_ForeignFaction");
            this.textBox_ForeignFaction.BackColor = System.Drawing.Color.GhostWhite;
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
            // label_Production
            // 
            resources.ApplyResources(this.label_Production, "label_Production");
            this.label_Production.Name = "label_Production";
            // 
            // pictureBox_Worker
            // 
            this.pictureBox_Worker.Image = global::ImperialSettlersCampaignCompanion.Pictures.Worker;
            resources.ApplyResources(this.pictureBox_Worker, "pictureBox_Worker");
            this.pictureBox_Worker.Name = "pictureBox_Worker";
            this.pictureBox_Worker.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_Worker, resources.GetString("pictureBox_Worker.ToolTip"));
            // 
            // pictureBox_Wood
            // 
            this.pictureBox_Wood.Image = global::ImperialSettlersCampaignCompanion.Pictures.Wood;
            resources.ApplyResources(this.pictureBox_Wood, "pictureBox_Wood");
            this.pictureBox_Wood.Name = "pictureBox_Wood";
            this.pictureBox_Wood.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_Wood, resources.GetString("pictureBox_Wood.ToolTip"));
            // 
            // pictureBox_Stone
            // 
            this.pictureBox_Stone.Image = global::ImperialSettlersCampaignCompanion.Pictures.Stone;
            resources.ApplyResources(this.pictureBox_Stone, "pictureBox_Stone");
            this.pictureBox_Stone.Name = "pictureBox_Stone";
            this.pictureBox_Stone.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_Stone, resources.GetString("pictureBox_Stone.ToolTip"));
            // 
            // pictureBox_Food
            // 
            this.pictureBox_Food.Image = global::ImperialSettlersCampaignCompanion.Pictures.Food;
            resources.ApplyResources(this.pictureBox_Food, "pictureBox_Food");
            this.pictureBox_Food.Name = "pictureBox_Food";
            this.pictureBox_Food.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_Food, resources.GetString("pictureBox_Food.ToolTip"));
            // 
            // pictureBox_Gold
            // 
            this.pictureBox_Gold.Image = global::ImperialSettlersCampaignCompanion.Pictures.Gold;
            resources.ApplyResources(this.pictureBox_Gold, "pictureBox_Gold");
            this.pictureBox_Gold.Name = "pictureBox_Gold";
            this.pictureBox_Gold.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_Gold, resources.GetString("pictureBox_Gold.ToolTip"));
            // 
            // pictureBox_Weapon
            // 
            this.pictureBox_Weapon.Image = global::ImperialSettlersCampaignCompanion.Pictures.Weapon;
            resources.ApplyResources(this.pictureBox_Weapon, "pictureBox_Weapon");
            this.pictureBox_Weapon.Name = "pictureBox_Weapon";
            this.pictureBox_Weapon.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_Weapon, resources.GetString("pictureBox_Weapon.ToolTip"));
            // 
            // pictureBox_CardAny
            // 
            this.pictureBox_CardAny.Image = global::ImperialSettlersCampaignCompanion.Pictures.CardAny;
            resources.ApplyResources(this.pictureBox_CardAny, "pictureBox_CardAny");
            this.pictureBox_CardAny.Name = "pictureBox_CardAny";
            this.pictureBox_CardAny.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_CardAny, resources.GetString("pictureBox_CardAny.ToolTip"));
            // 
            // pictureBox_CardCommon
            // 
            this.pictureBox_CardCommon.Image = global::ImperialSettlersCampaignCompanion.Pictures.CardCommon;
            resources.ApplyResources(this.pictureBox_CardCommon, "pictureBox_CardCommon");
            this.pictureBox_CardCommon.Name = "pictureBox_CardCommon";
            this.pictureBox_CardCommon.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_CardCommon, resources.GetString("pictureBox_CardCommon.ToolTip"));
            // 
            // pictureBox_CardFaction
            // 
            this.pictureBox_CardFaction.Image = global::ImperialSettlersCampaignCompanion.Pictures.CardFaction;
            resources.ApplyResources(this.pictureBox_CardFaction, "pictureBox_CardFaction");
            this.pictureBox_CardFaction.Name = "pictureBox_CardFaction";
            this.pictureBox_CardFaction.TabStop = false;
            this.toolTip_Production.SetToolTip(this.pictureBox_CardFaction, resources.GetString("pictureBox_CardFaction.ToolTip"));
            // 
            // textBox_ProdWorker
            // 
            this.textBox_ProdWorker.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdWorker, "textBox_ProdWorker");
            this.textBox_ProdWorker.Name = "textBox_ProdWorker";
            this.textBox_ProdWorker.ReadOnly = true;
            // 
            // textBox_ProdWood
            // 
            this.textBox_ProdWood.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdWood, "textBox_ProdWood");
            this.textBox_ProdWood.Name = "textBox_ProdWood";
            this.textBox_ProdWood.ReadOnly = true;
            // 
            // textBox_ProdStone
            // 
            this.textBox_ProdStone.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdStone, "textBox_ProdStone");
            this.textBox_ProdStone.Name = "textBox_ProdStone";
            this.textBox_ProdStone.ReadOnly = true;
            // 
            // textBox_ProdFood
            // 
            this.textBox_ProdFood.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdFood, "textBox_ProdFood");
            this.textBox_ProdFood.Name = "textBox_ProdFood";
            this.textBox_ProdFood.ReadOnly = true;
            // 
            // textBox_ProdGold
            // 
            this.textBox_ProdGold.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdGold, "textBox_ProdGold");
            this.textBox_ProdGold.Name = "textBox_ProdGold";
            this.textBox_ProdGold.ReadOnly = true;
            // 
            // textBox_ProdWeapon
            // 
            this.textBox_ProdWeapon.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdWeapon, "textBox_ProdWeapon");
            this.textBox_ProdWeapon.Name = "textBox_ProdWeapon";
            this.textBox_ProdWeapon.ReadOnly = true;
            // 
            // textBox_ProdCardAny
            // 
            this.textBox_ProdCardAny.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdCardAny, "textBox_ProdCardAny");
            this.textBox_ProdCardAny.Name = "textBox_ProdCardAny";
            this.textBox_ProdCardAny.ReadOnly = true;
            // 
            // textBox_ProdCardCommon
            // 
            this.textBox_ProdCardCommon.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdCardCommon, "textBox_ProdCardCommon");
            this.textBox_ProdCardCommon.Name = "textBox_ProdCardCommon";
            this.textBox_ProdCardCommon.ReadOnly = true;
            // 
            // textBox_ProdCardFaction
            // 
            this.textBox_ProdCardFaction.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.textBox_ProdCardFaction, "textBox_ProdCardFaction");
            this.textBox_ProdCardFaction.Name = "textBox_ProdCardFaction";
            this.textBox_ProdCardFaction.ReadOnly = true;
            // 
            // toolTip_Production
            // 
            this.toolTip_Production.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Production.ToolTipTitle = "Production";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_ProdCardFaction);
            this.Controls.Add(this.textBox_ProdCardCommon);
            this.Controls.Add(this.textBox_ProdCardAny);
            this.Controls.Add(this.textBox_ProdWeapon);
            this.Controls.Add(this.textBox_ProdGold);
            this.Controls.Add(this.textBox_ProdFood);
            this.Controls.Add(this.textBox_ProdStone);
            this.Controls.Add(this.textBox_ProdWood);
            this.Controls.Add(this.textBox_ProdWorker);
            this.Controls.Add(this.pictureBox_CardFaction);
            this.Controls.Add(this.pictureBox_CardCommon);
            this.Controls.Add(this.pictureBox_CardAny);
            this.Controls.Add(this.pictureBox_Weapon);
            this.Controls.Add(this.pictureBox_Gold);
            this.Controls.Add(this.pictureBox_Food);
            this.Controls.Add(this.pictureBox_Stone);
            this.Controls.Add(this.pictureBox_Wood);
            this.Controls.Add(this.pictureBox_Worker);
            this.Controls.Add(this.label_Production);
            this.Controls.Add(this.button_GameReport);
            this.Controls.Add(this.textBox_Chapter);
            this.Controls.Add(this.label_Chapter);
            this.Controls.Add(this.textBox_CampaignName);
            this.Controls.Add(this.textBox_ForeignFaction);
            this.Controls.Add(this.textBox_PlayerFaction);
            this.Controls.Add(this.label_ForeignFaction);
            this.Controls.Add(this.label_PlayerFaction);
            this.Controls.Add(this.label_CampaignName);
            this.Controls.Add(this.label_Separator);
            this.Controls.Add(this.button_LoadCampaign);
            this.Controls.Add(this.button_NewCampaign);
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CardAny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CardCommon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CardFaction)).EndInit();
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
        private System.Windows.Forms.TextBox textBox_Chapter;
        private System.Windows.Forms.Label label_Chapter;
        private System.Windows.Forms.Button button_GameReport;
        private System.Windows.Forms.Label label_Production;
        private System.Windows.Forms.PictureBox pictureBox_Worker;
        private System.Windows.Forms.PictureBox pictureBox_Wood;
        private System.Windows.Forms.PictureBox pictureBox_Stone;
        private System.Windows.Forms.PictureBox pictureBox_Food;
        private System.Windows.Forms.PictureBox pictureBox_Gold;
        private System.Windows.Forms.PictureBox pictureBox_Weapon;
        private System.Windows.Forms.PictureBox pictureBox_CardAny;
        private System.Windows.Forms.PictureBox pictureBox_CardCommon;
        private System.Windows.Forms.PictureBox pictureBox_CardFaction;
        private System.Windows.Forms.TextBox textBox_ProdWorker;
        private System.Windows.Forms.TextBox textBox_ProdWood;
        private System.Windows.Forms.TextBox textBox_ProdStone;
        private System.Windows.Forms.TextBox textBox_ProdFood;
        private System.Windows.Forms.TextBox textBox_ProdGold;
        private System.Windows.Forms.TextBox textBox_ProdWeapon;
        private System.Windows.Forms.TextBox textBox_ProdCardAny;
        private System.Windows.Forms.TextBox textBox_ProdCardCommon;
        private System.Windows.Forms.TextBox textBox_ProdCardFaction;
        private System.Windows.Forms.ToolTip toolTip_Production;
    }
}

