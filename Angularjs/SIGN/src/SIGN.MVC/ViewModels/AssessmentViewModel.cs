using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace SIGN.MVC.ViewModels
{
    public class AssessmentViewModel : IModificationHistory
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public AssessmentType Type { get; set; }
        public string Description { get; set; }
        public int FirstStepId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
