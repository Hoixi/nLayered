﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrates
{
    public class User : Entity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string profileImgPath { get; set; }
    }
}
