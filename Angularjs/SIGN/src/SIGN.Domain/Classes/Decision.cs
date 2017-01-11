using SIGN.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace SIGN.Domain.Classes
{
    public class Decision : IModificationHistory
    {
        public int Id { get; set; }

        public Step Step { get; set; }

        public bool Condition { get; set; }

        [Required]
        public StepAction Action { get; set; }

        [Required]
        public Assessment Assessment { get; set; }

        public int AssessmentId { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public bool IsDirty { get; set; }
    }
}