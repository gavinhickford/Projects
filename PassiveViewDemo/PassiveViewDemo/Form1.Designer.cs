namespace PassiveViewDemo
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
            this.printDialogView1 = new PassiveViewDemo.PrintDialogView();
            this.SuspendLayout();
            // 
            // printDialogView1
            // 
            this.printDialogView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printDialogView1.Location = new System.Drawing.Point(0, 0);
            this.printDialogView1.MyText = "";
            this.printDialogView1.Name = "printDialogView1";
            this.printDialogView1.SaveButtonEnabled = true;
            this.printDialogView1.SaveButtonText = "Save";
            this.printDialogView1.Size = new System.Drawing.Size(284, 262);
            this.printDialogView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.printDialogView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PrintDialogView printDialogView1;
    }
}

