namespace LZelley_Final_Project
{
    partial class frmGetPrompt
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radCustomize = new System.Windows.Forms.RadioButton();
            this.radDefault = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCustomize = new System.Windows.Forms.Panel();
            this.cboEmotion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radAbstract = new System.Windows.Forms.RadioButton();
            this.radSimple = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDuration = new System.Windows.Forms.CheckBox();
            this.chkReason = new System.Windows.Forms.CheckBox();
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.chkTheme = new System.Windows.Forms.CheckBox();
            this.chkTrait = new System.Windows.Forms.CheckBox();
            this.chkColor = new System.Windows.Forms.CheckBox();
            this.chkAction = new System.Windows.Forms.CheckBox();
            this.chkQuote = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrompt = new System.Windows.Forms.Button();
            this.wbReport = new System.Windows.Forms.WebBrowser();
            this.panel2.SuspendLayout();
            this.pnlCustomize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Eras Demi ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(51, 36);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(159, 24);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Write a scene...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.radCustomize);
            this.panel2.Controls.Add(this.radDefault);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pnlCustomize);
            this.panel2.Location = new System.Drawing.Point(521, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 401);
            this.panel2.TabIndex = 1;
            // 
            // radCustomize
            // 
            this.radCustomize.AutoSize = true;
            this.radCustomize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCustomize.Location = new System.Drawing.Point(124, 30);
            this.radCustomize.Name = "radCustomize";
            this.radCustomize.Size = new System.Drawing.Size(89, 19);
            this.radCustomize.TabIndex = 1;
            this.radCustomize.Text = "Customized";
            this.radCustomize.UseVisualStyleBackColor = true;
            this.radCustomize.CheckedChanged += new System.EventHandler(this.radCustomize_CheckedChanged);
            // 
            // radDefault
            // 
            this.radDefault.AutoSize = true;
            this.radDefault.Checked = true;
            this.radDefault.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDefault.Location = new System.Drawing.Point(52, 30);
            this.radDefault.Name = "radDefault";
            this.radDefault.Size = new System.Drawing.Size(65, 19);
            this.radDefault.TabIndex = 0;
            this.radDefault.TabStop = true;
            this.radDefault.Text = "Default";
            this.radDefault.UseVisualStyleBackColor = true;
            this.radDefault.CheckedChanged += new System.EventHandler(this.radDefault_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCustomize
            // 
            this.pnlCustomize.Controls.Add(this.cboEmotion);
            this.pnlCustomize.Controls.Add(this.label5);
            this.pnlCustomize.Controls.Add(this.radAbstract);
            this.pnlCustomize.Controls.Add(this.radSimple);
            this.pnlCustomize.Controls.Add(this.radAll);
            this.pnlCustomize.Controls.Add(this.label4);
            this.pnlCustomize.Controls.Add(this.chkDuration);
            this.pnlCustomize.Controls.Add(this.chkReason);
            this.pnlCustomize.Controls.Add(this.chkCompany);
            this.pnlCustomize.Controls.Add(this.chkTheme);
            this.pnlCustomize.Controls.Add(this.chkTrait);
            this.pnlCustomize.Controls.Add(this.chkColor);
            this.pnlCustomize.Controls.Add(this.chkAction);
            this.pnlCustomize.Controls.Add(this.chkQuote);
            this.pnlCustomize.Controls.Add(this.label3);
            this.pnlCustomize.Enabled = false;
            this.pnlCustomize.Location = new System.Drawing.Point(4, 63);
            this.pnlCustomize.Name = "pnlCustomize";
            this.pnlCustomize.Size = new System.Drawing.Size(260, 335);
            this.pnlCustomize.TabIndex = 2;
            // 
            // cboEmotion
            // 
            this.cboEmotion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmotion.FormattingEnabled = true;
            this.cboEmotion.Items.AddRange(new object[] {
            "any",
            "silly",
            "sad",
            "angry",
            "happy",
            "scared",
            "affectionate",
            "general",
            "miscellaneous"});
            this.cboEmotion.Location = new System.Drawing.Point(7, 264);
            this.cboEmotion.Name = "cboEmotion";
            this.cboEmotion.Size = new System.Drawing.Size(250, 23);
            this.cboEmotion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Emotion";
            // 
            // radAbstract
            // 
            this.radAbstract.AutoSize = true;
            this.radAbstract.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAbstract.Location = new System.Drawing.Point(113, 224);
            this.radAbstract.Name = "radAbstract";
            this.radAbstract.Size = new System.Drawing.Size(71, 19);
            this.radAbstract.TabIndex = 12;
            this.radAbstract.Text = "Abstract";
            this.radAbstract.UseVisualStyleBackColor = true;
            // 
            // radSimple
            // 
            this.radSimple.AutoSize = true;
            this.radSimple.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSimple.Location = new System.Drawing.Point(50, 224);
            this.radSimple.Name = "radSimple";
            this.radSimple.Size = new System.Drawing.Size(62, 19);
            this.radSimple.TabIndex = 11;
            this.radSimple.Text = "Simple";
            this.radSimple.UseVisualStyleBackColor = true;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(7, 224);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(39, 19);
            this.radAll.TabIndex = 10;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prompt Complexity";
            // 
            // chkDuration
            // 
            this.chkDuration.AutoSize = true;
            this.chkDuration.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDuration.Location = new System.Drawing.Point(7, 182);
            this.chkDuration.Name = "chkDuration";
            this.chkDuration.Size = new System.Drawing.Size(74, 19);
            this.chkDuration.TabIndex = 8;
            this.chkDuration.Text = "Duration";
            this.chkDuration.UseVisualStyleBackColor = true;
            this.chkDuration.CheckedChanged += new System.EventHandler(this.chkDuration_CheckedChanged);
            // 
            // chkReason
            // 
            this.chkReason.AutoSize = true;
            this.chkReason.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReason.Location = new System.Drawing.Point(7, 159);
            this.chkReason.Name = "chkReason";
            this.chkReason.Size = new System.Drawing.Size(65, 19);
            this.chkReason.TabIndex = 7;
            this.chkReason.Text = "Reason";
            this.chkReason.UseVisualStyleBackColor = true;
            this.chkReason.CheckedChanged += new System.EventHandler(this.chkReason_CheckedChanged);
            // 
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompany.Location = new System.Drawing.Point(7, 136);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(77, 19);
            this.chkCompany.TabIndex = 6;
            this.chkCompany.Text = "Company";
            this.chkCompany.UseVisualStyleBackColor = true;
            this.chkCompany.CheckedChanged += new System.EventHandler(this.chkCompany_CheckedChanged);
            // 
            // chkTheme
            // 
            this.chkTheme.AutoSize = true;
            this.chkTheme.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTheme.Location = new System.Drawing.Point(7, 113);
            this.chkTheme.Name = "chkTheme";
            this.chkTheme.Size = new System.Drawing.Size(64, 19);
            this.chkTheme.TabIndex = 5;
            this.chkTheme.Text = "Theme";
            this.chkTheme.UseVisualStyleBackColor = true;
            this.chkTheme.CheckedChanged += new System.EventHandler(this.chkTheme_CheckedChanged);
            // 
            // chkTrait
            // 
            this.chkTrait.AutoSize = true;
            this.chkTrait.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrait.Location = new System.Drawing.Point(7, 90);
            this.chkTrait.Name = "chkTrait";
            this.chkTrait.Size = new System.Drawing.Size(50, 19);
            this.chkTrait.TabIndex = 4;
            this.chkTrait.Text = "Trait";
            this.chkTrait.UseVisualStyleBackColor = true;
            this.chkTrait.CheckedChanged += new System.EventHandler(this.chkTrait_CheckedChanged);
            // 
            // chkColor
            // 
            this.chkColor.AutoSize = true;
            this.chkColor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkColor.Location = new System.Drawing.Point(7, 67);
            this.chkColor.Name = "chkColor";
            this.chkColor.Size = new System.Drawing.Size(55, 19);
            this.chkColor.TabIndex = 3;
            this.chkColor.Text = "Color";
            this.chkColor.UseVisualStyleBackColor = true;
            this.chkColor.CheckedChanged += new System.EventHandler(this.chkColor_CheckedChanged);
            // 
            // chkAction
            // 
            this.chkAction.AutoSize = true;
            this.chkAction.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAction.Location = new System.Drawing.Point(7, 44);
            this.chkAction.Name = "chkAction";
            this.chkAction.Size = new System.Drawing.Size(61, 19);
            this.chkAction.TabIndex = 2;
            this.chkAction.Text = "Action";
            this.chkAction.UseVisualStyleBackColor = true;
            this.chkAction.CheckedChanged += new System.EventHandler(this.chkAction_CheckedChanged);
            // 
            // chkQuote
            // 
            this.chkQuote.AutoSize = true;
            this.chkQuote.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuote.Location = new System.Drawing.Point(7, 21);
            this.chkQuote.Name = "chkQuote";
            this.chkQuote.Size = new System.Drawing.Size(61, 19);
            this.chkQuote.TabIndex = 1;
            this.chkQuote.Text = "Quote";
            this.chkQuote.UseVisualStyleBackColor = true;
            this.chkQuote.CheckedChanged += new System.EventHandler(this.chkQuote_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prompt Types";
            // 
            // btnPrompt
            // 
            this.btnPrompt.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrompt.Location = new System.Drawing.Point(357, 36);
            this.btnPrompt.Name = "btnPrompt";
            this.btnPrompt.Size = new System.Drawing.Size(104, 30);
            this.btnPrompt.TabIndex = 0;
            this.btnPrompt.Text = "Prompt!";
            this.btnPrompt.UseVisualStyleBackColor = true;
            this.btnPrompt.Click += new System.EventHandler(this.btnPrompt_Click);
            // 
            // wbReport
            // 
            this.wbReport.Location = new System.Drawing.Point(12, 69);
            this.wbReport.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbReport.Name = "wbReport";
            this.wbReport.Size = new System.Drawing.Size(503, 368);
            this.wbReport.TabIndex = 2;
            // 
            // frmGetPrompt
            // 
            this.AcceptButton = this.btnPrompt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LZelley_Final_Project.Properties.Resources.hexellence;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbReport);
            this.Controls.Add(this.btnPrompt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblSubtitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmGetPrompt";
            this.Text = "Customize Your Prompt!";
            this.Load += new System.EventHandler(this.frmGetPrompt_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCustomize.ResumeLayout(false);
            this.pnlCustomize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCustomize;
        private System.Windows.Forms.RadioButton radCustomize;
        private System.Windows.Forms.RadioButton radDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrompt;
        private System.Windows.Forms.CheckBox chkDuration;
        private System.Windows.Forms.CheckBox chkReason;
        private System.Windows.Forms.CheckBox chkCompany;
        private System.Windows.Forms.CheckBox chkTheme;
        private System.Windows.Forms.CheckBox chkTrait;
        private System.Windows.Forms.CheckBox chkColor;
        private System.Windows.Forms.CheckBox chkAction;
        private System.Windows.Forms.CheckBox chkQuote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radAbstract;
        private System.Windows.Forms.RadioButton radSimple;
        private System.Windows.Forms.ComboBox cboEmotion;
        private System.Windows.Forms.WebBrowser wbReport;
    }
}