﻿using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace SIGN.Services
{
    public class GuidelineService : IGuidelineService
    {
        private ISIGNRepository _repository;

        public GuidelineService(ISIGNRepository repository)
        {
            _repository = repository;
        }

        public Guideline GetGuideline(int id)
        {
            return _repository.GetGuideline(id);
        }

        public IEnumerable<Guideline> GetGuidelines()
        {
            return _repository.GetGuidelines();
        }

        public IEnumerable<Guideline> GetMyGuidelines(string authorName)
        {
            return _repository.GetGuidelinesByAuthor(authorName);
        }

        public async Task<bool> SaveGuideline(Guideline guideline)
        {
            _repository.SaveGuideline(guideline);
            return await _repository.SaveChangesAsync();
        }

        public Assessment GetAssessment(int id)
        {
            return _repository.GetAssessment(id);
        }

        public async Task<bool> AddAssessment(int guidelineId, Assessment assessment)
        {
            _repository.AddAssessment(guidelineId, assessment);
            return await _repository.SaveChangesAsync();
        }

        public StepAction GetAction(int stepId, bool condition)
        {
            return _repository.GetAction(stepId, condition);
        }

        public Step GetStep(int id)
        {
            return _repository.GetStep(id);
        }
    }
}