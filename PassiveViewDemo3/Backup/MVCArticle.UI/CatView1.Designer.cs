namespace MVCArticle.UI
{
    partial class CatView1
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
            this.label2 = new System.Windows.Forms.Label();
            this.m_lblName = new System.Windows.Forms.Label();
            this.m_lblAge = new System.Windows.Forms.Label();
            this.m_btnIncrementAge = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // m_lblName
            // 
            this.m_lblName.AutoSize = true;
            this.m_lblName.Location = new System.Drawing.Point(48, 8);
            this.m_lblName.Name = "m_lblName";
            this.m_lblName.Size = new System.Drawing.Size(35, 13);
            this.m_lblName.TabIndex = 2;
            this.m_lblName.Text = "label3";
            // 
            // m_lblAge
            // 
            this.m_lblAge.AutoSize = true;
            this.m_lblAge.Location = new System.Drawing.Point(49, 21);
            this.m_lblAge.Name = "m_lblAge";
            this.m_lblAge.Size = new System.Drawing.Size(35, 13);
            this.m_lblAge.TabIndex = 3;
            this.m_lblAge.Text = "label4";
            // 
            // m_btnIncrementAge
            // 
            this.m_btnIncrementAge.Location = new System.Drawing.Point(8, 37);
            this.m_btnIncrementAge.Name = "m_btnIncrementAge";
            this.m_btnIncrementAge.Size = new System.Drawing.Size(75, 23);
            this.m_btnIncrementAge.TabIndex = 4;
            this.m_btnIncrementAge.Text = "Birthday";
            this.m_btnIncrementAge.UseVisualStyleBackColor = true;
            this.m_btnIncrementAge.Click += new System.EventHandler(this.m_btnIncrementAge_Click);
            // 
            // CatView1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_btnIncrementAge);
            this.Controls.Add(this.m_lblAge);
            this.Controls.Add(this.m_lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CatView1";
            this.Size = new System.Drawing.Size(151, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lblName;
        private System.Windows.Forms.Label m_lblAge;
        private System.Windows.Forms.Button m_btnIncrementAge;
    }
}
