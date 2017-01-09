using SIGN.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SIGN.Domain.Classes
{
    public class Guideline : IModificationHistory
    {
        public Guideline()
        {
            Assessments = new Collection<Assessment>();
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime DatePublished { get; set; }
        public Collection<Assessment> Assessments { get; set; }
        public string Author { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}
