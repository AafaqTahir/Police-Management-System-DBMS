using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    class VictimDataBase
    {
        private readonly string SELECT_ALL = "SELECT * FROM VICTIM";
        private readonly string INSERT = "INSERT INTO VICTIM VALUES(@IDCard, @Name, @VictimAddress, @PhoneNumber, @CaseNumber)";
        private readonly string UPDATE = "UPDATE VICTIM SET IDCard = @IDCard, Name = @Name, VictimAddress = @VictimAddress, PhoneNumber = @PhoneNumber, CaseNumber = @CaseNumber WHERE ID = @ID";
        private readonly string DELETE = "DELETE FROM VICTIM WHERE ID = @ID";

        public List<Victim> Select_All()
        {
            SqlCommand cmd = new SqlCommand(SELECT_ALL, DBC.getConnection());
            return fetch(cmd);
        }
        public List<Victim> fetch(SqlCommand cmd)
        {
            SqlConnection con = cmd.Connection;
            con.Open();
            using (con)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<Victim> victim = null;
                if (dr.HasRows)
                {
                    victim = new List<Victim>();
                    while (dr.Read())
                    {
                        Victim d = new Victim();
                        d.ID = Convert.ToInt32(dr["ID"]);
                        d.IDCard = Convert.ToInt64(dr["IDCard"]);
                        d.Name = Convert.ToString(dr["Name"]);
                        d.VictimAddress = Convert.ToString(dr["VictimAddress"]);
                        d.PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]);
                        d.CaseNumber = Convert.ToInt32(dr["CaseNumber"]);
                        victim.Add(d);
                    }
                    victim.TrimExcess();
                }
                return victim;
            }
        }
        public void insert (Victim d)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(INSERT, DBC.getConnection());
                SqlConnection con = cmd.Connection;
                con.Open();
                cmd.Parameters.AddWithValue("@Name", d.Name);
                cmd.Parameters.AddWithValue("@IDCard", d.IDCard);
                cmd.Parameters.AddWithValue("@VictimAddress", d.VictimAddress);
                cmd.Parameters.AddWithValue("@PhoneNumber", d.PhoneNumber);
                cmd.Parameters.AddWithValue("@CaseNumber", d.CaseNumber);
                using (con)
                {
                    int rows = cmd.ExecuteNonQuery();
                    if(rows > 0)
                    {
                        MessageBox.Show("Data Inserted SuccesFully");
                    }
                    else
                    {
                        MessageBox.Show("Something Gone Wrong");
                    }
                }
            }
            catch (Exception e1)
            {

            }
        }
        public void update(Victim d)
        {
            SqlCommand cmd = new SqlCommand(UPDATE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attributes and right side class variables
            cmd.Parameters.AddWithValue("@ID", d.ID);
            cmd.Parameters.AddWithValue("@Name", d.Name);
            cmd.Parameters.AddWithValue("@IDCard", d.IDCard);
            cmd.Parameters.AddWithValue("@VictimAddress", d.VictimAddress);
            cmd.Parameters.AddWithValue("@PhoneNumber", d.PhoneNumber);
            cmd.Parameters.AddWithValue("@CaseNumber", d.CaseNumber);
            using (con)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data updated successfully");
                else
                    MessageBox.Show("something wrong");
            }
        }
        public void delete(Victim d)
        {
            SqlCommand cmd = new SqlCommand(DELETE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attribute and right side class variabled
            cmd.Parameters.AddWithValue("@ID", d.ID);
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
