using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmResult : Form
    {
        string _strSeason;

        public frmResult(string strSeason)
        {
            _strSeason = strSeason;
            InitializeComponent();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            if (_strSeason == "Spring")
            {
                // if user got spring result, update form text, title text, background image, and description text accordingly
                this.Text = "SPRING!";
                lblResultTitle.Text = "Your result:\nSPRING!";
                this.BackgroundImage = Final_Project.Properties.Resources.Spring;
                lblResultDesc.Text = Final_Project.Properties.Resources.SpringDesc;

            }
            else if (_strSeason == "Summer")
            {
                // if user got summer result, update form text, title text, background image, and description text accordingly
                this.Text = "SUMMER!";
                lblResultTitle.Text = "Your result:\nSUMMER!";
                this.BackgroundImage = Final_Project.Properties.Resources.Summer;
                lblResultDesc.Text = Final_Project.Properties.Resources.SummerDesc;
            }
            else if (_strSeason == "Fall")
            {
                // if user got fall result, update form text, title text, background image, and description text accordingly
                this.Text = "FALL!";
                lblResultTitle.Text = "Your result:\nFALL!";
                this.BackgroundImage = Final_Project.Properties.Resources.Fall;
                lblResultDesc.Text = Final_Project.Properties.Resources.FallDesc;
            }
            else if (_strSeason == "Winter")
            {
                // if user got winter result, update form text, title text, background image, and description text accordingly
                this.Text = "WINTER!";
                lblResultTitle.Text = "Your result:\nWINTER!";
                this.BackgroundImage = Final_Project.Properties.Resources.Winter;
                lblResultDesc.Text = Final_Project.Properties.Resources.WinterDesc;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the entire application
            Application.Exit();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            // call frmQuiz's resetForm function
            frmQuiz.instance.resetForm();
            // close the results form
            this.Close();
        }
    }
}
