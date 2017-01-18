using SIGN.Domain.Classes;
using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SIGN.MVC.ViewModels
{
    public class GuidelineViewModel : IModificationHistory
    {
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 10)]
        public string Name { get; set; }

        public string Author { get; set; }

        public GuidelineStatus Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DatePublished { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public bool IsDirty { get; set; }

        public IEnumerable<Assessment> Assessments { get; set; }
    }
}
