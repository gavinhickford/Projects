using SIGN.Domain.Interfaces;
using System;

namespace SIGN.Domain.Classes
{
    public class StepAction : IModificationHistory
    {
        public int Id { get; set; }

        public Step NextStep { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public bool IsDirty { get; set; }
    }
}
