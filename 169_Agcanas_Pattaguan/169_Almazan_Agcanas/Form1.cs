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
    public partial class Form1 : Form
    {
        int item1 = 120, item2 = 110, item3 = 125, item4 = 150, item5 = 90, item6 = 135, item7 = 155, item8 = 162;
       
       

        private void chkCreamy_CheckedChanged(object sender, EventArgs e)
        {
            #region MyRegion
            if (!chkCreamy.Checked)
            {
                nud1.Enabled = false;
                nud1.Value = 0;
            }
            else
            {
                nud1.Enabled = true;
                nud1.Value = 1;
            }
        }
        private void chkSalted_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSalted.Checked)
            {
                nud2.Enabled = false;
                nud2.Value = 0;
            }
            else
            {
                nud2.Enabled = true;
                nud2.Value = 1;
            }
        }
        private void chkVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkVanilla.Checked)
            {
                nud3.Enabled = false;
                nud3.Value = 0;
            }
            else
            {
                nud3.Enabled = true;
                nud3.Value = 1;
            }
        }

        private void chkBurnt_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBurnt.Checked)
            {
                nud4.Enabled = false;
                nud4.Value = 0;
            }
            else
            {
                nud4.Enabled = true;
                nud4.Value = 1;
            }
        }
        private void chkHot_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkHot.Checked)
            {
                nud5.Enabled = false;
                nud5.Value = 0;
            }
            else
            {
                nud5.Enabled = true;
                nud5.Value = 1;
            }
        }
        private void chkIced_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkIced.Checked)
            {
                nud6.Enabled = false;
                nud6.Value = 0;
            }
            else
            {
                nud6.Enabled = true;
                nud6.Value = 1;
            }
        }
        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkGreen.Checked)
            {
                nud7.Enabled = false;
                nud7.Value = 0;
            }
            else
            {
                nud7.Enabled = true;
                nud7.Value = 1;
            }
        }

        private void chkJava_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkJava.Checked)
            {
                nud8.Enabled = false;
                nud8.Value = 0;
            }
            else
            {
                nud8.Enabled = true;
                nud8.Value = 1;
            }
        } 
        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            #region MyRegion
            chkCreamy.Checked = false;
            chkSalted.Checked = false;
            chkVanilla.Checked = false;
            chkBurnt.Checked = false;
            chkHot.Checked = false;
            chkIced.Checked = false;
            chkGreen.Checked = false;
            chkJava.Checked = false;
            rdDine.Checked = false;
            rdGo.Checked = false;

            nud1.Value = 0;
            nud2.Value = 0;
            nud3.Value = 0;
            nud4.Value = 0;
            nud5.Value = 0;
            nud6.Value = 0;
            nud7.Value = 0;
            nud8.Value = 0;

            lblTotal.Text = "Total: ";
            lblPoints.Text = "Points: "; 
            #endregion
        }


        int discount = 50;
        int addFee = 10;
        

        public Form1()
        {
            InitializeComponent();     
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
           
            #region MyRegion
            double total = 0;
            double pts = 0.03;
            

            DataTable dt = new DataTable();
            dt.Columns.Add("Item Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Total");


            if (chkCreamy.Checked)
            {
                total += item1 * (int)nud1.Value;
                dt.Rows.Add("Creamy Caramel Latte", nud1.Value, nud1.Value * item1);
                

            }
            if (chkSalted.Checked)
            {
                total += item2 * (int)nud2.Value;
                dt.Rows.Add("Salted Caramel Cold Brew", nud2.Value, nud2.Value * item2);
            }
            if (chkVanilla.Checked)
            {
                total += item3 * (int)nud3.Value;
                dt.Rows.Add("Vanilla Sweet Cream Cold Brew", nud3.Value, nud3.Value * item3);
            }
            if (chkBurnt.Checked)
            {
                total += item4 * (int)nud4.Value;
                dt.Rows.Add("Burnt Caramel Oatmilk Latte", nud4.Value, nud4.Value * item4);
            }
            if (chkHot.Checked)
            {
                total += item5 * (int)nud5.Value;
                dt.Rows.Add("How Brewed Coffee", nud5.Value, nud5.Value * item5);
            }
            if (chkIced.Checked)
            {
                total += item6 * (int)nud6.Value;
                dt.Rows.Add("Iced Caramel Macchiato", nud6.Value, nud6.Value * item6);
            }
            if (chkGreen.Checked)
            {
                total += item7 * (int)nud7.Value;
                dt.Rows.Add("Green Tea Cream Capuccino", nud7.Value, nud7.Value * item7);
            }
            if (chkJava.Checked)
            {
                total += item8 * (int)nud8.Value;
                dt.Rows.Add("Java Chip Frappuccino", nud8.Value, nud8.Value * item8);
            }
            #endregion

            #region MyRegion
            if (chkMember.Checked)
            {
                if (rdDine.Checked)
                {
                    total -= discount;
                }
                else
                {
                    total -= discount;
                    total += addFee;
                }
            }
            else
            {
                if (rdGo.Checked)
                {
                    total += addFee;
                }
            }
            #endregion

            #region MyRegion


            double ptsEarned = 0;

            if (!chkCreamy.Checked && !chkSalted.Checked && !chkVanilla.Checked && !chkBurnt.Checked && !chkHot.Checked && !chkIced.Checked && !chkGreen.Checked && !chkJava.Checked)
            {
                MessageBox.Show("Bumili ka ng kape!!!", "Pumili ka!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (chkMember.Checked)
                {
                    if (rdDine.Checked || rdGo.Checked)
                    {
                        lblTotal.Text = "Total: " + total.ToString();
                        ptsEarned = total * pts;
                        lblPoints.Text = "Points: " + ptsEarned.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Dito here?", "Ober der", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                else
                {
                    if (rdDine.Checked || rdGo.Checked)
                    {
                        lblTotal.Text = "Total: " + total.ToString();
                        lblPoints.Text = "Points: 0";
                    }
                    else
                    {
                        MessageBox.Show("Dito here?", "Ober der", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            #endregion
            Form2 frm2 = new Form2 (total, dt, chkMember.Checked, rdDine.Checked, ptsEarned);
            frm2.ShowDialog();


        }

    }

}
