﻿using System;
using GPRStructure.Characters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRStructure.Interfaces
{
    public interface IAttack
    {
        void Attack(Character target);
    }
}
