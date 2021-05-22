using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class VictimForm : Form
    {
        Victim v;
        List<Victim> list_Victim;
        public VictimForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            VictimDataBase victimDataBase = new VictimDataBase();
            v = new Victim();
            v.Name = NameTextBox.Text;
            v.IDCard = Convert.ToInt64(IDCardTextBox.Text);
            v.VictimAddress = AddressTextBox.Text;
            v.PhoneNumber = Convert.ToInt32(PhoneNumberTextBox.Text);
            v.CaseNumber = Convert.ToInt32(CaseNumberTextBox.Text);
            victimDataBase.insert(v);
            populate();
        }

        public void populate()
        {
            VictimDataBase victimDataBase = new VictimDataBase();
            list_Victim = victimDataBase.Select_All();
            VictimGridView.DataSource = list_Victim;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            v = new Victim();
            v.ID = Convert.ToInt32(VictimGridView.CurrentRow.Cells[0].Value.ToString());
            VictimDataBase victimDataBase = new VictimDataBase();
            victimDataBase.delete(v);
            populate();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            VictimDataBase victimDataBase = new VictimDataBase();
            v = new Victim();
            v.ID = Convert.ToInt32(VictimGridView.CurrentRow.Cells[0].Value.ToString());
            v.Name = NameTextBox.Text;
            v.IDCard = Convert.ToInt64(IDCardTextBox.Text);
            v.VictimAddress = AddressTextBox.Text;
            v.PhoneNumber = Convert.ToInt32(PhoneNumberTextBox.Text);
            v.CaseNumber = Convert.ToInt32(CaseNumberTextBox.Text);
            victimDataBase.update(v);
            populate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = IDCardTextBox.Text = AddressTextBox.Text = PhoneNumberTextBox.Text = CaseNumberTextBox.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        public void load_data()
        {
            string driver_id = VictimGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (Victim v in list_Victim)
                if (v.ID == Convert.ToInt32(driver_id))
                {
                    NameTextBox.Text = v.Name;
                    IDCardTextBox.Text = Convert.ToString(v.IDCard);
                    AddressTextBox.Text = v.VictimAddress;
                    PhoneNumberTextBox.Text = Convert.ToString(v.PhoneNumber);
                    CaseNumberTextBox.Text = Convert.ToString(v.CaseNumber);

                }
        }

        private void VictimGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data();
        }

        private void VictimGridView_DoubleClick(object sender, EventArgs e)
        {
            load_data();
        }

        private void VictimForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        
    }
}
