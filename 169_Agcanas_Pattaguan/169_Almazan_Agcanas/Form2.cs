using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _169_Almazan_Agcanas
{
    public partial class Form2 : Form
    {
        double totalAmt, payment, change, ptsEarned;
        bool chkMember, rdDine;

        DataTable dt = new DataTable();
        public Form2(double _total, DataTable _dt, bool _member, bool _dine, double _points)
        {
            InitializeComponent();
            totalAmt = _total;
            dt = _dt;
            chkMember = _member;
            rdDine = _dine;
            ptsEarned = _points;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "Total Amount: " + totalAmt.ToString();
            lblPoints.Text = "Points Earned: " + ptsEarned.ToString();

            dtgrItems.DataSource = dt;
            
            if (chkMember)
            {
                lblMember.Text = "Membership: " + "oo";
            }
                else
                {
                lblMember.Text = "Memberbship: " + "hinde";
                }

            if (rdDine)
            {
                lblDine.Text = "Dine: " + "here na for sure!";
            } else
            {
                lblDine.Text = "Dine: " + "take out muna lods!";
            }


        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            payment = int.Parse(txtPay.Text);

            if (payment < totalAmt)
            {
                MessageBox.Show("Insufficient amount entered.");
            } else
            {
                change = payment - totalAmt;
                MessageBox.Show("Item/s purchased successfully." + "\nTotal Amount: " + totalAmt + "\nPayment Amount: " + payment + "\n Change: " + change);
            }
        }

    }
}
