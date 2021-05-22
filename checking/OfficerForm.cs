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
    public partial class OfficerForm : Form
    {
        Officer o;
        List<Officer> list_Officer;
        public OfficerForm()
        {
            InitializeComponent();
        }

        private void OfficerForm_Load(object sender, EventArgs e)
        {
            populate();
        }
    
        public void populate()
        {
            OfficerDataBase officerDB = new OfficerDataBase();
            list_Officer = officerDB.Select_All();
            officerGridView.DataSource = list_Officer;
        }
        public void load_data()
        {
            string officerID = officerGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (Officer o in list_Officer)
                if (o.officerID == Convert.ToInt32(officerID))
                {
                    txtName.Text = o.officerName;
                    txtAge.Text = Convert.ToString(o.officerAge);
                    txtRank.Text = o.officerRank;
                    txtSalary.Text = Convert.ToString(o.officerSalary);
                    txtAddress.Text = o.officerAddress;
                    txtPhoneNumber.Text = Convert.ToString(o.officerPhoneNo);
                    txtAge.Text = Convert.ToString(o.officerAge);
                    txtJoiningDate.Text = o.officerJoiningDate;
                    txtCNIC.Text = Convert.ToString(o.officerCNIC);
                }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            OfficerDataBase officerDB = new OfficerDataBase();
            o = new Officer();
            o.officerName = txtName.Text;
            o.officerSalary = Convert.ToInt32(txtSalary.Text);
            o.officerRank = txtRank.Text;
            o.officerAddress = txtAddress.Text;
            o.officerPhoneNo = Convert.ToInt64(txtPhoneNumber.Text);
            o.officerAge = Convert.ToInt32(txtAge.Text);
            o.officerJoiningDate = txtJoiningDate.Text;
            o.officerCNIC = Convert.ToInt64(txtCNIC.Text);
            officerDB.insert(o);
            populate();
        }

        private void officerGridView_MouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OfficerDataBase officerDB = new OfficerDataBase();
            o = new Officer();
            o.officerID = Convert.ToInt32(officerGridView.CurrentRow.Cells[0].Value.ToString());
            o.officerName = txtName.Text;
            o.officerSalary = Convert.ToInt32(txtSalary.Text);
            o.officerRank = txtRank.Text;
            o.officerAddress = txtAddress.Text;
            o.officerPhoneNo = Convert.ToInt32(txtPhoneNumber.Text);
            o.officerAge = Convert.ToInt32(txtAge.Text);
            o.officerJoiningDate = txtJoiningDate.Text;
            o.officerCNIC = Convert.ToInt32(txtCNIC.Text);
            officerDB.update(o);
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            o = new Officer();
            o.officerID = Convert.ToInt32(officerGridView.CurrentRow.Cells[0].Value.ToString());
            OfficerDataBase officerDB = new OfficerDataBase();
            officerDB.delete(o);
            populate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = txtAge.Text = txtCNIC.Text = txtJoiningDate.Text = txtName.Text = txtPhoneNumber.Text = txtRank.Text = txtSalary.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu obj = new Menu();
            obj.Show();
            this.Hide();
        }

        private void officerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data();
        }

        private void officerGridView_DoubleClick(object sender, EventArgs e)
        {
            load_data();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
