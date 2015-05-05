﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdFood.Domain.Interfaces.Infra
{
    public interface IAppUser
    {
        string Name { get; set; }

        string Lastname { get; set; }

        string FullName();
    }
}
