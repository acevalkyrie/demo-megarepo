namespace LZelley_Final_Project
{
    partial class frmLanding
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnGetPrompt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Agency FB", 51.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(66, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 83);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inspirize";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(44, 145);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(290, 24);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Writing Prompt Generator";
            // 
            // btnGetPrompt
            // 
            this.btnGetPrompt.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPrompt.Location = new System.Drawing.Point(49, 191);
            this.btnGetPrompt.Name = "btnGetPrompt";
            this.btnGetPrompt.Size = new System.Drawing.Size(268, 45);
            this.btnGetPrompt.TabIndex = 2;
            this.btnGetPrompt.Text = "Get Customizable Prompt";
            this.btnGetPrompt.UseVisualStyleBackColor = true;
            this.btnGetPrompt.Click += new System.EventHandler(this.btnGetPrompt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Custom Prompt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LZelley_Final_Project.Properties.Resources.hexellence;
            this.ClientSize = new System.Drawing.Size(368, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetPrompt);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(384, 374);
            this.Name = "frmLanding";
            this.Text = "Inspirize Prompt Generator";
            this.Load += new System.EventHandler(this.frmLanding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnGetPrompt;
        private System.Windows.Forms.Button button1;
    }
}

