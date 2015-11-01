namespace HelloWorld
{
    partial class Form1
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
            this.Displaybutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Messagelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Displaybutton
            // 
            this.Displaybutton.Location = new System.Drawing.Point(94, 182);
            this.Displaybutton.Name = "Displaybutton";
            this.Displaybutton.Size = new System.Drawing.Size(75, 23);
            this.Displaybutton.TabIndex = 0;
            this.Displaybutton.Text = "Display";
            this.Displaybutton.UseVisualStyleBackColor = true;
            this.Displaybutton.Click += new System.EventHandler(this.Displaybutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exitbutton.Location = new System.Drawing.Point(94, 226);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 1;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Messagelabel
            // 
            this.Messagelabel.Location = new System.Drawing.Point(48, 65);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(100, 23);
            this.Messagelabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.Displaybutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exitbutton;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Displaybutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Displaybutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label Messagelabel;
    }
}

