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
    public partial class CriminalsForm : Form
    {
        Criminals c;
        List<Criminals> list_criminals;
        public CriminalsForm()
        {
            InitializeComponent();
        }

        private void CriminalsForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            CriminalDataBase criminalDB = new CriminalDataBase();
            list_criminals = criminalDB.Select_All();
            criminalsGridView.DataSource = list_criminals;
        }
        public void load_data()
        {
            string criminalID = criminalsGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (Criminals c in list_criminals)
                if (c.criminalID == Convert.ToInt32(criminalID))
                {
                    nameTxt.Text = c.name;
                    ageTxt.Text = Convert.ToString(c.Age);
                    addressTxt.Text = c.criminalAddress;
                    arrestTxt.Text = c.dateOfArrest;
                    batchIDTxt.Text = Convert.ToString(c.batchID);
                    crimeIDTxt.Text = Convert.ToString(c.crimeID);
                    caseNoTxt.Text = Convert.ToString(c.caseNo);
                }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CriminalDataBase criminalDB = new CriminalDataBase();
            c = new Criminals();
            c.name = nameTxt.Text;
            c.Age = Convert.ToInt32(ageTxt.Text);
            c.criminalAddress = addressTxt.Text;
            c.dateOfArrest = arrestTxt.Text;
            c.batchID = Convert.ToInt32(batchIDTxt.Text);
            c.crimeID = Convert.ToInt32(crimesTxt.Text);
            c.caseNo = Convert.ToInt32(caseNoTxt.Text);
            criminalDB.insert(c);
            populate();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            CriminalDataBase criminalDB = new CriminalDataBase();
            c = new Criminals();
            c.criminalID = Convert.ToInt32(criminalsGridView.CurrentRow.Cells[0].Value.ToString());
            c.name = nameTxt.Text;
            c.Age = Convert.ToInt32(ageTxt.Text);
            c.criminalAddress = addressTxt.Text;
            c.dateOfArrest = arrestTxt.Text;
            c.batchID = Convert.ToInt32(batchIDTxt.Text);
            c.crimeID = Convert.ToInt32(crimeIDTxt.Text);
            c.caseNo = Convert.ToInt32(caseNoTxt.Text);
            criminalDB.update(c);
            populate();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            c = new Criminals();
            c.criminalID = Convert.ToInt32(criminalsGridView.CurrentRow.Cells[0].Value.ToString());
            CriminalDataBase criminalDB = new CriminalDataBase();
            criminalDB.delete(c);
            populate();
        }

        private void criminalsGridView_MouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            addressTxt.Text = nameTxt.Text = ageTxt.Text = arrestTxt.Text = crimesTxt.Text = crimeIDTxt.Text = caseNoTxt.Text = batchIDTxt.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void criminalsGridView_DoubleClick(object sender, EventArgs e)
        {
            load_data();
        }

       


       
    }
}
