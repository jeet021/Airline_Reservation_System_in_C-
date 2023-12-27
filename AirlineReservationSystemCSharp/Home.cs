using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystemCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer obj = new NewCustomer();
            obj.ShowDialog();
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFlight obj1 = new NewFlight();
            obj1.ShowDialog();
        }

        private void ticketReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketReservation obj2 = new TicketReservation();
            obj2.ShowDialog();
        }

        private void paymentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentType obj3 = new PaymentType();
            obj3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports obj4 = new Reports();
            obj4.ShowDialog();
        }
    }
}
