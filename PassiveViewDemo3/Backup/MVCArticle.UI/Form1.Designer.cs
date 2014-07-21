namespace MVCArticle.UI
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
            this.m_catView1 = new MVCArticle.UI.CatView1();
            this.m_catView2 = new MVCArticle.UI.CatView2();
            this.SuspendLayout();
            // 
            // m_catView1
            // 
            this.m_catView1.Location = new System.Drawing.Point(2, 12);
            this.m_catView1.Name = "m_catView1";
            this.m_catView1.Size = new System.Drawing.Size(151, 65);
            this.m_catView1.TabIndex = 0;
            // 
            // m_catView2
            // 
            this.m_catView2.Location = new System.Drawing.Point(2, 111);
            this.m_catView2.Name = "m_catView2";
            this.m_catView2.Size = new System.Drawing.Size(221, 50);
            this.m_catView2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.m_catView2);
            this.Controls.Add(this.m_catView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CatView1 m_catView1;
        private CatView2 m_catView2;
    }
}

