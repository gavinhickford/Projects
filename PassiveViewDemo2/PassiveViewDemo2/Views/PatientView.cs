using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassiveViewDemo2.Presenters;

namespace PassiveViewDemo2.Views
{
    public partial class PatientView : UserControl, IPatientView
    {
        private PatientViewPresenter patientViewPresenter;
        private string _patientName;

        public PatientView()
        {
            InitializeComponent();
            patientViewPresenter = new PatientViewPresenter(this);

            //GetPatientButton.Click += (sender, e) => patientViewPresenter.OnGetPatientButtonClick();
            PatientIdTextbox.TextChanged += (sender, e) => patientViewPresenter.OnTextChanged();
        }

        public string PatientIdInput
        {
            get { return this.PatientIdTextbox.Text.Trim(); }
        }

        public string PatientName
        {
            get 
            { 
                //return this.PatientNameLabel.Text.Trim();
                return _patientName;
            }
            set 
            {
                _patientName = value;
                this.PatientNameLabel.Text = value; 
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public bool GetPatientButtonEnabled
        {
            get { return GetPatientButton.Enabled; }
            set { GetPatientButton.Enabled = value; }
        }

		public void FireGetPatientButtonClick(object sender, EventArgs e)
		{
			GetPatientButton_Click(sender, e);
		}

		private void GetPatientButton_Click(object sender, EventArgs e)
		{
			patientViewPresenter.OnGetPatientButtonClick();
		}
    }
 }