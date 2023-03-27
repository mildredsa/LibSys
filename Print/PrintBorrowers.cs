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
using System.Windows.Forms;

namespace LibSys.Print
{
    public partial class PrintBorrowers : Form
    {
        String connection = "Data Source=LAPTOP-M3IQH77K\\MSASERVER;Initial Catalog=DBS;Integrated Security=True";
        public PrintBorrowers()
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

                // Define the width of each column
                int[] columnWidths = { 350, 150, 150 };

                // Set up the starting position of the first row
                int xPos = 100;
                int yPos = 100;

                // Retrieve data from the database table
                SqlCommand command = new SqlCommand("SELECT * FROM Borrowers", con);
                SqlDataReader reader = command.ExecuteReader();

                // Add the header
                string headerText = "Borrowers List Report";
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

                // Draw the column headers
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    e.Graphics.DrawString(columnName, font, Brushes.Black, xPos, yPos);
                    xPos += columnWidths[i]; // move to the next column
                }

                // Move to the next row
                xPos = 100;
                yPos += rowHeight;

                // Draw the data rows
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        string value = reader.GetValue(i).ToString();
                        e.Graphics.DrawString(value, font, Brushes.Black, xPos, yPos);
                        xPos += columnWidths[i]; // move to the next column
                    }

                    // Move to the next row
                    xPos = 100;
                    yPos += rowHeight;
                }
                reader.Close();

                SqlCommand countBorrowers = new SqlCommand("SELECT COUNT(*) AS total_borrowers FROM Borrowers", con);
                int totalBorrowers = (int)countBorrowers.ExecuteScalar();

                // Add the footer
                Font footerFont = new Font("Arial", 10, FontStyle.Bold);
                string footerText = "Total Borrowers: " + totalBorrowers.ToString();
                SizeF footerSize = e.Graphics.MeasureString(footerText, footerFont);
                float footerXPos = (e.PageBounds.Width - footerSize.Width) / 2; // center the footer horizontally
                float footerYPos = e.PageBounds.Bottom - footerSize.Height - 50; // position the footer near the bottom of the page
                e.Graphics.DrawString(footerText, footerFont, Brushes.Black, footerXPos, footerYPos);

                con.Close();
            }
        }

        private void PrintBorrowers_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Borrowers", con);
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
