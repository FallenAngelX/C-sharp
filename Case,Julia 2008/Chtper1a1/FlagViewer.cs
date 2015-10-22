using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chtper1a1
{
    public partial class FlagViewer : Form
    {
        public FlagViewer()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            //-> close app
            this.Close();
        }

        private void USAFlagDisplaybutton_Click(object sender, EventArgs e)
        {
            FlagpictureBox.Image = Properties.Resources.usa;
            Textlabel.Text = " USA ";
        }

        private void CanadaFlagDisplaybutton_Click(object sender, EventArgs e)
        {
            FlagpictureBox.Image = Properties.Resources.canada;
            Textlabel.Text = " Canada ";
        }

        private void JapanFlagDisplaybutton_Click(object sender, EventArgs e)
        {
            FlagpictureBox.Image = Properties.Resources.japan;
            Textlabel.Text = " Japan ";
        }

        private void MexicoFlagDisplaybutton_Click(object sender, EventArgs e)
        {
            FlagpictureBox.Image = Properties.Resources.mexico;
            Textlabel.Text = " Mexico ";
        }
    }
}
