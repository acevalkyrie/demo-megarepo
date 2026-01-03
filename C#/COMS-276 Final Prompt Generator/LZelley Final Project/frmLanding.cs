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
    public partial class frmLanding : Form
    {
        public frmLanding()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set color specifications from clsGlobal on formload.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLanding_Load(object sender, EventArgs e)
        {
            this.ForeColor = Color.FromName(clsGlobal.ForegroundColor);
            lblTitle.ForeColor = Color.FromName(clsGlobal.TitleColors);
            lblSubtitle.ForeColor = Color.FromName(clsGlobal.HeaderColors);
        }

        /// <summary>
        /// Open form to get a prompt.
        /// </summary>
        /// <param name="sender">Occurs when user clicks the Get Prompt button.</param>
        /// <param name="e"></param>
        private void btnGetPrompt_Click(object sender, EventArgs e)
        {
            frmGetPrompt GetPromptForm = new frmGetPrompt();
            GetPromptForm.ShowDialog();
        }

        /// <summary>
        /// Open form to add your own prompts.
        /// </summary>
        /// <param name="sender">Occurs when user clicks the Add Prompt button.</param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            frmAddPrompt AddPromptForm = new frmAddPrompt();
            AddPromptForm.ShowDialog();
        }
    }
}
