using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZelley_Final_Project
{
    public partial class frmGetPrompt : Form
    {
        /// <summary>
        /// Set up strings for the html report of any prompt types, as well as lists for quickly checking which customization options are enabled and easily adding to the report
        /// </summary>
        string quotetext = "<h2>...containing the dialogue,</h2>";
        string actiontext = "<h2>...where your character is</h2>";
        string colortext = "<h2>...placing significance on the color</h2>";
        string traittext = "<h2>...mentioning a character's</h2>";
        string themetext = "<h2>...focusing on a theme of</h2>";
        string companytext = "<h2>...where your character is with</h2>";
        string reasontext = "<h2>...where it's all happening because</h2>";
        string durationtext = "<h2>...which has been going on</h2>";

        List<CheckBox> Checklist = new List<CheckBox>();
        List<string> Typelist = new List<string>();
        

        public frmGetPrompt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the basic appearance of the form as well as populate lists later used to quickly check which customizations are enabled and adjust html accordingly
        /// </summary>
        /// <param name="sender">Occurs on form load</param>
        /// <param name="e"></param>
        private void frmGetPrompt_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromName(clsGlobal.ForegroundColor);
            lblSubtitle.ForeColor = Color.FromName(clsGlobal.HeaderColors);

            Checklist.Add(chkQuote);
            Checklist.Add(chkAction);
            Checklist.Add(chkColor);
            Checklist.Add(chkTrait);
            Checklist.Add(chkTheme);
            Checklist.Add(chkCompany);
            Checklist.Add(chkReason);
            Checklist.Add(chkDuration);

            Typelist.Add(quotetext);
            Typelist.Add(actiontext);
            Typelist.Add(colortext);
            Typelist.Add(traittext);
            Typelist.Add(themetext);
            Typelist.Add(companytext);
            Typelist.Add(reasontext);
            Typelist.Add(durationtext);
        }

        /// <summary>
        /// Method to enable the customization options if user toggles the corresponding radio button, or disable them otherwise
        /// </summary>
        private void toggleCustomization()
        {
            if (radCustomize.Checked) { pnlCustomize.Enabled = true; }
            else { pnlCustomize.Enabled = false; }
        }

        /// <summary>
        /// Method to disable the complexity options if any specific prompt type is chosen, as prompt types are near-universally cast as either abstract or simple
        /// </summary>
        private void toggleComplexity()
        {
            // If even one prompt type is checked, disable complexity options
            if (chkQuote.Checked || chkAction.Checked || chkColor.Checked || chkTrait.Checked || chkTheme.Checked || chkCompany.Checked || chkReason.Checked || chkDuration.Checked)
            {
                radAll.Enabled = false;
                radSimple.Enabled = false;
                radAbstract.Enabled = false;
            }
            else
            {
                radAll.Enabled = true;
                radSimple.Enabled = true;
                radAbstract.Enabled = true;
            }
        }

        /// <summary>
        /// Method to enable the emotion choices for quote prompts specifically
        /// </summary>
        private void toggleEmotion()
        {
            // Quotes are the only prompt types with associated emotions, so only enable the combo box if the quote option is checked
            if (chkQuote.Checked) cboEmotion.Enabled = true;
            else cboEmotion.Enabled = false;
        }

        /// <summary>
        /// Upon the change of checked status of either radDefault or RadCustomize, call ToggleCustomization() to enable/disable options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radDefault_CheckedChanged(object sender, EventArgs e)
        {
            toggleCustomization();
        }

        private void radCustomize_CheckedChanged(object sender, EventArgs e)
        {
            toggleCustomization();
        }

        /// <summary>
        /// Generate a web report and use selected customization options to access the database and randomly select a prompt.
        /// </summary>
        /// <param name="sender">Occurs when user clicks the prompt button</param>
        /// <param name="e"></param>
        private void btnPrompt_Click(object sender, EventArgs e)
        {
            // Set CSS for customization options
            string strCSS = "<style>body { font-family: Calibri; background-color: "+ clsGlobal.BackgroundColor +"; } h2 { font-size: 20px; font-style: italic; } p { font-size: 16px; text-align: right; }</style>";
            // Create basis for header and body of the HTML web report
            string strReportHeader;
            strReportHeader = "<html><head><title>Write a scene...</title>" + strCSS + "</head>";
            string strReportBody = "<body>";

            // Create instance of data class so that commands can be sent to the database
            clsData myData = new clsData();
            // The default prompt is any kind of quote. Without customization enabled, a random quote is picked from the database.
            if (radDefault.Checked)
            {
                myData.SQL = "SELECT content FROM tblPrompts WHERE type='quote'";
                var rand = new Random();
                int intRand = rand.Next(0, myData.dt.Rows.Count); // Use random function to obtain quote to be displayed
                string strPrompt = myData.dt.Rows[intRand]["content"].ToString();

                strReportBody += "<h2>...containing the dialogue,</h2><p>\"" + strPrompt + "\""; // Report selected quote to the web report
            }
            // Customization enabled, generate quote based on selected options
            else
            {
                // Complexity options (radAll, radSimple, radComplex) automatically determine many prompt types, so they are only enabled if no prompt types are selected to prevent errors
                if (!radAll.Enabled)
                {
                    // Quote type prompts are the only ones with additional customization in the form of associated emotion, so run quote checks separately.
                    if (chkQuote.Checked)
                    {
                        string strCommand = "SELECT content FROM tblPrompts WHERE type='quote'";
                        if (cboEmotion.SelectedIndex > 0) strCommand += " AND emotion='" + cboEmotion.SelectedItem + "'"; // Further narrow down results by associated emotion if one was selected
                        myData.SQL = strCommand;
                        var rand = new Random();
                        int intRand = rand.Next(0, myData.dt.Rows.Count); // Use random function to obtain quote to be displayed
                        string strPrompt = myData.dt.Rows[intRand]["content"].ToString();

                        strReportBody += quotetext + "<p>\"" + strPrompt + "\"</p>"; // Report selected quote to the web report
                    }
                    // Use Checklist and Typelist filled at form load to cycle through all prompt type checkboxes, query database for them, and display them as needed
                    for (int i = 1; i < Checklist.Count; i++)
                    {
                        if (Checklist[i].Checked)
                        {
                            myData.SQL = "SELECT content FROM tblPrompts WHERE type='" + Checklist[i].Text.ToLower() + "'"; // The checkbox's name corresponds with types from the database
                            var rand = new Random();
                            int intRand = rand.Next(0, myData.dt.Rows.Count); // Use random function to obtain prompt to be displayed
                            string strPrompt = myData.dt.Rows[intRand]["content"].ToString();

                            strReportBody += Typelist[i] + "<p>" + strPrompt + "</p>"; // Report selected prompt to the web report, using Typelist parallel to Checklist to fill the correct header
                        }
                    }
                }
                // If complexity options are enabled, generate any kind of prompt based on selected radio button
                else
                {
                    string strComplexity = "";
                    // Add contions to the eventual SQL command based on selected complexity
                    if (radSimple.Checked) strComplexity += " WHERE complexity=0";
                    if (radAbstract.Checked) strComplexity += " WHERE complexity=1";
                    myData.SQL = "SELECT type, content FROM tblPrompts" + strComplexity;
                    var rand = new Random();
                    int intRand = rand.Next(0, myData.dt.Rows.Count); // Use random function to obtain prompt to be displayed
                    string strPrompt = myData.dt.Rows[intRand]["content"].ToString();
                    string strType = myData.dt.Rows[intRand]["type"].ToString();

                    // Use switch statementto evaluate what type of quote was selected and display corresponding header
                    switch(strType)
                    {
                        case "quote":
                            strReportBody += quotetext;
                            break;
                        case "action":
                            strReportBody += actiontext;
                            break;
                        case "color":
                            strReportBody += colortext;
                            break;
                        case "trait":
                            strReportBody += traittext;
                            break;
                        case "theme":
                            strReportBody += themetext;
                            break;
                        case "company":
                            strReportBody += companytext;
                            break;
                        case "reason":
                            strReportBody += reasontext;
                            break;
                        case "duration":
                            strReportBody += durationtext;
                            break;
                        default:
                            break;
                    }
                    strReportBody += "<p>\"" + strPrompt + "\"</p>";
                }
            }

            // close out body and HTML, and display to web report
            strReportBody += "</body></html>";
            wbReport.DocumentText = strReportHeader + strReportBody;
        }

        /// <summary>
        /// Whenever any prompt type checkbox is enabled, disable complexity options, and vice/versa. In case of the Quote checkbox, also enable cboEmotions when checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkQuote_CheckedChanged(object sender, EventArgs e)
        {
            toggleComplexity();
            toggleEmotion();
        }

        private void chkAction_CheckedChanged(object sender, EventArgs e)
        {
            toggleComplexity();
        }

        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
            toggleComplexity();
        }

        private void chkTrait_CheckedChanged(object sender, EventArgs e)
        {
            toggleComplexity();
        }

        private void chkTheme_CheckedChanged(object sender, EventArgs e)
        {
            toggleComplexity();
        }

        private void chkCompany_CheckedChanged(object sender, EventArgs e)
        {
            toggleComplexity();
        }

        private void chkReason_CheckedChanged(object sender, EventArgs e)
        {
            toggleComplexity();
        }

        private void chkDuration_CheckedChanged(object sender, EventArgs e)
        {
            toggleComplexity();
        }
    }
}
