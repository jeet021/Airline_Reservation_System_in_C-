using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirlineReservationSystemCSharp
{
    public partial class NewFlight : Form
    {
        public NewFlight()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();

            try
            {
                string str = " INSERT INTO flight(f_name,source,dest,dep_time,arr_time,clas,charg,seats) VALUES('" + TextBox2.Text + "','" + ComboBox1.Text + "','" + ComboBox3.Text + "','" + ComboBox2.Text + "','" + ComboBox4.Text + "','" + ComboBox5.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from flight;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("New Flight Details Inserted Successfully..");

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();

            try
            {
                string getCust = "select f_name,source,dest,dep_time,arr_time,clas,charg,seats from flight where id=" + Convert.ToInt32(TextBox1.Text) + " ;";

                SqlCommand cmd = new SqlCommand(getCust, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TextBox2.Text = dr.GetValue(0).ToString();
                    ComboBox1.Text = dr.GetValue(1).ToString();
                    ComboBox3.Text = dr.GetValue(2).ToString();
                    ComboBox2.Text = dr.GetValue(3).ToString();
                    ComboBox4.Text = dr.GetValue(4).ToString();
                    ComboBox5.Text = dr.GetValue(5).ToString();
                    TextBox3.Text = dr.GetValue(6).ToString();
                    TextBox4.Text = dr.GetValue(7).ToString();
                    

                }
                else
                {
                    MessageBox.Show(" Sorry ,,This ID, " + TextBox1.Text + " Flight is not Available.   ");
                    TextBox1.Text = "";
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();
            try
            {
                string str = " Update flight set f_name='" + TextBox2.Text + "',source='" + ComboBox1.Text + "',dest='" + ComboBox3.Text + "',dep_time='" + ComboBox2.Text + "',arr_time='" + ComboBox4.Text + "',clas='" + ComboBox5.Text + "',charg='" + TextBox3.Text + "',seats='" + TextBox4.Text  + "' where id='" + TextBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from flight;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Flight number " + TextBox1.Text + "'s Details is Updated Successfully.. ", "Important Message");
                    this.Hide();

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
                con.Open();

                string str = "DELETE FROM flight WHERE id = '" + TextBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Flight Record Delete Successfully");
                this.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Please Enter Flight Id..");
            }
        }
    }
}

