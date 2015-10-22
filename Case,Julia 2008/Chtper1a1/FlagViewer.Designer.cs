namespace Chtper1a1
{
    partial class FlagViewer
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
            this.USAFlagDisplaybutton = new System.Windows.Forms.Button();
            this.CanadaFlagDisplaybutton = new System.Windows.Forms.Button();
            this.JapanFlagDisplaybutton = new System.Windows.Forms.Button();
            this.MexicoFlagDisplaybutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Textlabel = new System.Windows.Forms.Label();
            this.FlagpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FlagpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // USAFlagDisplaybutton
            // 
            this.USAFlagDisplaybutton.Location = new System.Drawing.Point(12, 344);
            this.USAFlagDisplaybutton.Name = "USAFlagDisplaybutton";
            this.USAFlagDisplaybutton.Size = new System.Drawing.Size(75, 23);
            this.USAFlagDisplaybutton.TabIndex = 1;
            this.USAFlagDisplaybutton.Text = "U&SA";
            this.USAFlagDisplaybutton.UseVisualStyleBackColor = true;
            this.USAFlagDisplaybutton.Click += new System.EventHandler(this.USAFlagDisplaybutton_Click);
            // 
            // CanadaFlagDisplaybutton
            // 
            this.CanadaFlagDisplaybutton.Location = new System.Drawing.Point(105, 344);
            this.CanadaFlagDisplaybutton.Name = "CanadaFlagDisplaybutton";
            this.CanadaFlagDisplaybutton.Size = new System.Drawing.Size(75, 23);
            this.CanadaFlagDisplaybutton.TabIndex = 2;
            this.CanadaFlagDisplaybutton.Text = "&Canada";
            this.CanadaFlagDisplaybutton.UseVisualStyleBackColor = true;
            this.CanadaFlagDisplaybutton.Click += new System.EventHandler(this.CanadaFlagDisplaybutton_Click);
            // 
            // JapanFlagDisplaybutton
            // 
            this.JapanFlagDisplaybutton.Location = new System.Drawing.Point(271, 344);
            this.JapanFlagDisplaybutton.Name = "JapanFlagDisplaybutton";
            this.JapanFlagDisplaybutton.Size = new System.Drawing.Size(75, 23);
            this.JapanFlagDisplaybutton.TabIndex = 3;
            this.JapanFlagDisplaybutton.Text = "&Japan";
            this.JapanFlagDisplaybutton.UseVisualStyleBackColor = true;
            this.JapanFlagDisplaybutton.Click += new System.EventHandler(this.JapanFlagDisplaybutton_Click);
            // 
            // MexicoFlagDisplaybutton
            // 
            this.MexicoFlagDisplaybutton.Location = new System.Drawing.Point(361, 344);
            this.MexicoFlagDisplaybutton.Name = "MexicoFlagDisplaybutton";
            this.MexicoFlagDisplaybutton.Size = new System.Drawing.Size(75, 23);
            this.MexicoFlagDisplaybutton.TabIndex = 4;
            this.MexicoFlagDisplaybutton.Text = "&Mexico";
            this.MexicoFlagDisplaybutton.UseVisualStyleBackColor = true;
            this.MexicoFlagDisplaybutton.Click += new System.EventHandler(this.MexicoFlagDisplaybutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(189, 379);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 5;
            this.Exitbutton.Text = "E&xit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Textlabel
            // 
            this.Textlabel.Location = new System.Drawing.Point(89, 284);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(268, 46);
            this.Textlabel.TabIndex = 6;
            this.Textlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlagpictureBox
            // 
            this.FlagpictureBox.Location = new System.Drawing.Point(12, 12);
            this.FlagpictureBox.Name = "FlagpictureBox";
            this.FlagpictureBox.Size = new System.Drawing.Size(425, 258);
            this.FlagpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlagpictureBox.TabIndex = 0;
            this.FlagpictureBox.TabStop = false;
            // 
            // FlagViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 415);
            this.Controls.Add(this.Textlabel);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.MexicoFlagDisplaybutton);
            this.Controls.Add(this.JapanFlagDisplaybutton);
            this.Controls.Add(this.CanadaFlagDisplaybutton);
            this.Controls.Add(this.USAFlagDisplaybutton);
            this.Controls.Add(this.FlagpictureBox);
            this.Name = "FlagViewer";
            this.Text = "Flag Viewer 2000";
            ((System.ComponentModel.ISupportInitialize)(this.FlagpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FlagpictureBox;
        private System.Windows.Forms.Button USAFlagDisplaybutton;
        private System.Windows.Forms.Button CanadaFlagDisplaybutton;
        private System.Windows.Forms.Button JapanFlagDisplaybutton;
        private System.Windows.Forms.Button MexicoFlagDisplaybutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label Textlabel;
    }
}

