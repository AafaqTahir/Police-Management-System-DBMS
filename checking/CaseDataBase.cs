using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    class CaseDataBase
    {
        private readonly string SELECT_ALL = "Select * from cases";
        private readonly string INSERT = "Insert into cases Values(@caseType,@startingDate,@endingDate,@crimeID,@officerBatchID,@solved,@victimID)";
        private readonly string UPDATE = "Update cases set caseType=@caseType,startingDate=@startingDate,endingDate=@endingDate,crimeID=@crimeID,officerBatchID=@officerBatchID,solved=@solved,victimID=@victimID";
        private readonly string DELETE = "Delete from cases where caseID = @caseID";


        public List<Case> Select_All()
        {
            SqlCommand cmd = new SqlCommand(SELECT_ALL, DBC.getConnection());
            return fetch(cmd);
        }



        public List<Case> fetch(SqlCommand cmd)
        {
            SqlConnection con = cmd.Connection;
            con.Open();
            using (con)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<Case> Case = null;
                if (dr.HasRows)
                {
                    Case = new List<Case>();
                    while (dr.Read())
                    {
                        Case c = new Case();
                        c.caseID = Convert.ToInt32(dr["caseID"]);
                        c.caseType = Convert.ToString(dr["caseType"]);
                        c.startingDate = Convert.ToString(dr["startingDate"]);
                        c.endingDate = Convert.ToString(dr["endingDate"]);
                        c.crimeID = Convert.ToInt32(dr["crimeID"]);
                        c.officerBatchID = Convert.ToInt32(dr["officerBatchID"]);
                        c.solved = Convert.ToString(dr["solved"]);
                        c.victimID = Convert.ToInt32(dr["victimID"]);
                        //left side class variables and right side table attributes 
                        Case.Add(c);
                    }
                    Case.TrimExcess();
                }
                return Case;
            }
        }

        public void insert(Case c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(INSERT, DBC.getConnection());
                SqlConnection con = cmd.Connection;
                con.Open();
                cmd.Parameters.AddWithValue("@caseType", c.caseType);
                cmd.Parameters.AddWithValue("@startingDate", c.startingDate);
                cmd.Parameters.AddWithValue("@endingDate", c.endingDate);
                cmd.Parameters.AddWithValue("@crimeID", c.crimeID);
                cmd.Parameters.AddWithValue("@officerBatchID", c.officerBatchID);
                cmd.Parameters.AddWithValue("@solved", c.solved);
                cmd.Parameters.AddWithValue("@victimID", c.victimID);
                using (con)
                {
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Data inserted successfully");
                    else
                        MessageBox.Show("something wrong");
                }
            }
            catch (Exception e1)
            {
                //MessageBox.Show(e1 + "");
            }
        }

        public void update(Case c)
        {
            SqlCommand cmd = new SqlCommand(UPDATE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attributes and right side class variables

            cmd.Parameters.AddWithValue("@caseID", c.caseID);
            cmd.Parameters.AddWithValue("@caseType", c.caseType);
            cmd.Parameters.AddWithValue("@startingDate", c.startingDate);
            cmd.Parameters.AddWithValue("@endingDate", c.endingDate);
            cmd.Parameters.AddWithValue("@crimeID", c.crimeID);
            cmd.Parameters.AddWithValue("@officerBatchID", c.officerBatchID);
            cmd.Parameters.AddWithValue("@solved", c.solved);
            cmd.Parameters.AddWithValue("@victimID", c.victimID);
            using (con)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data updated successfully");
                else
                    MessageBox.Show("something wrong");
            }

        }

        public void delete(Case c)
        {
            SqlCommand cmd = new SqlCommand(DELETE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attribute and right side class variabled
            cmd.Parameters.AddWithValue("@caseID", c.caseID);
            using (con)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data deleted successfully");
                else
                    MessageBox.Show("something wrong");
            }
        }
    }
}
