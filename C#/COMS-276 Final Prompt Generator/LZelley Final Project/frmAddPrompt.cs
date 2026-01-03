using LZelley_Final_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZelley_Final_Project
{
    public partial class frmAddPrompt : Form
    {
        public frmAddPrompt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On form load, adjust color specifications based on clsGlobal clas, and display a count of each type of prompt in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAddPrompt_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromName(clsGlobal.ForegroundColor);
            lblTitle.ForeColor = Color.FromName(clsGlobal.TitleColors);
            lblSubtitle.ForeColor = Color.FromName(clsGlobal.HeaderColors);
            CountPrompts();
            webReport();
        }

        /// <summary>
        /// Fill count labels with corresponding information on how many of their corresponding prompt types are in existence in the database.
        /// </summary>
        private void CountPrompts()
        {
            // create instance of class
            clsData myData = new clsData();
            myData.SQL = "SELECT COUNT(IIf(type='quote', 1, NULL)) AS quotecount, COUNT(IIf(type='action', 1, NULL)) AS actioncount, COUNT(IIf(type='color', 1, NULL)) AS colorcount, COUNT(IIf(type='trait', 1, NULL)) AS traitcount, COUNT(IIf(type='theme', 1, NULL)) AS themecount, COUNT(IIf(type='company', 1, NULL)) AS companycount, COUNT(IIf(type='reason', 1, NULL)) AS reasoncount, COUNT(IIf(type='duration', 1, NULL)) AS durationcount FROM tblPrompts";
            lblQuotes.Text = myData.dt.Rows[0]["quotecount"].ToString();
            lblActions.Text = myData.dt.Rows[0]["actioncount"].ToString();
            lblColors.Text = myData.dt.Rows[0]["colorcount"].ToString();
            lblTraits.Text = myData.dt.Rows[0]["traitcount"].ToString();
            lblThemes.Text = myData.dt.Rows[0]["themecount"].ToString();
            lblCompany.Text = myData.dt.Rows[0]["companycount"].ToString();
            lblReason.Text = myData.dt.Rows[0]["reasoncount"].ToString();
            lblDuration.Text = myData.dt.Rows[0]["durationcount"].ToString();
        }

        /// <summary>
        /// Display the most recent addition to the database, so user can confirm their input was added correctly.
        /// </summary>
        private void webReport()
        {
            wbReport.Visible = true; // Web report was previously not visible, now appears
            // Set CSS for customization options
            string strCSS;
            strCSS = "<style> body { background-color: "+ clsGlobal.BackgroundColor +"; } h1 { margin: 0; font-size: 13px; font-family: 'Eras Demi ITC'; color:"+ clsGlobal.HeaderColors +"; } table { margin: 0; border-spacing: 0px; border-collapse: collapse; width: 100%; font-family: Calibri; font-size: 12px; } th, td { border: 1px solid black; padding: 0px 5px; text-align: center; } </style>";
            // Create basis for header and body of the HTML web report
            string strReportHeader;
            strReportHeader = "<html><head><title>Last Prompt Created</title>" + strCSS + "</head>";
            string strReportBody = "<body>";
            strReportBody += "<h1>Last Prompt Created:</h1>";

            // Create instance of data class so that commands can be sent to the database
            clsData myData = new clsData();
            myData.SQL = "SELECT TOP 1 * FROM tblPrompts ORDER BY ID DESC"; // Select only the first entry by descending order
            // Obrain values to display in HTML report
            string strType = myData.dt.Rows[0]["type"].ToString();
            string strContent = myData.dt.Rows[0]["content"].ToString();
            string strComplexity;
            if (!Convert.ToBoolean(myData.dt.Rows[0]["complexity"])) { strComplexity = "simple"; } // Complexity is determined based on boolean values in the database
            else { strComplexity = "abstract"; }
            string strEmotion = myData.dt.Rows[0]["emotion"].ToString();

            // create a table in HTML and display the type, content, complexity, and emotion of the prompt in the table
            strReportBody += "<table>";
            strReportBody += "<tr> <th>type</th>        <th>content</th>        <th>complexity</th>        <th>emotion</th> </tr>";
            strReportBody += "<tr> <td>"+strType+"</td> <td>"+strContent+"</td> <td>"+strComplexity+"</td> <td>"+strEmotion+"</td> </tr>";

            // close out table, body, and HTML and display to web browser
            strReportBody += "</table></body></html>";
            wbReport.DocumentText = strReportHeader + strReportBody;

        }

        /// <summary>
        /// Once a prompt has been submitted, reset all inputs to default state so user doesn't accidentally add the same value twice
        /// </summary>
        private void clearInputs()
        {
            cboEmotion.SelectedIndex = -1;
            cboType.SelectedIndex = -1;
            txtPrompt.Text = "";
            cboComplexity.SelectedIndex = -1;
        }

        /// <summary>
        /// Add prompt to database, checking for user error and accounting for it where possible
        /// </summary>
        /// <param name="sender">Occurs when user clicks Add button</param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create strings for use in querying the database later
            string strType;
            string strContent;
            bool bolComplexity;
            string strEmotion;
            // If user hasn't selected a prompt type, it cannot be sent to the database
            if (cboType.SelectedIndex == -1)
            {
                MessageBox.Show("Select a prompt type.");
                cboType.Focus();
            }
            // otherwise, proceed
            else
            {
                // If user hasn't actually provided a prompt, it cannot be sent to the database
                if (txtPrompt.Text == "")
                {
                    MessageBox.Show("Your prompt seems to be blank.");
                    txtPrompt.Focus();
                }
                // otherwise, proceed
                else
                {
                    // Use inputs to determine what can be added to the database.
                    strType = cboType.SelectedItem.ToString();
                    strContent = txtPrompt.Text.Replace("'", "\'"); // try to account for any errors that can occur with quotes interfering with Access commands
                    // Complexity is determined by boolean values in the database
                    if (cboComplexity.SelectedIndex == -1 || cboComplexity.SelectedIndex == 0) { bolComplexity = false; }
                    else { bolComplexity = true; }
                    if (cboEmotion.Enabled == true)
                    {
                        if (cboEmotion.SelectedIndex != -1) { strEmotion = cboEmotion.SelectedItem.ToString(); }
                        else { strEmotion = "general"; }
                    }
                    else { strEmotion = null; }
                    // Create new instance of class
                    clsData myData = new clsData();
                    myData.CreatePrompt(strType, strContent, bolComplexity, strEmotion); // send the parameters found in user inputs to the database to create a new entry
                    CountPrompts(); // Update the counts of different prompt types
                    webReport(); // Display result to web report
                    clearInputs(); // Reset inputs for user convenience
                }
            }
        }

        /// <summary>
        /// Enable the emotion combo box only if the prompt type is quote, as other prompt types have no associated emotion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0) { cboEmotion.Enabled = true; }
            else { cboEmotion.Enabled = false; }
        }
    }
}
