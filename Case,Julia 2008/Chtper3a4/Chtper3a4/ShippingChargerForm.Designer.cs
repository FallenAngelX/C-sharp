namespace Chtper3a4
{
    partial class ShippingChargerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDInputtextBox = new System.Windows.Forms.TextBox();
            this.LBSInputtextBox = new System.Windows.Forms.TextBox();
            this.OZSInputtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShippingChargeOutputtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(76, 284);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(75, 23);
            this.Calculatebutton.TabIndex = 0;
            this.Calculatebutton.Text = "&Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(76, 313);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 23);
            this.Clearbutton.TabIndex = 1;
            this.Clearbutton.Text = "C&lear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(76, 342);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "E&xit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OZSInputtextBox);
            this.groupBox1.Controls.Add(this.LBSInputtextBox);
            this.groupBox1.Controls.Add(this.IDInputtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lbs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ozs:";
            // 
            // IDInputtextBox
            // 
            this.IDInputtextBox.Location = new System.Drawing.Point(54, 25);
            this.IDInputtextBox.Name = "IDInputtextBox";
            this.IDInputtextBox.Size = new System.Drawing.Size(100, 20);
            this.IDInputtextBox.TabIndex = 3;
            // 
            // LBSInputtextBox
            // 
            this.LBSInputtextBox.Location = new System.Drawing.Point(54, 55);
            this.LBSInputtextBox.Name = "LBSInputtextBox";
            this.LBSInputtextBox.Size = new System.Drawing.Size(100, 20);
            this.LBSInputtextBox.TabIndex = 4;
            // 
            // OZSInputtextBox
            // 
            this.OZSInputtextBox.Location = new System.Drawing.Point(54, 86);
            this.OZSInputtextBox.Name = "OZSInputtextBox";
            this.OZSInputtextBox.Size = new System.Drawing.Size(100, 20);
            this.OZSInputtextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shipping Charge:";
            // 
            // ShippingChargeOutputtextBox
            // 
            this.ShippingChargeOutputtextBox.Location = new System.Drawing.Point(66, 174);
            this.ShippingChargeOutputtextBox.Name = "ShippingChargeOutputtextBox";
            this.ShippingChargeOutputtextBox.ReadOnly = true;
            this.ShippingChargeOutputtextBox.Size = new System.Drawing.Size(100, 20);
            this.ShippingChargeOutputtextBox.TabIndex = 5;
            // 
            // ShippingChargerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 383);
            this.Controls.Add(this.ShippingChargeOutputtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Calculatebutton);
            this.Name = "ShippingChargerForm";
            this.Text = "Shipping Charge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OZSInputtextBox;
        private System.Windows.Forms.TextBox LBSInputtextBox;
        private System.Windows.Forms.TextBox IDInputtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ShippingChargeOutputtextBox;
    }
}

