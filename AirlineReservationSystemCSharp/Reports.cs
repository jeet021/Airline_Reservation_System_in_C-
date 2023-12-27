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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

       

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True")) 
                {

                    string str = "SELECT * FROM cust ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }

            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True"))
                {

                    string str = "SELECT * FROM tres";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True"))
                {

                    string str = "SELECT * FROM flight";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True"))
                {

                    string str = "SELECT * FROM cust WHERE Id = '" + TextBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }

            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True"))
                {

                    string str = "SELECT * FROM tres WHERE Id = '" + TextBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True"))
                {

                    string str = "SELECT * FROM flight WHERE Id = '" + TextBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
        }
    }
}
