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
    public partial class CrimeForm : Form
    {
        Crime c;
        List<Crime> list_crimes;
        public CrimeForm()
        {
            InitializeComponent();
        }

        private void CrimeForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void load_data()
        {
            string crimeID = CrimeGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (Crime c in list_crimes)
                if (c.crimeID == Convert.ToInt32(crimeID))
                {
                    crimeTxt.Text = c.crimeType;
                    crimeDateTxt.Text = c.crimeDate;
                    locationTxt.Text = c.location;
                    arrestTxt.Text = Convert.ToString(c.noOfPeopleArrest);
                }
        }
        public void populate()
        {
            CrimeDataBase crimeDB = new CrimeDataBase();
            list_crimes = crimeDB.Select_All();
            CrimeGridView.DataSource = list_crimes;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            CrimeDataBase crimeDB = new CrimeDataBase();
            c = new Crime();
            c.crimeType = crimeTxt.Text;
            c.crimeDate = crimeDateTxt.Text;
            c.location = locationTxt.Text;
            c.noOfPeopleArrest = Convert.ToInt32(arrestTxt.Text);
            crimeDB.insert(c);
            populate();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            CrimeDataBase crimeDB = new CrimeDataBase();
            c = new Crime();
            c.crimeID = Convert.ToInt32(CrimeGridView.CurrentRow.Cells[0].Value.ToString());
            c.crimeType = crimeTxt.Text;
            c.crimeDate = crimeDateTxt.Text;
            c.location = locationTxt.Text;
            c.noOfPeopleArrest = Convert.ToInt32(arrestTxt.Text);
            crimeDB.update(c);
            populate();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            c = new Crime();
            c.crimeID = Convert.ToInt32(CrimeGridView.CurrentRow.Cells[0].Value.ToString());
            CrimeDataBase crimeDB = new CrimeDataBase();
            crimeDB.delete(c);
            populate();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            arrestTxt.Text = crimeDateTxt.Text = crimeTxt.Text = locationTxt.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void CrimeGridView_DoubleClick(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
