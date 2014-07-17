namespace PassiveViewDemo2.Views
{
    partial class PatientView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetPatientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientIdTextbox = new System.Windows.Forms.TextBox();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetPatientButton
            // 
            this.GetPatientButton.Location = new System.Drawing.Point(3, 124);
            this.GetPatientButton.Name = "GetPatientButton";
            this.GetPatientButton.Size = new System.Drawing.Size(75, 23);
            this.GetPatientButton.TabIndex = 0;
            this.GetPatientButton.Text = "Get Patient";
            this.GetPatientButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Name ";
            // 
            // PatientIdTextbox
            // 
            this.PatientIdTextbox.Location = new System.Drawing.Point(85, 124);
            this.PatientIdTextbox.Name = "PatientIdTextbox";
            this.PatientIdTextbox.Size = new System.Drawing.Size(52, 20);
            this.PatientIdTextbox.TabIndex = 2;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.AutoSize = true;
            this.PatientNameLabel.Location = new System.Drawing.Point(85, 9);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(0, 13);
            this.PatientNameLabel.TabIndex = 3;
            // 
            // PatientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PatientNameLabel);
            this.Controls.Add(this.PatientIdTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetPatientButton);
            this.PatientName = "PatientView";
            this.Size = new System.Drawing.Size(350, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetPatientButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientIdTextbox;
        private System.Windows.Forms.Label PatientNameLabel;
    }
}
