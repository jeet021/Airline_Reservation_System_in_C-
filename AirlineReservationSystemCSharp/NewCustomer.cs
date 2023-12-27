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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();
            string gen=String.Empty;
            if (RadioButton1.Checked == true)
            {
                 gen = "Male";
            }
            else if(RadioButton2.Checked==true)
            {
                gen = "Female";
            }
            try
            {
                string str = " INSERT INTO cust(name,f_name,gen,dob,mob,addr) VALUES('" + TextBox1.Text  + "','" + TextBox2.Text + "','" + gen + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from cust;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("New Customers Details Inserted Successfully..");

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            
        }
    }
}
