﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCode.Interfaces
{
    public interface IPurposeIdentifier
    {
        string PurposeIdentifier { get; }
        delegate string GeneratePurposeIdentifier<GeneratorInputType>();
    }
}
