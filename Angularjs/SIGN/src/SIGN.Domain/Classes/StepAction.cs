using SIGN.Domain.Interfaces;
using System;

namespace SIGN.Domain.Classes
{
    public class StepAction : BaseEntity
    {
        public Step NextStep { get; set; }
    }
}
