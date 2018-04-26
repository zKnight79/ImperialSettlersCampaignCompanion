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
    public partial class LoadCampaignForm : Form
    {
        public Campaign Campaign { get; private set; }

        public LoadCampaignForm()
        {
            InitializeComponent();
        }

        private void LoadCampaignForm_Load(object sender, EventArgs e)
        {
            listBox_Campaigns.DataSource = Campaign.GetSavedCampaigns();
            button_OK.Enabled = (listBox_Campaigns.Items.Count > 0);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Campaign = listBox_Campaigns.SelectedItem as Campaign;
        }
    }
}
