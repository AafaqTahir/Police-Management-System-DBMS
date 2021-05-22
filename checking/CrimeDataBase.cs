using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    class CrimeDataBase
    {
        private readonly string SELECT_ALL = "Select * from Crime";
        private readonly string INSERT = "Insert into Crime values(@crimeType,@crimeDate,@location,@noOfPeopleArrest)";
        private readonly string UPDATE = "Update Crime set crimeType=@crimeType,crimeDate=@crimeDate,location=@location,noOfPeopleArrest=@noOfPeopleArrest where crimeID = @crimeID";
        private readonly string DELETE = "Delete from Crime where crimeID=@crimeID";


        public List<Crime> Select_All()
        {
            SqlCommand cmd = new SqlCommand(SELECT_ALL, DBC.getConnection());
            return fetch(cmd);
        }
        public List<Crime> fetch(SqlCommand cmd)
        {
            SqlConnection con = cmd.Connection;
            con.Open();
            using (con)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                List<Crime> crime = null;
                if (dr.HasRows)
                {
                    crime = new List<Crime>();
                    while (dr.Read())
                    {
                        Crime c = new Crime();
                        c.crimeID = Convert.ToInt32(dr["crimeID"]);
                        c.crimeType = Convert.ToString(dr["crimeType"]);
                        c.crimeDate = Convert.ToString(dr["crimeDate"]);
                        c.location = Convert.ToString(dr["location"]);
                        c.noOfPeopleArrest = Convert.ToInt32(dr["noOfPeopleArrest"]);
                        //left side class variables and right side table attributes 
                        crime.Add(c);
                    }
                    crime.TrimExcess();
                }
                return crime;
            }
        }


        public void insert(Crime c)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(INSERT, DBC.getConnection());
                SqlConnection con = cmd.Connection;
                con.Open();
                cmd.Parameters.AddWithValue("@crimeType", c.crimeType);
                cmd.Parameters.AddWithValue("@crimeDate", c.crimeDate);
                cmd.Parameters.AddWithValue("@location", c.location);
                cmd.Parameters.AddWithValue("@noOfPeopleArrest", c.noOfPeopleArrest);

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

        public void update(Crime c)
        {
            SqlCommand cmd = new SqlCommand(UPDATE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attributes and right side class variables
            cmd.Parameters.AddWithValue("@crimeID", c.crimeID);
            cmd.Parameters.AddWithValue("@crimeDate", c.crimeDate);
            cmd.Parameters.AddWithValue("@crimeType", c.crimeType);
            cmd.Parameters.AddWithValue("@location", c.location);
            cmd.Parameters.AddWithValue("@noOfPeopleArrest", c.noOfPeopleArrest);
            using (con)
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Data updated successfully");
                else
                    MessageBox.Show("something wrong");
            }
        }

        public void delete(Crime c)
        {
            SqlCommand cmd = new SqlCommand(DELETE, DBC.getConnection());
            SqlConnection con = cmd.Connection;
            con.Open();
            //Left side table attribute and right side class variabled
            cmd.Parameters.AddWithValue("@crimeID", c.crimeID);
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

