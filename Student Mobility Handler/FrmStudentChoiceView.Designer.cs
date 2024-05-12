namespace Student_Mobility_Handler
{
    partial class FrmStudentChoiceView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstChoice = new System.Windows.Forms.TextBox();
            this.txtSecondChoice = new System.Windows.Forms.TextBox();
            this.txtThirdChoice = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Choice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Choice:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Third Choice:";
            // 
            // txtFirstChoice
            // 
            this.txtFirstChoice.Location = new System.Drawing.Point(26, 62);
            this.txtFirstChoice.Name = "txtFirstChoice";
            this.txtFirstChoice.ReadOnly = true;
            this.txtFirstChoice.Size = new System.Drawing.Size(240, 22);
            this.txtFirstChoice.TabIndex = 3;
            // 
            // txtSecondChoice
            // 
            this.txtSecondChoice.Location = new System.Drawing.Point(26, 141);
            this.txtSecondChoice.Name = "txtSecondChoice";
            this.txtSecondChoice.ReadOnly = true;
            this.txtSecondChoice.Size = new System.Drawing.Size(240, 22);
            this.txtSecondChoice.TabIndex = 4;
            // 
            // txtThirdChoice
            // 
            this.txtThirdChoice.Location = new System.Drawing.Point(26, 217);
            this.txtThirdChoice.Name = "txtThirdChoice";
            this.txtThirdChoice.ReadOnly = true;
            this.txtThirdChoice.Size = new System.Drawing.Size(240, 22);
            this.txtThirdChoice.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(139, 286);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmStudentChoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 343);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtThirdChoice);
            this.Controls.Add(this.txtSecondChoice);
            this.Controls.Add(this.txtFirstChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentChoiceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Choices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstChoice;
        private System.Windows.Forms.TextBox txtSecondChoice;
        private System.Windows.Forms.TextBox txtThirdChoice;
        private System.Windows.Forms.Button btnClose;
    }
}