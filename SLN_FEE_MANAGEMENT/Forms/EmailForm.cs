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
                string tableRows = GetAmountDetails_Emails();
                string subject = "SLN Daily Financial Report As of  " + DateTime.Today.ToString("yyyy/MM/dd");                
                string htmlTemplate = @"
                                        <!DOCTYPE html>
                                        <html>
                                        <head>
                                            <style>
                                                table {
                                                    width: 100%;
                                                    border-collapse: collapse;
                                                }
                                                table, th, td {
                                                    border: 1px solid black;
                                                }
                                                th, td {
                                                    padding: 10px;
                                                    text-align: center;
                                                }
                                                th {
                                                    background-color: #f2f2f2;
                                                }
                                                h3 {
                                                    color: #333;
                                                    font-family: Arial, sans-serif;
                                                }
                                            </style>
                                        </head>
                                        <body>
                                            <h3>SLN Daily Financial Update</h3>
                                            <table>
                                                <thead>
                                                    <tr>
                                                        <th>Time Period</th>
                                                        <th>Collection Amount</th>                                                        
                                                        <th>Expense Amount</th>
                                                        <th>Fee Paid Amount</th>
                                                        <th>Bank Deposited Amount</>
                                                        <th>Amount In Cash</>
                                                        <th>Outstanding Amount (Collection - Expenses)</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    {{tableRows}}
                                                </tbody>
                                            </table>
                                        </body>
                                        </html>";


                string htmlBody = htmlTemplate.Replace("{{tableRows}}", tableRows);
                // Set up the email message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                string[] recipientList = toEmail.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string recipient in recipientList)
                {
                    mail.To.Add(recipient.Trim());
                }
                mail.Subject = subject; // Replace txtSubject with your actual input field
                mail.Body = htmlBody; // Replace txtBody with your actual input field
                mail.IsBodyHtml = true;  // Set true if the body contains HTML

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
                        data += $"<td>{row["BankDepositedAmount"]}</td>";
                        data += $"<td>{row["InCash"]}</td>";
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
    }
}
