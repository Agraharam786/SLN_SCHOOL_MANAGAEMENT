using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SLN_FEE_MANAGEMENT.Forms
{
    public partial class EmailForm : Form
    {
        private SLN_FEE_MANAGEMENT.DbHelper dbHelper;
        public EmailForm()
        {
            InitializeComponent();
            dbHelper = new DbHelper();
        }

        private void senEmailButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch email settings from App.config
                string fromEmail = ConfigurationManager.AppSettings["FromEmail"];
                string toEmail = ConfigurationManager.AppSettings["ToEmail"];
                string smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
                int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
                string emailPassword = ConfigurationManager.AppSettings["EmailPassword"];
                string emailTriggeredFrom = this.EmailFromComboBox.SelectedItem.ToString();
                string reportType = "Daily";
                string financialTableRows = string.Empty;
                string collectionSummary= string.Empty;
                string expenseSummary = string.Empty;
                string FeeSummary = string.Empty;
                string BankTransactionSummary = string.Empty;
                string ClassWiseFeeSummary = string.Empty;
                if (!string.IsNullOrEmpty(this.ReoprtTypeComboBox.SelectedItem.ToString()))
                {
                    reportType = this.ReoprtTypeComboBox.SelectedItem.ToString();
                }
                
                if(reportType.Equals("Daily"))
                {
                    financialTableRows = GetDynamicTableData(Common.EmailSummaryProcedure);
                    collectionSummary = GetDynamicTableData(Common.WeeklyCollectionSummaryProcedure);
                    expenseSummary = GetDynamicTableData(Common.WeeklyExpenseSummaryProcedure);
                    FeeSummary = GetDynamicTableData(Common.WeeklyFeeSummaryProcedure);
                    ClassWiseFeeSummary = GetDynamicTableData(Common.DailyFeeClassWiseSummaryProcedure);
                    BankTransactionSummary = GetDynamicTableData(Common.DailyBankTransactionSummaryProcedure);
                }
                else if(reportType.Equals("Weekly"))
                {
                    financialTableRows = GetDynamicTableData(Common.EmailSummaryProcedure);
                    collectionSummary = GetDynamicTableData(Common.WeeklyCollectionSummaryProcedure);
                    expenseSummary = GetDynamicTableData(Common.WeeklyExpenseSummaryProcedure);
                    FeeSummary = GetDynamicTableData(Common.WeeklyFeeSummaryProcedure);
                    ClassWiseFeeSummary = GetDynamicTableData(Common.WeeklyClasswiseFeeSummaryProcedure);
                    BankTransactionSummary = GetDynamicTableData(Common.WeeklyBankTransactionSummaryProcedure);
                }
                else if(reportType.Equals("Monthly"))
                {
                    // Get dynamic table rows for the financial summary table
                    financialTableRows = GetDynamicTableData(Common.EmailSummaryProcedure);
                    collectionSummary = GetDynamicTableData(Common.MonthlyCollectionSummaryProcedure);
                    expenseSummary = GetDynamicTableData(Common.MonthlyExpenseSummaryProcedure);
                    FeeSummary = GetDynamicTableData(Common.MonthlyFeeSummaryProcedure);
                    ClassWiseFeeSummary = GetDynamicTableData(Common.ClassandMonthlyFeeSummaryProcedure);
                    BankTransactionSummary = GetDynamicTableData(Common.MonthlyTransactionSummary);
                }
                else
                {
                    financialTableRows = GetDynamicTableData(Common.EmailSummaryProcedure);
                    collectionSummary = GetDynamicTableData(Common.WeeklyCollectionSummaryProcedure);
                    expenseSummary = GetDynamicTableData(Common.WeeklyExpenseSummaryProcedure);
                    FeeSummary = GetDynamicTableData(Common.WeeklyFeeSummaryProcedure);
                    ClassWiseFeeSummary = GetDynamicTableData(Common.DailyFeeClassWiseSummaryProcedure);
                    BankTransactionSummary = GetDynamicTableData(Common.DailyBankTransactionSummaryProcedure);
                }

               

                // Define the subject of the email
                string subject = "Email Initiated From - " + emailTriggeredFrom + ": SLN "+ reportType +" Financial Report As of " + DateTime.Today.ToString("yyyy/MM/dd");

                string htmlTemplate = @"
                  <!DOCTYPE html>
                  <html>
                  <head>
                      <style>
                          /* General table styles */
                          table {
                              width: 100%;
                              border-collapse: collapse;
                              font-size: 36px; /* Increased font size for the entire table */
                          }
                          table, th, td {
                              border: 1px solid black;
                          }
                          th {
                              padding: 12px;
                              text-align: center;
                              font-size: 36px; /* Increased font size for table header */
                              background-color: #4CAF50; /* Green background for header */
                              color: white; /* White text for the header */
                              font-weight: bold; /* Make header text bold */
                          }
                          td {
                              padding: 12px;
                              text-align: center;
                              font-size: 36px; /* Increased font size for table data cells */
                              color: #333; /* Dark text color for table data */
                              font-weight: bold; /* Make table rows bold */
                          }
                          tr:nth-child(even) {
                              background-color: #f2f2f2; /* Light gray for even rows */
                          }
                          tr:nth-child(odd) {
                              background-color: #ffffff; /* White for odd rows */
                          }

                          .default-section {
                               /* background-color: #ADD8E6; Light blue background for other sections */
                              color: #333; /* Dark text color for other sections */
                              padding: 12px;
                              font-size: 34px; /* Larger font for section titles */
                              font-weight: bold;
                          }

                          h3 {
                              color: #FF5733; /* Updated to reddish-orange color for h3 */
                              font-family: Arial, sans-serif;
                              font-size: 32px; /* Increased font size for the main title */
                          }

                          h4 {
                              color: #333;
                              font-family: Arial, sans-serif;
                              font-size: 32px; /* Increased font size for sub-headings */
                          }
                      </style>
                  </head>
                  <body>
                      <h3>SLN Daily Financial Update</h3>

                      <div class='default-section'>
                          <h4>Collection Summary</h4>
                          {{collectionSummary}}
                      </div>

                      <div class='default-section'>
                          <h4>Expense Summary</h4>
                          {{expenseSummary}}
                      </div>

                      <div class='default-section'>
                          <h4>Fee Summary</h4>
                          {{FeeSummary}}
                      </div>

                      <div class='default-section'>
                          <h4>Class Wise Fee Paid Summary</h4>
                          {{ClassWiseFeeSummary}}
                      </div>

                      <div class='default-section'>
                          <h4>Overall Financial Summary</h4>
                          {{financialTableRows}}
                      </div>

                      <div class='default-section'>
                          <h4>Bank Transaction Summary</h4>
                          {{BankTransactionSummary}}
                      </div>

                  </body>
                  </html>";

                //string htmlTemplate = @"
                //                <!DOCTYPE html>
                //                <html>
                //                <head>
                //                    <style>
                //                        /* General table styles */
                //                        table {
                //                            width: 100%;
                //                            border-collapse: collapse;
                //                            font-size: 36px; /* Increased font size for the entire table */
                //                        }
                //                        table, th, td {
                //                            border: 1px solid black;
                //                        }
                //                        th {
                //                            padding: 12px;
                //                            text-align: center;
                //                            font-size: 36px; /* Increased font size for table header */
                //                            background-color: #4CAF50; /* Green background for header */
                //                            color: white; /* White text for the header */
                //                            font-weight: bold; /* Make header text bold */
                //                        }
                //                        td {
                //                            padding: 12px;
                //                            text-align: center;
                //                            font-size: 36px; /* Increased font size for table data cells */
                //                            color: #333; /* Dark text color for table data */
                //                            font-weight: bold; /* Make table rows bold */
                //                        }
                //                        tr:nth-child(even) {
                //                            background-color: #f2f2f2; /* Light gray for even rows */
                //                        }
                //                        tr:nth-child(odd) {
                //                            background-color: #ffffff; /* White for odd rows */
                //                        }

                //                        .default-section {
                //                            background-color: #ADD8E6; /* Light blue background for other sections */
                //                            color: #333; /* Dark text color for other sections */
                //                            padding: 12px;
                //                            font-size: 34px; /* Larger font for section titles */
                //                            font-weight: bold;
                //                        }

                //                        h3 {
                //                            color: #003366; /* Dark blue color for static h3 text */
                //                            font-family: Arial, sans-serif;
                //                            font-size: 32px; /* Increased font size for the main title */
                //                        }

                //                        h4 {
                //                            color: #333;
                //                            font-family: Arial, sans-serif;
                //                            font-size: 32px; /* Increased font size for sub-headings */
                //                        }
                //                    </style>
                //                </head>
                //                <body>
                //                    <h3>SLN Daily Financial Update</h3>

                //                    <div class='default-section'>
                //                        <h4>Collection Summary</h4>
                //                        {{collectionSummary}}
                //                    </div>

                //                    <div class='default-section'>
                //                        <h4>Expense Summary</h4>
                //                        {{expenseSummary}}
                //                    </div>

                //                    <div class='default-section'>
                //                        <h4>Fee Summary</h4>
                //                        {{FeeSummary}}
                //                    </div>

                //                    <div class='default-section'>
                //                        <h4>Class Wise Fee Paid Summary</h4>
                //                        {{ClassWiseFeeSummary}}
                //                    </div>

                //                    <div class='default-section'>
                //                        <h4>Overall Financial Summary</h4>
                //                        {{financialTableRows}}
                //                    </div>

                //                    <div class='default-section'>
                //                        <h4>Bank Transaction Summary</h4>
                //                        {{BankTransactionSummary}}
                //                    </div>

                //                </body>
                //                </html>";


                // Replace placeholders with actual data
                string htmlBody = htmlTemplate
                    .Replace("{{financialTableRows}}", financialTableRows)
                    .Replace("{{collectionSummary}}", collectionSummary)
                    .Replace("{{expenseSummary}}", expenseSummary)
                    .Replace("{{FeeSummary}}", FeeSummary)
                    .Replace("{{ClassWiseFeeSummary}}", ClassWiseFeeSummary)
                    .Replace("{{BankTransactionSummary}}", BankTransactionSummary);

                if (reportType.ToLower() == "monthly")
                {
                    // Include only three sections for daily report
                    htmlBody = htmlBody.Replace("{{ClassWiseFeeSummary}}", string.Empty); // Remove ClassWiseFeeSummary for monthly
                }

                // Set up the email message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                string[] recipientList = toEmail.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string recipient in recipientList)
                {
                    mail.To.Add(recipient.Trim());
                }
                mail.Subject = subject;
                mail.Body = htmlBody;
                mail.IsBodyHtml = true;

                // Set up the SMTP client
                SmtpClient smtpClient = new SmtpClient(smtpServer);
                smtpClient.Port = smtpPort;
                smtpClient.Credentials = new NetworkCredential(fromEmail, emailPassword);
                smtpClient.EnableSsl = true;

                // Send the email
                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetAmountDetails_Emails()
        {
            string data = string.Empty;
            try
            {               
                var dataset = dbHelper.GetAmountsForEmailSummary(Common.EmailSummaryProcedure);

                if (dataset.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in dataset.Tables[0].Rows)
                    {
                        data += "<tr>";
                        data += $"<td>{row["TimePeriod"]}</td>";
                        data += $"<td>{row["CollectionAmount"]}</td>";
                        data += $"<td>{row["ExpenseAmount"]}</td>";
                        data += $"<td>{row["FeePaidAmount"]}</td>";
                        //data += $"<td>{row["BankDepositedAmount"]}</td>"; //To remove
                        //data += $"<td>{row["InCash"]}</td>";
                        data += $"<td>{row["OutstandingAmount"]}</td>";
                        data += "</tr>";
                    }
                }
                else
                {
                    data = "No data found ";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return data;
        }

        private string GetDynamicTableData(string procedureName)
        {
            string data = string.Empty;
            try
            {
                // Fetch data from the database based on the passed procedure name
                var dataset = dbHelper.GetAmountsForEmailSummary(procedureName);

                // Check if the dataset has rows
                if (dataset.Tables[0].Rows.Count > 0)
                {
                    // Start building the table
                    data += "<table><thead><tr>";

                    // Loop through column names dynamically to build the table headers
                    foreach (DataColumn column in dataset.Tables[0].Columns)
                    {
                        data += $"<th>{column.ColumnName}</th>";
                    }

                    data += "</tr></thead><tbody>";

                    // Iterate over the rows and construct the table dynamically
                    foreach (DataRow row in dataset.Tables[0].Rows)
                    {
                        data += "<tr>";

                        // Loop through each column in the row dynamically
                        foreach (DataColumn column in dataset.Tables[0].Columns)
                        {
                            data += $"<td>{row[column]}</td>";
                        }

                        data += "</tr>";
                    }

                    data += "</tbody></table>";
                }
                else
                {
                    data = "No data found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return data;
        }



    }
}
