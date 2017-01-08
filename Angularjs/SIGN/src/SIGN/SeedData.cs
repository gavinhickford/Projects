using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN
{
    public class SeedData
    {
        private ISIGNRepository _repository;

        public SeedData(ISIGNRepository repository)
        {
            _repository = repository;
        }

        public void EnsureSeedData()
        {
            Guideline guideline110 = new Guideline { Name = "Early management of patients with a head injury", Number = 110, DatePublished = new DateTime(2009, 5, 1) };
            Guideline guideline119 = new Guideline { Name = "Management of patients with stroke: identification and management of dysphagia", Number = 119, DatePublished = new DateTime(2010, 6, 1) };
            Guideline guideline143 = new Guideline { Name = "Diagnosis and management of epilepsy in adults", Number = 143, DatePublished = new DateTime(2015, 5, 1) };
            Guideline guideline153 = new Guideline { Name = "British guideline on the management of asthma", Number = 153, DatePublished = new DateTime(2016, 9, 1) };
            
            Assessment initialAssessment110 = new Assessment
            {
                Name = "Initial Telephone Assessment",
                Type = AssessmentType.Telephone,
                Description = "Telephone advice services should assess any patient who has sustained a head injury to determine whether the patient should be referred to the emergency ambulance services(999) for emergency transport to the emergency department"
            };

            Assessment initialPatientAssessment110 = new Assessment
            {
                Name = "Initial Patient Assessment",
                Type = AssessmentType.Consultation,
                Description = "Initial assessment of patient using Glasgow coma scale"
            };

            Assessment initialPaediatricAssessment110 = new Assessment
            {
                Name = "Initial Paediatric Assessment",
                Type = AssessmentType.Consultation,
                Description = "Initial assessment of paediatric patients"
            };

            guideline110.Assessments.Add(initialAssessment110);
            guideline110.Assessments.Add(initialPatientAssessment110);
            guideline110.Assessments.Add(initialPaediatricAssessment110);

            if (!_repository.GetGuidelines().Any())
            {
                _repository.AddGuideline(guideline110);
                _repository.AddGuideline(guideline119);
                _repository.AddGuideline(guideline143);
                _repository.AddGuideline(guideline153);
            }
        }
    }
}
