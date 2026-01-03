
namespace Final_Project
{
    partial class frmQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuiz));
            this.pnlStart = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuiz = new System.Windows.Forms.Panel();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.radFourthAnswer = new System.Windows.Forms.RadioButton();
            this.radThirdAnswer = new System.Windows.Forms.RadioButton();
            this.radSecondAnswer = new System.Windows.Forms.RadioButton();
            this.radFirstAnswer = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblRestart = new System.Windows.Forms.Label();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.pnlStart.SuspendLayout();
            this.pnlQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Controls.Add(this.label2);
            this.pnlStart.Controls.Add(this.label1);
            this.pnlStart.Location = new System.Drawing.Point(89, 79);
            this.pnlStart.Margin = new System.Windows.Forms.Padding(80, 70, 80, 70);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(590, 352);
            this.pnlStart.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Sienna;
            this.btnStart.Location = new System.Drawing.Point(180, 242);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(268, 41);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START QUIZ!";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(100, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 14, 20, 0);
            this.label2.Size = new System.Drawing.Size(428, 181);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are you more of a hopeful Spring? A solitary winter? Answer a few questions and t" +
    "his quiz will let you know which season represents you best!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(76, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which Season Are You?";
            // 
            // pnlQuiz
            // 
            this.pnlQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlQuiz.Controls.Add(this.lblQuestionCount);
            this.pnlQuiz.Controls.Add(this.btnResults);
            this.pnlQuiz.Controls.Add(this.btnContinue);
            this.pnlQuiz.Controls.Add(this.radFourthAnswer);
            this.pnlQuiz.Controls.Add(this.radThirdAnswer);
            this.pnlQuiz.Controls.Add(this.radSecondAnswer);
            this.pnlQuiz.Controls.Add(this.radFirstAnswer);
            this.pnlQuiz.Controls.Add(this.lblQuestion);
            this.pnlQuiz.Location = new System.Drawing.Point(69, 69);
            this.pnlQuiz.Margin = new System.Windows.Forms.Padding(60);
            this.pnlQuiz.Name = "pnlQuiz";
            this.pnlQuiz.Size = new System.Drawing.Size(630, 403);
            this.pnlQuiz.TabIndex = 1;
            this.pnlQuiz.Visible = false;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnResults.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnResults.FlatAppearance.BorderSize = 2;
            this.btnResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.Sienna;
            this.btnResults.Location = new System.Drawing.Point(458, 358);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(158, 34);
            this.btnResults.TabIndex = 5;
            this.btnResults.Text = "Get Results!";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Visible = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnContinue.FlatAppearance.BorderSize = 2;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Sienna;
            this.btnContinue.Location = new System.Drawing.Point(458, 358);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(158, 34);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Next Question!";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // radFourthAnswer
            // 
            this.radFourthAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFourthAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radFourthAnswer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFourthAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFourthAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFourthAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFourthAnswer.Location = new System.Drawing.Point(20, 294);
            this.radFourthAnswer.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.radFourthAnswer.Name = "radFourthAnswer";
            this.radFourthAnswer.Padding = new System.Windows.Forms.Padding(10, 6, 8, 6);
            this.radFourthAnswer.Size = new System.Drawing.Size(590, 56);
            this.radFourthAnswer.TabIndex = 3;
            this.radFourthAnswer.TabStop = true;
            this.radFourthAnswer.UseVisualStyleBackColor = false;
            // 
            // radThirdAnswer
            // 
            this.radThirdAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radThirdAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radThirdAnswer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radThirdAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radThirdAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radThirdAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThirdAnswer.Location = new System.Drawing.Point(20, 230);
            this.radThirdAnswer.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.radThirdAnswer.Name = "radThirdAnswer";
            this.radThirdAnswer.Padding = new System.Windows.Forms.Padding(10, 6, 8, 6);
            this.radThirdAnswer.Size = new System.Drawing.Size(590, 56);
            this.radThirdAnswer.TabIndex = 2;
            this.radThirdAnswer.TabStop = true;
            this.radThirdAnswer.UseVisualStyleBackColor = false;
            // 
            // radSecondAnswer
            // 
            this.radSecondAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radSecondAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radSecondAnswer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radSecondAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radSecondAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radSecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSecondAnswer.Location = new System.Drawing.Point(20, 166);
            this.radSecondAnswer.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.radSecondAnswer.Name = "radSecondAnswer";
            this.radSecondAnswer.Padding = new System.Windows.Forms.Padding(10, 6, 8, 6);
            this.radSecondAnswer.Size = new System.Drawing.Size(590, 56);
            this.radSecondAnswer.TabIndex = 1;
            this.radSecondAnswer.TabStop = true;
            this.radSecondAnswer.UseVisualStyleBackColor = false;
            // 
            // radFirstAnswer
            // 
            this.radFirstAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFirstAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radFirstAnswer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFirstAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFirstAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radFirstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFirstAnswer.Location = new System.Drawing.Point(20, 102);
            this.radFirstAnswer.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.radFirstAnswer.Name = "radFirstAnswer";
            this.radFirstAnswer.Padding = new System.Windows.Forms.Padding(10, 6, 8, 6);
            this.radFirstAnswer.Size = new System.Drawing.Size(590, 56);
            this.radFirstAnswer.TabIndex = 0;
            this.radFirstAnswer.TabStop = true;
            this.radFirstAnswer.UseVisualStyleBackColor = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(70, 20);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(70, 20, 70, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(490, 74);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 16);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(169, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "All done?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(657, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(139, 498);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(92, 30);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Start Over";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblRestart
            // 
            this.lblRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.Location = new System.Drawing.Point(14, 496);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblRestart.Size = new System.Drawing.Size(219, 34);
            this.lblRestart.TabIndex = 4;
            this.lblRestart.Text = "Made a mistake?";
            this.lblRestart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRestart.Visible = false;
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblQuestionCount.Location = new System.Drawing.Point(16, 358);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(69, 34);
            this.lblQuestionCount.TabIndex = 6;
            this.lblQuestionCount.Text = "0 / 0";
            this.lblQuestionCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 541);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlQuiz);
            this.Controls.Add(this.pnlStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmQuiz";
            this.Text = "Seasons Personality Quiz !";
            this.Load += new System.EventHandler(this.quiz_Load);
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlQuiz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlQuiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radFourthAnswer;
        private System.Windows.Forms.RadioButton radThirdAnswer;
        private System.Windows.Forms.RadioButton radSecondAnswer;
        private System.Windows.Forms.RadioButton radFirstAnswer;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.Label lblQuestionCount;
    }
}

