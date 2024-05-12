namespace Student_Mobility_Handler
{
    partial class FrmStudentFinalChoice
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEOSM = new System.Windows.Forms.TextBox();
            this.txtFinalChoice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(42, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 55);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(274, 279);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(109, 55);
            this.btnDecline.TabIndex = 1;
            this.btnDecline.Text = "Reject";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(506, 279);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(109, 55);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "EOSM Administrator:";
            // 
            // txtEOSM
            // 
            this.txtEOSM.Location = new System.Drawing.Point(28, 42);
            this.txtEOSM.Name = "txtEOSM";
            this.txtEOSM.ReadOnly = true;
            this.txtEOSM.Size = new System.Drawing.Size(232, 22);
            this.txtEOSM.TabIndex = 4;
            // 
            // txtFinalChoice
            // 
            this.txtFinalChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFinalChoice.Location = new System.Drawing.Point(189, 161);
            this.txtFinalChoice.Name = "txtFinalChoice";
            this.txtFinalChoice.ReadOnly = true;
            this.txtFinalChoice.Size = new System.Drawing.Size(270, 30);
            this.txtFinalChoice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(155, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "EOSM Administrators final choice:";
            // 
            // FrmStudentFinalChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinalChoice);
            this.Controls.Add(this.txtEOSM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmStudentFinalChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My final choice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEOSM;
        private System.Windows.Forms.TextBox txtFinalChoice;
        private System.Windows.Forms.Label label2;
    }
}