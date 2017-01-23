using Microsoft.AspNetCore.Identity;
using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.MVC
{
    public class SeedData
    {
        private ISIGNRepository _repository;
        private UserManager<SIGNUser> _userManager;
        private Guideline _guideline110, _guideline119, _guideline143, _guideline153;
        private Assessment _initialAssessmentEmergency110, _initialPatientAssessment110, _initialPaediatricAssessment110, _initialAssessmentNonEmergency110;
        private Step _step1_1, _step1_2, _step1_3, _step1_4, _step1_5, _step1_6, _step1_7, _step1_8;
        private Step _step2_1, _step2_2, _step2_3, _step2_4, _step2_5, _step2_6, _step2_7, _step2_8, _step2_9, _step2_10, _step2_11, _step2_12;
        private StepAction _action1_2, _action1_3, _action1_4, _action1_5, _action1_6, _action1_7, _action1_8;
        private StepAction _action2_2, _action2_3, _action2_4, _action2_5, _action2_6, _action2_7, _action2_8, _action2_9, _action2_10, _action2_11, _action2_12;
        private Decision _decision1_1, _decision1_2, _decision1_3, _decision1_4, _decision1_5, _decision1_6, _decision1_7, _decision1_8, _decision1_11, _decision1_12, _decision1_13, _decision1_14, _decision1_10, _decision9;
        private Decision _decision2_1, _decision2_2, _decision2_3, _decision2_4, _decision2_5, _decision2_6, _decision2_7, _decision2_8, _decision2_9, _decision2_10, _decision2_11, _decision2_12, _decision2_13, _decision2_14, _decision2_15, _decision2_16, _decision2_17, _decision2_18, _decision2_19, _decision2_20;
        private RecommendationGrade _gradeA, _gradeB, _gradeC, _gradeD;
        private StepDetail _stepDetail1, _stepDetail2, _stepDetail3;

        public SeedData(ISIGNRepository repository, UserManager<SIGNUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task EnsureSeedData()
        {
            if (await _userManager.FindByEmailAsync("gjhickford@sign.com") == null)
            {
                var user = new SIGNUser
                {
                    UserName = "GavinHickford",
                    Email = "gjhickford@sign.com"
                };

                var result = await _userManager.CreateAsync(user, "Pa$$word1");
            }


            if (!_repository.GetGuidelines().Any())
            {
                SetUpGuidelines();
                SetUpAssessments();
                SetupStepDetails();
                SetUpSteps();
                SetUpActions();
                SetUpDecisions();
                SetupRecommendationGrades();
   
                LinkData();

                AddDecisions();

                AddRecommendationGrades();

                await SaveData();
            }
        }

        private void SetupStepDetails()
        {
            _stepDetail1 = new StepDetail
            {
                Title = "Focal neurological deficit",
                Text = "Problems understanding, speaking, reading or writing" + Environment.NewLine +
                    "Loss of feeling in part of the body" + Environment.NewLine +
                    "Problems balancing" + Environment.NewLine +
                    "Unilateral weakness" + Environment.NewLine +
                    "Any changes in eyesight" + Environment.NewLine +
                    "Problems walking."
            };

            _stepDetail2 = new StepDetail
            {
                Title = "Skull fracture or penetrating head injury",
                Text = "Fluid running from the ears or nose" + Environment.NewLine +
                    "Black eye with no direct orbital trauma" + Environment.NewLine +
                    "Bleeding from one or both ears" + Environment.NewLine +
                    "New deafness in one or both ears" + Environment.NewLine +
                    "Bruising behind one or both ears" + Environment.NewLine +
                    "Penetrating injury" + Environment.NewLine +
                    "Major scalp wound or skull trauma."
            };

            _stepDetail3 = new StepDetail
            {
                Title = "High energy head injury",
                Text = "Pedestrian struck by motor vehicle" + Environment.NewLine +
                    "Occupant ejected from motor vehicle" + Environment.NewLine +
                    "A fall from a height of greater than one metre or more than five stairs" + Environment.NewLine +
                    "Diving accident" + Environment.NewLine +
                    "High speed motor vehicle collision" + Environment.NewLine +
                    "Rollover motor accident" + Environment.NewLine +
                    "Accident involving motorised recreational vehicles" + Environment.NewLine +
                    "Bicycle collision" + Environment.NewLine +
                    "Impact from golf club, cricket or baseball bat" + Environment.NewLine +
                    "Any other potentially high energy mechanism."
            };
        }

        private async Task SaveData()
        {
            _repository.SaveGuideline(_guideline110);
            _repository.SaveGuideline(_guideline119);
            _repository.SaveGuideline(_guideline143);
            _repository.SaveGuideline(_guideline153);
            await _repository.SaveChangesAsync();
        }

        private void AddRecommendationGrades()
        {
            _repository.AddRecommendationGrade(_gradeA);
            _repository.AddRecommendationGrade(_gradeB);
            _repository.AddRecommendationGrade(_gradeC);
            _repository.AddRecommendationGrade(_gradeD);
        }

        private void AddDecisions()
        {
            _repository.AddDecision(_decision1_1);
            _repository.AddDecision(_decision1_2);
            _repository.AddDecision(_decision1_3);
            _repository.AddDecision(_decision1_4);
            _repository.AddDecision(_decision1_5);
            _repository.AddDecision(_decision1_6);
            _repository.AddDecision(_decision1_7);
            _repository.AddDecision(_decision1_8);
            _repository.AddDecision(_decision9);
            _repository.AddDecision(_decision1_10);
            _repository.AddDecision(_decision1_11);
            _repository.AddDecision(_decision1_12);
            _repository.AddDecision(_decision1_13);
            _repository.AddDecision(_decision1_14);
            _repository.AddDecision(_decision2_1);
            _repository.AddDecision(_decision2_2);
            _repository.AddDecision(_decision2_3);
            _repository.AddDecision(_decision2_4);
            _repository.AddDecision(_decision2_5);
            _repository.AddDecision(_decision2_6);
            _repository.AddDecision(_decision2_7);
            _repository.AddDecision(_decision2_8);
            _repository.AddDecision(_decision2_9);
            _repository.AddDecision(_decision2_10);
            _repository.AddDecision(_decision2_11);
            _repository.AddDecision(_decision2_12);
            _repository.AddDecision(_decision2_13);
            _repository.AddDecision(_decision2_14);
            _repository.AddDecision(_decision2_15);
            _repository.AddDecision(_decision2_16);
            _repository.AddDecision(_decision2_17);
            _repository.AddDecision(_decision2_18);
            _repository.AddDecision(_decision2_19);
            _repository.AddDecision(_decision2_20);
        }

        private void SetupRecommendationGrades()
        {
            _gradeA = new RecommendationGrade
            {
                Grade = "A",
                Text = "At least one meta-analysis, systematic review, or RCT rated as 1++, and directly applicable to the target population; or A body of evidence consisting principally of studies rated as 1 +, directly applicable to the target population, and demonstrating overall consistency of results"
            };

            _gradeB = new RecommendationGrade
            {
                Grade = "B",
                Text = "A body of evidence including studies rated as 2++, directly applicable to the target population, and demonstrating overall consistency of results; or Extrapolated evidence from studies rated as 1++ or 1 + "
            };

            _gradeC = new RecommendationGrade
            {
                Grade = "C",
                Text = "A body of evidence including studies rated as 2+, directly applicable to the target population and demonstrating overall consistency of results; or Extrapolated evidence from studies rated as 2++"
            };

            _gradeD = new RecommendationGrade
            {
                Grade = "D",
                Text = "Evidence level 3 or 4; or Extrapolated evidence from studies rated as 2 + "
            };
        }

        private void SetUpDecisions()
        {
            // TODO - don't need these linked to an assessment
            _decision1_1 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = true,
                Step = _step1_1,
                Action = _action1_3
            };

            _decision1_2 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = false,
                Step = _step1_1,
                Action = _action1_2
            };

            _decision1_3 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = true,
                Step = _step1_2,
                Action = _action1_3
            };

            _decision1_4 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = false,
                Step = _step1_2,
                Action = _action1_5
            };

            _decision1_5 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = true,
                Step = _step1_3,
                Action = _action1_3
            };

            _decision1_6 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = false,
                Step = _step1_3,
                Action = _action1_5
            };

            _decision1_7 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = true,
                Step = _step1_5,
                Action = _action1_3
            };

            _decision1_8 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = false,
                Step = _step1_5,
                Action = _action1_6
            };

            _decision9 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = true,
                Step = _step1_6,
                Action = _action1_3
            };

            _decision1_10 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = false,
                Step = _step1_6,
                Action = _action1_7
            };

            _decision1_11 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = true,
                Step = _step1_7,
                Action = _action1_3
            };

            _decision1_12 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = false,
                Step = _step1_7,
                Action = _action1_8
            };

            _decision1_13 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = true,
                Step = _step1_8,
                Action = _action1_4
            };

            _decision1_14 = new Decision
            {
                Assessment = _initialAssessmentEmergency110,
                Condition = false,
                Step = _step1_8,
                Action = _action1_3
            };

            _decision2_1 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_1,
                Action = _action2_11
            };

            _decision2_2 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_1,
                Action = _action2_2
            };
            
            _decision2_3 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_2,
                Action = _action2_11
            };

            _decision2_4 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_2,
                Action = _action2_3
            };

            _decision2_5 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_3,
                Action = _action2_11
            };

            _decision2_6 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_3,
                Action = _action2_4
            };

            _decision2_7 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_4,
                Action = _action2_11
            };

            _decision2_8 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_4,
                Action = _action2_5
            };

            _decision2_9 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_5,
                Action = _action2_11
            };

            _decision2_10 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_5,
                Action = _action2_6
            };

            _decision2_11 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_6,
                Action = _action2_11
            };

            _decision2_12 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_6,
                Action = _action2_7
            };

            _decision2_13 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_7,
                Action = _action2_11
            };

            _decision2_14 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_7,
                Action = _action2_8
            };

            _decision2_15 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_8,
                Action = _action2_11
            };

            _decision2_16 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_8,
                Action = _action2_9
            };

            _decision2_17 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_9,
                Action = _action2_11
            };

            _decision2_18 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_9,
                Action = _action2_10
            };

            _decision2_19 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = true,
                Step = _step2_10,
                Action = _action2_11
            };

            _decision2_20 = new Decision
            {
                Assessment = _initialAssessmentNonEmergency110,
                Condition = false,
                Step = _step2_10,
                Action = _action2_12
            };
        }

        private void SetUpActions()
        {
            _action1_2 = new StepAction
            {
                NextStep = _step1_2
            };

            _action1_3 = new StepAction
            {
                NextStep = _step1_3
            };

            _action1_4 = new StepAction
            {
                NextStep = _step1_4
            };

            _action1_5 = new StepAction
            {
                NextStep = _step1_5
            };

            _action1_6 = new StepAction
            {
                NextStep = _step1_6
            };

            _action1_7 = new StepAction
            {
                NextStep = _step1_7
            };

            _action1_8 = new StepAction
            {
                NextStep = _step1_8
            };
            
            _action2_2 = new StepAction
            {
                NextStep = _step2_2
            };

            _action2_3 = new StepAction
            {
                NextStep = _step2_3
            };

            _action2_4 = new StepAction
            {
                NextStep = _step2_4
            };

            _action2_5 = new StepAction
            {
                NextStep = _step2_5
            };

            _action2_6 = new StepAction
            {
                NextStep = _step2_6
            };

            _action2_7 = new StepAction
            {
                NextStep = _step2_7
            };

            _action2_8 = new StepAction
            {
                NextStep = _step2_8
            };

            _action2_9 = new StepAction
            {
                NextStep = _step2_9
            };

            _action2_10 = new StepAction
            {
                NextStep = _step2_10
            };

            _action2_11 = new StepAction
            {
                NextStep = _step2_11
            };

            _action2_12 = new StepAction
            {
                NextStep = _step2_12
            };
        }

        private void LinkData()
        {
            //_initialAssessment110.Decisions = new Collection<Decision> { _decision1, _decision2, _decision3, _decision4 };
            _initialAssessmentEmergency110.FirstStep = _step1_1;
            _initialAssessmentNonEmergency110.FirstStep = _step2_1;
            _initialPaediatricAssessment110.FirstStep = _step1_1;
            _initialPatientAssessment110.FirstStep = _step1_1;

            _guideline110.Assessments.Add(_initialAssessmentEmergency110);
            _guideline110.Assessments.Add(_initialAssessmentNonEmergency110);
            _guideline110.Assessments.Add(_initialPatientAssessment110);
            _guideline110.Assessments.Add(_initialPaediatricAssessment110);
        }

        private void SetUpSteps()
        {
            _step1_1 = new Step
            {
                Text = "Is the patient unconsciousness, or show lack of full consciousness(e.g. problems keeping eyes open)",
                Type = StepType.Question
            };

            _step1_2 = new Step
            {
                Text = "Does the patient show any focal (i.e. restricted to a particular part of the body or a particular activity) neurological deficit since the injury",
                Type = StepType.Question,
                Detail = _stepDetail1
            };

            _step1_3 = new Step
            {
                Text = "Refer patient to the emergency ambulance services (999) for emergency transport to the emergency department",
                Type = StepType.Recommendation
            };

            _step1_4 = new Step
            {
                Text = "There is no indication to refer patient to the emergency ambulance services (999). Further assessment required to determine whether patient still requires medical attention.",
                Type = StepType.Recommendation
            };

            _step1_5 = new Step
            {
                Text = "Is there any suspicion of a skull fracture or penetrating head injury?",
                Type = StepType.Question,
                Detail = _stepDetail2
            };

            _step1_6 = new Step
            {
                Text = "Has there been any seizure (convulsion or fit) since the injury?",
                Type = StepType.Question
            };

            _step1_7 = new Step
            {
                Text = "Was this a high energy head injury?",
                Type = StepType.Question,
                Detail = _stepDetail3
            };

            _step1_8 = new Step
            {
                Text = "Can the injured person reach hospital safely without emergency transport?",
                Type = StepType.Question
            };

            _step2_1 = new Step
            {
                Text = "Has the patient had any loss of consciousness ('knocked out') as a result of the injury, from which the injured person has now recovered?", 
                Type = StepType.Question
            };

            _step2_2 = new Step
            {
                Text = "Has the patient had any amnesia for events before or after the injury(‘problems with memory’)",
                Type = StepType.Question
            };

            _step2_3 = new Step
            {
                Text = "Has the patient had persistent headache since the injury?",
                Type = StepType.Question
            };

            _step2_4 = new Step
            {
                Text = "Has the patient had any vomiting episodes since the injury?",
                Type = StepType.Question
            };

            _step2_5 = new Step
            {
                Text = "Has the patient had any previous cranial neurosurgical interventions (brain surgery)?",
                Type = StepType.Question
            };

            _step2_6 = new Step
            {
                Text = "Is there any history of bleeding or clotting disorder?0",
                Type = StepType.Question
            };

            _step2_7 = new Step
            {
                Text = "Is the patient currently on anticoagulant therapy such as warfarin?",
                Type = StepType.Question
            };

            _step2_8 = new Step
            {
                Text = "Is the patient currently show signs of drug or alcohol intoxication?",
                Type = StepType.Question
            };

            _step2_9 = new Step
            {
                Text = "Is there suspicion of non-accidental injury?",
                Type = StepType.Question
            };

            _step2_10 = new Step
            {
                Type = StepType.Question
            };

            _step2_11 = new Step
            {
                Text = "Patient should be referred to hospital emergency department.",
                Type = StepType.Recommendation
            };

            _step2_12 = new Step
            {
                Text = "No indication to refer to hospital emergency department. Advise patient to contact the telephone advice service again if symptoms worsen or there are any new developments.",
                Type = StepType.Recommendation
            };
        }

        private void SetUpAssessments()
        {
            _initialAssessmentEmergency110 = new Assessment
            {
                Name = "Initial Telephone Assessment - 999 referral",
                Type = AssessmentType.Telephone,
                Description = "Telephone advice services should assess any patient who has sustained a head injury to determine whether the patient should be referred to the emergency ambulance services(999) for emergency transport to the emergency department"
            };

            _initialAssessmentNonEmergency110 = new Assessment
            {
                Name = "Initial Telephone Assessment - hospital referral",
                Type = AssessmentType.Telephone,
                Description = "Telephone advice services should refer people who have sustained a head injury to a hospital emergency department if the history related indicates the presence of specific risk factors"
            }; 

            _initialPatientAssessment110 = new Assessment
            {
                Name = "Initial Patient Assessment",
                Type = AssessmentType.Consultation,
                Description = "Initial assessment of patient using Glasgow coma scale"
            };

            _initialPaediatricAssessment110 = new Assessment
            {
                Name = "Initial Paediatric Assessment",
                Type = AssessmentType.Consultation,
                Description = "Initial assessment of paediatric patients"
            };
        }

        private void SetUpGuidelines()
        {
            _guideline110 = new Guideline
            {
                Name = "Early management of patients with a head injury",
                Number = 110,
                DatePublished = new DateTime(2009, 5, 1),
                Author = "GavinHickford",
                Status = GuidelineStatus.GreaterThanSevenYears
            };
            _guideline119 = new Guideline
            {
                Name = "Management of patients with stroke: identification and management of dysphagia",
                Number = 119,
                DatePublished = new DateTime(2010, 6, 1),
                Author = "GavinHickford",
                Status = GuidelineStatus.CurrentThreeToSevenYears
            };
            _guideline143 = new Guideline
            {
                Name = "Diagnosis and management of epilepsy in adults",
                Number = 143,
                DatePublished = new DateTime(2015, 5, 1),
                Author = "JohnSmith",
                Status = GuidelineStatus.CurrentThreeToSevenYears
            };
            _guideline153 = new Guideline
            {
                Name = "British guideline on the management of asthma",
                Number = 153,
                DatePublished = new DateTime(2016, 9, 1),
                Author = "JohnSmith",
                Status = GuidelineStatus.CurrentLessThanThreeYears
            };
        }
    }
}
