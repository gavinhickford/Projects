﻿using SIGN.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.MVC.ViewModels
{
    public class GuidelinesViewModel
    {
        public IEnumerable<Guideline> Guidelines { get; set; }
    }
}