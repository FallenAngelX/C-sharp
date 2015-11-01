using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chtper3a4
{
    public partial class ShippingChargerForm : Form
    {
        private const decimal SHIPPING_RATE_PER_OZ_Decimal = 0.12m;
        private const decimal SHIPPING_RATE_PER_LB_Decimal = 1.92m;

        public ShippingChargerForm()
        {
            InitializeComponent();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            IDInputtextBox.Clear();
            LBSInputtextBox.Clear();
            OZSInputtextBox.Clear();
            ShippingChargeOutputtextBox.Clear();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            if (IDInputtextBox.Text != "")
            {
                try
                {
                    decimal OzPerPriceDecimal = decimal.Parse(OZSInputtextBox.Text);

                    try
                    {
                        decimal lbsPerPriceDecimal = decimal.Parse(LBSInputtextBox.Text);

                        decimal ozCostDecimal = (OzPerPriceDecimal * SHIPPING_RATE_PER_OZ_Decimal);
                        decimal lbsCostDecimal = (lbsPerPriceDecimal * SHIPPING_RATE_PER_LB_Decimal);
                        decimal TotalCostDecimal = ozCostDecimal + lbsCostDecimal;

                        ShippingChargeOutputtextBox.Text = TotalCostDecimal.ToString("C");
                    }
                    catch
                    {
                        MessageBox.Show("Missing Lbs Input", "Error");
                    }
                }
                catch
                {
                   MessageBox.Show("Missing OZ Input", "Error");
                }
            }
            else
            {
                MessageBox.Show("Missing ID Input", "Error");
            }
        }
    }
}
