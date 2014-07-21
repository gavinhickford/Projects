namespace PassiveViewDemo2
{
    partial class Form1
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
			this.patientView1 = new PassiveViewDemo2.Views.PatientView();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// patientView1
			// 
			this.patientView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.patientView1.GetPatientButtonEnabled = false;
			this.patientView1.Location = new System.Drawing.Point(0, 0);
			this.patientView1.Name = "patientView1";
			this.patientView1.PatientName = "PatientView";
			this.patientView1.Size = new System.Drawing.Size(284, 161);
			this.patientView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 205);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.patientView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private Views.PatientView patientView1;
		private System.Windows.Forms.Button button1;
    }
}

