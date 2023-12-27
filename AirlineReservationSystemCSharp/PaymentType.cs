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
    public partial class PaymentType : Form
    {
        public PaymentType()
        {
            InitializeComponent();
        }
        int a;

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();
            string pay = String.Empty;
            if (RadioButton1.Checked == true)
            {
                pay = "cheque";
            }
            else if (RadioButton2.Checked == true)
            {
                pay = "credit";
            }
            else if (RadioButton3.Checked == true)
            {
                pay = "cash";
            }
            try
            {
                string str = " INSERT INTO payment(c_id,f_id,amount,mod) VALUES('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + pay + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from payment;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Payment Details Inserted Successfully..");

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void PaymentType_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\a\\Desktop\\College\\B.Tech D to D\\Sem 5\\.Net with c#\\AirlineReservationSystemCSharp\\AirlineReservationSystemCSharp\\airline.mdf\";Integrated Security=True");
            con.Open();
            string str1 = "select max(id) from payment;";

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
        }
    }
}
