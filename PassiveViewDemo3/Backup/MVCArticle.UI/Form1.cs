using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVCArticle.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CatModel model = new CatModel() { Age = 10, Name = "Fluffy" };

            new CatControl(model, m_catView1); // wire up cat view 1
            new CatControl(model, m_catView2); // wire up cat view 2
        }
    }
}
