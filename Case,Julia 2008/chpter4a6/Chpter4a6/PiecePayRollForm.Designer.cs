namespace Chpter4a6
{
    partial class PiecePayRollForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearInputInfobutton = new System.Windows.Forms.Button();
            this.calculateInfoInputbutton = new System.Windows.Forms.Button();
            this.piecesCompletedtextBox = new System.Windows.Forms.TextBox();
            this.employeePayeeNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.payrollSummaryResultbutton = new System.Windows.Forms.Button();
            this.PayRollPayOuttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearSummaryInfobutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearInputInfobutton);
            this.groupBox1.Controls.Add(this.calculateInfoInputbutton);
            this.groupBox1.Controls.Add(this.piecesCompletedtextBox);
            this.groupBox1.Controls.Add(this.employeePayeeNametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // clearInputInfobutton
            // 
            this.clearInputInfobutton.Location = new System.Drawing.Point(21, 142);
            this.clearInputInfobutton.Name = "clearInputInfobutton";
            this.clearInputInfobutton.Size = new System.Drawing.Size(138, 23);
            this.clearInputInfobutton.TabIndex = 4;
            this.clearInputInfobutton.Text = "C&lear Input Info";
            this.clearInputInfobutton.UseVisualStyleBackColor = true;
            this.clearInputInfobutton.Click += new System.EventHandler(this.clearInputInfobutton_Click);
            // 
            // calculateInfoInputbutton
            // 
            this.calculateInfoInputbutton.Location = new System.Drawing.Point(21, 113);
            this.calculateInfoInputbutton.Name = "calculateInfoInputbutton";
            this.calculateInfoInputbutton.Size = new System.Drawing.Size(138, 23);
            this.calculateInfoInputbutton.TabIndex = 4;
            this.calculateInfoInputbutton.Text = "C&alculate Payroll";
            this.calculateInfoInputbutton.UseVisualStyleBackColor = true;
            this.calculateInfoInputbutton.Click += new System.EventHandler(this.calculateInfoInputbutton_Click);
            // 
            // piecesCompletedtextBox
            // 
            this.piecesCompletedtextBox.Location = new System.Drawing.Point(111, 76);
            this.piecesCompletedtextBox.Name = "piecesCompletedtextBox";
            this.piecesCompletedtextBox.Size = new System.Drawing.Size(48, 20);
            this.piecesCompletedtextBox.TabIndex = 3;
            // 
            // employeePayeeNametextBox
            // 
            this.employeePayeeNametextBox.Location = new System.Drawing.Point(59, 36);
            this.employeePayeeNametextBox.Name = "employeePayeeNametextBox";
            this.employeePayeeNametextBox.Size = new System.Drawing.Size(100, 20);
            this.employeePayeeNametextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "#Completed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.payrollSummaryResultbutton);
            this.groupBox2.Controls.Add(this.PayRollPayOuttextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(40, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // payrollSummaryResultbutton
            // 
            this.payrollSummaryResultbutton.Enabled = false;
            this.payrollSummaryResultbutton.Location = new System.Drawing.Point(21, 80);
            this.payrollSummaryResultbutton.Name = "payrollSummaryResultbutton";
            this.payrollSummaryResultbutton.Size = new System.Drawing.Size(104, 23);
            this.payrollSummaryResultbutton.TabIndex = 2;
            this.payrollSummaryResultbutton.Text = "PayRoll &Summary Info";
            this.payrollSummaryResultbutton.UseVisualStyleBackColor = true;
            this.payrollSummaryResultbutton.Click += new System.EventHandler(this.payrollSummaryResultbutton_Click);
            // 
            // PayRollPayOuttextBox
            // 
            this.PayRollPayOuttextBox.Location = new System.Drawing.Point(59, 32);
            this.PayRollPayOuttextBox.Name = "PayRollPayOuttextBox";
            this.PayRollPayOuttextBox.ReadOnly = true;
            this.PayRollPayOuttextBox.Size = new System.Drawing.Size(66, 20);
            this.PayRollPayOuttextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pay:";
            // 
            // ClearSummaryInfobutton
            // 
            this.ClearSummaryInfobutton.Location = new System.Drawing.Point(12, 334);
            this.ClearSummaryInfobutton.Name = "ClearSummaryInfobutton";
            this.ClearSummaryInfobutton.Size = new System.Drawing.Size(199, 23);
            this.ClearSummaryInfobutton.TabIndex = 2;
            this.ClearSummaryInfobutton.Text = "&Clear Summary Info";
            this.ClearSummaryInfobutton.UseVisualStyleBackColor = true;
            this.ClearSummaryInfobutton.Click += new System.EventHandler(this.ClearSummaryInfobutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(12, 363);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(199, 23);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "E&xit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // PiecePayRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 394);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.ClearSummaryInfobutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PiecePayRollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piece Work Payroll";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearInputInfobutton;
        private System.Windows.Forms.Button calculateInfoInputbutton;
        private System.Windows.Forms.TextBox piecesCompletedtextBox;
        private System.Windows.Forms.TextBox employeePayeeNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button payrollSummaryResultbutton;
        private System.Windows.Forms.TextBox PayRollPayOuttextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearSummaryInfobutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

