using PassiveViewDemo2.Model;
using PassiveViewDemo2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveViewDemo2.Presenters
{
    public class PatientViewPresenter
    {
        private IPatientView patientView;
        private PatientRepository repository;

        public PatientViewPresenter(IPatientView patientView)
        {
            this.patientView = patientView;
            this.repository = new PatientRepository();
            patientView.GetPatientButtonEnabled = false;
        }

        public void LoadPatient()
        {
            Patient patient = null;
            int patientId;

            if (patientView.PatientIdInput == string.Empty)
            {
                patientView.ShowMessage("PatientId cannot be empty");
                return;
            }

            try
            {
                patientId = Int32.Parse(patientView.PatientIdInput);
            }
            catch
            {
                patientView.ShowMessage("PatientId must be an integer value");
                return;
            }

            try
            {
                patient = repository.GetPatient(patientId);
            }
            catch (Exception ex)
            {
                patientView.ShowMessage(ex.Message);
                return;
            }

            patientView.PatientName = patient.Name;
        }

        public void OnGetPatientButtonClick()
        {
            LoadPatient();
        }

        public void OnTextChanged()
        {
            patientView.GetPatientButtonEnabled = !string.IsNullOrEmpty(patientView.PatientIdInput);
        }
    }
}
