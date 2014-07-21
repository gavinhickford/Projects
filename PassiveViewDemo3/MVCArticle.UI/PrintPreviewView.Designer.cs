namespace PrintDialog.UI
{
    partial class PrintPreviewView
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfCopiesLabel = new System.Windows.Forms.Label();
            this.SelectedPrinterLabel = new System.Windows.Forms.Label();
            this.NoOfCopiesLabel = new System.Windows.Forms.Label();
            this.IncrementNumberOfCopiesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // NumberOfCopiesLabel
            // 
            this.NumberOfCopiesLabel.AutoSize = true;
            this.NumberOfCopiesLabel.Location = new System.Drawing.Point(7, 21);
            this.NumberOfCopiesLabel.Name = "NumberOfCopiesLabel";
            this.NumberOfCopiesLabel.Size = new System.Drawing.Size(71, 13);
            this.NumberOfCopiesLabel.TabIndex = 1;
            this.NumberOfCopiesLabel.Text = "No of Copies:";
            // 
            // SelectedPrinterLabel
            // 
            this.SelectedPrinterLabel.AutoSize = true;
            this.SelectedPrinterLabel.Location = new System.Drawing.Point(84, 8);
            this.SelectedPrinterLabel.Name = "SelectedPrinterLabel";
            this.SelectedPrinterLabel.Size = new System.Drawing.Size(35, 13);
            this.SelectedPrinterLabel.TabIndex = 2;
            this.SelectedPrinterLabel.Text = "label3";
            // 
            // NoOfCopiesLabel
            // 
            this.NoOfCopiesLabel.AutoSize = true;
            this.NoOfCopiesLabel.Location = new System.Drawing.Point(84, 21);
            this.NoOfCopiesLabel.Name = "NoOfCopiesLabel";
            this.NoOfCopiesLabel.Size = new System.Drawing.Size(35, 13);
            this.NoOfCopiesLabel.TabIndex = 3;
            this.NoOfCopiesLabel.Text = "label4";
            // 
            // IncrementNumberOfCopiesButton
            // 
            this.IncrementNumberOfCopiesButton.Location = new System.Drawing.Point(8, 37);
            this.IncrementNumberOfCopiesButton.Name = "IncrementNumberOfCopiesButton";
            this.IncrementNumberOfCopiesButton.Size = new System.Drawing.Size(75, 23);
            this.IncrementNumberOfCopiesButton.TabIndex = 4;
            this.IncrementNumberOfCopiesButton.Text = "Add";
            this.IncrementNumberOfCopiesButton.UseVisualStyleBackColor = true;
            this.IncrementNumberOfCopiesButton.Click += new System.EventHandler(this.IncrementNumberOfCopiesButton_Click);
            // 
            // PrintPreviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IncrementNumberOfCopiesButton);
            this.Controls.Add(this.NoOfCopiesLabel);
            this.Controls.Add(this.SelectedPrinterLabel);
            this.Controls.Add(this.NumberOfCopiesLabel);
            this.Controls.Add(this.label1);
            this.Name = "PrintPreviewView";
            this.Size = new System.Drawing.Size(151, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberOfCopiesLabel;
        private System.Windows.Forms.Label SelectedPrinterLabel;
        private System.Windows.Forms.Label NoOfCopiesLabel;
        private System.Windows.Forms.Button IncrementNumberOfCopiesButton;
    }
}
