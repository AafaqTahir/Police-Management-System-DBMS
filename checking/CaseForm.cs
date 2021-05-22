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
    public partial class CaseForm : Form
    {
        Case c;
        List<Case> list_case;
        public CaseForm()
        {
            InitializeComponent();
        }

        private void CaseForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void load_data()
        {
            string caseID = CaseGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (Case c in list_case)
                if (c.caseID == Convert.ToInt32(caseID))
                {
                    txtCaseType.Text = c.caseType;
                    txtStartingDate.Text = c.startingDate;
                    txtEndingDate.Text = c.endingDate;
                    txtOfficerID.Text = Convert.ToString(c.officerBatchID);
                    txtSolved.Text = c.solved;
                    txtVictimID.Text = Convert.ToString(c.victimID);
                    txtCrimeID.Text = Convert.ToString(c.crimeID);
                }
        }
        public void populate()
        {
            CaseDataBase caseDB = new CaseDataBase();
            list_case = caseDB.Select_All();
            CaseGridView.DataSource = list_case;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CaseDataBase caseDB = new CaseDataBase();
            c = new Case();
            c.caseID = Convert.ToInt32(CaseGridView.CurrentRow.Cells[0].Value.ToString());
            c.caseType = txtCaseType.Text;
            c.startingDate = txtStartingDate.Text;
            c.endingDate = txtEndingDate.Text;
            c.officerBatchID = Convert.ToInt32(txtOfficerID.Text);
            c.solved = txtSolved.Text;
            c.victimID = Convert.ToInt32(txtVictimID.Text);
            c.crimeID = Convert.ToInt32(txtCrimeID.Text);
            caseDB.update(c);
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c = new Case();
            c.caseID = Convert.ToInt32(CaseGridView.CurrentRow.Cells[0].Value.ToString());
            CaseDataBase caseDB = new CaseDataBase();
            caseDB.delete(c);
            populate();
        }

        private void CaseGridView_MouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCaseType.Text = txtCrimeID.Text = txtEndingDate.Text = txtOfficerID.Text = txtSolved.Text = txtStartingDate.Text = txtVictimID.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void CaseGridView_DoubleClick(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            CaseDataBase caseDB = new CaseDataBase();
            c = new Case();
            c.caseType = txtCaseType.Text;
            c.startingDate = txtStartingDate.Text;
            c.endingDate = txtEndingDate.Text;
            c.officerBatchID = Convert.ToInt32(txtOfficerID.Text);
            c.solved = txtSolved.Text;
            c.victimID = Convert.ToInt32(txtVictimID.Text);
            c.crimeID = Convert.ToInt32(txtCrimeID.Text);
            caseDB.insert(c);
            populate();
        }
    }
}
