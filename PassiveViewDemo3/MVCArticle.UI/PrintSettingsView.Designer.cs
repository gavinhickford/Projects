namespace PrintDialog.UI
{
    partial class PrintSettingsView
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
            this.components = new System.ComponentModel.Container();
            this.SelectedPrinterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lblAge = new System.Windows.Forms.Label();
            this.PrintersComboBox = new System.Windows.Forms.ComboBox();
            this.printerSettingsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrintersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.printerSettingsModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedPrinterTextBox
            // 
            this.SelectedPrinterTextBox.Location = new System.Drawing.Point(50, 3);
            this.SelectedPrinterTextBox.Name = "SelectedPrinterTextBox";
            this.SelectedPrinterTextBox.Size = new System.Drawing.Size(133, 20);
            this.SelectedPrinterTextBox.TabIndex = 0;
            this.SelectedPrinterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // m_lblAge
            // 
            this.m_lblAge.AutoSize = true;
            this.m_lblAge.Location = new System.Drawing.Point(50, 30);
            this.m_lblAge.Name = "m_lblAge";
            this.m_lblAge.Size = new System.Drawing.Size(35, 13);
            this.m_lblAge.TabIndex = 2;
            this.m_lblAge.Text = "label3";
            // 
            // PrintersComboBox
            // 
            this.PrintersComboBox.FormattingEnabled = true;
            this.PrintersComboBox.Location = new System.Drawing.Point(50, 46);
            this.PrintersComboBox.Name = "PrintersComboBox";
            this.PrintersComboBox.Size = new System.Drawing.Size(202, 21);
            this.PrintersComboBox.TabIndex = 3;
            // 
            // printerSettingsModelBindingSource
            // 
            this.printerSettingsModelBindingSource.DataSource = typeof(PrintDialog.PrinterSettingsModel);
            // 
            // PrintersLabel
            // 
            this.PrintersLabel.AutoSize = true;
            this.PrintersLabel.Location = new System.Drawing.Point(4, 49);
            this.PrintersLabel.Name = "PrintersLabel";
            this.PrintersLabel.Size = new System.Drawing.Size(45, 13);
            this.PrintersLabel.TabIndex = 4;
            this.PrintersLabel.Text = "Printers:";
            // 
            // PrintSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PrintersLabel);
            this.Controls.Add(this.PrintersComboBox);
            this.Controls.Add(this.m_lblAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedPrinterTextBox);
            this.Name = "PrintSettingsView";
            this.Size = new System.Drawing.Size(271, 159);
            ((System.ComponentModel.ISupportInitialize)(this.printerSettingsModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectedPrinterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lblAge;
        private System.Windows.Forms.ComboBox PrintersComboBox;
        private System.Windows.Forms.Label PrintersLabel;
        private System.Windows.Forms.BindingSource printerSettingsModelBindingSource;
    }
}
