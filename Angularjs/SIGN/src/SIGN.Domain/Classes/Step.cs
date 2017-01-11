﻿using SIGN.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.Domain.Classes
{
    public class Step : IModificationHistory
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public StepType Type { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDirty { get; set; }
    }
}
