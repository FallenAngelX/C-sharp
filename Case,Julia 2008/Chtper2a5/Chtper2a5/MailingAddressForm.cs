using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chtper2a5
{
    public partial class MailingAddressForm : Form
    {
        public MailingAddressForm()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayInfobutton_Click(object sender, EventArgs e)
        {
            MailingLabelOutPuttextBox.Text = FirstNametextBox.Text + " " + LastNametextBox.Text + Environment.NewLine + StreetAddresstextBox.Text + Environment.NewLine +
                                                CitytextBox.Text + ", " + StatetextBox.Text + Environment.NewLine + ZipCodemaskedTextBox.Text;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            FirstNametextBox.Clear();
            LastNametextBox.Clear();
            StreetAddresstextBox.Clear();
            CitytextBox.Clear();
            StatetextBox.Clear();
            ZipCodemaskedTextBox.Clear();
            FirstNametextBox.Focus();

            // Clear output text box
            MailingLabelOutPuttextBox.Clear();
        }
    }
}
