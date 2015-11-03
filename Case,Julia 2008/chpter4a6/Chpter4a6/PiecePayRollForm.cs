using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chpter4a6
{
    public partial class PiecePayRollForm : Form
    {
        // Values for pieces Completed --> these could be const
        private decimal PiecesCompleted_1_199_Decimal = 0.50m;
        private decimal PiecesCompleted_200_399_Decimal = 0.55m;
        private decimal PiecesCompleted_400_599_Decimal = 0.60m;
        private decimal PiecesCompleted_600_Plus_Decimal = 0.65m;

        // Totals for Summary
        private int TOTALPAYEES_Integer;
        private decimal TOTALPAYEES_PAYOUT_Decimal;
        private int TOTALPIECESCOMPLETED_Integer;

        public PiecePayRollForm()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }

        private void ClearSummaryInfobutton_Click(object sender, EventArgs e)
        {
            // disable the summary result button
            payrollSummaryResultbutton.Enabled = false;
            // zero out the total variables
            TOTALPAYEES_Integer = 0;
            TOTALPAYEES_PAYOUT_Decimal = 0;
            TOTALPIECESCOMPLETED_Integer = 0;

            // A LITTLE BIT OF DEBUG CODE
            Console.WriteLine("Total Employees  \n" + TOTALPAYEES_Integer);
            Console.WriteLine("Total Pay Out  \n" + TOTALPAYEES_PAYOUT_Decimal);
            Console.WriteLine("Total Pieces Done  \n" + TOTALPIECESCOMPLETED_Integer);
        }

        private void clearInputInfobutton_Click(object sender, EventArgs e)
        {
            // clear input boxes
            employeePayeeNametextBox.Clear();
            piecesCompletedtextBox.Clear();
            PayRollPayOuttextBox.Clear();

            // place insertion in name box
            employeePayeeNametextBox.Focus();
        }

        private void calculateInfoInputbutton_Click(object sender, EventArgs e)
        {
            // test to make sure text boxes are not empty
            if (employeePayeeNametextBox.Text != "" | piecesCompletedtextBox.Text != "")
            {
                try
                {
                    int piecesDoneInteger = int.Parse(piecesCompletedtextBox.Text);
                    decimal payRollOutPutDecimal;

                    // now that we have data for summary we can enable it (before summary doesnt have data)
                    payrollSummaryResultbutton.Enabled = true;

                    if (piecesDoneInteger < 199)
                    {
                        PayRollPayOuttextBox.Text = ((piecesDoneInteger * PiecesCompleted_1_199_Decimal).ToString("C"));
                        payRollOutPutDecimal = (piecesDoneInteger * PiecesCompleted_1_199_Decimal);
                    }
                    else if (piecesDoneInteger < 399)
                    {
                        PayRollPayOuttextBox.Text = ((piecesDoneInteger * PiecesCompleted_200_399_Decimal).ToString("C"));
                        payRollOutPutDecimal = (piecesDoneInteger * PiecesCompleted_200_399_Decimal);
                    }
                    else if (piecesDoneInteger < 599)
                    {
                        PayRollPayOuttextBox.Text = ((piecesDoneInteger * PiecesCompleted_400_599_Decimal).ToString("C"));
                        payRollOutPutDecimal = (piecesDoneInteger * PiecesCompleted_400_599_Decimal);
                    }
                    else
                    {
                        PayRollPayOuttextBox.Text = ((piecesDoneInteger * PiecesCompleted_600_Plus_Decimal).ToString("C"));
                        payRollOutPutDecimal = (piecesDoneInteger * PiecesCompleted_600_Plus_Decimal);
                    }

                    TOTALPAYEES_Integer++;
                    TOTALPIECESCOMPLETED_Integer += piecesDoneInteger;
                    TOTALPAYEES_PAYOUT_Decimal += payRollOutPutDecimal;

                    // A LITTLE BIT OF DEBUG CODE
                    Console.WriteLine("Total Employees  \n" + TOTALPAYEES_Integer);
                    Console.WriteLine("Total Pay Out  \n" + TOTALPAYEES_PAYOUT_Decimal);
                    Console.WriteLine("Total Pieces Done  \n" + TOTALPIECESCOMPLETED_Integer);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Error, Incorrect Data In Data Input fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, Missing Input fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payrollSummaryResultbutton_Click(object sender, EventArgs e)
        {
            string SummaryData_String = "Total Employees Paid:     " + TOTALPAYEES_Integer.ToString() + "\n\n" +
                                        "Total PayRoll Paid:      " + TOTALPAYEES_PAYOUT_Decimal.ToString("C") + "\n\n" +
                                        "Total Pieces Complete:   " + TOTALPIECESCOMPLETED_Integer.ToString();

            // Show Summary Data
            MessageBox.Show(SummaryData_String, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
