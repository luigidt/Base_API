﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EnumTypes
{
    public enum ValidateError
    {
        [Description("O campo [PROPERTY_NAME] é obrigatório.")]
        RequiredProperty = 0,
        [Description("O campo [PROPERTY_NAME] precisa ter no mínimo [LENGTH] caracteres.")]
        MinLenProperty = 1,
        [Description("O campo [PROPERTY_NAME] suporta até [LENGTH] caracteres.")]
        MaxnLenProperty = 2
    }
}
