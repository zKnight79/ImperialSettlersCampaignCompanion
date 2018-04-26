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

        private void button_NewCampaign_Click(object sender, EventArgs e)
        {
            using(NewCampaignForm ncf = new NewCampaignForm())
            {
                if(ncf.ShowDialog() == DialogResult.OK)
                {
                    Campaign = ncf.Campaign;
                    Campaign.ToJSonFile();
                }
            }
        }

        private void button_LoadCampaign_Click(object sender, EventArgs e)
        {
            
        }
    }
}
