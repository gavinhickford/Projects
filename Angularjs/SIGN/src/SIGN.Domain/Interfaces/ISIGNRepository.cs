using SIGN.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.Domain.Interfaces
{
    public interface ISIGNRepository
    {
        IEnumerable<Guideline> GetGuidelines();
        Guideline GetGuideline(int id);
        Assessment GetAssessment(int id);
        Step GetStep(int id);
        void SaveGuideline(Guideline guideline);
        void AddAssessment(int guidelineId, Assessment assessment);
        void AddStep(Step step);
        void AddDecision(Decision decision);
        void AddStepAction(StepAction stepAction);
        Task<bool> SaveChangesAsync();
        int SaveChanges();
        IEnumerable<Guideline> GetGuidelinesByAuthor(string AuthorName);
        StepAction GetAction(int stepId, bool choice);
        void AddRecommendationGrade(RecommendationGrade grade);
    }
}
