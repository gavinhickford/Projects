using SIGN.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace SIGN.Domain.Classes
{
    public class Decision : BaseEntity
    {
        public Step Step { get; set; }

        public bool Condition { get; set; }

        [Required]
        public StepAction Action { get; set; }

        [Required]
        public Assessment Assessment { get; set; }

        public int AssessmentId { get; set; }
    }
}