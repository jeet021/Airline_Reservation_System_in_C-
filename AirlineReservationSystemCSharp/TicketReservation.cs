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
    public partial class TicketReservation : Form
    {
        public TicketReservation()
        {
            InitializeComponent();
        }
        int a;

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();

            try
            {
                string str = " INSERT INTO tres(c_id,name,f_name,gen,dob,mob,addr,doj,f_id,seat_no) VALUES('" + TextBox2.Text + "','" + label13.Text  + "','" + label14.Text + "','" + label15.Text + "','" + label16.Text + "','" + label17.Text + "','" + label18.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from tres;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("New Ticket Reservation Details is Inserted Successfully..");

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();

            try
            {
                string getCust = "select name,f_name,gen,dob,mob,addr from cust where id=" + Convert.ToInt32(TextBox2.Text) + " ;";

                SqlCommand cmd = new SqlCommand(getCust, con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label13.Text = dr.GetValue(0).ToString();
                    label14.Text = dr.GetValue(1).ToString();
                    label15.Text = dr.GetValue(2).ToString();
                    label16.Text = dr.GetValue(3).ToString();
                    label17.Text = dr.GetValue(4).ToString();
                    label18.Text = dr.GetValue(5).ToString();
                }
                else
                {
                    MessageBox.Show(" Sorry ,,This ID, " + TextBox1.Text + " record is not Available.   ");
                    TextBox1.Text = "";
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void TicketReservation_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();
            string str1 = "select max(id) from tres;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    TextBox1.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    TextBox1.Text = a.ToString();
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

      
    }
}
