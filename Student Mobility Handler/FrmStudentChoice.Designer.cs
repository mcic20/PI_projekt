namespace Student_Mobility_Handler
{
    partial class FrmStudentChoice
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
            this.txtEOSM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFirstChoice = new System.Windows.Forms.ComboBox();
            this.cboSecondChoice = new System.Windows.Forms.ComboBox();
            this.cboThirdChoice = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.listboxSuggestions = new System.Windows.Forms.ListBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "EOSM Adminsitrator:";
            // 
            // txtEOSM
            // 
            this.txtEOSM.Location = new System.Drawing.Point(26, 42);
            this.txtEOSM.Name = "txtEOSM";
            this.txtEOSM.Size = new System.Drawing.Size(191, 22);
            this.txtEOSM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Suggestions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(459, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "My choices:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Choice:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Second Choice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Third Choice:";
            // 
            // cboFirstChoice
            // 
            this.cboFirstChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFirstChoice.FormattingEnabled = true;
            this.cboFirstChoice.Location = new System.Drawing.Point(429, 127);
            this.cboFirstChoice.Name = "cboFirstChoice";
            this.cboFirstChoice.Size = new System.Drawing.Size(222, 24);
            this.cboFirstChoice.TabIndex = 8;
            // 
            // cboSecondChoice
            // 
            this.cboSecondChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSecondChoice.FormattingEnabled = true;
            this.cboSecondChoice.Location = new System.Drawing.Point(429, 189);
            this.cboSecondChoice.Name = "cboSecondChoice";
            this.cboSecondChoice.Size = new System.Drawing.Size(222, 24);
            this.cboSecondChoice.TabIndex = 9;
            // 
            // cboThirdChoice
            // 
            this.cboThirdChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThirdChoice.FormattingEnabled = true;
            this.cboThirdChoice.Location = new System.Drawing.Point(429, 263);
            this.cboThirdChoice.Name = "cboThirdChoice";
            this.cboThirdChoice.Size = new System.Drawing.Size(222, 24);
            this.cboThirdChoice.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(564, 394);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 44);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit my choices";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(416, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 44);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listboxSuggestions
            // 
            this.listboxSuggestions.FormattingEnabled = true;
            this.listboxSuggestions.ItemHeight = 16;
            this.listboxSuggestions.Location = new System.Drawing.Point(26, 108);
            this.listboxSuggestions.Name = "listboxSuggestions";
            this.listboxSuggestions.Size = new System.Drawing.Size(320, 292);
            this.listboxSuggestions.TabIndex = 13;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(412, 361);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(264, 20);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Please select at least two choices";
            // 
            // FrmStudentChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.listboxSuggestions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboThirdChoice);
            this.Controls.Add(this.cboSecondChoice);
            this.Controls.Add(this.cboFirstChoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEOSM);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Destination Choices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEOSM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFirstChoice;
        private System.Windows.Forms.ComboBox cboSecondChoice;
        private System.Windows.Forms.ComboBox cboThirdChoice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listboxSuggestions;
        private System.Windows.Forms.Label lblError;
    }
}