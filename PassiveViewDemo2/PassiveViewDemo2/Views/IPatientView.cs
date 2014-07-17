using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveViewDemo2.Views
{
    public interface IPatientView
    {
        string PatientIdInput { get; }
        string PatientName { get; set; }
        void ShowMessage(string message);
        bool GetPatientButtonEnabled { get; set; }
    }
}
