using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImperialSettlersCampaignCompanion
{
    public partial class MainForm : Form
    {
        private Campaign Campaign { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Campaign != null)
            {
                Campaign.ToJSonFile();
            }
        }

        private void button_NewCampaign_Click(object sender, EventArgs e)
        {
            using(NewCampaignForm ncf = new NewCampaignForm())
            {
                if(ncf.ShowDialog() == DialogResult.OK)
                {
                    Campaign = ncf.Campaign;
                    DisplayCampaign();
                }
            }
        }

        private void button_LoadCampaign_Click(object sender, EventArgs e)
        {
            using(LoadCampaignForm lcf = new LoadCampaignForm())
            {
                if(lcf.ShowDialog() == DialogResult.OK)
                {
                    Campaign = lcf.Campaign;
                    DisplayCampaign();
                }
            }
        }

        private void button_GameReport_Click(object sender, EventArgs e)
        {
            
        }

        private void DisplayCampaign()
        {
            #region Campaign Info
            textBox_CampaignName.Text = Campaign.Name;
            textBox_Chapter.Text = Campaign.Chapter.ToString();
            textBox_VictoryPoints.Text = Campaign.VictoryPoints.ToString();
            textBox_PlayerFaction.Text = Campaign.PlayerFaction.Name;
            textBox_ForeignFaction.Text = Campaign.ForeignFaction.Name;
            #endregion

            #region Production
            DisplayProductionField(textBox_ProdWorker, Campaign.ProdWorker, "");
            DisplayProductionField(textBox_ProdWood, Campaign.ProdWood, "");
            DisplayProductionField(textBox_ProdStone, Campaign.ProdStone, "");
            DisplayProductionField(textBox_ProdFood, Campaign.ProdFood, "");
            DisplayProductionField(textBox_ProdGold, Campaign.ProdGold, "");
            DisplayProductionField(textBox_ProdWeapon, Campaign.ProdWeapon, "");
            DisplayProductionField(textBox_ProdCardAny, Campaign.ProdCardAny, "");
            DisplayProductionField(textBox_ProdCardCommon, Campaign.ProdCardCommon, "");
            DisplayProductionField(textBox_ProdCardFaction, Campaign.ProdCardFaction, "");
            #endregion
        }

        private void DisplayProductionField(TextBox tb, int prodValue, string prodDetail)
        {
            if (prodValue > 0)
            {
                tb.Text = prodValue.ToString();
            }
            if (!string.IsNullOrEmpty(prodDetail))
            {
                toolTip_Production.SetToolTip(tb, prodDetail);
            }
        }
    }
}
