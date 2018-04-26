using ImperialSettlersCampaignCompanion.Data;
using ImperialSettlersCampaignCompanion.Data.Factions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImperialSettlersCampaignCompanion
{
    public partial class NewCampaignForm : Form
    {
        BindingList<Faction> m_Factions;

        public Campaign Campaign { get; private set; }

        public NewCampaignForm()
        {
            InitializeComponent();
        }

        private void NewCampaignForm_Load(object sender, EventArgs e)
        {
            m_Factions = new BindingList<Faction>();
            foreach(Faction f in Database.Instance.Factions)
            {
                m_Factions.Add(f);
            }
            listBox_Factions.DataSource = m_Factions;
            listBox_Factions.ValueMember = "Id";
            listBox_Factions.DisplayMember = "Name";
        }

        private void TransferFactionToTextBox(TextBox tb)
        {
            Faction f = listBox_Factions.SelectedItem as Faction;
            tb.Text = f.Name;
            tb.Tag = f;
            m_Factions.Remove(f);
        }
        private void RemoveFactionFromTextBox(TextBox tb)
        {
            object o = tb.Tag;
            if (o != null)
            {
                m_Factions.Add(o as Faction);
                tb.Tag = null;
                tb.Text = "";
            }
        }

        private void button_SelectPlayerFaction_Click(object sender, EventArgs e)
        {
            button_RemovePlayerFaction_Click(sender, e);
            TransferFactionToTextBox(textBox_PlayerFaction);
        }
        private void button_RemovePlayerFaction_Click(object sender, EventArgs e)
        {
            RemoveFactionFromTextBox(textBox_PlayerFaction);
        }

        private void button_SelectForeignFaction_Click(object sender, EventArgs e)
        {
            button_RemoveForeignFaction_Click(sender, e);
            TransferFactionToTextBox(textBox_ForeignFaction);
        }

        private void button_RemoveForeignFaction_Click(object sender, EventArgs e)
        {
            RemoveFactionFromTextBox(textBox_ForeignFaction);
        }

        private void textBox_CampaignName_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_CampaignName.Text) || Campaign.Exists(textBox_CampaignName.Text))
            {
                label_NameError.Visible = true;
                button_OK.Enabled = false;
                return;
            }

            label_NameError.Visible = false;
            button_OK.Enabled = true;
        }

        private void RandomizeFactionIfNeeded(TextBox tb)
        {
            if(tb.Tag == null)
            {
                listBox_Factions.SelectedIndex = DiceRoller.Roll(listBox_Factions.Items.Count) - 1;
                TransferFactionToTextBox(tb);
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            RandomizeFactionIfNeeded(textBox_PlayerFaction);
            RandomizeFactionIfNeeded(textBox_ForeignFaction);

            Campaign = new Campaign(textBox_CampaignName.Text, textBox_PlayerFaction.Tag as Faction, textBox_ForeignFaction.Tag as Faction);
        }
    }
}
