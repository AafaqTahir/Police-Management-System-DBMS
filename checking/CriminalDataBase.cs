using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PMS
{
    class CriminalDataBase
    {
        private readonly string SELECT_ALL = "select * from criminals";
        private readonly string INSERT = "insert into criminals values(@name,@Age,@criminalAddress,@dateOfArrest,@batchID,@crimeID,@caseNo);";
        private readonly string UPDATE = "Update Criminals set name=@name,Age=@Age,criminalAddress=@criminalAddress,dateOfArrest=@dateOfArrest,batchID=@batchID,crimeID=@crimeID,caseNo=@caseNo where CriminalID=@CriminalID";
        private readonly string DELETE = "Delete from criminals where CriminalID=@CriminalID";

        public List<Criminals> Select_All()
        {
            SqlCommand cmd = new SqlCommand(SELECT_ALL, DBC.getConnection());
            return fetch(cmd);
        }
        public List<Criminals> fetch(SqlCommand cmd)
        {
            SqlConnection con = cmd.Connection;
            con.Open();
            using (con)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<Criminals> criminal = null;
                if (dr.HasRows)
                {
                    criminal = new List<Criminals>();
                    while (dr.Read())
                    {
                        Criminals c = new Criminals();
                        c.criminalID = Convert.ToInt32(dr["CriminalID"]);
                        c.name = Convert.ToString(dr["name"]);
                        c.Age = Convert.ToInt32(dr["Age"]);
                        c.criminalAddress = Convert.ToString(dr["criminalAddress"]);
                        c.dateOfArrest = Convert.ToString(dr["dateOfArrest"]);
                        c.batchID = Convert.ToInt32(dr["batchID"]);
                        c.crimeID = Convert.ToInt32(dr["crimeID"]);
                        c.caseNo = Convert.ToInt32(dr["caseNo"]);
                        criminal.Add(c);
                    }
                    criminal.TrimExcess();
                }
                return criminal;
            }
        }
        public void insert(Criminals c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(INSERT, DBC.getConnection());
                SqlConnection con = cmd.Connection;
                con.Open();
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@age", c.Age);
                cmd.Parameters.AddWithValue("@criminalAddress", c.criminalAddress);
                cmd.Parameters.AddWithValue("@dateOfArrest", c.dateOfArrest);
                cmd.Parameters.AddWithValue("@batchID", c.batchID);
                cmd.Parameters.AddWithValue("@crimeID", c.crimeID);
                cmd.Parameters.AddWithValue("@caseNo", c.caseNo);
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
        public void update(Criminals c)
        {
            SqlCommand cmd = new SqlCommand(UPDATE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attributes and right side class variables

            cmd.Parameters.AddWithValue("@criminalID", c.criminalID);
            cmd.Parameters.AddWithValue("@name", c.name);
            cmd.Parameters.AddWithValue("@age", c.Age);
            cmd.Parameters.AddWithValue("@criminalAddress", c.criminalAddress);
            cmd.Parameters.AddWithValue("@dateOfArrest", c.dateOfArrest);
            cmd.Parameters.AddWithValue("@batchID", c.batchID);
            cmd.Parameters.AddWithValue("@crimeID", c.crimeID);
            cmd.Parameters.AddWithValue("@caseNo", c.caseNo);
            using (con)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data updated successfully");
                else
                    MessageBox.Show("something wrong");
            }
        }
        public void delete(Criminals c)
        {
            SqlCommand cmd = new SqlCommand(DELETE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attribute and right side class variabled
            cmd.Parameters.AddWithValue("@CriminalID", c.criminalID);
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
