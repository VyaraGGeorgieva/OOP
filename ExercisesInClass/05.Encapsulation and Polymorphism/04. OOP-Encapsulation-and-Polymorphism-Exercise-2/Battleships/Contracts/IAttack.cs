﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleships.Ships;

namespace Battleships.Contracts
{
    interface IAttack
    {
        string Attack(Ship target);
    }
}
