namespace Student_Mobility_Handler
{
    partial class FrmStudentView
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
            this.btnPossibleFaculties = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoices = new System.Windows.Forms.Button();
            this.lblWait = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPossibleFaculties
            // 
            this.btnPossibleFaculties.Location = new System.Drawing.Point(32, 173);
            this.btnPossibleFaculties.Name = "btnPossibleFaculties";
            this.btnPossibleFaculties.Size = new System.Drawing.Size(139, 52);
            this.btnPossibleFaculties.TabIndex = 0;
            this.btnPossibleFaculties.Text = "Select possible faculties";
            this.btnPossibleFaculties.UseVisualStyleBackColor = true;
            this.btnPossibleFaculties.Click += new System.EventHandler(this.btnPossibleFaculties_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(467, 173);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(139, 52);
            this.btnFinal.TabIndex = 1;
            this.btnFinal.Text = "View final recomendation";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(426, 39);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(50, 16);
            this.lblFaculty.TabIndex = 10;
            this.lblFaculty.Text = "Faculty";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(426, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Logged in as:";
            // 
            // btnChoices
            // 
            this.btnChoices.Location = new System.Drawing.Point(228, 173);
            this.btnChoices.Name = "btnChoices";
            this.btnChoices.Size = new System.Drawing.Size(150, 52);
            this.btnChoices.TabIndex = 11;
            this.btnChoices.Text = "View your choices";
            this.btnChoices.UseVisualStyleBackColor = true;
            this.btnChoices.Click += new System.EventHandler(this.btnChoices_Click);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(51, 127);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(524, 16);
            this.lblWait.TabIndex = 12;
            this.lblWait.Text = "Please wait while EOSM Administrator creates Recommendation list for you. Thank y" +
    "ou.";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(520, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit info";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 294);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.btnChoices);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnPossibleFaculties);
            this.Name = "FrmStudentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPossibleFaculties;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChoices;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Button btnEdit;
    }
}