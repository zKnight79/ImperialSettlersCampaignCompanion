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

        private void DisplayCampaign()
        {
            textBox_CampaignName.Text = Campaign.Name;
            textBox_Chapter.Text = Campaign.Chapter.ToString();
            textBox_PlayerFaction.Text = Campaign.PlayerFaction.Name;
            textBox_ForeignFaction.Text = Campaign.ForeignFaction.Name;
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
    }
}
