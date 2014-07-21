namespace PrintDialog.UI
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
            this.PrintPreviewView = new PrintDialog.UI.PrintPreviewView();
            this.PrinterSettingsView = new PrintDialog.UI.PrintSettingsView();
            this.SuspendLayout();
            // 
            // PrintPreviewView
            // 
            this.PrintPreviewView.Location = new System.Drawing.Point(2, 12);
            this.PrintPreviewView.Name = "PrintPreviewView";
            this.PrintPreviewView.Size = new System.Drawing.Size(278, 65);
            this.PrintPreviewView.TabIndex = 0;
            // 
            // PrinterSettingsView
            // 
            this.PrinterSettingsView.Location = new System.Drawing.Point(2, 111);
            this.PrinterSettingsView.Name = "PrinterSettingsView";
            this.PrinterSettingsView.Size = new System.Drawing.Size(278, 74);
            this.PrinterSettingsView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.PrinterSettingsView);
            this.Controls.Add(this.PrintPreviewView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PrintPreviewView PrintPreviewView;
        private PrintSettingsView PrinterSettingsView;
    }
}

