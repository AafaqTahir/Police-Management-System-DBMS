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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lblCriminals_Click(object sender, EventArgs e)
        {
            CriminalsForm objCrimininalForm = new CriminalsForm();
            objCrimininalForm.Show();
            this.Hide();
        }

        private void lblOfficers_Click(object sender, EventArgs e)
        {
            OfficerForm objOfficerForm = new OfficerForm();
            objOfficerForm.Show();
            this.Hide();
        }

        private void lblVictims_Click(object sender, EventArgs e)
        {
            VictimForm objVictimsForm = new VictimForm();
            objVictimsForm.Show();
            this.Hide();
        }

        private void lblCase_Click(object sender, EventArgs e)
        {
            CaseForm objCaseForm = new CaseForm();
            objCaseForm.Show();
            this.Hide();
        }

        private void lblCrime_Click(object sender, EventArgs e)
        {
            CrimeForm objCrimeForm = new CrimeForm();
            objCrimeForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
