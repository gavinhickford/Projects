namespace GenericResources.UI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LibraryItemsRadioButton = new System.Windows.Forms.RadioButton();
            this.DocumentsRadioButton = new System.Windows.Forms.RadioButton();
            this.TemplatesRadioButton = new System.Windows.Forms.RadioButton();
            this.ProtocolsRadioButton = new System.Windows.Forms.RadioButton();
            this.ConceptsRadioButton = new System.Windows.Forms.RadioButton();
            this.managerView1 = new GenericResources.UI.Views.ManagerView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.managerView1);
            this.splitContainer1.Size = new System.Drawing.Size(534, 381);
            this.splitContainer1.SplitterDistance = 134;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LibraryItemsRadioButton);
            this.groupBox1.Controls.Add(this.DocumentsRadioButton);
            this.groupBox1.Controls.Add(this.TemplatesRadioButton);
            this.groupBox1.Controls.Add(this.ProtocolsRadioButton);
            this.groupBox1.Controls.Add(this.ConceptsRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resource Type";
            // 
            // LibraryItemsRadioButton
            // 
            this.LibraryItemsRadioButton.AutoSize = true;
            this.LibraryItemsRadioButton.Location = new System.Drawing.Point(12, 120);
            this.LibraryItemsRadioButton.Name = "LibraryItemsRadioButton";
            this.LibraryItemsRadioButton.Size = new System.Drawing.Size(84, 17);
            this.LibraryItemsRadioButton.TabIndex = 4;
            this.LibraryItemsRadioButton.TabStop = true;
            this.LibraryItemsRadioButton.Text = "Library Items";
            this.LibraryItemsRadioButton.UseVisualStyleBackColor = true;
            this.LibraryItemsRadioButton.CheckedChanged += new System.EventHandler(this.LibraryItemsRadioButton_CheckedChanged);
            // 
            // DocumentsRadioButton
            // 
            this.DocumentsRadioButton.AutoSize = true;
            this.DocumentsRadioButton.Location = new System.Drawing.Point(12, 97);
            this.DocumentsRadioButton.Name = "DocumentsRadioButton";
            this.DocumentsRadioButton.Size = new System.Drawing.Size(126, 17);
            this.DocumentsRadioButton.TabIndex = 3;
            this.DocumentsRadioButton.TabStop = true;
            this.DocumentsRadioButton.Text = "Document Templates";
            this.DocumentsRadioButton.UseVisualStyleBackColor = true;
            this.DocumentsRadioButton.CheckedChanged += new System.EventHandler(this.DocumentsRadioButton_CheckedChanged);
            // 
            // TemplatesRadioButton
            // 
            this.TemplatesRadioButton.AutoSize = true;
            this.TemplatesRadioButton.Location = new System.Drawing.Point(12, 74);
            this.TemplatesRadioButton.Name = "TemplatesRadioButton";
            this.TemplatesRadioButton.Size = new System.Drawing.Size(74, 17);
            this.TemplatesRadioButton.TabIndex = 2;
            this.TemplatesRadioButton.TabStop = true;
            this.TemplatesRadioButton.Text = "Templates";
            this.TemplatesRadioButton.UseVisualStyleBackColor = true;
            this.TemplatesRadioButton.CheckedChanged += new System.EventHandler(this.TemplatesRadioButton_CheckedChanged);
            // 
            // ProtocolsRadioButton
            // 
            this.ProtocolsRadioButton.AutoSize = true;
            this.ProtocolsRadioButton.Location = new System.Drawing.Point(12, 51);
            this.ProtocolsRadioButton.Name = "ProtocolsRadioButton";
            this.ProtocolsRadioButton.Size = new System.Drawing.Size(69, 17);
            this.ProtocolsRadioButton.TabIndex = 1;
            this.ProtocolsRadioButton.TabStop = true;
            this.ProtocolsRadioButton.Text = "Protocols";
            this.ProtocolsRadioButton.UseVisualStyleBackColor = true;
            this.ProtocolsRadioButton.CheckedChanged += new System.EventHandler(this.ProtocolsRadioButton_CheckedChanged);
            // 
            // ConceptsRadioButton
            // 
            this.ConceptsRadioButton.AutoSize = true;
            this.ConceptsRadioButton.Location = new System.Drawing.Point(12, 28);
            this.ConceptsRadioButton.Name = "ConceptsRadioButton";
            this.ConceptsRadioButton.Size = new System.Drawing.Size(70, 17);
            this.ConceptsRadioButton.TabIndex = 0;
            this.ConceptsRadioButton.TabStop = true;
            this.ConceptsRadioButton.Text = "Concepts";
            this.ConceptsRadioButton.UseVisualStyleBackColor = true;
            this.ConceptsRadioButton.CheckedChanged += new System.EventHandler(this.ConceptsRadioButton_CheckedChanged);
            // 
            // managerView1
            // 
            this.managerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerView1.Location = new System.Drawing.Point(0, 0);
            this.managerView1.Name = "managerView1";
            this.managerView1.Size = new System.Drawing.Size(396, 381);
            this.managerView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 381);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Views.ManagerView managerView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LibraryItemsRadioButton;
        private System.Windows.Forms.RadioButton DocumentsRadioButton;
        private System.Windows.Forms.RadioButton TemplatesRadioButton;
        private System.Windows.Forms.RadioButton ProtocolsRadioButton;
        private System.Windows.Forms.RadioButton ConceptsRadioButton;
    }
}

