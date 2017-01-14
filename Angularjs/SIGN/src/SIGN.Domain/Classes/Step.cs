using SIGN.Domain.Enums;
using SIGN.Domain.Interfaces;
using System;

namespace SIGN.Domain.Classes
{
    public class Step : BaseEntity
    {
        public string Text { get; set; }
        public StepType Type { get; set; }
    }
}
