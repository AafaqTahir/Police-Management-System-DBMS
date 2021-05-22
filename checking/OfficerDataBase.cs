using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PMS
{
    class OfficerDataBase
    {
        private readonly string SELECT_ALL = "select * from officers";
        private readonly string INSERT = "Insert into Officers values(@officerName,@officerAge,@officerRank,@officerSalary,@officerAddress,@officerPhoneNo,@officerJoiningDate,@officerCNIC);";
        private readonly string UPDATE = "Update officers set officerName=@officerName,officerAge=@officerAge,officerRank=@officerRank,officerSalary=@officerSalary,officerAddress=@officerAddress,officerPhoneNo=@officerPhoneNo,officerJoiningDate=@officerJoiningDate,officerCNIC=@officerCNIC where officerID=@officerID";
        private readonly string DELETE = "Delete from officers where officerID=@officerID";

        public List<Officer> Select_All()

        {
            SqlCommand cmd = new SqlCommand(SELECT_ALL, DBC.getConnection());
            return fetch(cmd);
        }
        public List<Officer> fetch(SqlCommand cmd)
        {
            SqlConnection con = cmd.Connection;
            con.Open();
            using (con)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<Officer> officer = null;
                if (dr.HasRows)
                {
                    officer = new List<Officer>();
                    while (dr.Read())
                    {
                        Officer o = new Officer();
                        o.officerID = Convert.ToInt32(dr["officerID"]);
                        o.officerName = Convert.ToString(dr["officerName"]);
                        o.officerSalary = Convert.ToInt32(dr["officerSalary"]);
                        o.officerRank = Convert.ToString(dr["officerRank"]);
                        o.officerAddress = Convert.ToString(dr["officerAddress"]);
                        o.officerPhoneNo = Convert.ToInt64 (dr["officerPhoneNo"]);
                        o.officerAge = Convert.ToInt32(dr["officerAge"]);
                        o.officerJoiningDate = Convert.ToString(dr["officerJoiningDate"]);
                        o.officerCNIC = Convert.ToInt64(dr["officerCNIC"]);
                        officer.Add(o);
                    }
                    officer.TrimExcess();
                }
                return officer;
            }
        }
        public void insert(Officer o)
        {
            try
            {
                //MessageBox.Show("Hello");
                SqlCommand cmd = new SqlCommand(INSERT, DBC.getConnection());
                SqlConnection con = cmd.Connection;
                con.Open();
                cmd.Parameters.AddWithValue("@officerName", o.officerName);
                cmd.Parameters.AddWithValue("@officerAge", o.officerAge);
                cmd.Parameters.AddWithValue("@officerSalary", o.officerSalary);
                cmd.Parameters.AddWithValue("@officerRank", o.officerRank);
                cmd.Parameters.AddWithValue("@officerAddress", o.officerAddress);
                cmd.Parameters.AddWithValue("@officerPhoneNo", o.officerPhoneNo);
                cmd.Parameters.AddWithValue("@officerJoiningDate", o.officerJoiningDate);
                cmd.Parameters.AddWithValue("@officerCNIC", o.officerCNIC);
                
                using (con)
                {
                   // MessageBox.Show("He33llo");
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                       // MessageBox.Show("Hel222lo");
                        MessageBox.Show("Data inserted successfully");
                    }
                        
                    else
                        MessageBox.Show("something wrong");
                }
            }
            catch (Exception e1)
            {
                //MessageBox.Show(e1 + "");
            }
        }
        public void update(Officer o)
        {
            SqlCommand cmd = new SqlCommand(UPDATE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attributes and right side class variables
            cmd.Parameters.AddWithValue("@officerID", o.officerID);
            cmd.Parameters.AddWithValue("@officerName", o.officerName);
            cmd.Parameters.AddWithValue("@officerAge", o.officerAge);
            cmd.Parameters.AddWithValue("@officerSalary", o.officerSalary);
            cmd.Parameters.AddWithValue("@officerRank", o.officerRank);
            cmd.Parameters.AddWithValue("@officerAddress", o.officerAddress);
            cmd.Parameters.AddWithValue("@officerPhoneNo", o.officerPhoneNo);
            cmd.Parameters.AddWithValue("@officerJoiningDate", o.officerJoiningDate);
            cmd.Parameters.AddWithValue("@officerCNIC", o.officerCNIC);
            using (con)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data updated successfully");
                else
                    MessageBox.Show("something wrong");
            }
        }
        public void delete(Officer o)
        {
            SqlCommand cmd = new SqlCommand(DELETE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attribute and right side class variabled
            cmd.Parameters.AddWithValue("@officerID", o.officerID);
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
