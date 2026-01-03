
namespace Final_Project
{
    partial class frmResult
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
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResultDesc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblResultTitle.Font = new System.Drawing.Font("Baskerville Old Face", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultTitle.Location = new System.Drawing.Point(97, 27);
            this.lblResultTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Padding = new System.Windows.Forms.Padding(4);
            this.lblResultTitle.Size = new System.Drawing.Size(184, 44);
            this.lblResultTitle.TabIndex = 0;
            this.lblResultTitle.Text = "Your result:";
            this.lblResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultDesc
            // 
            this.lblResultDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblResultDesc.Location = new System.Drawing.Point(24, 266);
            this.lblResultDesc.Margin = new System.Windows.Forms.Padding(15, 0, 15, 45);
            this.lblResultDesc.Name = "lblResultDesc";
            this.lblResultDesc.Size = new System.Drawing.Size(330, 271);
            this.lblResultDesc.TabIndex = 1;
            this.lblResultDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Sienna;
            this.btnExit.Location = new System.Drawing.Point(195, 544);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "All done!";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRedo.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnRedo.FlatAppearance.BorderSize = 2;
            this.btnRedo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnRedo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.ForeColor = System.Drawing.Color.Sienna;
            this.btnRedo.Location = new System.Drawing.Point(80, 544);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(109, 36);
            this.btnRedo.TabIndex = 0;
            this.btnRedo.Text = "Retake!";
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 591);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResultDesc);
            this.Controls.Add(this.lblResultTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Label lblResultDesc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRedo;
    }
}