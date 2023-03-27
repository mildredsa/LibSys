using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace LibSys.Print
{
    public partial class PrintTransactions : Form
    {
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public PrintTransactions()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintPreviewControl printPreviewControl = new PrintPreviewControl();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                // Set up the font and the height of each row
                Font font = new Font("Arial", 10);
                int rowHeight = font.Height + 5;

                // Define the width of each column as a percentage
                float[] columnWidthPercentages = { 20f, 15f, 25f, 15f, 15f, 15f };

                // Calculate the total width of the table
                float totalWidth = e.PageBounds.Width - 200; // subtracting the left and right margins

                // Calculate the width of each column based on its percentage
                float[] columnWidths = new float[columnWidthPercentages.Length];
                float totalPercentage = columnWidthPercentages.Sum();
                for (int i = 0; i < columnWidthPercentages.Length; i++)
                {
                    columnWidths[i] = totalWidth * (columnWidthPercentages[i] / totalPercentage);
                }

                // Set up the starting position of the first row
                int xPos = 100;
                int yPos = 100;

                // Add the header
                string headerText = "Transactions Report";
                Font headerFont = new Font("Arial", 16, FontStyle.Bold);
                SizeF headerSize = e.Graphics.MeasureString(headerText, headerFont);
                float headerXPos = (e.PageBounds.Width - headerSize.Width) / 2;
                int headerYPos = (int)yPos;
                e.Graphics.DrawString(headerText, headerFont, Brushes.Black, headerXPos, headerYPos);
                yPos += (int)(headerSize.Height + 10); // increase the yPos value by the height of the header and a margin

                // Add the blank line
                string blankLineText = " ";
                Font blankLineFont = new Font("Arial", 12);
                SizeF blankLineSize = e.Graphics.MeasureString(blankLineText, blankLineFont);
                float blankLineXPos = (e.PageBounds.Width - blankLineSize.Width) / 2;
                int blankLineYPos = (int)yPos;
                e.Graphics.DrawString(blankLineText, blankLineFont, Brushes.Black, blankLineXPos, blankLineYPos);
                yPos += (int)(blankLineSize.Height + 5); // increase the yPos value by the height of the blank line and a margin

                // Add the subtitle with the current date
                string subtitleText = "Date: " + DateTime.Now.ToString("MM/dd/yyyy");
                Font subtitleFont = new Font("Arial", 12, FontStyle.Bold);
                SizeF subtitleSize = e.Graphics.MeasureString(subtitleText, subtitleFont);
                float subtitleXPos = (e.PageBounds.Width - subtitleSize.Width) / 2;
                int subtitleYPos = (int)yPos;
                e.Graphics.DrawString(subtitleText, subtitleFont, Brushes.Black, subtitleXPos, subtitleYPos);
                yPos += (int)(subtitleSize.Height + 5); // increase the yPos value by the height of the subtitle and a margin

                // Add the column headers
                string[] columnHeaders = { "Username", "Accession\n Number", "Title", "Author", "Date\n Borrowed", "Date\n Returned" };
                Font columnHeaderFont = new Font("Arial", 12, FontStyle.Bold);
                int columnHeaderYPos = yPos;
                for (int i = 0; i < columnWidths.Length; i++)
                {
                    string columnHeader = columnHeaders[i];
                    SizeF columnHeaderSize = e.Graphics.MeasureString(columnHeader, columnHeaderFont);
                    float columnHeaderXPos = xPos + (columnWidths.Take(i).Sum());
                    e.Graphics.DrawString(columnHeader, columnHeaderFont, Brushes.Black, columnHeaderXPos, columnHeaderYPos);
                }
                yPos += (int)(columnHeaderFont.Height + 20); // increase the yPos value by the height of the column headers and a margin

                // Add the data rows
                Font dataFont = new Font("Arial", 10);
                SolidBrush dataBrush = new SolidBrush(Color.Black);
                int rowIndex = 0;
                while (rowIndex < grid.Rows.Count)
                {
                    DataGridViewRow dataGridViewRow = grid.Rows[rowIndex];

                    // Skip the row if it is hidden
                    if (!dataGridViewRow.Visible)
                    {
                        rowIndex++;
                        continue;
                    }

                    float xPosition = xPos;
                    for (int i = 0; i < columnWidths.Length; i++)
                    {
                        string cellValue = dataGridViewRow.Cells[i].FormattedValue.ToString();
                        SizeF cellSize = e.Graphics.MeasureString(cellValue, dataFont);
                        e.Graphics.DrawString(cellValue, dataFont, dataBrush, xPosition, yPos);

                        xPosition += columnWidths[i];
                    }

                    rowIndex++;
                    yPos += rowHeight; // increase the yPos value by the height of the row and a margin
                }

                SqlCommand countTransactions = new SqlCommand("SELECT COUNT(*) AS total_transactions FROM transactions", con);
                int totalTransactions = (int)countTransactions.ExecuteScalar();

                // Add the footer
                Font footerFont = new Font("Arial", 10, FontStyle.Bold);
                string footerText = "Total Transactions: " + totalTransactions.ToString();
                SizeF footerSize = e.Graphics.MeasureString(footerText, footerFont);
                float footerXPos = (e.PageBounds.Width - footerSize.Width) / 2; // center the footer horizontally
                float footerYPos = e.PageBounds.Bottom - footerSize.Height - 50; // position the footer near the bottom of the page
                e.Graphics.DrawString(footerText, footerFont, Brushes.Black, footerXPos, footerYPos);

                con.Close();
            }
        }





        private void PrintTransactions_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Transactions", con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                grid.DataSource = dt;
                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
